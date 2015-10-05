namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    partial class SustentantesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboxParams = new System.Windows.Forms.GroupBox();
            this.lblMaxResults = new System.Windows.Forms.Label();
            this.nudMaxResults = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCritBusq = new System.Windows.Forms.ComboBox();
            this.lblVarFig = new System.Windows.Forms.Label();
            this.cbxVarFig = new System.Windows.Forms.ComboBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.cbxFigura = new System.Windows.Forms.ComboBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdSustentante = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdSustentante = new System.Windows.Forms.TextBox();
            this.txtNumeroMatricula = new System.Windows.Forms.TextBox();
            this.lblNumeroMatricula = new System.Windows.Forms.Label();
            this.lblCritBusq = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.nudGoToPage = new System.Windows.Forms.NumericUpDown();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGoToPage = new System.Windows.Forms.Button();
            this.pnlState = new System.Windows.Forms.Panel();
            this.pbarProc = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.gboxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoToPage)).BeginInit();
            this.pnlState.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(508, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Búsqueda de sustentantes autorizados para credencialización";
            // 
            // gboxParams
            // 
            this.gboxParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxParams.Controls.Add(this.lblMaxResults);
            this.gboxParams.Controls.Add(this.nudMaxResults);
            this.gboxParams.Controls.Add(this.btnLimpiar);
            this.gboxParams.Controls.Add(this.btnBuscar);
            this.gboxParams.Controls.Add(this.cbxCritBusq);
            this.gboxParams.Controls.Add(this.lblVarFig);
            this.gboxParams.Controls.Add(this.cbxVarFig);
            this.gboxParams.Controls.Add(this.lblFigura);
            this.gboxParams.Controls.Add(this.cbxFigura);
            this.gboxParams.Controls.Add(this.lblSegundoApellido);
            this.gboxParams.Controls.Add(this.lblPrimerApellido);
            this.gboxParams.Controls.Add(this.lblNombre);
            this.gboxParams.Controls.Add(this.lblIdSustentante);
            this.gboxParams.Controls.Add(this.txtSegundoApellido);
            this.gboxParams.Controls.Add(this.txtPrimerApellido);
            this.gboxParams.Controls.Add(this.txtNombre);
            this.gboxParams.Controls.Add(this.txtIdSustentante);
            this.gboxParams.Controls.Add(this.txtNumeroMatricula);
            this.gboxParams.Controls.Add(this.lblNumeroMatricula);
            this.gboxParams.Controls.Add(this.lblCritBusq);
            this.gboxParams.Location = new System.Drawing.Point(9, 37);
            this.gboxParams.Name = "gboxParams";
            this.gboxParams.Size = new System.Drawing.Size(660, 235);
            this.gboxParams.TabIndex = 1;
            this.gboxParams.TabStop = false;
            this.gboxParams.Text = "Parámetros de búsqueda";
            // 
            // lblMaxResults
            // 
            this.lblMaxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxResults.AutoSize = true;
            this.lblMaxResults.Location = new System.Drawing.Point(256, 205);
            this.lblMaxResults.Name = "lblMaxResults";
            this.lblMaxResults.Size = new System.Drawing.Size(113, 13);
            this.lblMaxResults.TabIndex = 19;
            this.lblMaxResults.Text = "Resultados por página";
            // 
            // nudMaxResults
            // 
            this.nudMaxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxResults.Location = new System.Drawing.Point(372, 202);
            this.nudMaxResults.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxResults.Name = "nudMaxResults";
            this.nudMaxResults.Size = new System.Drawing.Size(56, 20);
            this.nudMaxResults.TabIndex = 7;
            this.nudMaxResults.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(434, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(548, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbxCritBusq
            // 
            this.cbxCritBusq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCritBusq.FormattingEnabled = true;
            this.cbxCritBusq.Location = new System.Drawing.Point(150, 17);
            this.cbxCritBusq.Name = "cbxCritBusq";
            this.cbxCritBusq.Size = new System.Drawing.Size(472, 21);
            this.cbxCritBusq.TabIndex = 16;
            // 
            // lblVarFig
            // 
            this.lblVarFig.AutoSize = true;
            this.lblVarFig.Location = new System.Drawing.Point(51, 176);
            this.lblVarFig.Name = "lblVarFig";
            this.lblVarFig.Size = new System.Drawing.Size(93, 13);
            this.lblVarFig.TabIndex = 15;
            this.lblVarFig.Text = "Variante de Figura";
            // 
            // cbxVarFig
            // 
            this.cbxVarFig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxVarFig.FormattingEnabled = true;
            this.cbxVarFig.Location = new System.Drawing.Point(150, 173);
            this.cbxVarFig.Name = "cbxVarFig";
            this.cbxVarFig.Size = new System.Drawing.Size(472, 21);
            this.cbxVarFig.TabIndex = 14;
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(108, 153);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(36, 13);
            this.lblFigura.TabIndex = 13;
            this.lblFigura.Text = "Figura";
            // 
            // cbxFigura
            // 
            this.cbxFigura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFigura.FormattingEnabled = true;
            this.cbxFigura.Location = new System.Drawing.Point(150, 150);
            this.cbxFigura.Name = "cbxFigura";
            this.cbxFigura.Size = new System.Drawing.Size(472, 21);
            this.cbxFigura.TabIndex = 12;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(55, 131);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(89, 13);
            this.lblSegundoApellido.TabIndex = 11;
            this.lblSegundoApellido.Text = "Segundo apellido";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(69, 109);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(75, 13);
            this.lblPrimerApellido.TabIndex = 10;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(100, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdSustentante
            // 
            this.lblIdSustentante.AutoSize = true;
            this.lblIdSustentante.Location = new System.Drawing.Point(115, 65);
            this.lblIdSustentante.Name = "lblIdSustentante";
            this.lblIdSustentante.Size = new System.Drawing.Size(29, 13);
            this.lblIdSustentante.TabIndex = 8;
            this.lblIdSustentante.Text = "Folio";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(150, 128);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(472, 20);
            this.txtSegundoApellido.TabIndex = 7;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(150, 106);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(472, 20);
            this.txtPrimerApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(150, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(472, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtIdSustentante
            // 
            this.txtIdSustentante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdSustentante.Location = new System.Drawing.Point(150, 62);
            this.txtIdSustentante.Name = "txtIdSustentante";
            this.txtIdSustentante.Size = new System.Drawing.Size(472, 20);
            this.txtIdSustentante.TabIndex = 4;
            this.txtIdSustentante.Text = "0123456789";
            // 
            // txtNumeroMatricula
            // 
            this.txtNumeroMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroMatricula.Location = new System.Drawing.Point(150, 40);
            this.txtNumeroMatricula.Name = "txtNumeroMatricula";
            this.txtNumeroMatricula.Size = new System.Drawing.Size(472, 20);
            this.txtNumeroMatricula.TabIndex = 3;
            this.txtNumeroMatricula.Text = "0123456789";
            // 
            // lblNumeroMatricula
            // 
            this.lblNumeroMatricula.AutoSize = true;
            this.lblNumeroMatricula.Location = new System.Drawing.Point(92, 43);
            this.lblNumeroMatricula.Name = "lblNumeroMatricula";
            this.lblNumeroMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblNumeroMatricula.TabIndex = 1;
            this.lblNumeroMatricula.Text = "Matrícula";
            // 
            // lblCritBusq
            // 
            this.lblCritBusq.AutoSize = true;
            this.lblCritBusq.Location = new System.Drawing.Point(40, 21);
            this.lblCritBusq.Name = "lblCritBusq";
            this.lblCritBusq.Size = new System.Drawing.Size(104, 13);
            this.lblCritBusq.TabIndex = 0;
            this.lblCritBusq.Text = "Criterio de búsqueda";
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(10, 278);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(660, 159);
            this.dgvResults.TabIndex = 2;
            // 
            // nudGoToPage
            // 
            this.nudGoToPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGoToPage.Location = new System.Drawing.Point(495, 445);
            this.nudGoToPage.Name = "nudGoToPage";
            this.nudGoToPage.Size = new System.Drawing.Size(56, 20);
            this.nudGoToPage.TabIndex = 3;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Location = new System.Drawing.Point(10, 443);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<< Atrás";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(91, 443);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Siguiente >>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnGoToPage
            // 
            this.btnGoToPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoToPage.Location = new System.Drawing.Point(557, 443);
            this.btnGoToPage.Name = "btnGoToPage";
            this.btnGoToPage.Size = new System.Drawing.Size(112, 23);
            this.btnGoToPage.TabIndex = 6;
            this.btnGoToPage.Text = "Ir a la página";
            this.btnGoToPage.UseVisualStyleBackColor = true;
            // 
            // pnlState
            // 
            this.pnlState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlState.Controls.Add(this.pbarProc);
            this.pnlState.Controls.Add(this.lblMessage);
            this.pnlState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlState.Location = new System.Drawing.Point(0, 479);
            this.pnlState.Name = "pnlState";
            this.pnlState.Size = new System.Drawing.Size(679, 28);
            this.pnlState.TabIndex = 10;
            // 
            // pbarProc
            // 
            this.pbarProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbarProc.Location = new System.Drawing.Point(0, 0);
            this.pbarProc.Name = "pbarProc";
            this.pbarProc.Size = new System.Drawing.Size(586, 24);
            this.pbarProc.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbarProc.TabIndex = 10;
            this.pbarProc.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMessage.Location = new System.Drawing.Point(586, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMessage.Size = new System.Drawing.Size(89, 18);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "[Barra de Estado]";
            // 
            // lblPaginas
            // 
            this.lblPaginas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(172, 448);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(143, 13);
            this.lblPaginas.TabIndex = 11;
            this.lblPaginas.Text = "Página [XXXXX] de [YYYYY]";
            // 
            // SustentantesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.pnlState);
            this.Controls.Add(this.btnGoToPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.nudGoToPage);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.gboxParams);
            this.Controls.Add(this.lblTitle);
            this.Name = "SustentantesUserControl";
            this.Size = new System.Drawing.Size(679, 507);
            this.gboxParams.ResumeLayout(false);
            this.gboxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoToPage)).EndInit();
            this.pnlState.ResumeLayout(false);
            this.pnlState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gboxParams;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdSustentante;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdSustentante;
        private System.Windows.Forms.TextBox txtNumeroMatricula;
        private System.Windows.Forms.Label lblNumeroMatricula;
        private System.Windows.Forms.Label lblCritBusq;
        private System.Windows.Forms.NumericUpDown nudGoToPage;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGoToPage;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxCritBusq;
        private System.Windows.Forms.Label lblVarFig;
        private System.Windows.Forms.ComboBox cbxVarFig;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.ComboBox cbxFigura;
        private System.Windows.Forms.Label lblMaxResults;
        private System.Windows.Forms.NumericUpDown nudMaxResults;
        private System.Windows.Forms.Panel pnlState;
        private System.Windows.Forms.ProgressBar pbarProc;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPaginas;
    }
}
