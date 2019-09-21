namespace WindowsFormsApp2
{
    partial class Toplamaİslemi
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
            this.Tab1 = new System.Windows.Forms.TabControl();
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.lvlog = new System.Windows.Forms.ListView();
            this.Tab1.SuspendLayout();
            this.tabToplama.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab1
            // 
            this.Tab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab1.Controls.Add(this.tabToplama);
            this.Tab1.Controls.Add(this.tab2);
            this.Tab1.Location = new System.Drawing.Point(-3, -3);
            this.Tab1.Name = "Tab1";
            this.Tab1.SelectedIndex = 0;
            this.Tab1.Size = new System.Drawing.Size(272, 284);
            this.Tab1.TabIndex = 7;
            // 
            // tabToplama
            // 
            this.tabToplama.Controls.Add(this.lblSonuc);
            this.tabToplama.Controls.Add(this.txtSonuc);
            this.tabToplama.Controls.Add(this.txtİkinciSayi);
            this.tabToplama.Controls.Add(this.txtBirinciSayi);
            this.tabToplama.Controls.Add(this.lblİkinciSayi);
            this.tabToplama.Controls.Add(this.lblBirinciSayi);
            this.tabToplama.Controls.Add(this.btnTopla);
            this.tabToplama.Location = new System.Drawing.Point(4, 22);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.Padding = new System.Windows.Forms.Padding(3);
            this.tabToplama.Size = new System.Drawing.Size(264, 258);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            this.tabToplama.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(50, 136);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "Sonuc";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(114, 133);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 12;
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(114, 88);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtİkinciSayi.TabIndex = 1;
            this.txtİkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtİkinciSayi_KeyPress);
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(114, 48);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtBirinciSayi.TabIndex = 0;
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirinciSayi_KeyPress);
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.Location = new System.Drawing.Point(50, 88);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(55, 13);
            this.lblİkinciSayi.TabIndex = 9;
            this.lblİkinciSayi.Text = "İkinci Sayı";
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(50, 51);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblBirinciSayi.TabIndex = 8;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(123, 187);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.lvlog);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(264, 258);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Log";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // lvlog
            // 
            this.lvlog.HideSelection = false;
            this.lvlog.Location = new System.Drawing.Point(3, 6);
            this.lvlog.Name = "lvlog";
            this.lvlog.Size = new System.Drawing.Size(255, 246);
            this.lvlog.TabIndex = 0;
            this.lvlog.UseCompatibleStateImageBehavior = false;
            this.lvlog.View = System.Windows.Forms.View.List;
            // 
            // Toplamaİslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 275);
            this.Controls.Add(this.Tab1);
            this.Name = "Toplamaİslemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi";
            this.Shown += new System.EventHandler(this.Toplamaİslemi_Shown);
            this.Tab1.ResumeLayout(false);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab1;
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.ListView lvlog;
    }
}

