namespace _3d
{
    partial class MainForm
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
            textBoxSpeed = new TextBox();
            labelSpeed = new Label();
            buttonAddInDictionady = new Button();
            settingsGroupBox = new GroupBox();
            textBoxTestName = new TextBox();
            labelTestName = new Label();
            labelMaxVentilationSpeed = new Label();
            labelMinVentilationSpeed = new Label();
            labelTableTemp = new Label();
            textBoxMaxVentSped = new TextBox();
            textBoxMinVentSped = new TextBox();
            textBoxTableTemp = new TextBox();
            labelPrintingTemperature = new Label();
            textBoxPrintTemp = new TextBox();
            buttonRecord = new Button();
            buttonClose = new Button();
            settingsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Font = new Font("Segoe UI", 10F);
            textBoxSpeed.Location = new Point(227, 60);
            textBoxSpeed.Margin = new Padding(4);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(61, 25);
            textBoxSpeed.TabIndex = 0;
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 10F);
            labelSpeed.Location = new Point(6, 66);
            labelSpeed.Margin = new Padding(4, 0, 4, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(93, 19);
            labelSpeed.TabIndex = 1;
            labelSpeed.Text = "Speed (mm/s)";
            // 
            // buttonAddInDictionady
            // 
            buttonAddInDictionady.Font = new Font("Segoe UI", 10F);
            buttonAddInDictionady.Location = new Point(13, 306);
            buttonAddInDictionady.Margin = new Padding(4);
            buttonAddInDictionady.Name = "buttonAddInDictionady";
            buttonAddInDictionady.Size = new Size(96, 32);
            buttonAddInDictionady.TabIndex = 2;
            buttonAddInDictionady.Text = "Add";
            buttonAddInDictionady.UseVisualStyleBackColor = true;
            buttonAddInDictionady.Click += buttonAddInDictionady_Click;
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.BackColor = SystemColors.GradientActiveCaption;
            settingsGroupBox.Controls.Add(textBoxTestName);
            settingsGroupBox.Controls.Add(labelTestName);
            settingsGroupBox.Controls.Add(labelMaxVentilationSpeed);
            settingsGroupBox.Controls.Add(labelMinVentilationSpeed);
            settingsGroupBox.Controls.Add(labelTableTemp);
            settingsGroupBox.Controls.Add(textBoxMaxVentSped);
            settingsGroupBox.Controls.Add(textBoxMinVentSped);
            settingsGroupBox.Controls.Add(textBoxTableTemp);
            settingsGroupBox.Controls.Add(labelPrintingTemperature);
            settingsGroupBox.Controls.Add(textBoxPrintTemp);
            settingsGroupBox.Controls.Add(textBoxSpeed);
            settingsGroupBox.Controls.Add(labelSpeed);
            settingsGroupBox.Font = new Font("Segoe UI", 12F);
            settingsGroupBox.Location = new Point(13, 12);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Size = new Size(296, 287);
            settingsGroupBox.TabIndex = 4;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Settings";
            // 
            // textBoxTestName
            // 
            textBoxTestName.Font = new Font("Segoe UI", 10F);
            textBoxTestName.Location = new Point(103, 28);
            textBoxTestName.Name = "textBoxTestName";
            textBoxTestName.Size = new Size(185, 25);
            textBoxTestName.TabIndex = 15;
            // 
            // labelTestName
            // 
            labelTestName.AutoSize = true;
            labelTestName.Font = new Font("Segoe UI", 10F);
            labelTestName.Location = new Point(6, 34);
            labelTestName.Name = "labelTestName";
            labelTestName.Size = new Size(73, 19);
            labelTestName.TabIndex = 14;
            labelTestName.Text = "Test Name";
            // 
            // labelMaxVentilationSpeed
            // 
            labelMaxVentilationSpeed.AutoSize = true;
            labelMaxVentilationSpeed.Font = new Font("Segoe UI", 10F);
            labelMaxVentilationSpeed.Location = new Point(6, 191);
            labelMaxVentilationSpeed.Name = "labelMaxVentilationSpeed";
            labelMaxVentilationSpeed.Size = new Size(171, 19);
            labelMaxVentilationSpeed.TabIndex = 13;
            labelMaxVentilationSpeed.Text = "Max. Ventilation Speed (%)";
            // 
            // labelMinVentilationSpeed
            // 
            labelMinVentilationSpeed.AutoSize = true;
            labelMinVentilationSpeed.Font = new Font("Segoe UI", 10F);
            labelMinVentilationSpeed.Location = new Point(8, 160);
            labelMinVentilationSpeed.Name = "labelMinVentilationSpeed";
            labelMinVentilationSpeed.Size = new Size(169, 19);
            labelMinVentilationSpeed.TabIndex = 12;
            labelMinVentilationSpeed.Text = "Min. Ventilation Speed (%)";
            // 
            // labelTableTemp
            // 
            labelTableTemp.AutoSize = true;
            labelTableTemp.Font = new Font("Segoe UI", 10F);
            labelTableTemp.Location = new Point(6, 129);
            labelTableTemp.Name = "labelTableTemp";
            labelTableTemp.Size = new Size(97, 19);
            labelTableTemp.TabIndex = 11;
            labelTableTemp.Text = "Table Temp (C)";
            // 
            // textBoxMaxVentSped
            // 
            textBoxMaxVentSped.Font = new Font("Segoe UI", 10F);
            textBoxMaxVentSped.Location = new Point(227, 185);
            textBoxMaxVentSped.Name = "textBoxMaxVentSped";
            textBoxMaxVentSped.Size = new Size(61, 25);
            textBoxMaxVentSped.TabIndex = 9;
            // 
            // textBoxMinVentSped
            // 
            textBoxMinVentSped.Font = new Font("Segoe UI", 10F);
            textBoxMinVentSped.Location = new Point(227, 154);
            textBoxMinVentSped.Name = "textBoxMinVentSped";
            textBoxMinVentSped.Size = new Size(61, 25);
            textBoxMinVentSped.TabIndex = 8;
            // 
            // textBoxTableTemp
            // 
            textBoxTableTemp.Font = new Font("Segoe UI", 10F);
            textBoxTableTemp.Location = new Point(227, 123);
            textBoxTableTemp.Name = "textBoxTableTemp";
            textBoxTableTemp.Size = new Size(61, 25);
            textBoxTableTemp.TabIndex = 7;
            // 
            // labelPrintingTemperature
            // 
            labelPrintingTemperature.AutoSize = true;
            labelPrintingTemperature.Font = new Font("Segoe UI", 10F);
            labelPrintingTemperature.Location = new Point(6, 98);
            labelPrintingTemperature.Name = "labelPrintingTemperature";
            labelPrintingTemperature.Size = new Size(115, 19);
            labelPrintingTemperature.TabIndex = 6;
            labelPrintingTemperature.Text = "Printing Temp (C)";
            // 
            // textBoxPrintTemp
            // 
            textBoxPrintTemp.Font = new Font("Segoe UI", 10F);
            textBoxPrintTemp.Location = new Point(227, 92);
            textBoxPrintTemp.Name = "textBoxPrintTemp";
            textBoxPrintTemp.Size = new Size(61, 25);
            textBoxPrintTemp.TabIndex = 5;
            // 
            // buttonRecord
            // 
            buttonRecord.Location = new Point(116, 305);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(103, 32);
            buttonRecord.TabIndex = 5;
            buttonRecord.Text = "Record Data";
            buttonRecord.UseVisualStyleBackColor = true;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(225, 305);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(84, 32);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(321, 351);
            Controls.Add(buttonClose);
            Controls.Add(buttonRecord);
            Controls.Add(settingsGroupBox);
            Controls.Add(buttonAddInDictionady);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(337, 390);
            Name = "MainForm";
            Text = "Settings Recording";
            settingsGroupBox.ResumeLayout(false);
            settingsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxSpeed;
        private Label labelSpeed;
        private Button buttonAddInDictionady;
        private GroupBox settingsGroupBox;
        private TextBox textBoxPrintTemp;
        private Label labelPrintingTemperature;
        private TextBox textBoxMaxVentSped;
        private TextBox textBoxMinVentSped;
        private TextBox textBoxTableTemp;
        private Label labelMaxVentilationSpeed;
        private Label labelMinVentilationSpeed;
        private Label labelTableTemp;
        private Button buttonRecord;
        private Button buttonClose;
        private TextBox textBoxTestName;
        private Label labelTestName;
    }
}
