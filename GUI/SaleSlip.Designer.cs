namespace QLTiemVang.GUI
{
    partial class fSaleSlip
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
            panel2 = new Panel();
            lvSaleSlip = new ListView();
            panel4 = new Panel();
            button1 = new Button();
            nm_ProductCount = new NumericUpDown();
            b_Add = new Button();
            cbProduct = new ComboBox();
            label1 = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            tb_Customer = new TextBox();
            tb_Date = new TextBox();
            tb_ID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_ProductCount).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lvSaleSlip);
            panel2.Location = new Point(12, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 235);
            panel2.TabIndex = 1;
            // 
            // lvSaleSlip
            // 
            lvSaleSlip.Dock = DockStyle.Fill;
            lvSaleSlip.GridLines = true;
            lvSaleSlip.Location = new Point(0, 0);
            lvSaleSlip.Name = "lvSaleSlip";
            lvSaleSlip.Size = new Size(824, 235);
            lvSaleSlip.TabIndex = 0;
            lvSaleSlip.UseCompatibleStateImageBehavior = false;
            lvSaleSlip.View = View.Details;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(nm_ProductCount);
            panel4.Controls.Add(b_Add);
            panel4.Controls.Add(cbProduct);
            panel4.Location = new Point(12, 435);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 63);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(712, 6);
            button1.Name = "button1";
            button1.Size = new Size(98, 51);
            button1.TabIndex = 4;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = false;
            // 
            // nm_ProductCount
            // 
            nm_ProductCount.Location = new Point(538, 23);
            nm_ProductCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nm_ProductCount.Name = "nm_ProductCount";
            nm_ProductCount.Size = new Size(57, 23);
            nm_ProductCount.TabIndex = 3;
            nm_ProductCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // b_Add
            // 
            b_Add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_Add.Location = new Point(608, 6);
            b_Add.Name = "b_Add";
            b_Add.Size = new Size(98, 51);
            b_Add.TabIndex = 2;
            b_Add.Text = "Thêm";
            b_Add.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(3, 22);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(529, 23);
            cbProduct.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 4);
            label1.Name = "label1";
            label1.Size = new Size(287, 37);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU BÁN HÀNG";
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(824, 46);
            panel5.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_Customer);
            panel1.Controls.Add(tb_Date);
            panel1.Controls.Add(tb_ID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 63);
            panel1.TabIndex = 5;
            // 
            // tb_Customer
            // 
            tb_Customer.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Customer.ForeColor = Color.Gray;
            tb_Customer.Location = new Point(104, 35);
            tb_Customer.Name = "tb_Customer";
            tb_Customer.Size = new Size(160, 21);
            tb_Customer.TabIndex = 9;
            tb_Customer.Text = "Chưa chọn khách hàng";
            tb_Customer.MouseClick += tb_Customer_MouseClick;
            // 
            // tb_Date
            // 
            tb_Date.Location = new Point(529, 8);
            tb_Date.Name = "tb_Date";
            tb_Date.Size = new Size(160, 23);
            tb_Date.TabIndex = 8;
            // 
            // tb_ID
            // 
            tb_ID.Location = new Point(104, 8);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(160, 23);
            tb_ID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 11);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 38);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 11);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Số phiếu:";
            // 
            // fSaleSlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 510);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "fSaleSlip";
            Text = "Lusso Jewelry";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nm_ProductCount).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ListView lvSaleSlip;
        private Panel panel4;
        private ComboBox cbProduct;
        private Button b_Add;
        private NumericUpDown nm_ProductCount;
        private Label label1;
        private Panel panel5;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox tb_ID;
        private TextBox tb_Customer;
        private TextBox tb_Date;
    }
}