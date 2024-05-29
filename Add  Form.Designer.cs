namespace _3d
{
    partial class AddForm
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
            label1 = new Label();
            buttonAddFormClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Data added";
            // 
            // buttonAddFormClose
            // 
            buttonAddFormClose.Font = new Font("Segoe UI", 12F);
            buttonAddFormClose.Location = new Point(104, 54);
            buttonAddFormClose.Name = "buttonAddFormClose";
            buttonAddFormClose.Size = new Size(89, 41);
            buttonAddFormClose.TabIndex = 1;
            buttonAddFormClose.Text = "OK";
            buttonAddFormClose.UseVisualStyleBackColor = true;
            buttonAddFormClose.Click += buttonAddFormClose_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 107);
            Controls.Add(buttonAddFormClose);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Add Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAddFormClose;
    }
}