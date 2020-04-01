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



public partial class tcLogin : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string Username = TextBox1.Text.Trim();
        string Password = TextBox2.Text.Trim();
        SqlConnection con = new SqlConnection(strConnString);
        con.Open();
        str = "Select * from TcReg";
        com = new SqlCommand(str);
        sqlda = new SqlDataAdapter(com.CommandText, con);
        dt = new DataTable();
        sqlda.Fill(dt);
        RowCount = dt.Rows.Count;
        for (int i = 0; i < RowCount; i++)
        {
            Username = dt.Rows[i]["ID"].ToString();
            Password = dt.Rows[i]["Password"].ToString();
            if (Username == TextBox1.Text && Password ==TextBox2.Text)
            {
                Session["Username"] = Username;
                Response.Redirect("tcCheck.aspx");
            }
            else
            {
                Label3.Text = "Invalid User Name or Password! Please try again!";
            }
        }
    }
}