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
            if (comboBoxCustomer.SelectedIndex == -1 || comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose Customer and Product.", "Input error");
            }
            else
            {
                if (txtTitle.Text == "" || txtDescription.Text == "")
                {
                    MessageBox.Show("Title and Description are a required field.", "Input error");
                }
                else
                {
                    incident = new Incident();
                    incident.CustomerID = (int)comboBoxCustomer.SelectedValue;
                    incident.ProductCode = comboBoxProduct.SelectedValue.ToString();
                    incident.Title = txtTitle.Text;
                    incident.Description = txtDescription.Text;
                    incident.TechName = "";
                    incident.DateOpened = DateTime.Now;

                    try
                    {
                        IncidentDAL.AddIncident(incident);
                        MessageBox.Show(this, "Incident was successfully created");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        this.BeginInvoke(new MethodInvoker(Close));
                    }
                }
            }      
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

                comboBoxCustomer.SelectedIndex = -1;
                comboBoxProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
    }
}
