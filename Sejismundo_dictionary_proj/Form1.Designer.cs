namespace Sejismundo_dictionary_proj
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
            this.IUSDictionary = new System.Windows.Forms.Label();
            this.searchbx = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.resultbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IUSDictionary
            // 
            this.IUSDictionary.AutoSize = true;
            this.IUSDictionary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.IUSDictionary.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IUSDictionary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IUSDictionary.Location = new System.Drawing.Point(282, 26);
            this.IUSDictionary.Name = "IUSDictionary";
            this.IUSDictionary.Size = new System.Drawing.Size(297, 56);
            this.IUSDictionary.TabIndex = 0;
            this.IUSDictionary.Text = "IUS DICTIONARY";
            this.IUSDictionary.Click += new System.EventHandler(this.IUSDictionary_Click);
            // 
            // searchbx
            // 
            this.searchbx.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbx.Location = new System.Drawing.Point(143, 85);
            this.searchbx.Multiline = true;
            this.searchbx.Name = "searchbx";
            this.searchbx.Size = new System.Drawing.Size(421, 38);
            this.searchbx.TabIndex = 1;
            this.searchbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.searchbtn.Location = new System.Drawing.Point(605, 85);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(118, 38);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // resultbx
            // 
            this.resultbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(138)))));
            this.resultbx.FormattingEnabled = true;
            this.resultbx.ItemHeight = 16;
            this.resultbx.Location = new System.Drawing.Point(37, 149);
            this.resultbx.Name = "resultbx";
            this.resultbx.Size = new System.Drawing.Size(767, 388);
            this.resultbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sejismundo_dictionary_proj.Properties.Resources.Screenshot_2024_07_08_224645;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 549);
            this.Controls.Add(this.resultbx);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchbx);
            this.Controls.Add(this.IUSDictionary);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IUSDictionary;
        private System.Windows.Forms.TextBox searchbx;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ListBox resultbx;
    }
}

