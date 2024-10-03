namespace Project
{
    partial class frmThemNguoiDungVaoNhom
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
            this.module_DN = new Project.Module_DN();
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungTableAdapter = new Project.Module_DNTableAdapters.QL_NguoiDungTableAdapter();
            this.tableAdapterManager = new Project.Module_DNTableAdapters.TableAdapterManager();
            this.qL_NhomNguoiDungTableAdapter = new Project.Module_DNTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDung_DKTableAdapter = new Project.Module_DNTableAdapters.QL_NguoiDungNhomNguoiDung_DKTableAdapter();
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.qL_NguoiDungNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDungTableAdapter = new Project.Module_DNTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.module_DN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // module_DN
            // 
            this.module_DN.DataSetName = "Module_DN";
            this.module_DN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            this.qL_NguoiDungBindingSource.DataSource = this.module_DN;
            // 
            // qL_NguoiDungTableAdapter
            // 
            this.qL_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDung_DKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = this.qL_NguoiDungTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.Module_DNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(12, 136);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(350, 417);
            this.qL_NguoiDungDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HoatDong";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.module_DN;
            // 
            // qL_NhomNguoiDungComboBox
            // 
            this.qL_NhomNguoiDungComboBox.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungComboBox.DisplayMember = "TenNhom";
            this.qL_NhomNguoiDungComboBox.FormattingEnabled = true;
            this.qL_NhomNguoiDungComboBox.Location = new System.Drawing.Point(511, 61);
            this.qL_NhomNguoiDungComboBox.Name = "qL_NhomNguoiDungComboBox";
            this.qL_NhomNguoiDungComboBox.Size = new System.Drawing.Size(201, 24);
            this.qL_NhomNguoiDungComboBox.TabIndex = 2;
            this.qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
            // 
            // qL_NguoiDungNhomNguoiDung_DKBindingSource
            // 
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource.DataMember = "QL_NguoiDungNhomNguoiDung_DK";
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource.DataSource = this.module_DN;
            // 
            // qL_NguoiDungNhomNguoiDung_DKTableAdapter
            // 
            this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NguoiDungNhomNguoiDung_DKDataGridView
            // 
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.DataSource = this.qL_NguoiDungNhomNguoiDung_DKBindingSource;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Location = new System.Drawing.Point(511, 136);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Name = "qL_NguoiDungNhomNguoiDung_DKDataGridView";
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.RowTemplate.Height = 24;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Size = new System.Drawing.Size(347, 417);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn5.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(381, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 32);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "> >";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // qL_NguoiDungNhomNguoiDungBindingSource
            // 
            this.qL_NguoiDungNhomNguoiDungBindingSource.DataMember = "QL_NguoiDungNhomNguoiDung";
            this.qL_NguoiDungNhomNguoiDungBindingSource.DataSource = this.module_DN;
            // 
            // qL_NguoiDungNhomNguoiDungTableAdapter
            // 
            this.qL_NguoiDungNhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 605);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.qL_NguoiDungNhomNguoiDung_DKDataGridView);
            this.Controls.Add(this.qL_NhomNguoiDungComboBox);
            this.Controls.Add(this.qL_NguoiDungDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThemNguoiDungVaoNhom";
            this.Text = "frmThemNguoiDungVaoNhom";
            this.Load += new System.EventHandler(this.frmThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.module_DN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Module_DN module_DN;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private Module_DNTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter;
        private Module_DNTableAdapters.TableAdapterManager tableAdapterManager;
        private Module_DNTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private System.Windows.Forms.ComboBox qL_NhomNguoiDungComboBox;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDung_DKBindingSource;
        private Module_DNTableAdapters.QL_NguoiDungNhomNguoiDung_DKTableAdapter qL_NguoiDungNhomNguoiDung_DKTableAdapter;
        private System.Windows.Forms.DataGridView qL_NguoiDungNhomNguoiDung_DKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDungBindingSource;
        private Module_DNTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter qL_NguoiDungNhomNguoiDungTableAdapter;
    }
}