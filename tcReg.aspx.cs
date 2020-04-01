using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

public partial class tcReg : System.Web.UI.Page
{
    public SqlConnection sad = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Pranali\\Desktop\\orps\\orps1\\App_Data\\reg.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
           conn.Open();
           string insertQuery = "insert into TcReg(ID,Name,Password) values(@id,@name,@pass)";
           SqlCommand com = new SqlCommand(insertQuery, conn);
           com.Parameters.AddWithValue("@id", TextBox1.Text);
           com.Parameters.AddWithValue("@name",TextBox2.Text);
           com.Parameters.AddWithValue("@pass", TextBox3.Text);
           com.ExecuteNonQuery();
           Response.Redirect("tcLogin.aspx");
           conn.Close();
           ClearTextBox();
        }
        catch (Exception ex)
        {
            Response.Write("Error" + ex.ToString());
        }
    }
 
    private void ClearTextBox()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlCommand com;
        string str;
        sad.Open();
        str = "select * from TcVerify where ID='" + TextBox1.Text + "'";
        com = new SqlCommand(str, sad);
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
        {
            TextBox2.Text = reader["Name"].ToString();
            reader.Close();
            Label5.Text = "SUCCCESS";
            sad.Close();
        }
        else
        {
            Label5.Text  = "FAILED";

        }
    }
}