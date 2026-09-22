using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArtSchool
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Введите ФИО ученика");
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text, out age) || age < 5 || age > 18)
            {
                MessageBox.Show("Введите возраст от 5 до 18 лет");
                return;
            }

            Student student = new Student();
            student.Name = txtName.Text;
            student.Age = age;
            student.Direction = txtDirection.Text;
            students.Add(student);

            UpdateList();

            txtName.Clear();
            txtAge.Clear();
            txtDirection.Clear();
        }

        private void UpdateList()
        {
            lstStudents.Items.Clear();
            foreach (Student s in students)
            {
                string text = s.Name + " — " + s.Age + " лет";
                lstStudents.Items.Add(text + " — " + s.Direction);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Student s in students)
            {
                if (s.Name.Contains(txtSearch.Text))
                {
                    MessageBox.Show("Найдено:\n\n" + s.Name + "\nВозраст: " + s.Age +
                        " лет\nНаправление: " + s.Direction);
                    return;
                }
            }
            MessageBox.Show("Ученик не найден");
        }

        // кнопка «Рассчитать стоимость»
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ученика в списке");
                return;
            }

            int months;
            if (!int.TryParse(txtMonths.Text, out months))
            {
                MessageBox.Show("Введите количество месяцев числом");
                return;
            }
            if (months < 1 || months > 12)
            {
                MessageBox.Show("Количество месяцев должно быть от 1 до 12");
                return;
            }

            CalculateTuition(months);
        }

        // расчёт стоимости обучения выбранного ученика
        private void CalculateTuition(int months)
        {
            Student s = students[lstStudents.SelectedIndex];
            int price = 3000;
            if (s.Direction == "Живопись" || s.Direction == "Скульптура")
            {
                price = 4000;
            }
            int total = price * months;
            lblResult.Text = "Стоимость обучения: " + total + " руб.";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ученика в списке");
                return;
            }

            students.RemoveAt(lstStudents.SelectedIndex);
            UpdateList();
        }
    }
}
