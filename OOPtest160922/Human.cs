using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtest160922
{
    public class Human
    {
        private string _name;
        private int _height;
        private int _weight;


        public string Name { 
            get 
            { 
                return _name; 
            } 
            set 
            { 
                _name = value; 
            } 
        }

        public int Height { 
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public int BMI
        {
            get { 
                return (_weight * 10000) / (_height * _height);
            }
        }

        public Human( string name, int weight, int height  )
        {
            _name = name; 
            _height = height;
            _weight = weight;
        }

    }
}
