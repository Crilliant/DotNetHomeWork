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
            orderBindingSource.DataSource = CurrentOrder;
            orderDetailsBindingSource.DataSource = CurrentOrder.details;
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
                lbl_orderID_value.Text = (service.OrderList.Count+1).ToString();                
            }
            customerBindingSource.DataSource = CustomerList;
            productBindingSource.DataSource = ProductList;
            orderBindingSource.ResetBindings(true);
        }


        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtBoxDiscount.Text, out float discount))
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




        private void btn_modify_Click(object sender, EventArgs e)
        {
            OrderDetails currentDetail = orderDetailsBindingSource.Current as OrderDetails;
            if (currentDetail == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            if (!float.TryParse(txtBoxDiscount.Text, out float discount))
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
            orderDetailsBindingSource.ResetBindings(false);
        }
        private void btn_deleteDetail_Click(object sender, EventArgs e)
        {
            OrderDetails currentDetail = orderDetailsBindingSource.Current as OrderDetails;
            try
            {
                CurrentOrder.RemoveDetail(currentDetail);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            orderDetailsBindingSource.ResetBindings(false);
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (!EditModel)//增加
            {
                try
                {
                    CurrentOrder.customer =(Customer) cbb_customer_value.SelectedItem;
                    service.AddOdder(CurrentOrder);
                }catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
            orderDetailsBindingSource.ResetBindings(false);
            this.Close();
        }



       
    }
}
