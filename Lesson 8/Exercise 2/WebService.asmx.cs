using System;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
public class CalculatorService : System.Web.Services.WebService
{
    [WebMethod]
    public int Add(int a, int b)
    {
        return a + b;
    }

    [WebMethod]
    public float Subtract(float A, float B)
    {
        return A - B;
    }

    [WebMethod]
    public float Multiply(float A, float B)
    {
        return A * B;
    }

    [WebMethod]
    public float Divide(float A, float B)
    {
        if (B == 0) return -1;
        return Convert.ToSingle(A / B);
    }
}