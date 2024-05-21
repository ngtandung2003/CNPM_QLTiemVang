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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            listView1 = new ListView();
            panel3 = new Panel();
            panel4 = new Panel();
            nm_ProductCount = new NumericUpDown();
            b_Add = new Button();
            comboBox2 = new ComboBox();
            cbProduct = new ComboBox();
            label1 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_ProductCount).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 408);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(402, 408);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(434, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 337);
            panel2.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(396, 331);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(434, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 54);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(nm_ProductCount);
            panel4.Controls.Add(b_Add);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(cbProduct);
            panel4.Location = new Point(434, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 63);
            panel4.TabIndex = 3;
            // 
            // nm_ProductCount
            // 
            nm_ProductCount.Location = new Point(337, 22);
            nm_ProductCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nm_ProductCount.Name = "nm_ProductCount";
            nm_ProductCount.Size = new Size(57, 23);
            nm_ProductCount.TabIndex = 3;
            nm_ProductCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // b_Add
            // 
            b_Add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_Add.Location = new Point(233, 3);
            b_Add.Name = "b_Add";
            b_Add.Size = new Size(98, 51);
            b_Add.TabIndex = 2;
            b_Add.Text = "Thêm";
            b_Add.UseVisualStyleBackColor = true;
            b_Add.Click += b_Add_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 34);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 23);
            comboBox2.TabIndex = 1;
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(3, 5);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(224, 23);
            cbProduct.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 21);
            label1.Name = "label1";
            label1.Size = new Size(186, 24);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU BÁN HÀNG";
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 63);
            panel5.TabIndex = 4;
            // 
            // fSaleSlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 510);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fSaleSlip";
            Text = "Lusso Jewelry";
            Load += fSaleSlip_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nm_ProductCount).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ListView listView1;
        private Panel panel4;
        private ComboBox cbProduct;
        private Button b_Add;
        private ComboBox comboBox2;
        private NumericUpDown nm_ProductCount;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel5;
    }
}