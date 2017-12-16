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
using System.Data.SqlClient;

public partial class addmovie : System.Web.UI.Page
{
    SqlDataReader dr;
   // SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\koushik\\Desktop\\project\\New folder\\omb\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
   // SqlConnection con1 = new SqlConnection(" Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\omb\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
   // SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\dotnet project\\BALLE BALLE\\BALLE BALLE\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null || Session["type"] == null)
        {
            Response.Redirect("errorpage.aspx");
        }
        string sql1 = "select MAX(SUBSTRING(MovieID,2,4)) from Movie";
        SqlCommand cmd = new SqlCommand(sql1, con1);
        con1.Open();
        dr = cmd.ExecuteReader();
        String m=null;
        while (dr.Read())
        {
            m = dr.GetValue(0).ToString();
        }
        con1.Close();

        int i = int.Parse(m);
        i = i + 1;
        TextBox1.Text = "m" + i.ToString();
       }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }
    
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i=0;
        if (TextBox2.Text.Length==0)
        {
            Label9.Text = "Movie name cannot be left blank";
            i++;
        }   
          
         if (TextBox3.Text.Length == 0)
         {Label10.Text = "Actor detail cannont be left blank";
         i++;}
                
          if (DropDownList1.SelectedIndex==0)
          {Label11.Text = "please select a language";
          i++;}

           if (DropDownList2.SelectedIndex==0)
           { Label12.Text = "please select a type";
           i++;
           }

                        if (DropDownList3.SelectedIndex==0)
                        {
                            Label13.Text = "please enter the rating";
                        
                            i++;
                        }

                             
                            if(i==0)
                            {
                            SqlCommand cmd1 = new SqlCommand("insert into Movie(MovieID,MovieName,ActorDetails,Lang,Type,rated) VALUES(@mid,@mn,@Ad,@la,@ty,@rt)", con1);

                            cmd1.Parameters.Add("@mid", SqlDbType.VarChar);
                            cmd1.Parameters.Add("@mn", SqlDbType.VarChar);
                            cmd1.Parameters.Add("@ad", SqlDbType.VarChar);
                            cmd1.Parameters.Add("@la", SqlDbType.VarChar);
                            cmd1.Parameters.Add("@ty", SqlDbType.VarChar);
                            cmd1.Parameters.Add("@rt", SqlDbType.VarChar);
                            cmd1.Parameters["@mid"].Value = TextBox1.Text;
                            cmd1.Parameters["@mn"].Value = TextBox2.Text;
                            cmd1.Parameters["@ad"].Value = TextBox3.Text;
                            cmd1.Parameters["@la"].Value = DropDownList3.SelectedItem.ToString();
                            cmd1.Parameters["@ty"].Value = DropDownList1.SelectedItem.ToString();
                            cmd1.Parameters["@rt"].Value = DropDownList2.SelectedItem.ToString();




                            con1.Open();
                            cmd1.ExecuteNonQuery();
                            con1.Close();
                            Page_Load(sender, e);
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            DropDownList1.SelectedIndex = 0;
                            DropDownList2.SelectedIndex = 0;
                            DropDownList3.SelectedIndex = 0;
                           Label7.Text = " Last Movie Added Successfully enter new movie detail";
                            }
                         
                        }

                    
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("movie.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        DropDownList1.SelectedIndex=0;
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        Label11.Text = "";
        Label7.Text = "";
        Label12.Text = "";
        Label9.Text = "";
        Label10.Text = "";
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
   

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("changepassword.aspx");
    }
}
