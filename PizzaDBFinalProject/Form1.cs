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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string statement = "SELECT DISTINCT Customer.cust_ID, Customer.customer_name, PizzaOrder.order_ID, PizzaOrder.[size], " +
                "PizzaOrder.price, PizzaToppings.Topping FROM PizzaToppings INNER JOIN " +
                "((Customer INNER JOIN PizzaOrder ON Customer.[cust_ID] = PizzaOrder.[cust_ID]) " +
                "INNER JOIN OrderToppings ON PizzaOrder.[order_ID] = OrderToppings.[order_ID]) " +
                "ON PizzaToppings.[topping _ID] = OrderToppings.[topping_ID] WHERE Customer.cust_ID = 5 ORDER BY PizzaOrder.order_ID ASC";

            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnOpenCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
        }

        private void btnOpenOrders_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string statement = "SELECT DISTINCT Customer.cust_ID, Customer.customer_name, PizzaOrder.order_ID, PizzaOrder.[size], PizzaOrder.price, PizzaToppings.Topping FROM PizzaToppings INNER JOIN ((Customer INNER JOIN PizzaOrder ON Customer.[cust_ID] = PizzaOrder.[cust_ID]) INNER JOIN OrderToppings ON PizzaOrder.[order_ID] = OrderToppings.[order_ID]) ON PizzaToppings.[topping _ID] = OrderToppings.[topping_ID] ORDER BY PizzaOrder.order_ID ASC";

            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnOrdersOver10_Click(object sender, EventArgs e)
        {
            string statement = "SELECT DISTINCT Customer.cust_ID, Customer.customer_name, PizzaOrder.order_ID, PizzaOrder.[size], " +
                "PizzaOrder.price, PizzaToppings.Topping FROM PizzaToppings INNER JOIN " +
                "((Customer INNER JOIN PizzaOrder ON Customer.[cust_ID] = PizzaOrder.[cust_ID]) " +
                "INNER JOIN OrderToppings ON PizzaOrder.[order_ID] = OrderToppings.[order_ID]) " +
                "ON PizzaToppings.[topping _ID] = OrderToppings.[topping_ID] WHERE PizzaOrder.price > 12 ORDER BY PizzaOrder.order_ID ASC";

            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnViewMeatLvrs_Click(object sender, EventArgs e)
        {
            string statement = "SELECT DISTINCT Customer.cust_ID, Customer.customer_name, PizzaOrder.order_ID, PizzaOrder.[size], " +
                "PizzaOrder.price, PizzaToppings.Topping FROM PizzaToppings INNER JOIN " +
                "((Customer INNER JOIN PizzaOrder ON Customer.[cust_ID] = PizzaOrder.[cust_ID]) " +
                "INNER JOIN OrderToppings ON PizzaOrder.[order_ID] = OrderToppings.[order_ID]) " +
                "ON PizzaToppings.[topping _ID] = OrderToppings.[topping_ID] WHERE PizzaToppings.[topping _ID] = 5 ORDER BY PizzaOrder.order_ID ASC";

            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\PizzaDBFinalProject\PizzaDB1.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(statement, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
