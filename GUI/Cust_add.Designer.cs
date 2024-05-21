namespace QLTiemVang.GUI
{
    partial class fCust_add
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
            dgv_Cust = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            tb_id = new TextBox();
            tb_name = new TextBox();
            tb_phone = new TextBox();
            panel2 = new Panel();
            b_AddCust = new Button();
            tb_Search = new TextBox();
            b_ChoseCust = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Cust).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Cust
            // 
            dgv_Cust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cust.Location = new Point(0, 58);
            dgv_Cust.Name = "dgv_Cust";
            dgv_Cust.Size = new Size(643, 313);
            dgv_Cust.TabIndex = 0;
            dgv_Cust.CellClick += dgv_Cust_CellClick;
            dgv_Cust.CellContentClick += dgv_Cust_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgv_Cust);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 371);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(tb_id);
            panel3.Controls.Add(tb_name);
            panel3.Controls.Add(tb_phone);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(643, 49);
            panel3.TabIndex = 3;
            // 
            // tb_id
            // 
            tb_id.ForeColor = SystemColors.WindowFrame;
            tb_id.Location = new Point(15, 13);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(95, 23);
            tb_id.TabIndex = 3;
            // 
            // tb_name
            // 
            tb_name.ForeColor = SystemColors.WindowFrame;
            tb_name.Location = new Point(116, 13);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(295, 23);
            tb_name.TabIndex = 2;
            // 
            // tb_phone
            // 
            tb_phone.ForeColor = SystemColors.WindowFrame;
            tb_phone.Location = new Point(417, 13);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(223, 23);
            tb_phone.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(b_AddCust);
            panel2.Controls.Add(tb_Search);
            panel2.Controls.Add(b_ChoseCust);
            panel2.Location = new Point(12, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 49);
            panel2.TabIndex = 2;
            // 
            // b_AddCust
            // 
            b_AddCust.Location = new Point(442, 3);
            b_AddCust.Name = "b_AddCust";
            b_AddCust.Size = new Size(96, 43);
            b_AddCust.TabIndex = 2;
            b_AddCust.Text = "Thêm";
            b_AddCust.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            tb_Search.ForeColor = SystemColors.WindowFrame;
            tb_Search.Location = new Point(15, 14);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(421, 23);
            tb_Search.TabIndex = 1;
            tb_Search.Text = "Tìm khách hàng";
            tb_Search.MouseClick += tb_Search_MouseClick;
            tb_Search.KeyPress += tb_Search_KeyPress;
            // 
            // b_ChoseCust
            // 
            b_ChoseCust.Location = new Point(544, 3);
            b_ChoseCust.Name = "b_ChoseCust";
            b_ChoseCust.Size = new Size(96, 43);
            b_ChoseCust.TabIndex = 0;
            b_ChoseCust.Text = "Chọn";
            b_ChoseCust.UseVisualStyleBackColor = true;
            b_ChoseCust.Click += b_ChoseCust_Click;
            // 
            // fCust_add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fCust_add";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_Cust).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Cust;
        private Panel panel1;
        private Panel panel2;
        private TextBox tb_Search;
        private Button b_ChoseCust;
        private Button b_AddCust;
        private Panel panel3;
        private TextBox tb_id;
        private TextBox tb_name;
        private TextBox tb_phone;
    }
}