namespace computerRepairing
{
    partial class ClientMenuForm
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
            this.btnShowCatalog = new System.Windows.Forms.Button();
            this.btnSetPosition = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowMyPositon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowCatalog
            // 
            this.btnShowCatalog.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnShowCatalog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCatalog.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.btnShowCatalog.Image = global::computerRepairing.Properties.Resources.computer128;
            this.btnShowCatalog.Location = new System.Drawing.Point(15, 32);
            this.btnShowCatalog.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowCatalog.Name = "btnShowCatalog";
            this.btnShowCatalog.Size = new System.Drawing.Size(136, 133);
            this.btnShowCatalog.TabIndex = 1;
            this.btnShowCatalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowCatalog.UseVisualStyleBackColor = true;
            this.btnShowCatalog.Click += new System.EventHandler(this.btnShowCatalog_Click);
            // 
            // btnSetPosition
            // 
            this.btnSetPosition.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSetPosition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPosition.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.btnSetPosition.Image = global::computerRepairing.Properties.Resources.shopping_cart_add128;
            this.btnSetPosition.Location = new System.Drawing.Point(187, 32);
            this.btnSetPosition.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetPosition.Name = "btnSetPosition";
            this.btnSetPosition.Size = new System.Drawing.Size(136, 133);
            this.btnSetPosition.TabIndex = 2;
            this.btnSetPosition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetPosition.UseVisualStyleBackColor = true;
            this.btnSetPosition.Click += new System.EventHandler(this.btnSetPosition_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.label3.Location = new System.Drawing.Point(550, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выход";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::computerRepairing.Properties.Resources.Remove_Male_User128;
            this.btnExit.Location = new System.Drawing.Point(513, 32);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 133);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowMyPositon
            // 
            this.btnShowMyPositon.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnShowMyPositon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowMyPositon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMyPositon.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.btnShowMyPositon.Image = global::computerRepairing.Properties.Resources.shopping_cart_insert128;
            this.btnShowMyPositon.Location = new System.Drawing.Point(354, 32);
            this.btnShowMyPositon.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowMyPositon.Name = "btnShowMyPositon";
            this.btnShowMyPositon.Size = new System.Drawing.Size(136, 133);
            this.btnShowMyPositon.TabIndex = 8;
            this.btnShowMyPositon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowMyPositon.UseVisualStyleBackColor = true;
            this.btnShowMyPositon.Click += new System.EventHandler(this.btnShowMyPositon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Каталог услуг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.label2.Location = new System.Drawing.Point(222, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сделать\r\nзаказ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.label4.Location = new System.Drawing.Point(367, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "Просмотреть\r\nмои заказы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 235);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowMyPositon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSetPosition);
            this.Controls.Add(this.btnShowCatalog);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientMenuForm";
            this.Text = "Меню клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCatalog;
        private System.Windows.Forms.Button btnSetPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowMyPositon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}