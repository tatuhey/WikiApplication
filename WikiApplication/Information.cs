using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiApplication
{

    // 6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure 
    // Matrix as a guide). Use private properties for the fields which must be of type “string”. The class file must 
    // have separate setters and getters, add an appropriate IComparable for the Name attribute. Save the class Information.cs”.
    internal class Information: IComparable<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public Information() { }

        public Information(string newName, string newCategory, string newStructure, string newDefinition)
        {
            name = newName;
            category = newCategory;
            structure = newStructure;
            definition = newDefinition;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
        }

        public void setCategory(string newCategory)
        {
            category = newCategory;          
        }

        public string getCategory()
        {
            return category;
        }

        public void setStructure(string newStructure)
        {
            structure = newStructure;
        }

        public string getStructure()
        {
            return structure;
        }

        public void setDefinition(string newDefinition)
        {
            definition = newDefinition;
        }

        public string getDefinition()
        {
            return definition;
        }

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
