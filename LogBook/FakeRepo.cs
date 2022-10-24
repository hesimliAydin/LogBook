using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook
{
    public class FakeRepo
    {
        public static List<Student> Students { get; set; } = new()
        {
            new Student(1,"Aydin","Hesimli","Alsan",new DateTime(2022,10,25),10,11,2)
        };
    }
}
