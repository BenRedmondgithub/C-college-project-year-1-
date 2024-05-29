namespace popularity
{
    partial class PopulationForm
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
            this.sumlistbox = new System.Windows.Forms.ListBox();
            this.Calulatebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.dailyTextBox = new System.Windows.Forms.TextBox();
            this.organismsTextbox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumlistbox
            // 
            this.sumlistbox.FormattingEnabled = true;
            this.sumlistbox.Location = new System.Drawing.Point(449, 46);
            this.sumlistbox.Name = "sumlistbox";
            this.sumlistbox.Size = new System.Drawing.Size(279, 329);
            this.sumlistbox.TabIndex = 0;
            // 
            // Calulatebutton
            // 
            this.Calulatebutton.Location = new System.Drawing.Point(186, 205);
            this.Calulatebutton.Name = "Calulatebutton";
            this.Calulatebutton.Size = new System.Drawing.Size(114, 48);
            this.Calulatebutton.TabIndex = 1;
            this.Calulatebutton.Text = "Go!";
            this.Calulatebutton.UseVisualStyleBackColor = true;
            this.Calulatebutton.Click += new System.EventHandler(this.Calulatebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(186, 310);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(115, 52);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(261, 150);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(95, 20);
            this.daysTextBox.TabIndex = 2;
            // 
            // dailyTextBox
            // 
            this.dailyTextBox.Location = new System.Drawing.Point(261, 89);
            this.dailyTextBox.Name = "dailyTextBox";
            this.dailyTextBox.Size = new System.Drawing.Size(95, 20);
            this.dailyTextBox.TabIndex = 2;
            // 
            // organismsTextbox
            // 
            this.organismsTextbox.Location = new System.Drawing.Point(260, 36);
            this.organismsTextbox.Name = "organismsTextbox";
            this.organismsTextbox.Size = new System.Drawing.Size(96, 20);
            this.organismsTextbox.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(186, 259);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 45);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Starting Organisms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daily Increase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Days";
            // 
            // PopulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.organismsTextbox);
            this.Controls.Add(this.dailyTextBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Calulatebutton);
            this.Controls.Add(this.sumlistbox);
            this.Name = "PopulationForm";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sumlistbox;
        private System.Windows.Forms.Button Calulatebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox dailyTextBox;
        private System.Windows.Forms.TextBox organismsTextbox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

