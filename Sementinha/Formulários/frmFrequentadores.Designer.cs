namespace Sementinha
{
    partial class frmFrequentadores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panFREQUENTADORES = new System.Windows.Forms.Panel();
            this.dgvFREQUENTADORES = new System.Windows.Forms.DataGridView();
            this.btnFREQUENTADORESexcluir = new System.Windows.Forms.Button();
            this.btnFREQUENTADORESconsultar = new System.Windows.Forms.Button();
            this.btnFREQUENTADORESalterar = new System.Windows.Forms.Button();
            this.btnFREQUENTADORESincluir = new System.Windows.Forms.Button();
            this.bdsFREQUENTADORES = new System.Windows.Forms.BindingSource(this.components);
            this.panFREQUENTADORES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFREQUENTADORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFREQUENTADORES)).BeginInit();
            this.SuspendLayout();
            // 
            // panFREQUENTADORES
            // 
            this.panFREQUENTADORES.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panFREQUENTADORES.Controls.Add(this.dgvFREQUENTADORES);
            this.panFREQUENTADORES.Controls.Add(this.btnFREQUENTADORESexcluir);
            this.panFREQUENTADORES.Controls.Add(this.btnFREQUENTADORESconsultar);
            this.panFREQUENTADORES.Controls.Add(this.btnFREQUENTADORESalterar);
            this.panFREQUENTADORES.Controls.Add(this.btnFREQUENTADORESincluir);
            this.panFREQUENTADORES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFREQUENTADORES.Location = new System.Drawing.Point(0, 0);
            this.panFREQUENTADORES.Name = "panFREQUENTADORES";
            this.panFREQUENTADORES.Size = new System.Drawing.Size(644, 428);
            this.panFREQUENTADORES.TabIndex = 1;
            this.panFREQUENTADORES.Tag = "";
            // 
            // dgvFREQUENTADORES
            // 
            this.dgvFREQUENTADORES.AllowUserToAddRows = false;
            this.dgvFREQUENTADORES.AllowUserToDeleteRows = false;
            this.dgvFREQUENTADORES.AllowUserToResizeColumns = false;
            this.dgvFREQUENTADORES.AllowUserToResizeRows = false;
            this.dgvFREQUENTADORES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFREQUENTADORES.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvFREQUENTADORES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFREQUENTADORES.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvFREQUENTADORES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFREQUENTADORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFREQUENTADORES.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFREQUENTADORES.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFREQUENTADORES.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvFREQUENTADORES.Location = new System.Drawing.Point(12, 44);
            this.dgvFREQUENTADORES.Name = "dgvFREQUENTADORES";
            this.dgvFREQUENTADORES.ReadOnly = true;
            this.dgvFREQUENTADORES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFREQUENTADORES.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFREQUENTADORES.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFREQUENTADORES.Size = new System.Drawing.Size(349, 348);
            this.dgvFREQUENTADORES.TabIndex = 6;
            // 
            // btnFREQUENTADORESexcluir
            // 
            this.btnFREQUENTADORESexcluir.Location = new System.Drawing.Point(394, 251);
            this.btnFREQUENTADORESexcluir.Name = "btnFREQUENTADORESexcluir";
            this.btnFREQUENTADORESexcluir.Size = new System.Drawing.Size(73, 63);
            this.btnFREQUENTADORESexcluir.TabIndex = 4;
            this.btnFREQUENTADORESexcluir.Text = "Excluir";
            this.btnFREQUENTADORESexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFREQUENTADORESexcluir.UseVisualStyleBackColor = true;
            // 
            // btnFREQUENTADORESconsultar
            // 
            this.btnFREQUENTADORESconsultar.Location = new System.Drawing.Point(394, 182);
            this.btnFREQUENTADORESconsultar.Name = "btnFREQUENTADORESconsultar";
            this.btnFREQUENTADORESconsultar.Size = new System.Drawing.Size(73, 63);
            this.btnFREQUENTADORESconsultar.TabIndex = 3;
            this.btnFREQUENTADORESconsultar.Text = "Consultar";
            this.btnFREQUENTADORESconsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFREQUENTADORESconsultar.UseVisualStyleBackColor = true;
            this.btnFREQUENTADORESconsultar.Click += new System.EventHandler(this.btnFREQUENTADORESconsultar_Click);
            // 
            // btnFREQUENTADORESalterar
            // 
            this.btnFREQUENTADORESalterar.Location = new System.Drawing.Point(394, 113);
            this.btnFREQUENTADORESalterar.Name = "btnFREQUENTADORESalterar";
            this.btnFREQUENTADORESalterar.Size = new System.Drawing.Size(73, 63);
            this.btnFREQUENTADORESalterar.TabIndex = 2;
            this.btnFREQUENTADORESalterar.Text = "Alterar";
            this.btnFREQUENTADORESalterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFREQUENTADORESalterar.UseVisualStyleBackColor = true;
            this.btnFREQUENTADORESalterar.Click += new System.EventHandler(this.btnFREQUENTADORESalterar_Click);
            // 
            // btnFREQUENTADORESincluir
            // 
            this.btnFREQUENTADORESincluir.Location = new System.Drawing.Point(394, 44);
            this.btnFREQUENTADORESincluir.Name = "btnFREQUENTADORESincluir";
            this.btnFREQUENTADORESincluir.Size = new System.Drawing.Size(73, 63);
            this.btnFREQUENTADORESincluir.TabIndex = 1;
            this.btnFREQUENTADORESincluir.Text = "Incluir";
            this.btnFREQUENTADORESincluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFREQUENTADORESincluir.UseVisualStyleBackColor = true;
            this.btnFREQUENTADORESincluir.Click += new System.EventHandler(this.btnFREQUENTADORESincluir_Click);
            // 
            // frmFrequentadoresIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 428);
            this.Controls.Add(this.panFREQUENTADORES);
            this.Name = "frmFrequentadoresIHM";
            this.Text = "FrequentadoresIHM";
            this.Load += new System.EventHandler(this.FrequentadoresIHM_Load);
            this.panFREQUENTADORES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFREQUENTADORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFREQUENTADORES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFREQUENTADORES;
        private System.Windows.Forms.Button btnFREQUENTADORESconsultar;
        private System.Windows.Forms.Button btnFREQUENTADORESalterar;
        private System.Windows.Forms.Button btnFREQUENTADORESincluir;
        private System.Windows.Forms.Button btnFREQUENTADORESexcluir;
        private System.Windows.Forms.BindingSource bdsFREQUENTADORES;
        private System.Windows.Forms.DataGridView dgvFREQUENTADORES;
    }
}