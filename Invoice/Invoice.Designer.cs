namespace Invoice
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCustomers = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AllowDrop = true;
            this.lblTitel.BackColor = System.Drawing.Color.Navy;
            this.lblTitel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitel.Location = new System.Drawing.Point(284, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(269, 51);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "** شاشة الفاتورة **";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum
            // 
            this.lblNum.AllowDrop = true;
            this.lblNum.Location = new System.Drawing.Point(12, 94);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(148, 30);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "رقم الفاتورة :";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Location = new System.Drawing.Point(39, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(748, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "__________________________________________________________";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.txtInvoiceNumber.Location = new System.Drawing.Point(166, 94);
            this.txtInvoiceNumber.Multiline = true;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(413, 30);
            this.txtInvoiceNumber.TabIndex = 11;
            this.txtInvoiceNumber.Text = "0001113";
            this.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(799, 197);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // c1
            // 
            this.c1.HeaderText = "الصنف ";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 200;
            // 
            // c2
            // 
            this.c2.HeaderText = "الكمية";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.Width = 180;
            // 
            // c3
            // 
            this.c3.HeaderText = "سعر الوحدة";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 185;
            // 
            // c4
            // 
            this.c4.HeaderText = "الإجمالي الفرعي";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c4.Width = 180;
            // 
            // txtData
            // 
            this.txtData.HideSelection = false;
            this.txtData.Location = new System.Drawing.Point(165, 146);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(413, 30);
            this.txtData.TabIndex = 19;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            this.txtData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtData_MouseDown);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Location = new System.Drawing.Point(11, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "التاريخ  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Location = new System.Drawing.Point(11, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "إسم الزبون  :";
            // 
            // txtNameCustomers
            // 
            this.txtNameCustomers.Location = new System.Drawing.Point(165, 196);
            this.txtNameCustomers.Multiline = true;
            this.txtNameCustomers.Name = "txtNameCustomers";
            this.txtNameCustomers.Size = new System.Drawing.Size(413, 34);
            this.txtNameCustomers.TabIndex = 22;
            this.txtNameCustomers.Text = "الاسم";
            this.txtNameCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameCustomers_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::Invoice.Properties.Resources.Untitled2;
            this.pictureBox1.Location = new System.Drawing.Point(590, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 137);
            this.panel1.TabIndex = 24;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Indigo;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Yellow;
            this.txtTotalPrice.Location = new System.Drawing.Point(110, 84);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(103, 43);
            this.txtTotalPrice.TabIndex = 36;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAdd.Location = new System.Drawing.Point(10, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 43);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Location = new System.Drawing.Point(689, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "الصنف :";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Location = new System.Drawing.Point(689, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 30);
            this.label7.TabIndex = 27;
            this.label7.Text = "السعر  :";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(110, 23);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(579, 40);
            this.cbxType.TabIndex = 33;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            this.cbxType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxType_KeyDown);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(524, 84);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(165, 43);
            this.txtPrice.TabIndex = 34;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.Location = new System.Drawing.Point(425, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "الكمية :";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.Location = new System.Drawing.Point(219, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 30);
            this.label9.TabIndex = 29;
            this.label9.Text = "الإجمالي :";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Gold;
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprint.Location = new System.Drawing.Point(10, 22);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(88, 41);
            this.btnprint.TabIndex = 30;
            this.btnprint.Text = "طباعة";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Location = new System.Drawing.Point(335, 84);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(84, 43);
            this.txtQuantity.TabIndex = 32;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNameCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblTitel);
            this.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.Resize += new System.EventHandler(this.Invoice_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

