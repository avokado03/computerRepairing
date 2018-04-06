namespace computerRepairing
{
    partial class EditPositionForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.comboBoxChoosePose = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBoxPricePos = new System.Windows.Forms.TextBox();
            this.textBoxDescPos = new System.Windows.Forms.TextBox();
            this.textBoxNamePos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iluhaDataSet = new computerRepairing.IluhaDataSet();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter = new computerRepairing.IluhaDataSetTableAdapters.УслугиTableAdapter();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iluhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(584, 77);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "headFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::computerRepairing.Properties.Settings.Default.headFont;
            this.label1.Location = new System.Drawing.Point(199, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редактировать услугу";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Controls.Add(this.comboBoxChoosePose);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.btnEdit);
            this.panelContent.Controls.Add(this.textBoxPricePos);
            this.panelContent.Controls.Add(this.textBoxDescPos);
            this.panelContent.Controls.Add(this.textBoxNamePos);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.panelContent.Location = new System.Drawing.Point(0, 77);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(584, 363);
            this.panelContent.TabIndex = 1;
            // 
            // comboBoxChoosePose
            // 
            this.comboBoxChoosePose.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxChoosePose.DataSource = this.услугиBindingSource;
            this.comboBoxChoosePose.DisplayMember = "Наименование";
            this.comboBoxChoosePose.FormattingEnabled = true;
            this.comboBoxChoosePose.Location = new System.Drawing.Point(202, 24);
            this.comboBoxChoosePose.Name = "comboBoxChoosePose";
            this.comboBoxChoosePose.Size = new System.Drawing.Size(368, 32);
            this.comboBoxChoosePose.TabIndex = 8;
            this.comboBoxChoosePose.ValueMember = "id_Услуги";
            this.comboBoxChoosePose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoosePose_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Выберите услугу";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::computerRepairing.Properties.Resources.edit48;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(14, 285);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(556, 57);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxPricePos
            // 
            this.textBoxPricePos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPricePos.Location = new System.Drawing.Point(202, 223);
            this.textBoxPricePos.Name = "textBoxPricePos";
            this.textBoxPricePos.Size = new System.Drawing.Size(368, 32);
            this.textBoxPricePos.TabIndex = 5;
            // 
            // textBoxDescPos
            // 
            this.textBoxDescPos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxDescPos.Location = new System.Drawing.Point(202, 152);
            this.textBoxDescPos.MaxLength = 100;
            this.textBoxDescPos.Multiline = true;
            this.textBoxDescPos.Name = "textBoxDescPos";
            this.textBoxDescPos.Size = new System.Drawing.Size(368, 59);
            this.textBoxDescPos.TabIndex = 4;
            // 
            // textBoxNamePos
            // 
            this.textBoxNamePos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxNamePos.Location = new System.Drawing.Point(202, 76);
            this.textBoxNamePos.MaxLength = 100;
            this.textBoxNamePos.Multiline = true;
            this.textBoxNamePos.Name = "textBoxNamePos";
            this.textBoxNamePos.Size = new System.Drawing.Size(368, 59);
            this.textBoxNamePos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Описание услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название услуги";
            // 
            // iluhaDataSet
            // 
            this.iluhaDataSet.DataSetName = "IluhaDataSet";
            this.iluhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.iluhaDataSet;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // EditPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 440);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditPositionForm";
            this.Text = "Добавить услугу";
            this.Load += new System.EventHandler(this.EditPositionForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iluhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxNamePos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBoxPricePos;
        private System.Windows.Forms.TextBox textBoxDescPos;
        private System.Windows.Forms.ComboBox comboBoxChoosePose;
        private System.Windows.Forms.Label label5;
        private IluhaDataSet iluhaDataSet;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private IluhaDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
    }
}