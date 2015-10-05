namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    partial class PrinterLoggingUserControl
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
            this.dtpFechaAl = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDel = new System.Windows.Forms.DateTimePicker();
            this.lblMaxResults = new System.Windows.Forms.Label();
            this.nudMaxResults = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCritBusq = new System.Windows.Forms.ComboBox();
            this.lblFechaAl = new System.Windows.Forms.Label();
            this.lblFechaDel = new System.Windows.Forms.Label();
            this.lblCritBusq = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.gboxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Bitácora de impresión";
            // 
            // gboxParams
            // 
            this.gboxParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxParams.Controls.Add(this.dtpFechaAl);
            this.gboxParams.Controls.Add(this.dtpFechaDel);
            this.gboxParams.Controls.Add(this.lblMaxResults);
            this.gboxParams.Controls.Add(this.nudMaxResults);
            this.gboxParams.Controls.Add(this.btnLimpiar);
            this.gboxParams.Controls.Add(this.btnBuscar);
            this.gboxParams.Controls.Add(this.cbxCritBusq);
            this.gboxParams.Controls.Add(this.lblFechaAl);
            this.gboxParams.Controls.Add(this.lblFechaDel);
            this.gboxParams.Controls.Add(this.lblCritBusq);
            this.gboxParams.Location = new System.Drawing.Point(9, 37);
            this.gboxParams.Name = "gboxParams";
            this.gboxParams.Size = new System.Drawing.Size(660, 122);
            this.gboxParams.TabIndex = 3;
            this.gboxParams.TabStop = false;
            this.gboxParams.Text = "Parámetros de búsqueda";
            // 
            // dtpFechaAl
            // 
            this.dtpFechaAl.Location = new System.Drawing.Point(150, 62);
            this.dtpFechaAl.Name = "dtpFechaAl";
            this.dtpFechaAl.Size = new System.Drawing.Size(277, 20);
            this.dtpFechaAl.TabIndex = 21;
            // 
            // dtpFechaDel
            // 
            this.dtpFechaDel.Location = new System.Drawing.Point(150, 40);
            this.dtpFechaDel.Name = "dtpFechaDel";
            this.dtpFechaDel.Size = new System.Drawing.Size(277, 20);
            this.dtpFechaDel.TabIndex = 20;
            // 
            // lblMaxResults
            // 
            this.lblMaxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxResults.AutoSize = true;
            this.lblMaxResults.Location = new System.Drawing.Point(255, 93);
            this.lblMaxResults.Name = "lblMaxResults";
            this.lblMaxResults.Size = new System.Drawing.Size(113, 13);
            this.lblMaxResults.TabIndex = 19;
            this.lblMaxResults.Text = "Resultados por página";
            // 
            // nudMaxResults
            // 
            this.nudMaxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxResults.Location = new System.Drawing.Point(371, 90);
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
            this.btnLimpiar.Location = new System.Drawing.Point(433, 88);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(547, 88);
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
            // lblFechaAl
            // 
            this.lblFechaAl.AutoSize = true;
            this.lblFechaAl.Location = new System.Drawing.Point(128, 65);
            this.lblFechaAl.Name = "lblFechaAl";
            this.lblFechaAl.Size = new System.Drawing.Size(16, 13);
            this.lblFechaAl.TabIndex = 8;
            this.lblFechaAl.Text = "Al";
            // 
            // lblFechaDel
            // 
            this.lblFechaDel.AutoSize = true;
            this.lblFechaDel.Location = new System.Drawing.Point(121, 43);
            this.lblFechaDel.Name = "lblFechaDel";
            this.lblFechaDel.Size = new System.Drawing.Size(23, 13);
            this.lblFechaDel.TabIndex = 1;
            this.lblFechaDel.Text = "Del";
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
            this.dgvResults.Location = new System.Drawing.Point(9, 165);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(660, 307);
            this.dgvResults.TabIndex = 4;
            // 
            // PrinterLoggingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.gboxParams);
            this.Controls.Add(this.lblTitle);
            this.Name = "PrinterLoggingUserControl";
            this.Size = new System.Drawing.Size(679, 507);
            this.gboxParams.ResumeLayout(false);
            this.gboxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gboxParams;
        private System.Windows.Forms.DateTimePicker dtpFechaAl;
        private System.Windows.Forms.DateTimePicker dtpFechaDel;
        private System.Windows.Forms.Label lblMaxResults;
        private System.Windows.Forms.NumericUpDown nudMaxResults;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxCritBusq;
        private System.Windows.Forms.Label lblFechaAl;
        private System.Windows.Forms.Label lblFechaDel;
        private System.Windows.Forms.Label lblCritBusq;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}
