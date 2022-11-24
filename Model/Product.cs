using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Model
{
    class Product
    {
        User User;
        string _name;
        double _price;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 2)
                {
                    _name=value;
                }
            }
        }


    }
}
