using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiApplication
{
    internal class Information: IComparable<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public Information(string newName, string newCategory, string newStructure, string newDefinition)
        {
            name = newName;
            category = newCategory;
            structure = newStructure;
            definition = newDefinition;
        }


        // needs fixing
        public int CompareTo(Information other)
        {
            if (other == null)
            {
                return 1;
            }
            return name.CompareTo(other.name);
        }
    }
}
