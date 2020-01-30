using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class hero
    {
        private string _name;
        private string _class;
        private int _health;
        private int _mana;

        public hero()
        {
            _name = "";
            _class = "";
            _health = -1;
            _mana = -1;
        } 

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

        public string Class
        {
            get
            {
                return _class;
            }

            set
            {
                _class = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            } 
        }

        public int Mana
        {
            get
            {
                return _mana;
            }

            set
            {
                _mana = value;
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
