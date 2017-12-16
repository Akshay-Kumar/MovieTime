using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Data.SqlClient;
public partial class user : System.Web.UI.Page
{
   
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    //Data Source=.\SQLEXPRESS;AttachDbFilename="G:\Documents and Settings\AKKI\Desktop\amit\web.mdf";Integrated Security=True
    SqlDataAdapter da;
    SqlCommandBuilder cb;
    DataSet ds;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Label12.Text = "Welcome Guest!";
        }
        else
        {
            string mail = Session["email"].ToString();
            string sql = "select fname from username where email='" + mail + "'";
            SqlCommand cmd5 = new SqlCommand(sql, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd5.ExecuteReader();
            while (dr.Read())
            {
                string str = dr.GetValue(0).ToString();
                Label12.Text = "Welcome" + " " + str + "!";
                Session["name"] = str;
            }
            con.Close();
        }
        

        if (IsPostBack == false)
        {
            if (DropDownList1.Items.ToString()!=null)
            {
                DropDownList2.Enabled = true;
            }
            if (DropDownList1.Items.ToString() == null)
            { DropDownList2.Enabled = false; }
            DropDownList1.Items.Add("select");
            string sql6 = "select MovieName from Movie";
            da = new SqlDataAdapter(sql6, con);
            ds = new DataSet();
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "emp2");
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = dt.Rows[i][0].ToString();
                DropDownList1.Items.Add(s);
            }

            DropDownList2.Items.Add("select");
            string sql2 = "select Addr from Screen";
            da = new SqlDataAdapter(sql2, con);
            ds = new DataSet();
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "emp4");
            DataTable dt2 = ds.Tables[0];
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                string s = dt2.Rows[i][0].ToString();
                DropDownList2.Items.Add(s);
            }
        }
    }
    
   
    protected void LoadData()
    {
      
        string x1 = DropDownList1.SelectedItem.ToString();
        string x2 = DropDownList2.SelectedItem.ToString();
        string sql = "select * from View2 where MovieName='"+x1+"' and Addr='"+x2+"'";
        da = new SqlDataAdapter(sql, con);
        ds = new DataSet();
        cb = new SqlCommandBuilder(da);
        da.Fill(ds, "emp");
        Session["da"] = da;
        Session["dt"] = ds.Tables[0];

    }
    protected void GetData()
    {
        DataTable dt = (DataTable)Session["dt"];
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        LoadData();
        GetData();
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("signup.aspx");
        }
        else
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridViewRow row;
                row = GridView1.Rows[i];
                RadioButton rb;
                rb = (RadioButton)row.FindControl("radiobutton1");

                if (rb.Checked = true)
                {


                    Label l1 = (Label)row.FindControl("label1");//movname
                    Label l2 = (Label)row.FindControl("label5");//type
                    Label l3 = (Label)row.FindControl("label2");//screen
                    Label l4 = (Label)row.FindControl("label3");//slot
                    Label l5 = (Label)row.FindControl("label4");//fare

                    Label l7 = (Label)row.FindControl("label10");//date  
                    Label l8 = (Label)row.FindControl("label8");//location
                    Label l9 = (Label)row.FindControl("label6");//movie id
                    
                    //SESSIONS----------------------------------------------------------------
                    Session["movname"] = l1.Text;
                    Session["type"] = l2.Text;
                    Session["screen"] = l3.Text;
                    Session["slot"] = l4.Text;
                    Session["fare"] = l5.Text;
                    Session["date"] = l7.Text;
                    Session["location"] = l8.Text;
                    Session["movid"] = l9.Text;
                    //SESSIONS-------------------------------------------------------------

                        string sqlcd = "select MAX(SUBSTRING(TransactionID,2,10)) from Transaction1";
                        //string sqlcd = "select MAX(TransactionID) from Transaction1";
                        SqlCommand cmdd = new SqlCommand(sqlcd, con);
                        SqlDataReader dr;
                        
                       // string s2 = null;
                        con.Open();
                        dr = cmdd.ExecuteReader();
                        int x = 0; 
                        while (dr.Read())
                        {
                            string s1 = dr.GetValue(0).ToString();
                            x = int.Parse(s1);
                        }
                        con.Close();

                         x++;
                        string y = "T" + x.ToString();
                        Session["tid"] = y;
                        //Session["ftid"] = s2;

                        string sqlstmt = "insert into Transaction1 (UserID,TransactionID,MovieID,MovieName,type,slot,fare,Dt,location) values (@userid,@t,@mid,@mname,@type,@slot,@fare,@date,@location)";
                        SqlCommand cmd1 = new SqlCommand(sqlstmt, con);
                        cmd1.Parameters.Add("@userid", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@t", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@mid", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@mname", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@type", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@slot", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@fare", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@date", SqlDbType.VarChar);
                        cmd1.Parameters.Add("@location", SqlDbType.VarChar);
                        cmd1.Parameters["@userid"].Value = Session["userid"].ToString();
                        cmd1.Parameters["@t"].Value = y;
                        cmd1.Parameters["@mid"].Value = l9.Text;
                        cmd1.Parameters["@mname"].Value = l1.Text;
                        cmd1.Parameters["@type"].Value = l2.Text;
                        cmd1.Parameters["@slot"].Value = l4.Text;
                        cmd1.Parameters["@fare"].Value = l5.Text;
                        cmd1.Parameters["@date"].Value = l7.Text;
                        cmd1.Parameters["@location"].Value = l8.Text;


                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        Trans();
                        Response.Redirect("seatbook.aspx");
                       
                }
            }
        }
    }

    protected void Trans()
    {
        string sid = null;
        string mid = Session["movid"].ToString();
        string sql2 = "select ScreenID from View2 where MovieID='" + mid + "'";
        SqlCommand cmd2 = new SqlCommand(sql2, con);
        SqlDataReader dr=null;
        con.Open();
        dr = cmd2.ExecuteReader();
        while (dr.Read())
        {
            sid = dr.GetValue(0).ToString();
            Session["screenid"] = sid;
        }
        
       con.Close();
        string trans = Session["tid"].ToString();
        string movieid = Session["movid"].ToString();
        string sql9 = "update Transaction1 set ScreenID='" + sid + "' where TransactionID='"+trans+"' and MovieID='"+movieid+"'";
        SqlCommand cmdnd = new SqlCommand(sql9,con);
        con.Open();
        cmdnd.ExecuteNonQuery();
        con.Close();
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        //Clear the existing selected row
        foreach (GridViewRow oldrow in GridView1.Rows)
        {
            ((RadioButton)oldrow.FindControl("radiobutton1")).Checked = false;
        }

        //Set the new selected row
        RadioButton rb = (RadioButton)sender;
        GridViewRow row = (GridViewRow)rb.NamingContainer;
        ((RadioButton)row.FindControl("radiobutton1")).Checked = true;
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
      
    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("changepassword.aspx");
    }
}
  

