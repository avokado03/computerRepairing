namespace computerRepairing
{
    partial class MasterMenuForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowMyPositon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.label4.Location = new System.Drawing.Point(183, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 72);
            this.label4.TabIndex = 17;
            this.label4.Text = "Просмотреть\r\nпринятые\r\nзаказы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.label2.Location = new System.Drawing.Point(52, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 48);
            this.label2.TabIndex = 16;
            this.label2.Text = "Принять\r\nзаказ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowMyPositon
            // 
            this.btnShowMyPositon.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnShowMyPositon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowMyPositon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMyPositon.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.btnShowMyPositon.Image = global::computerRepairing.Properties.Resources.shopping_cart_insert128;
            this.btnShowMyPositon.Location = new System.Drawing.Point(184, 15);
            this.btnShowMyPositon.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowMyPositon.Name = "btnShowMyPositon";
            this.btnShowMyPositon.Size = new System.Drawing.Size(136, 133);
            this.btnShowMyPositon.TabIndex = 15;
            this.btnShowMyPositon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowMyPositon.UseVisualStyleBackColor = true;
            this.btnShowMyPositon.Click += new System.EventHandler(this.btnShowMyPositon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.label3.Location = new System.Drawing.Point(380, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выход";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::computerRepairing.Properties.Resources.Remove_Male_User128;
            this.btnExit.Location = new System.Drawing.Point(343, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 133);
            this.btnExit.TabIndex = 13;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::computerRepairing.Properties.Settings.Default, "contentFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnGetPosition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPosition.Font = global::computerRepairing.Properties.Settings.Default.contentFont;
            this.btnGetPosition.Image = global::computerRepairing.Properties.Resources.item_configuration1128;
            this.btnGetPosition.Location = new System.Drawing.Point(17, 15);
            this.btnGetPosition.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(136, 133);
            this.btnGetPosition.TabIndex = 12;
            this.btnGetPosition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // MasterMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 231);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowMyPositon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterMenuForm";
            this.Text = "Меню мастера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowMyPositon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetPosition;
    }
}