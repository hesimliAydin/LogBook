namespace LogBook
{
    public partial class LogBook : Form
    {
        public LogBook()
        {
            InitializeComponent();

            var student = new List<Student>
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

                }
            };
        }

        
    }
}