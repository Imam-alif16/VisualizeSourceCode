using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizeSourceCode
{
    internal class ClassDataType
    {
        public int id { get; set; }
        public int target { get; set; }

        //public List<int> target = new List<int>();
        public string className { get; set; }
        public string superClass { get; set; }
       
        //public List<string> superClassList = new List<string>();

        public ClassDataType(string aClassName, string aSuperClass)
        {
            this.className = aClassName;
            this.superClass = aSuperClass;
            /*if (aSuperClass != "")
            {
                this.superClassList.Add(aSuperClass);
            }*/
        }


    }
}
