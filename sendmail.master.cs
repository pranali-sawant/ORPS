using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net.Mail;
using System.Net;

public partial class sendmail : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void email_Click(object sender, EventArgs e)
    {
       MailMessage mailobj = new MailMessage(
            "orps.mumbai@gmail.com", "pranalis901@gmail.com", "PASS DETAILS", "test mail");
        SmtpClient SMTPServer = new SmtpClient("127.0.0.1");
        try
        {
            SMTPServer.Send(mailobj);
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Login.aspx");
    }
    protected void print_Click(object sender, EventArgs e)
    {
        Response.Redirect("print.aspx");
    }
}
