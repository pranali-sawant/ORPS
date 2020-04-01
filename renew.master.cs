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
public partial class renew : System.Web.UI.MasterPage
{
    string strConnString = ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString;
    string str;
    SqlCommand com;
    SqlConnection fare = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\orps\\orps1\\App_Data\\reg.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        Label10.Text = DateTime.Now.ToString("dd:MM:yyyy");
        SqlConnection con = new SqlConnection(strConnString);
        con.Open();
        str = "select * from register where Username='" + Session["Username"] + "'";
        com = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader rdr = com.ExecuteReader();
        rdr.Read();
            Label2.Text = rdr["Name"].ToString();
        rdr.Close();
        con.Close();
        con.Open();
        str = "select * from passdetail where Name='" + Label2.Text + "'";
        com = new SqlCommand(str, con);
        SqlDataAdapter san = new SqlDataAdapter(com);
        SqlDataReader psr = com.ExecuteReader();
        psr.Read();
        Label4.Text = psr["SOURCE"].ToString();
        Label6.Text = psr["DESTINATION"].ToString();
        Label8.Text = psr["VIA"].ToString();
        //Label14.Text = psr["FARE"].ToString();
        Label12.Text = psr["EXP"].ToString();
        Label18.Text = psr["CLASS"].ToString();
        psr.Close();
        con.Close();

        if (DropDownList1.SelectedItem.Value == "MONTHLY")
        {
            Label12.Text = DateTime.Now.AddMonths(1).ToString("dd:MM:yyyy");
        }
        else
        {
            Label12.Text = DateTime.Now.AddMonths(3).ToString("dd:MM:yyyy");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into renew(NAME,SOURCE,DESTINATION,VIA,PERIOD,FARE,CLASS,EXP)values(@name,@src,@des,@via,@per,@fare,@cls,@dte)";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@name", Label2.Text);
            com.Parameters.AddWithValue("@src", Label4.Text);
            com.Parameters.AddWithValue("@des", Label6.Text);
            com.Parameters.AddWithValue("@per", DropDownList1.SelectedItem.Text);
            com.Parameters.AddWithValue("@cls", Label18.Text);
            com.Parameters.AddWithValue("@via", Label8.Text);
            com.Parameters.AddWithValue("@fare", Label14.Text);
            com.Parameters.AddWithValue("@dte", Label12.Text);
            com.ExecuteNonQuery();
            Response.Redirect("paysuccess.aspx");
            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error" + ex.ToString());
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand com;
        string str;

        fare.Open();
        str = "select fare from ROUTE where SOURCE='" + Label4.Text + "' and DESTINATION='" + Label6.Text + "'and CLASS='" + Label18.Text + "' and PERIOD='" + DropDownList1.SelectedItem.Text + "' and VIA='" +Label8.Text + "'";
        com = new SqlCommand(str, fare);
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
        {
            Label14.Text = reader["FARE"].ToString();
            reader.Close();
        }
        fare.Close();
    }
}
