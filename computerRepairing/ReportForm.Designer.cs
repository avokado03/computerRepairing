namespace computerRepairing
{
    partial class ReportForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSetPosition = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetPosition)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(779, 77);
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
            this.label1.Location = new System.Drawing.Point(281, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет о прибыли";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.dateTimePicker2);
            this.panelContent.Controls.Add(this.dateTimePicker1);
            this.panelContent.Controls.Add(this.dgvSetPosition);
            this.panelContent.Controls.Add(this.btnAdd);
            this.panelContent.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.panelContent.Location = new System.Drawing.Point(0, 77);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(779, 426);
            this.panelContent.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::computerRepairing.Properties.Resources.budget48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(3, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(769, 57);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Cформировать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSetPosition
            // 
            this.dgvSetPosition.AllowUserToAddRows = false;
            this.dgvSetPosition.AllowUserToDeleteRows = false;
            this.dgvSetPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSetPosition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSetPosition.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvSetPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetPosition.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvSetPosition.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.dgvSetPosition.Location = new System.Drawing.Point(0, 49);
            this.dgvSetPosition.Name = "dgvSetPosition";
            this.dgvSetPosition.Size = new System.Drawing.Size(777, 257);
            this.dgvSetPosition.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 32);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(465, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(242, 32);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "С";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "по";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Выручка за период:";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 503);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.Text = "Добавить услугу";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvSetPosition;
    }
}