using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public partial class userMaster : System.Web.UI.MasterPage
{
    string strConnString = ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString;
    string str;
    SqlCommand com;
    SqlConnection fare = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\orps\\orps1\\App_Data\\reg.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (DropDownList4.SelectedItem.Value == "MONTHLY")
        {
            Label17.Text = DateTime.Now.AddMonths(1).ToString("dd:MM:yyyy");
        }
        else
        {
            Label17.Text = DateTime.Now.AddMonths(3).ToString("dd:MM:yyyy");
        }
        SqlConnection con = new SqlConnection(strConnString);
        con.Open();
        str = "select * from register where Username='" + Session["Username"] + "'";
        com = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader rdr = com.ExecuteReader();
        rdr.Read();
        TextBox1.Text = rdr["Name"].ToString();
        rdr.Close();
        con.Close();
     }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into passdetail(NAME,SOURCE,DESTINATION,VIA,PERIOD,FARE,CLASS,EXP)values(@name,@src,@des,@via,@per,@fare,@cls,@dte)";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@name",TextBox1.Text);
            com.Parameters.AddWithValue("@src", DropDownList1.SelectedItem.Text);
            com.Parameters.AddWithValue("@des", DropDownList2.SelectedItem.Text);
            com.Parameters.AddWithValue("@per", DropDownList4.SelectedItem.Text);
            com.Parameters.AddWithValue("@cls", DropDownList3.SelectedItem.Text);
            com.Parameters.AddWithValue("@via", DropDownList5.SelectedItem.Text);
            com.Parameters.AddWithValue("@fare", Label16.Text);
            com.Parameters.AddWithValue("@dte", Label17.Text);
            com.ExecuteNonQuery();
            Response.Redirect("payment.aspx");
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
        str = "select fare from ROUTE where SOURCE='" + DropDownList1.SelectedItem.Text + "' and DESTINATION='" + DropDownList2.SelectedItem.Text + "'and CLASS='" + DropDownList3.SelectedItem.Text + "' and PERIOD='" + DropDownList4.SelectedItem.Text + "' and VIA='" + DropDownList5.SelectedItem.Text + "'";
        com = new SqlCommand(str, fare);
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
        {
            Label16.Text = reader["FARE"].ToString();
            reader.Close();
        }
        fare.Close();
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
 
    }
}