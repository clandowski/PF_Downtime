namespace PF_Downtime.GUI
{
    partial class ManagersDisplay
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
            this.ManagerList = new System.Windows.Forms.ListView();
            this.focus_Label = new System.Windows.Forms.Label();
            this.Focus_Combo = new System.Windows.Forms.ComboBox();
            this.GPNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.MagicNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.LaborNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.InfNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.GoodsNum = new System.Windows.Forms.NumericUpDown();
            this.BonusLabel = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Notes_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Skills_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Manager_Combo = new System.Windows.Forms.ComboBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.New_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GPNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaborNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerList
            // 
            this.ManagerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerList.FullRowSelect = true;
            this.ManagerList.Location = new System.Drawing.Point(14, 12);
            this.ManagerList.MultiSelect = false;
            this.ManagerList.Name = "ManagerList";
            this.ManagerList.Size = new System.Drawing.Size(727, 205);
            this.ManagerList.TabIndex = 2;
            this.ManagerList.UseCompatibleStateImageBehavior = false;
            this.ManagerList.View = System.Windows.Forms.View.Details;
            this.ManagerList.SelectedIndexChanged += new System.EventHandler(this.ManagerList_SelectedIndexChanged);
            // 
            // focus_Label
            // 
            this.focus_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.focus_Label.AutoSize = true;
            this.focus_Label.Location = new System.Drawing.Point(56, 582);
            this.focus_Label.Name = "focus_Label";
            this.focus_Label.Size = new System.Drawing.Size(53, 20);
            this.focus_Label.TabIndex = 106;
            this.focus_Label.Text = "Focus";
            // 
            // Focus_Combo
            // 
            this.Focus_Combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Focus_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Focus_Combo.FormattingEnabled = true;
            this.Focus_Combo.Location = new System.Drawing.Point(119, 579);
            this.Focus_Combo.Name = "Focus_Combo";
            this.Focus_Combo.Size = new System.Drawing.Size(592, 28);
            this.Focus_Combo.TabIndex = 105;
            // 
            // GPNum
            // 
            this.GPNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GPNum.Location = new System.Drawing.Point(647, 608);
            this.GPNum.Name = "GPNum";
            this.GPNum.Size = new System.Drawing.Size(63, 26);
            this.GPNum.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 610);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 103;
            this.label9.Text = "GP";
            // 
            // MagicNum
            // 
            this.MagicNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MagicNum.Location = new System.Drawing.Point(515, 608);
            this.MagicNum.Name = "MagicNum";
            this.MagicNum.Size = new System.Drawing.Size(63, 26);
            this.MagicNum.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 101;
            this.label8.Text = "Magic";
            // 
            // LaborNum
            // 
            this.LaborNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LaborNum.Location = new System.Drawing.Point(383, 608);
            this.LaborNum.Name = "LaborNum";
            this.LaborNum.Size = new System.Drawing.Size(63, 26);
            this.LaborNum.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Labor";
            // 
            // InfNum
            // 
            this.InfNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfNum.Location = new System.Drawing.Point(251, 608);
            this.InfNum.Name = "InfNum";
            this.InfNum.Size = new System.Drawing.Size(63, 26);
            this.InfNum.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Influence";
            // 
            // GoodsNum
            // 
            this.GoodsNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoodsNum.Location = new System.Drawing.Point(119, 608);
            this.GoodsNum.Name = "GoodsNum";
            this.GoodsNum.Size = new System.Drawing.Size(63, 26);
            this.GoodsNum.TabIndex = 96;
            // 
            // BonusLabel
            // 
            this.BonusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BonusLabel.AutoSize = true;
            this.BonusLabel.Location = new System.Drawing.Point(56, 610);
            this.BonusLabel.Name = "BonusLabel";
            this.BonusLabel.Size = new System.Drawing.Size(57, 20);
            this.BonusLabel.TabIndex = 95;
            this.BonusLabel.Text = "Goods";
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(119, 639);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(592, 40);
            this.Save_Button.TabIndex = 94;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Notes";
            // 
            // Notes_Text
            // 
            this.Notes_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_Text.Location = new System.Drawing.Point(119, 484);
            this.Notes_Text.Multiline = true;
            this.Notes_Text.Name = "Notes_Text";
            this.Notes_Text.Size = new System.Drawing.Size(593, 87);
            this.Notes_Text.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 91;
            this.label6.Text = "Description";
            // 
            // Description_Text
            // 
            this.Description_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_Text.Location = new System.Drawing.Point(119, 378);
            this.Description_Text.Multiline = true;
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.ReadOnly = true;
            this.Description_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description_Text.Size = new System.Drawing.Size(593, 99);
            this.Description_Text.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 89;
            this.label5.Text = "Skills";
            // 
            // Skills_Text
            // 
            this.Skills_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skills_Text.Location = new System.Drawing.Point(119, 345);
            this.Skills_Text.Name = "Skills_Text";
            this.Skills_Text.ReadOnly = true;
            this.Skills_Text.Size = new System.Drawing.Size(593, 26);
            this.Skills_Text.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Type";
            // 
            // Name_Text
            // 
            this.Name_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_Text.Location = new System.Drawing.Point(119, 278);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(593, 26);
            this.Name_Text.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Name";
            // 
            // Manager_Combo
            // 
            this.Manager_Combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Manager_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manager_Combo.FormattingEnabled = true;
            this.Manager_Combo.Location = new System.Drawing.Point(119, 310);
            this.Manager_Combo.Name = "Manager_Combo";
            this.Manager_Combo.Size = new System.Drawing.Size(593, 28);
            this.Manager_Combo.TabIndex = 84;
            this.Manager_Combo.SelectedIndexChanged += new System.EventHandler(this.Manager_Combo_SelectedIndexChanged);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_Button.Location = new System.Drawing.Point(224, 232);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(226, 40);
            this.Delete_Button.TabIndex = 108;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // New_Button
            // 
            this.New_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Button.Location = new System.Drawing.Point(456, 232);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(284, 40);
            this.New_Button.TabIndex = 107;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // ManagersDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 691);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.New_Button);
            this.Controls.Add(this.focus_Label);
            this.Controls.Add(this.Focus_Combo);
            this.Controls.Add(this.GPNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MagicNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LaborNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoodsNum);
            this.Controls.Add(this.BonusLabel);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Notes_Text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Description_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Skills_Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Manager_Combo);
            this.Controls.Add(this.ManagerList);
            this.Name = "ManagersDisplay";
            this.Text = "ManagersDisplay";
            this.Load += new System.EventHandler(this.ManagersDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GPNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaborNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ManagerList;
        private System.Windows.Forms.Label focus_Label;
        private System.Windows.Forms.ComboBox Focus_Combo;
        private System.Windows.Forms.NumericUpDown GPNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown MagicNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown LaborNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown InfNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GoodsNum;
        private System.Windows.Forms.Label BonusLabel;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Notes_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Description_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Skills_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Manager_Combo;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button New_Button;
    }
}