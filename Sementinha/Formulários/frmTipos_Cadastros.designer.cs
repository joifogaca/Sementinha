namespace Sementinha
{
    partial class frmTipos_CadastrosIHM
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
            this.panTIPOS_CADASTROS = new System.Windows.Forms.Panel();
            this.dgvTIPOS_CADASTROS = new System.Windows.Forms.DataGridView();
            this.btnTIPOS_CADASTROSexcluir = new System.Windows.Forms.Button();
            this.btnTIPOS_CADASTROSconsultar = new System.Windows.Forms.Button();
            this.btnTIPOS_CADASTROSalterar = new System.Windows.Forms.Button();
            this.btnTIPOS_CADASTROSincluir = new System.Windows.Forms.Button();
            this.bdsTIPOS_CADASTROS = new System.Windows.Forms.BindingSource(this.components);
            this.panTIPOS_CADASTROS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTIPOS_CADASTROS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTIPOS_CADASTROS)).BeginInit();
            this.SuspendLayout();
            // 
            // panTIPOS_CADASTROS
            // 
            this.panTIPOS_CADASTROS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panTIPOS_CADASTROS.Controls.Add(this.dgvTIPOS_CADASTROS);
            this.panTIPOS_CADASTROS.Controls.Add(this.btnTIPOS_CADASTROSexcluir);
            this.panTIPOS_CADASTROS.Controls.Add(this.btnTIPOS_CADASTROSconsultar);
            this.panTIPOS_CADASTROS.Controls.Add(this.btnTIPOS_CADASTROSalterar);
            this.panTIPOS_CADASTROS.Controls.Add(this.btnTIPOS_CADASTROSincluir);
            this.panTIPOS_CADASTROS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTIPOS_CADASTROS.Location = new System.Drawing.Point(0, 0);
            this.panTIPOS_CADASTROS.Name = "panTIPOS_CADASTROS";
            this.panTIPOS_CADASTROS.Size = new System.Drawing.Size(644, 428);
            this.panTIPOS_CADASTROS.TabIndex = 1;
            this.panTIPOS_CADASTROS.Tag = "";
            // 
            // dgvTIPOS_CADASTROS
            // 
            this.dgvTIPOS_CADASTROS.AllowUserToAddRows = false;
            this.dgvTIPOS_CADASTROS.AllowUserToDeleteRows = false;
            this.dgvTIPOS_CADASTROS.AllowUserToResizeColumns = false;
            this.dgvTIPOS_CADASTROS.AllowUserToResizeRows = false;
            this.dgvTIPOS_CADASTROS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTIPOS_CADASTROS.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvTIPOS_CADASTROS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTIPOS_CADASTROS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTIPOS_CADASTROS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTIPOS_CADASTROS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTIPOS_CADASTROS.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTIPOS_CADASTROS.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTIPOS_CADASTROS.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvTIPOS_CADASTROS.Location = new System.Drawing.Point(12, 44);
            this.dgvTIPOS_CADASTROS.Name = "dgvTIPOS_CADASTROS";
            this.dgvTIPOS_CADASTROS.ReadOnly = true;
            this.dgvTIPOS_CADASTROS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTIPOS_CADASTROS.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTIPOS_CADASTROS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTIPOS_CADASTROS.Size = new System.Drawing.Size(349, 348);
            this.dgvTIPOS_CADASTROS.TabIndex = 6;
            // 
            // btnTIPOS_CADASTROSexcluir
            // 
            this.btnTIPOS_CADASTROSexcluir.Location = new System.Drawing.Point(394, 251);
            this.btnTIPOS_CADASTROSexcluir.Name = "btnTIPOS_CADASTROSexcluir";
            this.btnTIPOS_CADASTROSexcluir.Size = new System.Drawing.Size(73, 63);
            this.btnTIPOS_CADASTROSexcluir.TabIndex = 4;
            this.btnTIPOS_CADASTROSexcluir.Text = "Excluir";
            this.btnTIPOS_CADASTROSexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTIPOS_CADASTROSexcluir.UseVisualStyleBackColor = true;
            this.btnTIPOS_CADASTROSexcluir.Click += new System.EventHandler(this.btn_genérico_Click);
            // 
            // btnTIPOS_CADASTROSconsultar
            // 
            this.btnTIPOS_CADASTROSconsultar.Location = new System.Drawing.Point(394, 182);
            this.btnTIPOS_CADASTROSconsultar.Name = "btnTIPOS_CADASTROSconsultar";
            this.btnTIPOS_CADASTROSconsultar.Size = new System.Drawing.Size(73, 63);
            this.btnTIPOS_CADASTROSconsultar.TabIndex = 3;
            this.btnTIPOS_CADASTROSconsultar.Text = "Consultar";
            this.btnTIPOS_CADASTROSconsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTIPOS_CADASTROSconsultar.UseVisualStyleBackColor = true;
            this.btnTIPOS_CADASTROSconsultar.Click += new System.EventHandler(this.btn_genérico_Click);
            // 
            // btnTIPOS_CADASTROSalterar
            // 
            this.btnTIPOS_CADASTROSalterar.Location = new System.Drawing.Point(394, 113);
            this.btnTIPOS_CADASTROSalterar.Name = "btnTIPOS_CADASTROSalterar";
            this.btnTIPOS_CADASTROSalterar.Size = new System.Drawing.Size(73, 63);
            this.btnTIPOS_CADASTROSalterar.TabIndex = 2;
            this.btnTIPOS_CADASTROSalterar.Text = "Alterar";
            this.btnTIPOS_CADASTROSalterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTIPOS_CADASTROSalterar.UseVisualStyleBackColor = true;
            this.btnTIPOS_CADASTROSalterar.Click += new System.EventHandler(this.btn_genérico_Click);
            // 
            // btnTIPOS_CADASTROSincluir
            // 
            this.btnTIPOS_CADASTROSincluir.Location = new System.Drawing.Point(394, 44);
            this.btnTIPOS_CADASTROSincluir.Name = "btnTIPOS_CADASTROSincluir";
            this.btnTIPOS_CADASTROSincluir.Size = new System.Drawing.Size(73, 63);
            this.btnTIPOS_CADASTROSincluir.TabIndex = 1;
            this.btnTIPOS_CADASTROSincluir.Text = "Incluir";
            this.btnTIPOS_CADASTROSincluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTIPOS_CADASTROSincluir.UseVisualStyleBackColor = true;
            this.btnTIPOS_CADASTROSincluir.Click += new System.EventHandler(this.btn_genérico_Click);
            // 
            // frmTipos_CadastrosIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 428);
            this.Controls.Add(this.panTIPOS_CADASTROS);
            this.Name = "frmTipos_CadastrosIHM";
            this.Text = "Tipos de Cadastros ";
            this.Load += new System.EventHandler(this.Tipos_CadastrosIHM_Load);
            this.panTIPOS_CADASTROS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTIPOS_CADASTROS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTIPOS_CADASTROS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTIPOS_CADASTROS;
        private System.Windows.Forms.Button btnTIPOS_CADASTROSconsultar;
        private System.Windows.Forms.Button btnTIPOS_CADASTROSalterar;
        private System.Windows.Forms.Button btnTIPOS_CADASTROSincluir;
        private System.Windows.Forms.Button btnTIPOS_CADASTROSexcluir;
        private System.Windows.Forms.BindingSource bdsTIPOS_CADASTROS;
        private System.Windows.Forms.DataGridView dgvTIPOS_CADASTROS;
    }
}