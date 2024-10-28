using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librar
{
    internal abstract class LibraryItem
    {
        public string Title { get; private set; }
        public int? PublicationYear { get; private set; }

        protected LibraryItem(string title, int? publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public abstract void DisplayInfo();
    }
}
    
