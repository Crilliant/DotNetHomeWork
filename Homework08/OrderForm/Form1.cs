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

        //ToolStripMenuItem updateItem = new ToolStripMenuItem();
        //ToolStripMenuItem deleteItem = new ToolStripMenuItem();

        public OrderManagementForm()
        {
            InitializeComponent();
            initDataBindings();

            Querycbx.SelectedIndex= 0;


            //AddContextMenuToGridRow();
        }
        void initDataBindings()
        {

            apple = new Product("apple", 1.5f);
            banana = new Product("banana", 2.3f);
            cat = new Product("cat", 50);
            Ada = new Customer("Ada");
            Rick = new Customer("Rick");

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

        //// 表格右键选项==>失败了，没有任何右键菜单出现
        //// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewrow.contextmenustrip?view=windowsdesktop-6.0
        //private void AddContextMenuToGridRow()
        //{
        //    updateItem.Text = "修改";
        //    deleteItem.Text = "删除";
        //    updateItem.Click += new EventHandler(updateOrder);
        //    deleteItem.Click += new EventHandler(deleteOrder);

        //    ContextMenuStrip strip = new ContextMenuStrip();
        //    foreach(DataGridViewRow row in OrderGridView.Rows)
        //    {
        //        row.ContextMenuStrip = strip;
        //        row.ContextMenuStrip.Items.Add(updateItem);
        //        row.ContextMenuStrip.Items.Add(deleteItem);

        //    }
            
        //}

        // 修改订单
        private void updateOrder(object sender, EventArgs args)
        {

        }

        // 删除订单
        private void deleteOrder(object sender, EventArgs args)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void Querycbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlOperation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Order o=orderBindingSource.Current as Order;
            //For single row selection;            
            int id = (int)OrderGridView.CurrentRow.Cells[0].Value;
            service.DeleteByID(id);

        }

        private void exprtBtn_Click(object sender, EventArgs e)
        {
            service.Export("../OrderList.xml");
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            service.Import("../OrderList.xml");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
