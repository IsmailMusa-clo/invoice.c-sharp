using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            txtData.Text = DateTime.Now.ToString("d");

            Dictionary<int, string> itemsData = new Dictionary<int, string>();
            itemsData.Add(7000,"لابتوب hp");
            itemsData.Add(6500, "لابتوب Dell");
            itemsData.Add(6000, "لابتوب Lenovo");
            itemsData.Add(20, "ماوس hp");
            itemsData.Add(100, "شاحن hp");
            itemsData.Add(70, "لوحة مفاتيح hp");
            itemsData.Add(15, "ماوس Dell");
            itemsData.Add(110, "شاحن dell");
            itemsData.Add(80, "شاحن Lenovo");
            itemsData.Add(90, "شاحن Tosheba");
            itemsData.Add(60, "راوتر TpLink");
            itemsData.Add(17, "شنطة لابتوب");
            itemsData.Add(5, "سماعات Lg");
            itemsData.Add(10, "سماعات Sony");
            itemsData.Add(2, "منظف");
            itemsData.Add(24, "مايك");

            cbxType.DataSource = new BindingSource(itemsData, null);
            cbxType.DisplayMember ="value" ;
            cbxType.ValueMember = "key";

            txtPrice.Text = cbxType.SelectedValue.ToString();


            txtNameCustomers.Focus();
            txtNameCustomers.Select();
            txtNameCustomers.SelectAll();
        }

        private void Invoice_Resize(object sender, EventArgs e)
        {
            this.Size=new Size(817, 646);
            
          
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons)
            {
                txtData.ContextMenu = new ContextMenu();
            }
        }

        private void txtNameCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbxType.Focus();
                
            }
        }

        private void cbxType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
              
                txtQuantity.Focus();
                txtQuantity.SelectAll();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text.Trim();
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.PerformClick();
                cbxType.Focus();
                
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = cbxType.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex <= -1) return;
            String Type = cbxType.Text;
            int price =Convert.ToInt32( txtPrice.Text);
            if (txtQuantity== null) { txtQuantity.Text ="1"; }
            txtQuantity.Text = txtQuantity.Text.Trim();
            int qunt = Convert.ToInt32(txtQuantity.Text);
            int subTotal = price * qunt;
            object[] AllData = { Type, qunt, price, subTotal };

            dataGridView1.Rows.Add(AllData);
            txtTotalPrice.Text = Convert.ToInt32(txtTotalPrice.Text) + subTotal+"";
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            { 
                e.Handled = true;
            }
        }

        string oldQuty = "1";
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                oldQuty = dataGridView1.CurrentRow.Cells["c2"].Value + "";
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {     
            if(dataGridView1.CurrentRow != null)
            {
                string newQuty = dataGridView1.CurrentRow.Cells["c2"].Value + "";
                if (oldQuty == newQuty) return;
                if(!Regex.IsMatch(newQuty,"^\\d+$"))
                {
                    dataGridView1.CurrentRow.Cells["c2"].Value = oldQuty;
                }
                else
                {
                    int p = (int)dataGridView1.CurrentRow.Cells[3].Value;
                    
                    string q = dataGridView1.CurrentRow.Cells["c2"].Value.ToString();
                    q = q.Replace(" ","");
                    int x =Convert.ToInt32(q);
                    dataGridView1.CurrentRow.Cells["c4"].Value = (x * p);
                    int total = 0;
                    foreach(DataGridViewRow r in dataGridView1.Rows)
                    {
                        total += Convert.ToInt32(r.Cells["c4"].Value);
                        
                    }
                    txtTotalPrice.Text = total+"";
                }
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            ((Form) printPreviewDialog1).WindowState = System.Windows.Forms.FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ///////////كتابة رقم الفاتورة والتاريخ والاسم ووضع الشعار
            float marginLeft = 40;

            Font f = new Font("Arial", 20, FontStyle.Bold);
            string numNo = " #No " + txtInvoiceNumber.Text;
            string date = "التاريخ  :" + txtData.Text;
            string name = "فاتورة   :" + txtNameCustomers.Text;
            SizeF fontSize = e.Graphics.MeasureString(numNo, f);
            SizeF fontSizedate = e.Graphics.MeasureString(date, f);
            SizeF fontSizename = e.Graphics.MeasureString(name, f);

            e.Graphics.DrawImage(Properties.Resources.Untitled2, 5, 5, 200, 200);
            e.Graphics.DrawString(numNo, f, Brushes.Red, (e.PageBounds.Width - fontSize.Width) / 2, marginLeft);
            e.Graphics.DrawString(date, f, Brushes.Chocolate, (e.PageBounds.Width -fontSizedate.Width)-marginLeft , marginLeft+fontSize.Height);
            e.Graphics.DrawString(name, f, Brushes.PaleVioletRed, (e.PageBounds.Width - fontSizename.Width)-marginLeft , marginLeft+fontSize.Height+fontSizedate.Height);

            ///////////////////رسم المستطيل **اطار الجدول
            float preRegtangle = marginLeft + fontSize.Height + fontSizedate.Height + fontSizename.Height+60;
            e.Graphics.DrawRectangle(Pens.Black, marginLeft, preRegtangle, e.PageBounds.Width-marginLeft*2 , e.PageBounds.Height - marginLeft * 2 - preRegtangle);

            //////////////////// رسم الأعمدة وكتابة الصفوف الرئيسية
            float Higthcolmuns = 60;

            float widthcolm1 =330;
            float widthcolm2 = widthcolm1 + 125;
            float widthcolm3 = widthcolm2 + 125;
            float widthcolm4 = widthcolm3 + 125;

            e.Graphics.DrawLine(Pens.Black, marginLeft, preRegtangle + Higthcolmuns, e.PageBounds.Width-marginLeft, preRegtangle+Higthcolmuns );
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marginLeft - 80, preRegtangle, e.PageBounds.Width - marginLeft - 80, e.PageBounds.Height - marginLeft * 2);
            e.Graphics.DrawString("الصنف", f, Brushes.Brown, e.PageBounds.Width-widthcolm1+50 , preRegtangle + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width-marginLeft - widthcolm1, preRegtangle, e.PageBounds.Width - marginLeft - widthcolm1, e.PageBounds.Height - marginLeft*2);

            e.Graphics.DrawString("الكمية", f, Brushes.Brown, e.PageBounds.Width - widthcolm2, preRegtangle + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marginLeft - widthcolm2, preRegtangle, e.PageBounds.Width - marginLeft - widthcolm2, e.PageBounds.Height - marginLeft * 2);

            e.Graphics.DrawString("السعر", f, Brushes.Brown, e.PageBounds.Width - widthcolm3, preRegtangle + 20);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - marginLeft - widthcolm3, preRegtangle, e.PageBounds.Width - marginLeft - widthcolm3, e.PageBounds.Height - marginLeft * 2);

            e.Graphics.DrawString("الإجمالي", f, Brushes.Brown, e.PageBounds.Width - widthcolm4-30, preRegtangle + 20);

            //////////////////// رسم الصفوف الفرعية وكتابة الأصناف

            float rowsHigth = 20;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                rowsHigth+=50;
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), f, Brushes.DarkBlue, e.PageBounds.Width -marginLeft-widthcolm1+50, preRegtangle +rowsHigth );
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), f, Brushes.DarkBlue, e.PageBounds.Width - marginLeft - widthcolm2+50, preRegtangle + rowsHigth);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), f, Brushes.DarkBlue, e.PageBounds.Width - marginLeft - widthcolm3+30, preRegtangle + rowsHigth);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), f, Brushes.DarkBlue, e.PageBounds.Width - marginLeft - widthcolm4+10, preRegtangle + rowsHigth);
                e.Graphics.DrawString(Convert.ToString(i+1), f, Brushes.Brown, e.PageBounds.Width - marginLeft - 60, preRegtangle + rowsHigth);
                e.Graphics.DrawLine(Pens.Black, marginLeft, preRegtangle + rowsHigth+fontSize.Height , e.PageBounds.Width - marginLeft, preRegtangle +rowsHigth+fontSize.Height);
                
            }
            e.Graphics.DrawString("الاجمالي", f, Brushes.Brown, e.PageBounds.Width - widthcolm3-10, preRegtangle + 40+rowsHigth);
            e.Graphics.DrawString(txtTotalPrice.Text, f, Brushes.Brown, e.PageBounds.Width - widthcolm4 - marginLeft, preRegtangle + 40 + rowsHigth);

        }
    }
}
