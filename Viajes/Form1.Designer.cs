
namespace Viajes
{
    partial class Form1
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dB_ZEMOGDataSet = new Viajes.DB_ZEMOGDataSet();
            this.hoja1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoja1_TableAdapter = new Viajes.DB_ZEMOGDataSetTableAdapters.Hoja1_TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPendienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeÚltimaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ZEMOGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.AutoGenerateColumns = false;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.contactoComercialDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.teléfonoDataGridViewTextBoxColumn,
            this.saldoPendienteDataGridViewTextBoxColumn,
            this.fechaDeÚltimaCompraDataGridViewTextBoxColumn,
            this.f8DataGridViewTextBoxColumn});
            this.DG.DataSource = this.hoja1BindingSource;
            this.DG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DG.Location = new System.Drawing.Point(0, 84);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(800, 366);
            this.DG.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2024, 2, 27, 8, 17, 2, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dB_ZEMOGDataSet
            // 
            this.dB_ZEMOGDataSet.DataSetName = "DB_ZEMOGDataSet";
            this.dB_ZEMOGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoja1BindingSource
            // 
            this.hoja1BindingSource.DataMember = "Hoja1$";
            this.hoja1BindingSource.DataSource = this.dB_ZEMOGDataSet;
            // 
            // hoja1_TableAdapter
            // 
            this.hoja1_TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            // 
            // contactoComercialDataGridViewTextBoxColumn
            // 
            this.contactoComercialDataGridViewTextBoxColumn.DataPropertyName = "Contacto comercial";
            this.contactoComercialDataGridViewTextBoxColumn.HeaderText = "Contacto comercial";
            this.contactoComercialDataGridViewTextBoxColumn.Name = "contactoComercialDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // teléfonoDataGridViewTextBoxColumn
            // 
            this.teléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.Name = "teléfonoDataGridViewTextBoxColumn";
            // 
            // saldoPendienteDataGridViewTextBoxColumn
            // 
            this.saldoPendienteDataGridViewTextBoxColumn.DataPropertyName = "Saldo pendiente";
            this.saldoPendienteDataGridViewTextBoxColumn.HeaderText = "Saldo pendiente";
            this.saldoPendienteDataGridViewTextBoxColumn.Name = "saldoPendienteDataGridViewTextBoxColumn";
            // 
            // fechaDeÚltimaCompraDataGridViewTextBoxColumn
            // 
            this.fechaDeÚltimaCompraDataGridViewTextBoxColumn.DataPropertyName = "Fecha de última compra";
            this.fechaDeÚltimaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha de última compra";
            this.fechaDeÚltimaCompraDataGridViewTextBoxColumn.Name = "fechaDeÚltimaCompraDataGridViewTextBoxColumn";
            // 
            // f8DataGridViewTextBoxColumn
            // 
            this.f8DataGridViewTextBoxColumn.DataPropertyName = "F8";
            this.f8DataGridViewTextBoxColumn.HeaderText = "F8";
            this.f8DataGridViewTextBoxColumn.Name = "f8DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ZEMOGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoja1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DB_ZEMOGDataSet dB_ZEMOGDataSet;
        private System.Windows.Forms.BindingSource hoja1BindingSource;
        private DB_ZEMOGDataSetTableAdapters.Hoja1_TableAdapter hoja1_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeÚltimaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f8DataGridViewTextBoxColumn;
    }
}

