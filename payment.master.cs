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

public partial class payment : System.Web.UI.MasterPage
{
    string strConnString = ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString;
    string str;
    SqlCommand com;
    public SqlConnection get = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\orps\\orps1\\App_Data\\reg.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        Label11.Text = DateTime.Now.ToString("dd:MM:yyyy");
        SqlConnection con = new SqlConnection(strConnString);
        con.Open();
        str = "select * from register where Username='" + Session["Username"] + "'";
        com = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader rdr = com.ExecuteReader();
        rdr.Read();
        Label14.Text = rdr["Name"].ToString();
        rdr.Close();
        con.Close();
        con.Open();
        str = "select * from passdetail where Name='" +Label14.Text+ "'";
        com = new SqlCommand(str, con);
        SqlDataAdapter san = new SqlDataAdapter(com);
        SqlDataReader psr = com.ExecuteReader();
        psr.Read();
        Label3.Text = psr["SOURCE"].ToString();
        Label5.Text = psr["DESTINATION"].ToString();
        Label7.Text = psr["VIA"].ToString();
        Label9.Text = psr["FARE"].ToString();
        Label13.Text = psr["EXP"].ToString();
        Label16.Text = psr["CLASS"].ToString();
        psr.Close();
        con.Close();
         
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            Response.Redirect("paysuccess.aspx");
    }
}
