using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;

public partial class adminhome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null || Session["type"] == null)
        {
            Response.Redirect("errorpage.aspx");
        }
    }
   
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("addscreen.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }

    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("addmovie.aspx");
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        Response.Redirect("updatemovie.aspx");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        Response.Redirect("assignmovie.aspx");
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("updatescreen.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("changepassword.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }
}
