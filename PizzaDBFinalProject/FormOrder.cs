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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            string statement = "SELECT DISTINCT Customer.cust_ID, Customer.customer_name, PizzaOrder.order_ID, PizzaOrder.[size], PizzaOrder.price, PizzaToppings.Topping FROM PizzaToppings INNER JOIN ((Customer INNER JOIN PizzaOrder ON Customer.[cust_ID] = PizzaOrder.[cust_ID]) INNER JOIN OrderToppings ON PizzaOrder.[order_ID] = OrderToppings.[order_ID]) ON PizzaToppings.[topping _ID] = OrderToppings.[topping_ID] ORDER BY PizzaOrder.order_ID ASC";
            
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvAddOrder.DataSource = dt;
            dgvEditOrder.DataSource = dt;

            con.Close();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

            string statement = $"INSERT INTO PizzaOrder (order_ID, [size], price, cust_ID) " +
                $"values ({txtNewOrderID.Text}, '{txtOrderSize.Text}', '{txtOrderPrice.Text}', '{txtCustID.Text}')";

            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            statement = $"INSERT INTO OrderToppings (ID, order_ID, topping_ID) " +
                $"values ({txtNewOrderID.Text}, '{txtNewOrderID.Text}', '{txtOrderToppingsID.Text}')";
            cmd = new OleDbCommand(statement, con);
            reader = cmd.ExecuteReader();

            statement = "SELECT Customer.cust_ID, Customer.customer_name, PizzaOrder.order_ID, PizzaOrder.[size], PizzaOrder.price, PizzaToppings.Topping FROM PizzaToppings INNER JOIN ((Customer INNER JOIN PizzaOrder ON Customer.[cust_ID] = PizzaOrder.[cust_ID]) INNER JOIN OrderToppings ON PizzaOrder.[order_ID] = OrderToppings.[order_ID]) ON PizzaToppings.[topping _ID] = OrderToppings.[topping_ID]";
            cmd = new OleDbCommand(statement, con);
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvAddOrder.DataSource = dt;
            dgvEditOrder.DataSource = dt;

            con.Close();

            MessageBox.Show("Order Created");
        }

        private void chkCustID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustID.Checked)
            {
                txtEditCustID.ReadOnly = false;
            }
            else { txtEditCustID.ReadOnly = true; }
        }

        private void chkSize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSize.Checked)
            {
                txtEditSize.ReadOnly = false;
            }
            else { txtEditSize.ReadOnly = true; }
        }

        private void chkToppings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToppings.Checked)
            {
                txtEditIToppingID.ReadOnly = false;
            }
            else { txtEditIToppingID.ReadOnly = true; }
        }

        private void chkPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrice.Checked)
            {
                txtEditPrice.ReadOnly = false;
            }
            else { txtEditIToppingID.ReadOnly = true; }
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            string tempOrderID = "", tempCustomerID = "", tempSize = "", tempToppingID = "", tempPrice = "", values = "";

            //if (txtCustID.Text.Length > 0) { tempID = txtCustID.Text; }
            if (txtEditSize.Text.Length > 0) { values += $"[size] = '{txtEditSize.Text}'"; }
            if (txtEditPrice.Text.Length > 0)
            {
                if (values.Length >= 1) { values += ", "; }
                values += $"price = '{txtEditPrice.Text}'";
            }
            if (txtEditCustID.Text.Length > 0)
            {
                if (values.Length >= 1) { values += ", "; }
                values += $"cust_ID = '{txtEditCustID.Text}'";
            }

            string statement = $"UPDATE PizzaOrder SET {values} " +
                $"WHERE order_ID = {txtEditID.Text}";
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (txtEditIToppingID.Text.Length > 0) 
            { 
                values = $"topping_ID = '{txtEditIToppingID.Text}'";

                statement = $"UPDATE OrderToppings SET {values} " +
                $"WHERE order_ID = {txtEditID.Text}";

                cmd = new OleDbCommand(statement, con);
                reader = cmd.ExecuteReader();
            }

            statement = "SELECT Customer.cust_ID, Customer.customer_name, PizzaOrder.order_ID, PizzaOrder.[size], PizzaOrder.price, PizzaToppings.Topping FROM PizzaToppings INNER JOIN ((Customer INNER JOIN PizzaOrder ON Customer.[cust_ID] = PizzaOrder.[cust_ID]) INNER JOIN OrderToppings ON PizzaOrder.[order_ID] = OrderToppings.[order_ID]) ON PizzaToppings.[topping _ID] = OrderToppings.[topping_ID]";
            cmd = new OleDbCommand(statement, con);
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvAddOrder.DataSource = dt;
            dgvEditOrder.DataSource = dt;

            con.Close();

            MessageBox.Show("Order Updated.");
        }
    }
}
