namespace LAB1okienko
{
    partial class BackpackProblem
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
            this.textInputAmount = new System.Windows.Forms.TextBox();
            this.textCapacity = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.textInputCapacity = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textItems = new System.Windows.Forms.TextBox();
            this.textOutputItems = new System.Windows.Forms.TextBox();
            this.textSolution = new System.Windows.Forms.TextBox();
            this.textOutputSolution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textInputAmount
            // 
            this.textInputAmount.Location = new System.Drawing.Point(189, 76);
            this.textInputAmount.Name = "textInputAmount";
            this.textInputAmount.Size = new System.Drawing.Size(100, 22);
            this.textInputAmount.TabIndex = 0;
            this.textInputAmount.TextChanged += new System.EventHandler(this.textInputAmount_TextChanged);
            // 
            // textCapacity
            // 
            this.textCapacity.BackColor = System.Drawing.SystemColors.Menu;
            this.textCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCapacity.Location = new System.Drawing.Point(12, 29);
            this.textCapacity.Multiline = true;
            this.textCapacity.Name = "textCapacity";
            this.textCapacity.ReadOnly = true;
            this.textCapacity.Size = new System.Drawing.Size(171, 24);
            this.textCapacity.TabIndex = 1;
            this.textCapacity.Text = "Podaj pojemność plecaka:";
            this.textCapacity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(316, 29);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(90, 69);
            this.button.TabIndex = 2;
            this.button.Text = "Wynik";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textInputCapacity
            // 
            this.textInputCapacity.Location = new System.Drawing.Point(189, 29);
            this.textInputCapacity.Name = "textInputCapacity";
            this.textInputCapacity.Size = new System.Drawing.Size(100, 22);
            this.textInputCapacity.TabIndex = 3;
            this.textInputCapacity.TextChanged += new System.EventHandler(this.textInputCapacity_TextChanged);
            // 
            // textAmount
            // 
            this.textAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.textAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAmount.Location = new System.Drawing.Point(12, 76);
            this.textAmount.Multiline = true;
            this.textAmount.Name = "textAmount";
            this.textAmount.ReadOnly = true;
            this.textAmount.Size = new System.Drawing.Size(171, 24);
            this.textAmount.TabIndex = 4;
            this.textAmount.Text = "Podaj ilość przedmiotów:\r\n\r\n";
            this.textAmount.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // textItems
            // 
            this.textItems.BackColor = System.Drawing.SystemColors.Menu;
            this.textItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textItems.Location = new System.Drawing.Point(12, 156);
            this.textItems.Multiline = true;
            this.textItems.Name = "textItems";
            this.textItems.ReadOnly = true;
            this.textItems.Size = new System.Drawing.Size(171, 24);
            this.textItems.TabIndex = 5;
            this.textItems.Text = "Wygenerowane przedmioty:";
            this.textItems.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textOutputItems
            // 
            this.textOutputItems.Location = new System.Drawing.Point(12, 177);
            this.textOutputItems.Multiline = true;
            this.textOutputItems.Name = "textOutputItems";
            this.textOutputItems.ReadOnly = true;
            this.textOutputItems.Size = new System.Drawing.Size(171, 259);
            this.textOutputItems.TabIndex = 6;
            this.textOutputItems.TextChanged += new System.EventHandler(this.textOutputItems_TextChanged);
            // 
            // textSolution
            // 
            this.textSolution.BackColor = System.Drawing.SystemColors.Menu;
            this.textSolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSolution.Location = new System.Drawing.Point(235, 156);
            this.textSolution.Multiline = true;
            this.textSolution.Name = "textSolution";
            this.textSolution.ReadOnly = true;
            this.textSolution.Size = new System.Drawing.Size(171, 24);
            this.textSolution.TabIndex = 7;
            this.textSolution.Text = "Rozwiązanie:";
            this.textSolution.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textOutputSolution
            // 
            this.textOutputSolution.Location = new System.Drawing.Point(235, 177);
            this.textOutputSolution.Multiline = true;
            this.textOutputSolution.Name = "textOutputSolution";
            this.textOutputSolution.ReadOnly = true;
            this.textOutputSolution.Size = new System.Drawing.Size(171, 259);
            this.textOutputSolution.TabIndex = 8;
            this.textOutputSolution.TextChanged += new System.EventHandler(this.textOutputSolution_TextChanged);
            // 
            // BackpackProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 448);
            this.Controls.Add(this.textOutputSolution);
            this.Controls.Add(this.textSolution);
            this.Controls.Add(this.textOutputItems);
            this.Controls.Add(this.textItems);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textInputCapacity);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.textInputAmount);
            this.Name = "BackpackProblem";
            this.Text = "BackpackProblem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInputAmount;
        private System.Windows.Forms.TextBox textCapacity;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textInputCapacity;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textItems;
        private System.Windows.Forms.TextBox textOutputItems;
        private System.Windows.Forms.TextBox textSolution;
        private System.Windows.Forms.TextBox textOutputSolution;
    }
}

