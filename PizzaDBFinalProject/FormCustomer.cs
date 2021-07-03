using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDBFinalProject
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            string statement = "SELECT * FROM Customer";
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvAddCust.DataSource = dt;
            dgvEditCust.DataSource = dt;

            con.Close();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            string tempID = "", tempName = "", tempPhone = "", tempEmail = "";
            
            if (txtCustID.Text.Length > 0) { tempID = txtCustID.Text; }
            if (txtCNAME.Text.Length > 0) { tempName = txtCNAME.Text; }
            if (txtCPHONE.Text.Length > 0) { tempPhone = txtCPHONE.Text; }
            if (txtCEMAIL.Text.Length > 0) { tempEmail = txtCEMAIL.Text; }

            string statement = $"INSERT INTO Customer (cust_ID, customer_name, phone_number, email) " +
                $"values ({tempID}, '{tempName}', '{tempPhone}', '{tempEmail}')";
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            statement = "SELECT * FROM Customer";
            cmd = new OleDbCommand(statement, con);
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvAddCust.DataSource = dt;
            dgvEditCust.DataSource = dt;

            con.Close();

            MessageBox.Show("Customer Added.");
        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            if(chkName.Checked)
            {
                txtAddNAME.ReadOnly = false;
            }
            else { txtAddNAME.ReadOnly = true; }
                
        }

        private void chkPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhone.Checked)
            {
                txtAddPHONE.ReadOnly = false;
            }
            else { txtAddPHONE.ReadOnly = true; }
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmail.Checked)
            {
                txtAddEMAIL.ReadOnly = false;
            }
            else { txtAddEMAIL.ReadOnly = true; }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tempID = "", tempName = "", tempPhone = "", tempEmail = "", values = "";

            //if (txtCustID.Text.Length > 0) { tempID = txtCustID.Text; }
            if (txtAddNAME.Text.Length > 0) { values += $"customer_name = '{txtAddNAME.Text}'"; }
            if (txtAddPHONE.Text.Length > 0) 
            {
                if(values.Length >= 1) { values += ", "; }
                values += $"phone_number = '{txtAddPHONE.Text}'";
            }
            if (txtAddEMAIL.Text.Length > 0) 
            {
                if (values.Length >= 1) { values += ", "; }
                values += $"email = '{txtAddEMAIL.Text}'";
            }

            string statement = $"UPDATE Customer SET {values} " +
                $"WHERE cust_ID = {txtAddID.Text}";
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            statement = "SELECT * FROM Customer";
            cmd = new OleDbCommand(statement, con);
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvAddCust.DataSource = dt;
            dgvEditCust.DataSource = dt;

            con.Close();

            MessageBox.Show("Customer Updated.");
        }

    }
}
