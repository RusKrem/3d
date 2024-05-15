namespace _3d
{
    partial class Sucsess
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
            labelSuccessful = new Label();
            buttonSuccessful = new Button();
            SuspendLayout();
            // 
            // labelSuccessful
            // 
            labelSuccessful.AutoSize = true;
            labelSuccessful.Font = new Font("Segoe UI", 14F);
            labelSuccessful.Location = new Point(23, 9);
            labelSuccessful.Name = "labelSuccessful";
            labelSuccessful.Size = new Size(99, 25);
            labelSuccessful.TabIndex = 0;
            labelSuccessful.Text = "Successful";
            // 
            // buttonSuccessful
            // 
            buttonSuccessful.Font = new Font("Segoe UI", 12F);
            buttonSuccessful.Location = new Point(34, 63);
            buttonSuccessful.Name = "buttonSuccessful";
            buttonSuccessful.Size = new Size(75, 36);
            buttonSuccessful.TabIndex = 1;
            buttonSuccessful.Text = "OK";
            buttonSuccessful.UseVisualStyleBackColor = true;
            buttonSuccessful.Click += buttonSuccessful_Click;
            // 
            // Sucsess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(145, 111);
            Controls.Add(buttonSuccessful);
            Controls.Add(labelSuccessful);
            Name = "Sucsess";
            Text = "Sucsess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSuccessful;
        private Button buttonSuccessful;
    }
}