using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Subject
    {
        public string FavoriteSubject {  get; set; }

        public int Grade { get; set; }

        public Subject (string subject, int grade)
        {
            FavoriteSubject = subject;

            Grade = grade;
        }
    }
}
