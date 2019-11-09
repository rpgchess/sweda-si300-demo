namespace SwedaDemo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtCodeBar = new System.Windows.Forms.TextBox();
            this.btnGaveta = new System.Windows.Forms.Button();
            this.lblCodeBar = new System.Windows.Forms.Label();
            this.imgClosed = new System.Windows.Forms.PictureBox();
            this.imgCodeBar = new System.Windows.Forms.PictureBox();
            this.imgConnect = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgCupom = new System.Windows.Forms.PictureBox();
            this.imgBgBot = new System.Windows.Forms.PictureBox();
            this.imgBgTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCupom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBgBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBgTop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(466, 622);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(350, 75);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "Imprimir XML";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtCodeBar
            // 
            this.txtCodeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodeBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeBar.Location = new System.Drawing.Point(466, 156);
            this.txtCodeBar.Name = "txtCodeBar";
            this.txtCodeBar.Size = new System.Drawing.Size(350, 42);
            this.txtCodeBar.TabIndex = 1;
            this.txtCodeBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodeBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeBar_KeyPress);
            // 
            // btnGaveta
            // 
            this.btnGaveta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGaveta.BackColor = System.Drawing.Color.Transparent;
            this.btnGaveta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGaveta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaveta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaveta.Location = new System.Drawing.Point(110, 622);
            this.btnGaveta.Name = "btnGaveta";
            this.btnGaveta.Size = new System.Drawing.Size(350, 75);
            this.btnGaveta.TabIndex = 7;
            this.btnGaveta.TabStop = false;
            this.btnGaveta.Text = "Abrir Gaveta";
            this.btnGaveta.UseVisualStyleBackColor = false;
            this.btnGaveta.Click += new System.EventHandler(this.btnGaveta_Click);
            // 
            // lblCodeBar
            // 
            this.lblCodeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodeBar.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeBar.Location = new System.Drawing.Point(466, 126);
            this.lblCodeBar.Name = "lblCodeBar";
            this.lblCodeBar.Size = new System.Drawing.Size(350, 30);
            this.lblCodeBar.TabIndex = 12;
            this.lblCodeBar.Text = "Colete o código de barra:";
            this.lblCodeBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // imgClosed
            // 
            this.imgClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClosed.BackColor = System.Drawing.Color.Transparent;
            this.imgClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClosed.Image = global::SwedaDemo.Properties.Resources.btn_closed;
            this.imgClosed.Location = new System.Drawing.Point(752, 12);
            this.imgClosed.Name = "imgClosed";
            this.imgClosed.Size = new System.Drawing.Size(64, 64);
            this.imgClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClosed.TabIndex = 13;
            this.imgClosed.TabStop = false;
            this.imgClosed.Click += new System.EventHandler(this.imgClosed_Click);
            this.imgClosed.MouseLeave += new System.EventHandler(this.imgClosed_MouseLeave);
            this.imgClosed.MouseHover += new System.EventHandler(this.imgClosed_MouseHover);
            // 
            // imgCodeBar
            // 
            this.imgCodeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCodeBar.Image = global::SwedaDemo.Properties.Resources.codebar;
            this.imgCodeBar.Location = new System.Drawing.Point(513, 216);
            this.imgCodeBar.Name = "imgCodeBar";
            this.imgCodeBar.Size = new System.Drawing.Size(260, 81);
            this.imgCodeBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCodeBar.TabIndex = 10;
            this.imgCodeBar.TabStop = false;
            this.imgCodeBar.Visible = false;
            // 
            // imgConnect
            // 
            this.imgConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgConnect.BackColor = System.Drawing.Color.Transparent;
            this.imgConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgConnect.Image = global::SwedaDemo.Properties.Resources.disconnected;
            this.imgConnect.Location = new System.Drawing.Point(12, 633);
            this.imgConnect.Name = "imgConnect";
            this.imgConnect.Size = new System.Drawing.Size(64, 64);
            this.imgConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgConnect.TabIndex = 8;
            this.imgConnect.TabStop = false;
            this.imgConnect.Click += new System.EventHandler(this.imgConnect_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::SwedaDemo.Properties.Resources.sweda_logo;
            this.imgLogo.Location = new System.Drawing.Point(12, 14);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(332, 103);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // imgCupom
            // 
            this.imgCupom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCupom.Image = global::SwedaDemo.Properties.Resources.cupom;
            this.imgCupom.Location = new System.Drawing.Point(513, 216);
            this.imgCupom.Name = "imgCupom";
            this.imgCupom.Size = new System.Drawing.Size(261, 400);
            this.imgCupom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCupom.TabIndex = 11;
            this.imgCupom.TabStop = false;
            this.imgCupom.Visible = false;
            // 
            // imgBgBot
            // 
            this.imgBgBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBgBot.Image = global::SwedaDemo.Properties.Resources.bg_bottom;
            this.imgBgBot.Location = new System.Drawing.Point(0, 580);
            this.imgBgBot.Name = "imgBgBot";
            this.imgBgBot.Size = new System.Drawing.Size(827, 200);
            this.imgBgBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBgBot.TabIndex = 4;
            this.imgBgBot.TabStop = false;
            // 
            // imgBgTop
            // 
            this.imgBgTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBgTop.Image = global::SwedaDemo.Properties.Resources.bg_top;
            this.imgBgTop.Location = new System.Drawing.Point(0, 0);
            this.imgBgTop.Name = "imgBgTop";
            this.imgBgTop.Size = new System.Drawing.Size(827, 170);
            this.imgBgTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBgTop.TabIndex = 3;
            this.imgBgTop.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 709);
            this.Controls.Add(this.imgClosed);
            this.Controls.Add(this.lblCodeBar);
            this.Controls.Add(this.txtCodeBar);
            this.Controls.Add(this.imgCodeBar);
            this.Controls.Add(this.imgConnect);
            this.Controls.Add(this.btnGaveta);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.imgCupom);
            this.Controls.Add(this.imgBgBot);
            this.Controls.Add(this.imgBgTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Sweda Demonstração";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCupom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBgBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBgTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtCodeBar;
        private System.Windows.Forms.PictureBox imgBgTop;
        private System.Windows.Forms.PictureBox imgBgBot;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnGaveta;
        private System.Windows.Forms.PictureBox imgConnect;
        private System.Windows.Forms.PictureBox imgCodeBar;
        private System.Windows.Forms.PictureBox imgCupom;
        private System.Windows.Forms.Label lblCodeBar;
        private System.Windows.Forms.PictureBox imgClosed;
    }
}

