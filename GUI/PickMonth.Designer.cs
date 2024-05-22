namespace WinFormsApp2
{
    partial class PickMonth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePickerMonth = new DateTimePicker();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // dateTimePickerMonth
            // 
            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.Location = new Point(85, 84);
            dateTimePickerMonth.Name = "dateTimePickerMonth";
            dateTimePickerMonth.Size = new Size(250, 27);
            dateTimePickerMonth.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(165, 170);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // PickMonth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 265);
            Controls.Add(buttonOK);
            Controls.Add(dateTimePickerMonth);
            Name = "PickMonth";
            Text = "Chọn tháng";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerMonth;
        private Button buttonOK;
    }
}
