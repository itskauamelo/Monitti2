namespace Monitoramento
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFechar = new System.Windows.Forms.Label();
            this.pbxMonit = new System.Windows.Forms.PictureBox();
            this.lblMonitorar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMinimiz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(554, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(26, 25);
            this.lblFechar.TabIndex = 0;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.LblFechar_Click);
            // 
            // pbxMonit
            // 
            this.pbxMonit.Image = ((System.Drawing.Image)(resources.GetObject("pbxMonit.Image")));
            this.pbxMonit.Location = new System.Drawing.Point(234, 78);
            this.pbxMonit.Name = "pbxMonit";
            this.pbxMonit.Size = new System.Drawing.Size(130, 121);
            this.pbxMonit.TabIndex = 2;
            this.pbxMonit.TabStop = false;
            this.pbxMonit.Click += new System.EventHandler(this.PbxMonit_Click);
            // 
            // lblMonitorar
            // 
            this.lblMonitorar.AutoSize = true;
            this.lblMonitorar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitorar.ForeColor = System.Drawing.Color.White;
            this.lblMonitorar.Location = new System.Drawing.Point(237, 202);
            this.lblMonitorar.Name = "lblMonitorar";
            this.lblMonitorar.Size = new System.Drawing.Size(127, 30);
            this.lblMonitorar.TabIndex = 3;
            this.lblMonitorar.Text = "Monitorar";
            this.lblMonitorar.Click += new System.EventHandler(this.LblMonitorar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(473, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lblMinimiz
            // 
            this.lblMinimiz.AutoSize = true;
            this.lblMinimiz.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimiz.ForeColor = System.Drawing.Color.White;
            this.lblMinimiz.Location = new System.Drawing.Point(530, 6);
            this.lblMinimiz.Name = "lblMinimiz";
            this.lblMinimiz.Size = new System.Drawing.Size(23, 25);
            this.lblMinimiz.TabIndex = 5;
            this.lblMinimiz.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(592, 323);
            this.Controls.Add(this.lblMinimiz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMonitorar);
            this.Controls.Add(this.pbxMonit);
            this.Controls.Add(this.lblFechar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMonit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.PictureBox pbxMonit;
        private System.Windows.Forms.Label lblMonitorar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMinimiz;
    }
}

