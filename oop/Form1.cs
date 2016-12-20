using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            interfaces.InvoiceBase objHeader = new InvoiceHeader();
            objHeader.InvoiceCode = "inv001";
          
            objHeader.Lines.Add(new InvoiceDetail {
                 Id = 1,
                  ItemCode ="001",
                  OrderedQty = 1
            });

            objHeader.Lines.Add(new InvoiceDetail
            {
                Id = 2,
                ItemCode = "002",
                OrderedQty = 3
            });
            objHeader.Add();
          
           
        }
    }
}
