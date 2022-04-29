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
    public partial class OrderManagementForm : Form
    {
        OrderService service=new OrderService();
        Product apple, banana, cat;
        Customer Ada, Rick;
        Order order1, order2, order3;

        public OrderManagementForm()
        {
            InitializeComponent();
            initDataBindings();

            Querycbx.SelectedIndex= 0;

        }
        void initDataBindings()
        {

            apple = new Product("apple", 1.5f);
            banana = new Product("banana", 2.3f);
            cat = new Product("cat", 50);
            Ada = new Customer("Ada");
            Rick = new Customer("Rick");
            EditForm.CustomerList.Add(Ada);
            EditForm.CustomerList.Add(Rick);
            EditForm.ProductList.Add(apple);
            EditForm.ProductList.Add(banana);
            EditForm.ProductList.Add(cat);

            order1 = new Order(new List<OrderDetails> {
                new OrderDetails(apple, 2, 1)
            }, Ada);


            order2 = new Order(new List<OrderDetails> {
                new OrderDetails(apple, 8, 0.88),
                new OrderDetails(banana, 10, 0.6)
            }, Rick);

            order3 = new Order(new List<OrderDetails>{
                new OrderDetails(cat, 1, 1)
            }, Rick);

            service.AddOdder(order1);
            service.AddOdder(order2);
            service.AddOdder(order3);

            orderBindingSource.DataSource = service.OrderList;  // 绑定数据源


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            EditForm form2 = new EditForm(order, true, service);
            form2.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {            
            EditForm form2 = new EditForm(new Order(), false, service);
            form2.Show();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            int index = Querycbx.SelectedIndex;
            switch (index)
            {              
                case 1:// 按照id查询
                    int id;
                    if(Int32.TryParse(txbQuery.Text, out id))
                    {
                        orderBindingSource.DataSource = service.GetByID(id);
                    }
                    else
                    {
                        MessageBox.Show("Invalid id num!");
                    }
                    break;
                case 2: // 按照顾客姓名查询
                    String name;
                    if (String.IsNullOrEmpty(txbQuery.Text))
                    {
                        MessageBox.Show("Invalid name!");
                    }
                    else
                    {
                        name =txbQuery.Text;
                        orderBindingSource.DataSource = service.Query(name);
                    }
                    break;

                default:    // 查询所有订单
                    orderBindingSource.DataSource = service.QueryAll();
                    break;

            }
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Order o=orderBindingSource.Current as Order;//For single row selection;
            if (o == null)
            {
                MessageBox.Show("请选择一个订单进行删除！");
            }
            DialogResult result = 
                MessageBox.Show($"确认要删除Id为{o.ID}的订单吗？", "删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                service.DeleteByID(o.ID);
                orderBindingSource.ResetBindings(false);//不改数据源，强制刷新
            }            
        }



        private void exprtBtn_Click(object sender, EventArgs e)
        {
            service.Export("../OrderList.xml");
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            string openPath = "../OrderList.xml";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openPath = openFileDialog.FileName;
                    service.Import(openPath);
                }
            }
        }
    }
}
