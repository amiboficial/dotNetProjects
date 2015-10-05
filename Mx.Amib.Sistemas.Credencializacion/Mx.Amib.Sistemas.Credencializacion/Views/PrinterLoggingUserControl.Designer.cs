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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblMaxResults = new System.Windows.Forms.Label();
            this.nudMaxResults = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCritBusq = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdSustentante = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroMatricula = new System.Windows.Forms.Label();
            this.lblCritBusq = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gboxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.gboxParams.Controls.Add(this.dateTimePicker2);
            this.gboxParams.Controls.Add(this.dateTimePicker1);
            this.gboxParams.Controls.Add(this.lblMaxResults);
            this.gboxParams.Controls.Add(this.nudMaxResults);
            this.gboxParams.Controls.Add(this.btnLimpiar);
            this.gboxParams.Controls.Add(this.btnBuscar);
            this.gboxParams.Controls.Add(this.cbxCritBusq);
            this.gboxParams.Controls.Add(this.lblNombre);
            this.gboxParams.Controls.Add(this.lblIdSustentante);
            this.gboxParams.Controls.Add(this.txtNombre);
            this.gboxParams.Controls.Add(this.lblNumeroMatricula);
            this.gboxParams.Controls.Add(this.lblCritBusq);
            this.gboxParams.Location = new System.Drawing.Point(9, 37);
            this.gboxParams.Name = "gboxParams";
            this.gboxParams.Size = new System.Drawing.Size(660, 144);
            this.gboxParams.TabIndex = 3;
            this.gboxParams.TabStop = false;
            this.gboxParams.Text = "Parámetros de búsqueda";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(150, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(472, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(472, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // lblMaxResults
            // 
            this.lblMaxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxResults.AutoSize = true;
            this.lblMaxResults.Location = new System.Drawing.Point(255, 115);
            this.lblMaxResults.Name = "lblMaxResults";
            this.lblMaxResults.Size = new System.Drawing.Size(113, 13);
            this.lblMaxResults.TabIndex = 19;
            this.lblMaxResults.Text = "Resultados por página";
            // 
            // nudMaxResults
            // 
            this.nudMaxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxResults.Location = new System.Drawing.Point(371, 112);
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
            this.btnLimpiar.Location = new System.Drawing.Point(433, 110);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(547, 110);
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
            this.lblIdSustentante.Location = new System.Drawing.Point(128, 65);
            this.lblIdSustentante.Name = "lblIdSustentante";
            this.lblIdSustentante.Size = new System.Drawing.Size(16, 13);
            this.lblIdSustentante.TabIndex = 8;
            this.lblIdSustentante.Text = "Al";
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
            // lblNumeroMatricula
            // 
            this.lblNumeroMatricula.AutoSize = true;
            this.lblNumeroMatricula.Location = new System.Drawing.Point(121, 43);
            this.lblNumeroMatricula.Name = "lblNumeroMatricula";
            this.lblNumeroMatricula.Size = new System.Drawing.Size(23, 13);
            this.lblNumeroMatricula.TabIndex = 1;
            this.lblNumeroMatricula.Text = "Del";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 307);
            this.dataGridView1.TabIndex = 4;
            // 
            // PrinterLoggingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gboxParams);
            this.Controls.Add(this.lblTitle);
            this.Name = "PrinterLoggingUserControl";
            this.Size = new System.Drawing.Size(679, 507);
            this.gboxParams.ResumeLayout(false);
            this.gboxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gboxParams;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblMaxResults;
        private System.Windows.Forms.NumericUpDown nudMaxResults;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxCritBusq;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdSustentante;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumeroMatricula;
        private System.Windows.Forms.Label lblCritBusq;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
