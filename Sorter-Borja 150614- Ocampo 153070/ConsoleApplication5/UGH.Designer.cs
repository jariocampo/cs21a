namespace ConsoleApplication5
{
    partial class UGH
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
            this.enterbox = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.Binsertion = new System.Windows.Forms.Button();
            this.Bubbly = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterbox
            // 
            this.enterbox.BackColor = System.Drawing.Color.DarkSalmon;
            this.enterbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterbox.Location = new System.Drawing.Point(227, 76);
            this.enterbox.Name = "enterbox";
            this.enterbox.Size = new System.Drawing.Size(211, 20);
            this.enterbox.TabIndex = 0;
            this.enterbox.Text = "Enter a number";
            this.enterbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterbox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(62, 279);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(98, 39);
            this.select.TabIndex = 2;
            this.select.Text = "Selection";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // Binsertion
            // 
            this.Binsertion.BackColor = System.Drawing.Color.Transparent;
            this.Binsertion.FlatAppearance.BorderSize = 0;
            this.Binsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binsertion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Binsertion.Location = new System.Drawing.Point(62, 203);
            this.Binsertion.Name = "Binsertion";
            this.Binsertion.Size = new System.Drawing.Size(98, 39);
            this.Binsertion.TabIndex = 3;
            this.Binsertion.Text = "Binsertion";
            this.Binsertion.UseVisualStyleBackColor = false;
            this.Binsertion.Click += new System.EventHandler(this.binsertion_Click);
            // 
            // Bubbly
            // 
            this.Bubbly.BackColor = System.Drawing.Color.Transparent;
            this.Bubbly.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Bubbly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bubbly.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bubbly.Location = new System.Drawing.Point(62, 129);
            this.Bubbly.Name = "Bubbly";
            this.Bubbly.Size = new System.Drawing.Size(98, 39);
            this.Bubbly.TabIndex = 4;
            this.Bubbly.Text = "Bubbly";
            this.Bubbly.UseVisualStyleBackColor = false;
            this.Bubbly.Click += new System.EventHandler(this.Bubbly_Click);
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.Snow;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.Color.Tomato;
            this.Results.Location = new System.Drawing.Point(227, 111);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Results.Size = new System.Drawing.Size(252, 230);
            this.Results.TabIndex = 5;
            this.Results.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(433, 75);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(46, 21);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ConsoleApplication5.Properties.Resources.UGH;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(530, 385);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Bubbly);
            this.Controls.Add(this.Binsertion);
            this.Controls.Add(this.select);
            this.Controls.Add(this.enterbox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UGH";
            this.Text = "UGH";
            this.Load += new System.EventHandler(this.UGH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterbox;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button Binsertion;
        private System.Windows.Forms.Button Bubbly;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}