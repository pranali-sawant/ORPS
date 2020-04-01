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
public partial class payment : System.Web.UI.Page
{
    SqlConnection ver = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\orps\\orps1\\App_Data\\reg.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        /*SqlCommand com;
        string str;

        ver.Open();
        str = "select * from passdetail";
        com = new SqlCommand(str, ver);
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
        {
            nm.Text = reader["NAME"].ToString();
            co.Text = reader["CONTACT"].ToString();
            reader.Close();
            Label8.Text = "SUCCCESS";
            ver.Close();
        }*/
    }
}