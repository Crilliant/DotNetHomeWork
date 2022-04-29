using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class EditForm : Form
    {
        
        bool EditModel { get; set; }//修改为1，增加为0
        private OrderService service;
        public Order CurrentOrder { get; set; }
       // public event Action<EditForm> CloseEditFrom;
       static public List<Customer> CustomerList { get; set; }=new List<Customer>();
        static public List<Product> ProductList { get; set; }=new List<Product>();

        public EditForm(Order order, bool model, OrderService service)
        {
            InitializeComponent();
            this.service = service;
            EditModel= model;
            CurrentOrder = order;
            orderDetailsBindingSource.DataSource = CurrentOrder;
            InitialForm();
        }
        private void InitialForm()
        {
            if (EditModel)//修改
            {
                lbl_dealTime.Text = CurrentOrder.DealTime.ToString();
                cbb_customer_value.SelectedItem = CurrentOrder.customer;
                lbl_orderID_value.Text = CurrentOrder.ID.ToString();
            }
            else
            {
                lbl_dealTime.Text = DateTime.Now.ToString();
            }
            customerBindingSource.DataSource = CustomerList;
            productBindingSource.DataSource = ProductList;

        }


        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtBoxDiscount.Text, out int discount))
                MessageBox.Show("invalid discount");
            try
            {
                OrderDetails newDetail = new OrderDetails(
                    (Product)cbxProduct.SelectedItem, 
                    (int)nudNum.Value, 
                    discount);
                CurrentOrder.AddDetail(newDetail);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderDetailsBindingSource.ResetBindings(false);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EditModel)//如果是add
                {
                    service.AddOdder(CurrentOrder);
                }
                else
                {
                    service.Updata(CurrentOrder);
                }
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderDetailsBindingSource.ResetBindings(false);
        }

 

        private void btn_modify_Click(object sender, EventArgs e)
        {
            OrderDetails currentDetail = orderBindingSource.Current as OrderDetails;
            if (!Int32.TryParse(txtBoxDiscount.Text, out int discount))
                MessageBox.Show("invalid discount");
            try
            {
                OrderDetails newDetail = new OrderDetails(
                    (Product)cbxProduct.SelectedItem,
                    (int)nudNum.Value,
                    discount);
                CurrentOrder.RemoveDetail(currentDetail);
                CurrentOrder.AddDetail(newDetail);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
