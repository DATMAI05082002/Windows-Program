using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculatorService service = new CalculatorService();

            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            switch (ddlOperation.SelectedValue)
            {
                case "Add":
                    lblResult.Text = $"Result: {service.Add(num1, num2)}";
                    break;

                case "Subtract":
                    lblResult.Text = $"Result: {service.Subtract(num1, num2)}";
                    break;

                case "Multiply":
                    lblResult.Text = $"Result: {service.Multiply(num1, num2)}";
                    break;

                case "Divide":
                    lblResult.Text = $"Result: {service.Divide(num1, num2)}";
                    break;

                default:
                    lblResult.Text = "Invalid operation!";
                    break;
            }
        }
    }
}