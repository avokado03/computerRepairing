namespace computerRepairing
{
    partial class GetPositionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idЗаказDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idЗаказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idМастерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iluhaDataSet1 = new computerRepairing.IluhaDataSet1();
            this.btnAdd = new System.Windows.Forms.Button();
            this.заказTableAdapter = new computerRepairing.IluhaDataSet1TableAdapters.ЗаказTableAdapter();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluhaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.buttonBack);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(777, 77);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = global::computerRepairing.Properties.Resources.back48;
            this.buttonBack.Location = new System.Drawing.Point(47, 14);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 53);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "headFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::computerRepairing.Properties.Settings.Default.headFont;
            this.label1.Location = new System.Drawing.Point(312, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Принять заказ";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Controls.Add(this.dataGridView1);
            this.panelContent.Controls.Add(this.btnAdd);
            this.panelContent.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.panelContent.Location = new System.Drawing.Point(0, 77);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(777, 424);
            this.panelContent.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаказDataGridViewTextBoxColumn,
            this.idЗаказчикDataGridViewTextBoxColumn,
            this.idМастерDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.заказBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(767, 343);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idЗаказDataGridViewTextBoxColumn
            // 
            this.idЗаказDataGridViewTextBoxColumn.DataPropertyName = "id_Заказ";
            this.idЗаказDataGridViewTextBoxColumn.HeaderText = "Заказ";
            this.idЗаказDataGridViewTextBoxColumn.Name = "idЗаказDataGridViewTextBoxColumn";
            this.idЗаказDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idЗаказчикDataGridViewTextBoxColumn
            // 
            this.idЗаказчикDataGridViewTextBoxColumn.DataPropertyName = "id_Заказчик";
            this.idЗаказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.idЗаказчикDataGridViewTextBoxColumn.Name = "idЗаказчикDataGridViewTextBoxColumn";
            // 
            // idМастерDataGridViewTextBoxColumn
            // 
            this.idМастерDataGridViewTextBoxColumn.DataPropertyName = "id_Мастер";
            this.idМастерDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.idМастерDataGridViewTextBoxColumn.Name = "idМастерDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Выбрать";
            this.Column1.Name = "Column1";
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.iluhaDataSet1;
            // 
            // iluhaDataSet1
            // 
            this.iluhaDataSet1.DataSetName = "IluhaDataSet1";
            this.iluhaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::computerRepairing.Properties.Resources.item_configuration148;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(10, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(753, 57);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Принять";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // GetPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 501);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetPositionForm";
            this.Text = "Добавить услугу";
            this.Load += new System.EventHandler(this.GetPositionForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluhaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IluhaDataSet1 iluhaDataSet1;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private IluhaDataSet1TableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаказDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idМастерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}