using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class Answer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Accessing all the query params
            string result = Request["result"];
            string num1 = Request["num1"];
            string num2 = Request["num2"];
            string ops = Request["operator"];
            Console.WriteLine(ops);

            //Writing the result on page
            Response.Write(num1 + " " + ops + " " + num2 + " is " + result );
        }
    }
}