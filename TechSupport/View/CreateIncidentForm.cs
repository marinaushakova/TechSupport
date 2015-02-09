using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupportData.Model;
using TechSupportData.DAL;

namespace TechSupport.View
{
    public partial class CreateIncidentForm : Form
    {
        private Incident incident;

        public CreateIncidentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateIncidentForm_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                List<Customer> custList;
                custList = CustomerDAL.GetCustomers();
                comboBoxCustomer.DataSource = custList;
                comboBoxCustomer.DisplayMember = "Name";
                comboBoxCustomer.ValueMember = "CustomerID";

                List<Product> prodlist;
                prodlist = ProductDAL.GetProductList();
                comboBoxProduct.DataSource = prodlist;
                comboBoxProduct.DisplayMember = "Name";
                comboBoxProduct.ValueMember = "ProductCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
