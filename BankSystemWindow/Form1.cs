using ClassLibrary2;

namespace BankSystemWindow
{
    public partial class Form1 : Form
    {
        private StudentManager manager = new StudentManager();
        public Form1()
        {
            InitializeComponent();
            LoadStudentToDataGridView();
        }
        public void LoadStudentToDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var studen in manager.students)
            {
                dataGridView1.Rows.Add(studen.Name, studen.Gender, studen.Age, studen.Id);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = txtGender.Text;
            int age = int.Parse(txtAge.Text);
            string id = txtId.Text;

            manager.addStudent(new Student(name, gender, age, id));
            LoadStudentToDataGridView();
            ClearTextBoxs();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string studenID = txtId.Text;
            manager.RemoveStudent(studenID);
            LoadStudentToDataGridView();
            ClearTextBoxs();
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = txtGender.Text;
            int age = int.Parse(s: txtAge.Text);
            string id = txtId.Text;

            manager.ModifyStudent(name, gender, age, id);
            LoadStudentToDataGridView();
            ClearTextBoxs();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string keyword = txtSerch.Text;
            dataGridView1.Rows.Clear();
            var results = manager.students.FindAll(s => s.Id == keyword || s.Name.Contains(keyword));
            foreach (var studen in results)
            {
                dataGridView1.Rows.Add(studen.Name, studen.Gender, studen.Age, studen.Id);

            }
        }

        private void btnSerchAll_Click(object sender, EventArgs e)
        {
            manager.DisplayAllStudents();
            LoadStudentToDataGridView();
        }


























        public void ClearTextBoxs()
        {
            txtAge.Clear();
            txtGender.Clear();
            txtName.Clear();
            txtId.Clear();
        }


    }
}
