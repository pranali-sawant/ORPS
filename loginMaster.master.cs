using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


public partial class loginMaster : System.Web.UI.MasterPage
{
    string strConnString = ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString;
    SqlCommand com;
    SqlDataAdapter sqlda;
    string str;
    DataTable dt;
    int RowCount;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
protected void  Button1_Click1(object sender, EventArgs e)
{
    string Username = us1.Text.Trim();
    string Password = ps1.Text.Trim();
    SqlConnection con = new SqlConnection(strConnString);
    con.Open();
    str = "Select * from register";
    com = new SqlCommand(str);
    sqlda = new SqlDataAdapter(com.CommandText, con);
    dt = new DataTable();
    sqlda.Fill(dt);
    RowCount = dt.Rows.Count;
    for (int i = 0; i < RowCount; i++)
    {
        Username = dt.Rows[i]["Username"].ToString();
        Password = dt.Rows[i]["Password"].ToString();
        if (Username == us1.Text && Password == ps1.Text)
        {
            Session["Username"] = Username;
            Response.Redirect("select.aspx");
        }
        else
        {
            Label3.Text = "Invalid User Name or Password! Please try again!";
        }
    }
}
}
