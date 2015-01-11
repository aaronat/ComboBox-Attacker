namespace ComboboxAttacker2
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

            if (disposing)
            {
                // Release event sink
                if (-1 != cookie) icp.Unadvise(cookie);
                cookie = -1;
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.url1 = new System.Windows.Forms.TextBox();
            this.go1 = new System.Windows.Forms.Button();
            this.Exit1b = new System.Windows.Forms.Button();
            this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // url1
            // 
            this.url1.Location = new System.Drawing.Point(21, 12);
            this.url1.Name = "url1";
            this.url1.Size = new System.Drawing.Size(554, 20);
            this.url1.TabIndex = 1;
            this.url1.TextChanged += new System.EventHandler(this.url1_TextChanged);
            this.url1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url1_KeyDown);
            // 
            // go1
            // 
            this.go1.Location = new System.Drawing.Point(582, 11);
            this.go1.Name = "go1";
            this.go1.Size = new System.Drawing.Size(75, 23);
            this.go1.TabIndex = 2;
            this.go1.Text = "Go";
            this.go1.UseVisualStyleBackColor = true;
            this.go1.Click += new System.EventHandler(this.go1_Click);
            // 
            // Exit1b
            // 
            this.Exit1b.Location = new System.Drawing.Point(576, 271);
            this.Exit1b.Name = "Exit1b";
            this.Exit1b.Size = new System.Drawing.Size(75, 23);
            this.Exit1b.TabIndex = 3;
            this.Exit1b.Text = "Exit";
            this.Exit1b.UseVisualStyleBackColor = true;
            this.Exit1b.Click += new System.EventHandler(this.Exit1b_Click);
            // 
            // axWebBrowser1
            // 
            this.axWebBrowser1.Enabled = true;
            this.axWebBrowser1.Location = new System.Drawing.Point(21, 40);
            this.axWebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser1.OcxState")));
            this.axWebBrowser1.Size = new System.Drawing.Size(630, 224);
            this.axWebBrowser1.TabIndex = 0;
            this.axWebBrowser1.Enter += new System.EventHandler(this.axWebBrowser1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 305);
            this.Controls.Add(this.Exit1b);
            this.Controls.Add(this.go1);
            this.Controls.Add(this.url1);
            this.Controls.Add(this.axWebBrowser1);
            this.Name = "Form1";
            this.Text = "Combobox Attacker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSHDocVw.AxWebBrowser axWebBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox url1;
        private System.Windows.Forms.Button go1;
        private System.Windows.Forms.Button Exit1b;
    }
}

