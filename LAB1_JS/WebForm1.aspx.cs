using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Collections;
using System.Data;

namespace LAB1_JS
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["zmianyukladu"] = (int)Session["zmianyukladu"] + 1;
            switch (DropDownList1.SelectedItem.Value)
            {
                case "0":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "0%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "50%");
                    Image1.Style.Add("left", "50%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "100%");
                    Image2.Style.Add("left", "100%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "100%");
                    Image3.Style.Add("left", "0%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "0%");
                    Image4.Style.Add("left", "100%");
                    Image4.Style.Add("position", "absolute");

                    break;
                case "1":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "0%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "25%");
                    Image1.Style.Add("left", "25%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "75%");
                    Image3.Style.Add("left", "75%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "100%");
                    Image4.Style.Add("left", "100%");
                    Image4.Style.Add("position", "absolute");
                    break;
                case "2":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "100%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "25%");
                    Image1.Style.Add("left", "75%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "75%");
                    Image3.Style.Add("left", "25%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("bottom", "0%");
                    Image4.Style.Add("left", "0%");
                    Image4.Style.Add("position", "absolute");
                    break;
                case "3":
                    Image0.Style.Add("top", "50%");
                    Image0.Style.Add("left", "0%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "50%");
                    Image1.Style.Add("left", "25%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "50%");
                    Image3.Style.Add("left", "75%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "50%");
                    Image4.Style.Add("left", "100%");
                    Image4.Style.Add("position", "absolute");
                    break;
                case "4":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "50%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "25%");
                    Image1.Style.Add("left", "50%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "75%");
                    Image3.Style.Add("left", "50%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "100%");
                    Image4.Style.Add("left", "50%");
                    Image4.Style.Add("position", "absolute");
                    break;
                
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["zmianyrozmiaru"] = (int)Session["zmianyrozmiaru"] + 1;
            if (RadioButtonList1.SelectedItem.Value == "s")
            {
                Image0.Style.Add("height", "30px");
                Image0.Style.Add("width", "30px");

                Image1.Style.Add("height", "30px");
                Image1.Style.Add("width", "30px");

                Image2.Style.Add("height", "30px");
                Image2.Style.Add("width", "30px");

                Image3.Style.Add("height", "30px");
                Image3.Style.Add("width", "30px");

                Image4.Style.Add("height", "30px");
                Image4.Style.Add("width", "30px");

            }
            if (RadioButtonList1.SelectedItem.Value == "m")
            {
                Image0.Style.Add("height", "45px");
                Image0.Style.Add("width", "45px");
                Image1.Style.Add("height", "45px");
                Image1.Style.Add("width", "45px");
                Image2.Style.Add("height", "45px");
                Image2.Style.Add("width", "45px");
                Image3.Style.Add("height", "45px");
                Image3.Style.Add("width", "45px");
                Image4.Style.Add("height", "45px");
                Image4.Style.Add("width", "45px");
            }
            if (RadioButtonList1.SelectedItem.Value == "x")
            {
                Image0.Style.Add("height", "60px");
                Image0.Style.Add("width", "60px");
                Image1.Style.Add("height", "60px");
                Image1.Style.Add("width", "60px");
                Image2.Style.Add("height", "60px");
                Image2.Style.Add("width", "60px");
                Image3.Style.Add("height", "60px");
                Image3.Style.Add("width", "60px");
                Image4.Style.Add("height", "60px");
                Image4.Style.Add("width", "60px");


            }

            ;
        }
       

        protected void JSButton1_Click1(object sender, EventArgs e)
        {
            List<JSlista> JSusers = (List<JSlista>)Application["users"];
            if(!JSusers.Exists(x=> String.Equals(x.JSdane, JSTextBox1.Text)))
            {
                JSusers.Add(new JSlista(JSTextBox1.Text));
                Application["users"] = JSusers;
                CustomValidator1.IsValid = true;
                Session["Imie_nazwisko"] = JSTextBox1.Text;
                foreach (JSlista item in JSusers)
                {
                    Debug.WriteLine(item.getUz());
                }
                JSPanel1.Visible = true;
                JSPanel2.Visible = false;
                Label1.Text = JSTextBox1.Text;              
                Debug.WriteLine((int)Application["licznik"]);
            }
            else
            {
                CustomValidator1.IsValid = false;
                Debug.WriteLine("Takie imie jest juz w bazie");
                
            }
           
                
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            DropDownList dl = new DropDownList();
            List<JSlista> JSusers = (List<JSlista>)Application["users"];
            DropDownList2.Items.Clear();
            foreach (JSlista item in JSusers)
            {
                DropDownList2.Items.Add((string)item.getUz());
            }
            JSPanel1.Controls.Add(dl);
            Label2.Text = (string)Application["data"];
            Label3.Text = (string)Application["czas"];
            Label4.Text = Application["licznik"].ToString();
            Label5.Text = Session["zmianyrozmiaru"].ToString();
            Label6.Text = Session["zmianyukladu"].ToString();
        }
    }
}