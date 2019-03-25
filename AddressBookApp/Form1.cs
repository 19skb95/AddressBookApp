using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder l;
        DataSet ds = new DataSet();
        int id;
        SqlConnection GetConnection()
        {
            return (new SqlConnection(@"data source = DESKTOP-3LP5LOL\SQLEXPRESS; initial catalog = AddressBook_db; Integrated security = true;"));
        }
        public void Bindid()
        {
            using (con = GetConnection())
            {
                using (SqlCommand com = new SqlCommand("SELECT TOP 1 address_id FROM tbl_ddressBook ORDER BY firstName DESC ", con))
                {
                    con.Open();
                    id = (int)com.ExecuteScalar();
                    con.Close();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        void FillDataSet()
        {
            con = GetConnection();
            da = new SqlDataAdapter("select * from tbl_ddressBook", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            l = new SqlCommandBuilder(da);
            da.Fill(ds);
        }
        public DataTable AddressBookList()
        {
            FillDataSet();

            DataTable dt = ds.Tables[0];
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AddressBookList();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FillDataSet();

            DataRow dr = ds.Tables[0].Rows.Find(Convert.ToInt32(TxtId.Text));
            dr["firstName"] = txtfn.Text;
            dr["lastname"] = txtln.Text;
            dr["email"] = emtxt.Text;
            dr["phone"] = txtph.Text;
            da.Update(ds);
            MessageBox.Show("Record Updated.");
        }

        //Insert
        private void submitBtn_Click(object sender, EventArgs e)
        {
            FillDataSet();
            DataRow dr = ds.Tables[0].NewRow();

            dr["firstName"] = txtfn.Text;
            dr["lastname"] = txtln.Text;
            dr["email"] = emtxt.Text;

            dr["phone"] = txtph.Text;

            ds.Tables[0].Rows.Add(dr);
            da.Update(ds);

        }
        //Find
        private void FindName(DataTable dt, string Name)
        {

            DataTable tbl = dt;

            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["lastname".ToLower()] };
            DataRow currentRow = tbl.Rows.Find(Name);
            if (currentRow != null)
            {
                TxtId.Text = currentRow["address_id"].ToString();
                txtfn.Text= currentRow["firstName"].ToString();
                txtln.Text = currentRow["lastname"].ToString();
                emtxt.Text = currentRow["email"].ToString();
                txtph.Text = currentRow["phone"].ToString();

            }
            else
            {
                MessageBox.Show("Record Doesnot Exist");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bindid();
            if (id != 0)
            {
                TxtId.Text = (id+1).ToString();
            }
            else
                TxtId.ReadOnly = false;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            con = GetConnection();
            da = new SqlDataAdapter("select * from tbl_ddressBook", con);
           
            l = new SqlCommandBuilder(da);
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            if(txtln.Text!=""&&dt!=null)
            FindName(dt,txtln.Text);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            FillDataSet();
            ds.Tables[0].Rows.Find(Convert.ToInt32(TxtId.Text)).Delete();
            da.Update(ds);
        }
    }
}
