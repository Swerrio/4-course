using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace CarRental
{
    // Формирование документа Word с данными автомобиля.
    //
    // Файл .docx — это обычный zip-архив с XML-файлами внутри, поэтому
    // документ собирается средствами System.IO.Compression, которые входят
    // в состав .NET Framework. Внешняя библиотека и установка NuGet-пакета
    // не требуются: программа соберётся на любом компьютере с .NET 4.8.
    public static class WordExporter
    {
        private const string NS_W =
            "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
        private const string NS_R =
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships";
        private const string NS_WP =
            "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing";
        private const string NS_A =
            "http://schemas.openxmlformats.org/drawingml/2006/main";
        private const string NS_PIC =
            "http://schemas.openxmlformats.org/drawingml/2006/picture";

        // Создаёт документ с карточкой автомобиля
        public static void CreateCarCard(Car car, Image photo, string path)
        {
            byte[] png = null;
            int picW = 0;
            int picH = 0;

            if (photo != null)
            {
                png = ToPng(photo, 440, out picW, out picH);
            }

            string body = BuildBody(car, png != null, picW, picH);

            using (FileStream fs = new FileStream(path, FileMode.Create,
                FileAccess.Write))
            {
                using (ZipArchive zip = new ZipArchive(fs,
                    ZipArchiveMode.Create))
                {
                    AddText(zip, "[Content_Types].xml", ContentTypes());
                    AddText(zip, "_rels/.rels", RootRels());
                    AddText(zip, "word/_rels/document.xml.rels",
                        DocumentRels(png != null));
                    AddText(zip, "word/styles.xml", Styles());
                    AddText(zip, "word/document.xml", body);
                    if (png != null)
                    {
                        AddBytes(zip, "word/media/image1.png", png);
                    }
                }
            }
        }

        // ------------------------------------------------ содержимое
        private static string BuildBody(Car car, bool withPhoto,
            int picW, int picH)
        {
            decimal week = car.Price * 7;

            StringBuilder b = new StringBuilder();
            b.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            b.Append("<w:document xmlns:w=\"" + NS_W + "\" xmlns:r=\"" + NS_R +
                "\" xmlns:wp=\"" + NS_WP + "\" xmlns:a=\"" + NS_A +
                "\" xmlns:pic=\"" + NS_PIC + "\"><w:body>");

            b.Append(Par("КАРТОЧКА АВТОМОБИЛЯ", true, 32, "center"));
            b.Append(Par("Прокат автомобилей «АвтоПрокат»", false, 20,
                "center"));
            b.Append(Par("", false, 24, "left"));
            b.Append(Par(car.Brand + " " + car.Model, true, 28, "center"));

            if (withPhoto)
            {
                b.Append(Picture(picW, picH));
                b.Append(Par("", false, 24, "left"));
            }

            b.Append(Table(new string[,] {
                { "Марка", car.Brand },
                { "Модель", car.Model },
                { "Класс автомобиля", car.Type },
                { "Цена за сутки", car.Price + " руб." },
                { "Стоимость аренды на 7 суток", week + " руб." }
            }));

            b.Append(Par("", false, 24, "left"));
            b.Append(Par("Дополнительная информация", true, 24, "left"));
            b.Append(Par("Автомобиль доступен к аренде. Стоимость указана " +
                "без учёта страховки. При оформлении страховки к сумме " +
                "аренды добавляется 15 %.", false, 24, "left"));
            b.Append(Par("", false, 24, "left"));
            b.Append(Par("Сформировано программой: АвтоПрокат", false, 20,
                "left"));
            b.Append(Par("Дата формирования: " +
                DateTime.Now.ToString("dd.MM.yyyy HH:mm"), false, 20, "left"));

            b.Append("<w:sectPr><w:pgSz w:w=\"11906\" w:h=\"16838\"/>");
            b.Append("<w:pgMar w:top=\"1134\" w:right=\"850\" " +
                "w:bottom=\"1134\" w:left=\"1134\" w:header=\"708\" " +
                "w:footer=\"708\" w:gutter=\"0\"/></w:sectPr>");
            b.Append("</w:body></w:document>");
            return b.ToString();
        }

        private static string Par(string text, bool bold, int halfPoints,
            string align)
        {
            StringBuilder b = new StringBuilder();
            b.Append("<w:p><w:pPr><w:spacing w:after=\"60\"/>");
            b.Append("<w:jc w:val=\"" + align + "\"/></w:pPr>");
            if (text.Length > 0)
            {
                b.Append("<w:r><w:rPr>");
                if (bold) { b.Append("<w:b/>"); }
                b.Append("<w:sz w:val=\"" + halfPoints + "\"/>");
                b.Append("<w:szCs w:val=\"" + halfPoints + "\"/></w:rPr>");
                b.Append("<w:t xml:space=\"preserve\">" + Esc(text) +
                    "</w:t></w:r>");
            }
            b.Append("</w:p>");
            return b.ToString();
        }

        private static string Table(string[,] rows)
        {
            StringBuilder b = new StringBuilder();
            b.Append("<w:tbl><w:tblPr><w:tblW w:w=\"9500\" w:type=\"dxa\"/>");
            b.Append("<w:tblBorders>");
            string[] edges = { "top", "left", "bottom", "right",
                "insideH", "insideV" };
            foreach (string e in edges)
            {
                b.Append("<w:" + e + " w:val=\"single\" w:sz=\"6\" " +
                    "w:space=\"0\" w:color=\"808080\"/>");
            }
            b.Append("</w:tblBorders></w:tblPr>");
            b.Append("<w:tblGrid><w:gridCol w:w=\"3800\"/>" +
                "<w:gridCol w:w=\"5700\"/></w:tblGrid>");

            for (int i = 0; i < rows.GetLength(0); i++)
            {
                b.Append("<w:tr>");
                b.Append(Cell(rows[i, 0], 3800, true));
                b.Append(Cell(rows[i, 1], 5700, false));
                b.Append("</w:tr>");
            }
            b.Append("</w:tbl>");
            return b.ToString();
        }

        private static string Cell(string text, int width, bool bold)
        {
            StringBuilder b = new StringBuilder();
            b.Append("<w:tc><w:tcPr><w:tcW w:w=\"" + width +
                "\" w:type=\"dxa\"/></w:tcPr>");
            b.Append("<w:p><w:pPr><w:spacing w:after=\"0\"/></w:pPr>");
            b.Append("<w:r><w:rPr>");
            if (bold) { b.Append("<w:b/>"); }
            b.Append("<w:sz w:val=\"24\"/></w:rPr>");
            b.Append("<w:t xml:space=\"preserve\">" + Esc(text) +
                "</w:t></w:r></w:p></w:tc>");
            return b.ToString();
        }

        private static string Picture(int px, int py)
        {
            long cx = (long)px * 9525;
            long cy = (long)py * 9525;

            StringBuilder b = new StringBuilder();
            b.Append("<w:p><w:pPr><w:jc w:val=\"center\"/></w:pPr><w:r>");
            b.Append("<w:drawing><wp:inline distT=\"0\" distB=\"0\" " +
                "distL=\"0\" distR=\"0\">");
            b.Append("<wp:extent cx=\"" + cx + "\" cy=\"" + cy + "\"/>");
            b.Append("<wp:docPr id=\"1\" name=\"Фотография автомобиля\"/>");
            b.Append("<a:graphic><a:graphicData uri=\"" + NS_PIC + "\">");
            b.Append("<pic:pic><pic:nvPicPr>");
            b.Append("<pic:cNvPr id=\"0\" name=\"image1.png\"/>");
            b.Append("<pic:cNvPicPr/></pic:nvPicPr>");
            b.Append("<pic:blipFill><a:blip r:embed=\"rId2\"/>");
            b.Append("<a:stretch><a:fillRect/></a:stretch></pic:blipFill>");
            b.Append("<pic:spPr><a:xfrm><a:off x=\"0\" y=\"0\"/>");
            b.Append("<a:ext cx=\"" + cx + "\" cy=\"" + cy + "\"/></a:xfrm>");
            b.Append("<a:prstGeom prst=\"rect\"><a:avLst/></a:prstGeom>");
            b.Append("</pic:spPr></pic:pic>");
            b.Append("</a:graphicData></a:graphic>");
            b.Append("</wp:inline></w:drawing></w:r></w:p>");
            return b.ToString();
        }

        // ------------------------------------------------ служебные части
        private static string ContentTypes()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>" +
                "<Types xmlns=\"http://schemas.openxmlformats.org/package/" +
                "2006/content-types\">" +
                "<Default Extension=\"rels\" ContentType=\"application/" +
                "vnd.openxmlformats-package.relationships+xml\"/>" +
                "<Default Extension=\"xml\" ContentType=\"application/xml\"/>" +
                "<Default Extension=\"png\" ContentType=\"image/png\"/>" +
                "<Override PartName=\"/word/document.xml\" ContentType=" +
                "\"application/vnd.openxmlformats-officedocument." +
                "wordprocessingml.document.main+xml\"/>" +
                "<Override PartName=\"/word/styles.xml\" ContentType=" +
                "\"application/vnd.openxmlformats-officedocument." +
                "wordprocessingml.styles+xml\"/>" +
                "</Types>";
        }

        private static string RootRels()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>" +
                "<Relationships xmlns=\"http://schemas.openxmlformats.org/" +
                "package/2006/relationships\">" +
                "<Relationship Id=\"rId1\" Type=\"" + NS_R +
                "/officeDocument\" Target=\"word/document.xml\"/>" +
                "</Relationships>";
        }

        private static string DocumentRels(bool withPhoto)
        {
            StringBuilder b = new StringBuilder();
            b.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            b.Append("<Relationships xmlns=\"http://schemas.openxmlformats.org/" +
                "package/2006/relationships\">");
            b.Append("<Relationship Id=\"rId1\" Type=\"" + NS_R +
                "/styles\" Target=\"styles.xml\"/>");
            if (withPhoto)
            {
                b.Append("<Relationship Id=\"rId2\" Type=\"" + NS_R +
                    "/image\" Target=\"media/image1.png\"/>");
            }
            b.Append("</Relationships>");
            return b.ToString();
        }

        private static string Styles()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>" +
                "<w:styles xmlns:w=\"" + NS_W + "\"><w:docDefaults>" +
                "<w:rPrDefault><w:rPr><w:rFonts w:ascii=\"Times New Roman\" " +
                "w:hAnsi=\"Times New Roman\" w:cs=\"Times New Roman\"/>" +
                "<w:sz w:val=\"24\"/><w:szCs w:val=\"24\"/>" +
                "<w:lang w:val=\"ru-RU\"/></w:rPr></w:rPrDefault>" +
                "<w:pPrDefault><w:pPr><w:spacing w:after=\"0\" " +
                "w:line=\"240\" w:lineRule=\"auto\"/></w:pPr>" +
                "</w:pPrDefault></w:docDefaults></w:styles>";
        }

        // ------------------------------------------------ вспомогательные
        private static byte[] ToPng(Image img, int maxWidth, out int w,
            out int h)
        {
            w = img.Width;
            h = img.Height;
            if (w > maxWidth)
            {
                h = (int)((long)h * maxWidth / w);
                w = maxWidth;
            }
            if (h < 1) { h = 1; }

            using (Bitmap bmp = new Bitmap(w, h))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D
                        .InterpolationMode.HighQualityBicubic;
                    g.DrawImage(img, 0, 0, w, h);
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }

        private static void AddText(ZipArchive zip, string name, string text)
        {
            AddBytes(zip, name, new UTF8Encoding(false).GetBytes(text));
        }

        private static void AddBytes(ZipArchive zip, string name, byte[] data)
        {
            ZipArchiveEntry entry = zip.CreateEntry(name,
                CompressionLevel.Optimal);
            using (Stream s = entry.Open())
            {
                s.Write(data, 0, data.Length);
            }
        }

        private static string Esc(string s)
        {
            if (s == null) { return ""; }
            return s.Replace("&", "&amp;").Replace("<", "&lt;")
                    .Replace(">", "&gt;").Replace("\"", "&quot;");
        }
    }
}
