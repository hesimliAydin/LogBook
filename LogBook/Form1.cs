namespace LogBook
{
    public partial class LogBook : Form
    {
        public List<Student> Students { get; set; }
        public LogBook()
        {
            InitializeComponent();

            Students = new List<Student>
            {
                new Student
                {
                    Number = 1,
                    FirtName="Aydin",
                    LastName="Hesimli",
                    FatherName="Alsan",
                    LastIn=DateTime.Now,
                    LaboratoryWork=11,ClassWork=12,
                    Crystal=2
                },
                new Student
                {
                    Number=2,
                    FirtName="Revan",
                    LastName="Sadiqov",
                    FatherName ="Elsen",
                    LastIn = DateTime.Now,
                    LaboratoryWork=12,ClassWork=13,
                    Crystal=3

                },
                new Student
                {
                    Number=3,
                    FirtName="Kamran",
                    LastName="Kerimzade",
                    FatherName ="Natiq",
                    LastIn = DateTime.Now,
                    LaboratoryWork=12,ClassWork=13,
                    Crystal=3
                },
                new Student
                {
                    Number=4,
                    FirtName="Revan",
                    LastName="Sadiqov",
                    FatherName ="Elsen",
                    LastIn = DateTime.Now,
                    LaboratoryWork=12,ClassWork=13,
                    Crystal=3

                },

            };
            LoadStudents();


        }

        public int location { get; set; }
        public void LoadStudents()
        {
            foreach (var s in Students)
            {
                var uc = new UserControl1(s);
                
                

                uc.Location = new Point(0, location);
                location += 200;
                
                this.panel1.Controls.Add(uc);
            }
        }



    }
}