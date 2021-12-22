using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB1_JS
{
    [Serializable]
    public class JSlista
    {
        public string  JSdane;

        public JSlista(string JSuzytkownik)
        {
            this.JSdane = JSuzytkownik;
        }
         public string getUz()
        {
            return this.JSdane;
        }
    }
}