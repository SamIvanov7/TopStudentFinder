using System.Collections.Generic;
using System.Linq;

namespace SolarPowerEngineering
{
    public static class StudentCollection
    {
        public static Student FindTopStudent(IEnumerable<Student> students)
        {
            return students.OrderByDescending(s => s.Grade).FirstOrDefault();
        }
    }
}
