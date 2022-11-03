using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook
{
    public class Student
    {
        public int Number { get; set; }
        public string? FirtName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public DateTime LastIn { get; set; }
        public int LaboratoryWork { get; set; }
        public int ClassWork { get; set; }
        public byte? Crystal { get; set; }


        public string FullName =>$"{FirtName} {LastName} {FatherName}";
        public Istirak Istirak { get; set; }


    }

    public enum Istirak {Gelmiyib,Gecikib,Istirak };
}
