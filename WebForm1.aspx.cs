using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Task_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_DB;Integrated Security=True"); // nik...
        SqlCommand cmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountryList();
            }
        }
        private void BindCountryList()
        {
            try
            {
                        cmd.CommandText = "SELECT CountryId, County FROM Country";
                        cmd.Connection = con;
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "CountryId";
                        DropDownList1.DataTextField = "County";
                        DropDownList1.DataBind();
                        con.Close();
                        DropDownList1.Items.Insert(0, new ListItem("Please select country", "0"));
                        DropDownList2.Items.Insert(0, new ListItem("Please select state", "0"));
                        DropDownList3.Items.Insert(0, new ListItem("Please select City", "0"));
                    
            }
            catch { }
        }
       
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)    // DropDownList Country .........
        {
            try
            {
                cmd.CommandText = "SELECT StateID,State FROM countryState WHERE CountryId = @CountryId";
                cmd.Parameters.AddWithValue("@CountryId", DropDownList1.SelectedValue);
                cmd.Connection = con;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataValueField = "StateID";
                DropDownList2.DataTextField = "State";
                DropDownList2.DataBind();
                con.Close();
                DropDownList2.Items.Insert(0, new ListItem("Please select state", "0"));
            }
            catch { }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)    // DropDownList State .........
        {
            try
            {
                cmd.CommandText = "SELECT CountryId,City FROM State_City WHERE CountryId = '"+ DropDownList2.SelectedValue + "'";
                cmd.Connection = con;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList3.DataSource = dt;
                DropDownList3.DataValueField = "CountryId";
                DropDownList3.DataTextField = "City";
                DropDownList3.DataBind();
                con.Close();

                DropDownList3.Items.Insert(0, new ListItem("Please select city", "0"));
            }
            catch { }
        }
    }
}