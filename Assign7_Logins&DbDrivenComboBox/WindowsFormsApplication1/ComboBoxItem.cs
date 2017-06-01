using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /* ********************************************************
     * Extra-Credit:    Design an object to hold a Person's
     * Name and their Person_ID
     * *******************************************************/
    class ComboBoxItem
    {
        //private string FName;
        //public int Person_ID;

        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
