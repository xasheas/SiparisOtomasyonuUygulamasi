namespace nyp1
{
    partial class anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gIRISYAPINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINGIRISIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uYEGIRISIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uYEOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gIRISYAPINToolStripMenuItem,
            this.uYEOLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gIRISYAPINToolStripMenuItem
            // 
            this.gIRISYAPINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINGIRISIToolStripMenuItem,
            this.uYEGIRISIToolStripMenuItem});
            this.gIRISYAPINToolStripMenuItem.Name = "gIRISYAPINToolStripMenuItem";
            this.gIRISYAPINToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gIRISYAPINToolStripMenuItem.Text = "GIRIS YAP";
            this.gIRISYAPINToolStripMenuItem.Click += new System.EventHandler(this.gIRISYAPINToolStripMenuItem_Click);
            // 
            // aDMINGIRISIToolStripMenuItem
            // 
            this.aDMINGIRISIToolStripMenuItem.Name = "aDMINGIRISIToolStripMenuItem";
            this.aDMINGIRISIToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aDMINGIRISIToolStripMenuItem.Text = "ADMIN GIRISI";
            this.aDMINGIRISIToolStripMenuItem.Click += new System.EventHandler(this.aDMINGIRISIToolStripMenuItem_Click);
            // 
            // uYEGIRISIToolStripMenuItem
            // 
            this.uYEGIRISIToolStripMenuItem.Name = "uYEGIRISIToolStripMenuItem";
            this.uYEGIRISIToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.uYEGIRISIToolStripMenuItem.Text = "UYE GIRISI";
            this.uYEGIRISIToolStripMenuItem.Click += new System.EventHandler(this.uYEGIRISIToolStripMenuItem_Click);
            // 
            // uYEOLToolStripMenuItem
            // 
            this.uYEOLToolStripMenuItem.Name = "uYEOLToolStripMenuItem";
            this.uYEOLToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.uYEOLToolStripMenuItem.Text = "UYE OL";
            this.uYEOLToolStripMenuItem.Click += new System.EventHandler(this.uYEOLToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::nyp1.Properties.Resources.yetkili_servis_sol;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 217);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yönetici Giriş";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::nyp1.Properties.Resources.indir;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(390, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(374, 217);
            this.button2.TabIndex = 1;
            this.button2.Text = "Üye Giriş";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(302, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kayıt Ol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gIRISYAPINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINGIRISIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uYEGIRISIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uYEOLToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

