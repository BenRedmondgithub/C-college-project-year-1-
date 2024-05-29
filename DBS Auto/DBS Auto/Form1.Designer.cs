namespace DBS_Auto
{
    partial class Form1
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
            this.billListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partsandlaborBox = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MicsBox = new System.Windows.Forms.GroupBox();
            this.chkTire = new System.Windows.Forms.CheckBox();
            this.chkMufflerReplacement = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.Flushesbox = new System.Windows.Forms.GroupBox();
            this.chkTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.OilLubeBox = new System.Windows.Forms.GroupBox();
            this.chkLubeJob = new System.Windows.Forms.CheckBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.partsandlaborBox.SuspendLayout();
            this.MicsBox.SuspendLayout();
            this.Flushesbox.SuspendLayout();
            this.OilLubeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // billListbox
            // 
            this.billListbox.FormattingEnabled = true;
            this.billListbox.Location = new System.Drawing.Point(545, 137);
            this.billListbox.Name = "billListbox";
            this.billListbox.Size = new System.Drawing.Size(205, 186);
            this.billListbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Your Final Bill: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partsandlaborBox
            // 
            this.partsandlaborBox.Controls.Add(this.laborTextBox);
            this.partsandlaborBox.Controls.Add(this.partsTextBox);
            this.partsandlaborBox.Controls.Add(this.label3);
            this.partsandlaborBox.Controls.Add(this.label2);
            this.partsandlaborBox.Location = new System.Drawing.Point(230, 191);
            this.partsandlaborBox.Name = "partsandlaborBox";
            this.partsandlaborBox.Size = new System.Drawing.Size(205, 88);
            this.partsandlaborBox.TabIndex = 16;
            this.partsandlaborBox.TabStop = false;
            this.partsandlaborBox.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(76, 61);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(76, 25);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Labor €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parts:";
            // 
            // MicsBox
            // 
            this.MicsBox.Controls.Add(this.chkTire);
            this.MicsBox.Controls.Add(this.chkMufflerReplacement);
            this.MicsBox.Controls.Add(this.chkInspection);
            this.MicsBox.Location = new System.Drawing.Point(230, 76);
            this.MicsBox.Name = "MicsBox";
            this.MicsBox.Size = new System.Drawing.Size(163, 92);
            this.MicsBox.TabIndex = 15;
            this.MicsBox.TabStop = false;
            this.MicsBox.Text = "Misc";
            // 
            // chkTire
            // 
            this.chkTire.AutoSize = true;
            this.chkTire.Location = new System.Drawing.Point(6, 70);
            this.chkTire.Name = "chkTire";
            this.chkTire.Size = new System.Drawing.Size(114, 17);
            this.chkTire.TabIndex = 2;
            this.chkTire.Text = "Tire Rotation (€30)";
            this.chkTire.UseVisualStyleBackColor = true;
            // 
            // chkMufflerReplacement
            // 
            this.chkMufflerReplacement.AutoSize = true;
            this.chkMufflerReplacement.Location = new System.Drawing.Point(6, 42);
            this.chkMufflerReplacement.Name = "chkMufflerReplacement";
            this.chkMufflerReplacement.Size = new System.Drawing.Size(152, 17);
            this.chkMufflerReplacement.TabIndex = 1;
            this.chkMufflerReplacement.Text = "Muffler replacement (€200)";
            this.chkMufflerReplacement.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(6, 12);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(102, 17);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection (€10)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(43, 340);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 35);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Pay now";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(343, 340);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 35);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(198, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 35);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Flushesbox
            // 
            this.Flushesbox.Controls.Add(this.chkTransmissionFlush);
            this.Flushesbox.Controls.Add(this.chkRadiatorFlush);
            this.Flushesbox.Location = new System.Drawing.Point(49, 201);
            this.Flushesbox.Name = "Flushesbox";
            this.Flushesbox.Size = new System.Drawing.Size(151, 78);
            this.Flushesbox.TabIndex = 11;
            this.Flushesbox.TabStop = false;
            this.Flushesbox.Text = "Flushes";
            // 
            // chkTransmissionFlush
            // 
            this.chkTransmissionFlush.AutoSize = true;
            this.chkTransmissionFlush.Location = new System.Drawing.Point(7, 44);
            this.chkTransmissionFlush.Name = "chkTransmissionFlush";
            this.chkTransmissionFlush.Size = new System.Drawing.Size(145, 17);
            this.chkTransmissionFlush.TabIndex = 1;
            this.chkTransmissionFlush.Text = "Transmission flush (€100)";
            this.chkTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Location = new System.Drawing.Point(7, 20);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(118, 17);
            this.chkRadiatorFlush.TabIndex = 0;
            this.chkRadiatorFlush.Text = "Radiator flush (€60)";
            this.chkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // OilLubeBox
            // 
            this.OilLubeBox.Controls.Add(this.chkLubeJob);
            this.OilLubeBox.Controls.Add(this.chkOilChange);
            this.OilLubeBox.Location = new System.Drawing.Point(49, 93);
            this.OilLubeBox.Name = "OilLubeBox";
            this.OilLubeBox.Size = new System.Drawing.Size(157, 75);
            this.OilLubeBox.TabIndex = 10;
            this.OilLubeBox.TabStop = false;
            this.OilLubeBox.Text = "Oil and Lube";
            // 
            // chkLubeJob
            // 
            this.chkLubeJob.AutoSize = true;
            this.chkLubeJob.Location = new System.Drawing.Point(7, 44);
            this.chkLubeJob.Name = "chkLubeJob";
            this.chkLubeJob.Size = new System.Drawing.Size(97, 17);
            this.chkLubeJob.TabIndex = 1;
            this.chkLubeJob.Text = "Lube Job( €20)";
            this.chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(7, 20);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(105, 17);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "Oil Change (€50)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partsandlaborBox);
            this.Controls.Add(this.MicsBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Flushesbox);
            this.Controls.Add(this.OilLubeBox);
            this.Name = "Form1";
            this.Text = "DBS Auto";
            this.partsandlaborBox.ResumeLayout(false);
            this.partsandlaborBox.PerformLayout();
            this.MicsBox.ResumeLayout(false);
            this.MicsBox.PerformLayout();
            this.Flushesbox.ResumeLayout(false);
            this.Flushesbox.PerformLayout();
            this.OilLubeBox.ResumeLayout(false);
            this.OilLubeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox billListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox partsandlaborBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox MicsBox;
        private System.Windows.Forms.CheckBox chkTire;
        private System.Windows.Forms.CheckBox chkMufflerReplacement;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox Flushesbox;
        private System.Windows.Forms.CheckBox chkTransmissionFlush;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.GroupBox OilLubeBox;
        private System.Windows.Forms.CheckBox chkLubeJob;
        private System.Windows.Forms.CheckBox chkOilChange;
    }
}

