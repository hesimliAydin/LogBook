namespace LogBook
{
    public partial class LogBook : Form
    {
        public List<Student> Students { get; set; }
        public EventHandler<EventArgs>  DecreaseDiamond{ get; set; }
        public EventHandler<EventArgs> IncreaseDiamond { get; set; }
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
            DecreaseDiamond = new EventHandler<EventArgs>(DecreaseDiamondHandler);
            IncreaseDiamond = new EventHandler<EventArgs>(IncreaseDiamondHandler);
            LoadStudents();

        }

        public void IncreaseDiamondHandler(object sender, EventArgs args)
        {
            int number = int.Parse(label8.Text) + 1;
            if (number >= 0)
                label8.Text = (number).ToString();
            else MessageBox.Show("No Diamond");
        }
        public void DecreaseDiamondHandler(object sender,EventArgs args)
        {
            int number = int.Parse(label8.Text) - 1;
            if(number >= 0)
            label8.Text=(number).ToString();
            else MessageBox.Show("No Diamond");
        }

        public int location { get; set; }
        public void LoadStudents()
        {
            foreach (var s in Students)
            {
                var uc = new UserControl1(s);

                uc.DiamondClick = DecreaseDiamond;
                uc.DiamondClickIncrease = IncreaseDiamond;

                uc.Location = new Point(0, location);
                location += 200;
                
                this.panel1.Controls.Add(uc);
            }
        }



    }
}