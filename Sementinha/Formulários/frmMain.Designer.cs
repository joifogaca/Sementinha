namespace Sementinha
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menMain = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFrequentadores = new System.Windows.Forms.Button();
            this.btnTipos_Cadastros = new System.Windows.Forms.Button();
            this.menMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menMain
            // 
            this.menMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menMain.Location = new System.Drawing.Point(0, 0);
            this.menMain.Name = "menMain";
            this.menMain.Size = new System.Drawing.Size(905, 24);
            this.menMain.TabIndex = 1;
            this.menMain.Text = "Menu";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // btnFrequentadores
            // 
            this.btnFrequentadores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFrequentadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrequentadores.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrequentadores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFrequentadores.Image = ((System.Drawing.Image)(resources.GetObject("btnFrequentadores.Image")));
            this.btnFrequentadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFrequentadores.Location = new System.Drawing.Point(0, 27);
            this.btnFrequentadores.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnFrequentadores.Name = "btnFrequentadores";
            this.btnFrequentadores.Size = new System.Drawing.Size(66, 66);
            this.btnFrequentadores.TabIndex = 2;
            this.btnFrequentadores.Text = "Frequentadores";
            this.btnFrequentadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFrequentadores.UseVisualStyleBackColor = false;
            this.btnFrequentadores.Click += new System.EventHandler(this.btnFrequentadores_Click);
            // 
            // btnTipos_Cadastros
            // 
            this.btnTipos_Cadastros.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipos_Cadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTipos_Cadastros.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipos_Cadastros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTipos_Cadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnTipos_Cadastros.Image")));
            this.btnTipos_Cadastros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTipos_Cadastros.Location = new System.Drawing.Point(72, 27);
            this.btnTipos_Cadastros.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnTipos_Cadastros.Name = "btnTipos_Cadastros";
            this.btnTipos_Cadastros.Size = new System.Drawing.Size(66, 66);
            this.btnTipos_Cadastros.TabIndex = 4;
            this.btnTipos_Cadastros.Text = "Tipos de Cadastros";
            this.btnTipos_Cadastros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTipos_Cadastros.UseVisualStyleBackColor = false;
            this.btnTipos_Cadastros.Click += new System.EventHandler(this.btnTipos_Cadastros_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 322);
            this.Controls.Add(this.btnTipos_Cadastros);
            this.Controls.Add(this.btnFrequentadores);
            this.Controls.Add(this.menMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menMain;
            this.Name = "frmMain";
            this.Text = "Sementinha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menMain.ResumeLayout(false);
            this.menMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menMain;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btnFrequentadores;
        private System.Windows.Forms.Button btnTipos_Cadastros;
    }
}

