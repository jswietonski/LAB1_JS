using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LAB1_JS
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["users"] = new List<JSlista>();
            Application["licznik"] = 0;
            Application["data"] = DateTime.Now.ToString("dd.MM.yyy");
            Application["czas"] = DateTime.Now.ToString("h:mm:ss tt");
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["licznik"] = (int)Application["licznik"] + 1;
            Session["zmianyrozmiaru"] = 0;
            Session["zmianyukladu"] = 0;

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["licznik"] = (int)Application["licznik"] - 1;
            List<JSlista> JSusers = (List<JSlista>)Application["users"];
            JSlista doUsunicia = JSusers.Single(r => String.Equals(r.JSdane, (string)Session["Imie_nazwisko"]));
            JSusers.Remove(doUsunicia);
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}