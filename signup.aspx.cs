using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

//using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{

    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    public void GetError()
    {
        TextBox5.Text = TextBox4.Text = TextBox3.Text = TextBox2.Text = TextBox1.Text = "";
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        DropDownList1.Items.Clear();
        DropDownList2.Items.Clear();
        Label14.Text = "Please fill up all the above required '*' fields.";
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || DropDownList1.SelectedItem.ToString() == "" || DropDownList2.SelectedItem.ToString() == "" || RadioButton1.Checked == false && RadioButton2.Checked == false)
        {
            GetError();
        }
        else
        {

            string email = TextBox1.Text;
            string pass = TextBox2.Text;
            String fname = TextBox3.Text;
            String lname = TextBox4.Text;
            String gender=null;
            if (RadioButton1.Checked == true)
            {
                gender = "MALE";
            }
            if (RadioButton2.Checked == true)
            {
                gender = "FEMALE";
            }
            string state = DropDownList1.SelectedItem.ToString();
            string city = DropDownList2.SelectedItem.ToString();
            string phone = TextBox5.Text;
            string dob = TextBox6.Text;
            string address = TextBox7.Text;
    
            SqlDataReader dr;
            string userid=null;
            string sql1 = "select MAX(SUBSTRING(user_id,2,10)) from username";
            SqlCommand cmd = new SqlCommand(sql1, con1);
            con1.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               userid = dr.GetValue(0).ToString();
            }
            con1.Close();
            
            int i = int.Parse(userid);
            i=i+1;
            
            String sql = "insert into username(user_id,type,email,password,fname,lname,gender,state,city,phone,dob,address) values(@u,@t,@e,@p,@f,@l,@g,@s,@c,@ph,@dob,@addr)";
            SqlCommand cmd1 = new SqlCommand(sql,con1);
            cmd1.Parameters.Add("@u", SqlDbType.VarChar);
            cmd1.Parameters.Add("@t", SqlDbType.VarChar);
            cmd1.Parameters.Add("@e", SqlDbType.VarChar);
            cmd1.Parameters.Add("@p", SqlDbType.VarChar);
            cmd1.Parameters.Add("@f", SqlDbType.VarChar);
            cmd1.Parameters.Add("@l", SqlDbType.VarChar);
            cmd1.Parameters.Add("@g", SqlDbType.VarChar);
            cmd1.Parameters.Add("@s", SqlDbType.VarChar);
            cmd1.Parameters.Add("@c", SqlDbType.VarChar);
            cmd1.Parameters.Add("@ph", SqlDbType.BigInt);
            cmd1.Parameters.Add("@dob", SqlDbType.VarChar);
            cmd1.Parameters.Add("@addr", SqlDbType.VarChar);
            string type = Session["type"].ToString();
            if ( type == "a")
            {
                cmd1.Parameters["@u"].Value = "a" + i.ToString();
                cmd1.Parameters["@t"].Value = "a";
            }
            else
            {
                cmd1.Parameters["@u"].Value = "u" + i.ToString();
                cmd1.Parameters["@t"].Value = "u";
            }
            cmd1.Parameters["@e"].Value = email;
            cmd1.Parameters["@p"].Value = pass;
            cmd1.Parameters["@f"].Value = fname;
            cmd1.Parameters["@l"].Value = lname;
            cmd1.Parameters["@g"].Value = gender;
            cmd1.Parameters["@s"].Value = state;
            cmd1.Parameters["@c"].Value = city;
            cmd1.Parameters["@ph"].Value = phone;
            cmd1.Parameters["@dob"].Value = dob;
            cmd1.Parameters["@addr"].Value = address; 
            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();
            TextBox6.Text = TextBox7.Text = TextBox5.Text = TextBox4.Text = TextBox3.Text = TextBox2.Text = TextBox1.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            DropDownList1.Items.Clear();
            DropDownList2.Items.Clear();
            Label14.Text = "Added successfully!";
            Label15.Text = "";

            if (type == "a")
            {
                LinkButton1.Visible = false;
                LinkButton2.Text = "Go to Admin page!";
            }
            else
            {
                LinkButton1.Text = "Go to Homepage!";
            }
                                                      
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
       
        {
            SqlDataReader dr;
            SqlCommand cmd2 = new SqlCommand("select state from State",con1);
            con1.Open();
            dr = cmd2.ExecuteReader();
            DropDownList1.Items.Add("Select");
            while (dr.Read())
            {
               String s = dr.GetValue(0).ToString();
               DropDownList1.Items.Add(s);
               
            }
            
            con1.Close();
          
        }
        
    }
    public void LoadData()
    {
        
        string state1 = DropDownList1.SelectedItem.ToString();
        SqlDataReader dr;
        SqlCommand cmd3 = new SqlCommand("select city1,city2,city3,city4,city5 from State where state='"+state1+"'",con1);
        con1.Open();
        dr = cmd3.ExecuteReader();
        while(dr.Read())
        {
            for (int i = 0; i < 5; i++)
            {
                String aks = dr.GetValue(i).ToString();
                DropDownList2.Items.Add(aks);
            }
            
        }
        con1.Close();
        
    }
    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("Select");
        LoadData(); 
    }
    protected void Button1_Click(object sender, EventArgs e)
    {



        string t1 = TextBox1.Text;
        int n = t1.IndexOf("@");
        int x = t1.IndexOf("co");
        int y = t1.IndexOf("CO");
        if (n != -1 && x!=-1 || y!=-1)
        {
            string k = (t1.Substring(n, 1));
            if(k=="@")

            {
            
                int count = 0;
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand("select count(*) from username where email='" + t1 + "'", con1);
                con1.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count = int.Parse(dr.GetValue(0).ToString());
                }
                if (count == 0)
                {
                    Label15.Text = "Available!";
                }
                else
                {
                    Label15.Text = "Email Id Already Exists Try another one!";
                    TextBox1.Text = "";
                }
            }
        }
            else
            {

                Label15.Text = "Please enter a valid email id!";
                TextBox1.Text = "";

            }


        }
    
    
   
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
}
