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
        public DateTime? LastIn { get; set; }
        public byte? LaboratoryWork { get; set; }
        public byte? ClassWork { get; set; }
        public byte? Crystal { get; set; }


        public Student(int number, string? firtName, string? lastName, string? fatherName, DateTime? lastIn, byte? laboratoryWork, byte? classWork, byte? crystal)
        {
            Number = number;
            FirtName = firtName;
            LastName = lastName;
            FatherName = fatherName;
            LastIn = lastIn;
            LaboratoryWork = laboratoryWork;
            ClassWork = classWork;
            Crystal = crystal;
        }



        public override string ToString()
        {
            return $"{FirtName} {LastName} {FatherName}";
        }

    }
}
