namespace WindowsFormsApp1
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
            this.AreaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.AreaBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AreaButton
            // 
            this.AreaButton.Location = new System.Drawing.Point(191, 237);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(100, 31);
            this.AreaButton.TabIndex = 0;
            this.AreaButton.Text = "Räkna";
            this.AreaButton.UseVisualStyleBackColor = true;
            this.AreaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bredd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(191, 159);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(100, 22);
            this.LengthBox.TabIndex = 2;
            // 
            // AreaBox
            // 
            this.AreaBox.Location = new System.Drawing.Point(191, 338);
            this.AreaBox.Name = "AreaBox";
            this.AreaBox.Size = new System.Drawing.Size(100, 22);
            this.AreaBox.TabIndex = 3;
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(191, 55);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 22);
            this.WidthBox.TabIndex = 4;
            this.WidthBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Längd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.AreaBox);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AreaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LengthBox;
        private System.Windows.Forms.TextBox AreaBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

