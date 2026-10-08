using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Teacher
    {
        public string Name { get; set; }

        public string Subject { get; set; }

        public Teacher (string name, string subject)
        {
            Name = name;

            Subject = subject;
        }
    }
}
