using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librar
{
    internal class librarian : Person
    {
        public DateTime HireDate { get; set; }

        public librarian(string name, DateTime hireDate) : base(name)
        {
            HireDate = hireDate;
        }
    }
}
