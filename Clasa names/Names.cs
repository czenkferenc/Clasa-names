using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_names
{
    class Names
    {
        private List<string> names;

        public Names()
        {
            names = new List<string>();
            names.Add("FirstName LastName");
        }

        public string this[int IntIndex]
        {
            get 
            { 
                if (IntIndex < names.Count) return names.ElementAt(IntIndex);
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (IntIndex < names.Count) names[IntIndex] = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public string this[string StringIndex]
        {
            get
            {
                string NameFound = "";
                bool IsFound = false;
                for (int i = 0; i < names.Count; i++)
                {
                    if(names[i] == StringIndex)
                    {
                        NameFound = names[i];
                        IsFound = true;
                    }
                }
                if (IsFound == false) throw new NoNameFoundExcepion();
                else return NameFound;
            }
        }

        public void Add(string Name)
        {
            names.Add(Name);
        }

        public void DisplayNames()
        {
            foreach(string name in names)
                Console.WriteLine(name);
        }
    }
}
