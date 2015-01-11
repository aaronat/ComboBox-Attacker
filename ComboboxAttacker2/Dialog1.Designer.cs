namespace ComboboxAttacker2
{
    partial class Dialog1
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
            this.urldata1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.postdata1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.original = new System.Windows.Forms.Label();
            this.encoded1 = new System.Windows.Forms.TextBox();
            this.original1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.headers1 = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Cookies = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urldata1
            // 
            this.urldata1.Location = new System.Drawing.Point(14, 298);
            this.urldata1.Multiline = true;
            this.urldata1.Name = "urldata1";
            this.urldata1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.urldata1.Size = new System.Drawing.Size(976, 71);
            this.urldata1.TabIndex = 0;
            this.urldata1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Post Data";
            // 
            // postdata1
            // 
            this.postdata1.Location = new System.Drawing.Point(13, 403);
            this.postdata1.Multiline = true;
            this.postdata1.Name = "postdata1";
            this.postdata1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.postdata1.Size = new System.Drawing.Size(976, 116);
            this.postdata1.TabIndex = 2;
            this.postdata1.TextChanged += new System.EventHandler(this.postdata1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.original);
            this.groupBox1.Controls.Add(this.encoded1);
            this.groupBox1.Controls.Add(this.original1);
            this.groupBox1.Location = new System.Drawing.Point(502, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UrlEncoder";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Encode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encoded";
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.Location = new System.Drawing.Point(19, 22);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(42, 13);
            this.original.TabIndex = 2;
            this.original.Text = "Original";
            // 
            // encoded1
            // 
            this.encoded1.Location = new System.Drawing.Point(67, 45);
            this.encoded1.Name = "encoded1";
            this.encoded1.Size = new System.Drawing.Size(327, 20);
            this.encoded1.TabIndex = 1;
            // 
            // original1
            // 
            this.original1.Location = new System.Drawing.Point(67, 19);
            this.original1.Name = "original1";
            this.original1.Size = new System.Drawing.Size(327, 20);
            this.original1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Headers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // headers1
            // 
            this.headers1.Location = new System.Drawing.Point(15, 106);
            this.headers1.Multiline = true;
            this.headers1.Name = "headers1";
            this.headers1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.headers1.Size = new System.Drawing.Size(976, 37);
            this.headers1.TabIndex = 7;
            this.headers1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(835, 537);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // OK1
            // 
            this.OK1.Location = new System.Drawing.Point(916, 537);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(75, 23);
            this.OK1.TabIndex = 9;
            this.OK1.Text = "OK";
            this.OK1.UseVisualStyleBackColor = true;
            this.OK1.Click += new System.EventHandler(this.OK1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cookies";
            // 
            // Cookies
            // 
            this.Cookies.Location = new System.Drawing.Point(15, 170);
            this.Cookies.Multiline = true;
            this.Cookies.Name = "Cookies";
            this.Cookies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Cookies.Size = new System.Drawing.Size(976, 98);
            this.Cookies.TabIndex = 11;
            // 
            // Dialog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 573);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cookies);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headers1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postdata1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urldata1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Your Post";
            this.Load += new System.EventHandler(this.Dialog1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urldata1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox postdata1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label original;
        private System.Windows.Forms.TextBox encoded1;
        private System.Windows.Forms.TextBox original1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox headers1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cookies;
    }
}