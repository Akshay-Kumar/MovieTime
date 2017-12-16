using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class printpage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Visible = true;
        if (Session["da"] == null || Session["dt"] == null || Session["name"] == null || Session["userid"] == null || Session["email"] == null || Session["tid"] == null || Session["movname"] == null || Session["type"] == null || Session["slot"] == null || Session["screen"] == null || Session["fare"] == null || Session["date"] == null || Session["movid"] == null || Session["screenid"] == null || Session["location"] == null || Session["seatno"] == null || Session["payment"] == null || Session["noseat"] == null)
        {
            Response.Redirect("errorpage.aspx");
        }
        else
        {
            string tid = Session["tid"].ToString();
            string payment = Session["payment"].ToString();
            string sql = "update Transaction1 set payment='"+payment+"' where TransactionID='"+tid+"'";
            SqlCommand cmd = new SqlCommand(sql,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            string seat = Session["seatno"].ToString();
             seat = seat.Substring(0, seat.Length - 1);
             seat = seat + ".";
            Label12.Text = Session["email"].ToString();
            Label13.Text = Session["tid"].ToString();
            Label14.Text = seat;
            Label15.Text = Session["screen"].ToString();
            Label16.Text = Session["movname"].ToString();
            Label17.Text = Session["type"].ToString();
            Label18.Text = Session["slot"].ToString();
            Label19.Text = Session["date"].ToString();
            Label20.Text = Session["fare"].ToString();
            Label21.Text = Session["noseat"].ToString();
            Label23.Text = Session["payment"].ToString();
            string name = Session["name"].ToString();
            Label25.Text = name.ToUpper();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), "key", "window.print()", true);
        Button1.Visible = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }
}
