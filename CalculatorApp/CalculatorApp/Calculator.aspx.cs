using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Calculate(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numX.Text);
            double num2 = Convert.ToDouble(numY.Text);

            double result = 0;
            

            if(dropdown.SelectedValue == "+")
            {
                result = num1 + num2;
            } 
            else if (dropdown.SelectedValue == "-")
            {
                result = num1 - num2;

            }
            else if (dropdown.SelectedValue == "*")
            {
                result = num1 * num2;

            }
            else if (dropdown.SelectedValue == "/")
            {
                result = num1 / num2;

            }
            string operation = dropdown.SelectedValue;

            //Query string
            string myStr = "Answer.aspx?result=" + result + "&num1=" + num1 + "&num2=" + num2 + "&operator=" + HttpUtility.UrlEncode(operation);

            //Redirectig page  
            Response.Redirect(myStr);

            
        }


    }
}