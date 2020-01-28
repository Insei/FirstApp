using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class people
    {
        private string _name;
        private string _lastname;
        private int _age;

        public people()
        {
            _name = "";
            _lastname = "";
            _age = -1;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            
            _name = name;
        }

        public string GetLastName()
        {
            return _lastname;
        }
        public void SetLastName(string lastname)
        {

            _lastname = lastname;
        }

        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {

            _age = age;
        }

        public string GetFI()
        {
            string FI = _lastname + " " + _name;
            return FI;
        }

        public void SetFI(string FI)
        {
            var arrayFI = FI.Split(" ");
            SetName(arrayFI[0]);
            SetLastName(arrayFI[1]);
        }
    }
}
