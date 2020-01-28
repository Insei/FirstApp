using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class employee : people
    {
        private string _workspace;

        public string workspace
        {
            get
            {
                return _workspace;
            }
            set
            {
                _workspace = value;
            }
        }
    }
}
