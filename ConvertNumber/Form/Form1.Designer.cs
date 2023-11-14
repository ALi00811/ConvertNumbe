namespace ConvertNumber
{
    partial class Form1
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
            txtNum = new TextBox();
            lblText = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(38, 46);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(390, 23);
            txtNum.TabIndex = 0;
            txtNum.TextAlign = HorizontalAlignment.Center;
            txtNum.TextChanged += txtNum_TextChanged;
            txtNum.KeyPress += txtNum_KeyPress;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(38, 72);
            lblText.Name = "lblText";
            lblText.Size = new Size(34, 15);
            lblText.TabIndex = 1;
            lblText.Text = "سلام!";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(161, 168);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "بستن";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 238);
            Controls.Add(btnClose);
            Controls.Add(lblText);
            Controls.Add(txtNum);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "زیباست";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Label lblText;
        private Button btnClose;
    }
}