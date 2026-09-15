namespace ArtSchool;

public partial class Form1 : Form
{
    // список учеников
    List<Student> students = new List<Student>();

    public Form1()
    {
        InitializeComponent();
    }

    // кнопка «Добавить»
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

    // вывод всех учеников в список
    private void UpdateList()
    {
        lstStudents.Items.Clear();
        foreach (Student s in students)
        {
            lstStudents.Items.Add($"{s.Name} — {s.Age} лет — {s.Direction}");
        }
    }

    // кнопка «Найти»
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

    // кнопка «Удалить»
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
