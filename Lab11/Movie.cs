using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab11
{
    public class Movie
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }//my properties for class Movie
            set
            {
                title = value;
            }
        }
        private string category;
        public string Category
        {
            get
            {
                return category;
            }//my properties for class Movie
            set
            {
                category = value;
            }
        }
        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;//calling the properties
        }
    }
}

