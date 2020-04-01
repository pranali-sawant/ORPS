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
public partial class tcCheck : System.Web.UI.Page
{
    string strConnString = ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString;
    string str;
    SqlCommand com;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strConnString);
        con.Open();
        str = "select * from register where ID='" + TextBox1.Text + "'";
        com = new SqlCommand(str, con);
        SqlDataAdapter san = new SqlDataAdapter(com);
        SqlDataReader psr = com.ExecuteReader();
        if (psr.Read())
        {
            Label3.Text = psr["NAME"].ToString();
            psr.Close();
            Label21.Text = "SUCCCESS";
            con.Close();
        }
        else
        {
            Label21.Text = "FAILED";
        }
        con.Open();
        str = "select * from passdetail where Name='"+ Label3.Text +"'";
        com = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader rdr = com.ExecuteReader();
        rdr.Read();
        Label7.Text = rdr["SOURCE"].ToString();
        Label9.Text = rdr["DESTINATION"].ToString();
        Label11.Text = rdr["VIA"].ToString();
        Label13.Text = rdr["FARE"].ToString();
        Label20.Text = rdr["CLASS"].ToString();
        Label23.Text = rdr["PERIOD"].ToString();
        Label15.Text = rdr["EXP"].ToString();
        rdr.Close();
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("tcSelect.aspx");
    }
}