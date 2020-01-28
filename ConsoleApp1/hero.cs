using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class hero
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public virtual string FirstSkill()
        {
            return "Asasdasdasd";
        }

        public virtual void SecondSkill()
        {

        }

        public virtual void ThirdSkill()
        {

        }

        public virtual void Ultimate()
        {

        }
    }
}
