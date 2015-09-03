namespace PF_Downtime
{
    partial class ManagerDisplay
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Notes";
            // 
            // Notes_Text
            // 
            this.Notes_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_Text.Location = new System.Drawing.Point(109, 218);
            this.Notes_Text.Multiline = true;
            this.Notes_Text.Name = "Notes_Text";
            this.Notes_Text.Size = new System.Drawing.Size(642, 94);
            this.Notes_Text.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Description";
            // 
            // Description_Text
            // 
            this.Description_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_Text.Location = new System.Drawing.Point(109, 112);
            this.Description_Text.Multiline = true;
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.ReadOnly = true;
            this.Description_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description_Text.Size = new System.Drawing.Size(642, 99);
            this.Description_Text.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Skills";
            // 
            // Skills_Text
            // 
            this.Skills_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skills_Text.Location = new System.Drawing.Point(109, 79);
            this.Skills_Text.Name = "Skills_Text";
            this.Skills_Text.ReadOnly = true;
            this.Skills_Text.Size = new System.Drawing.Size(642, 26);
            this.Skills_Text.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Type";
            // 
            // Name_Text
            // 
            this.Name_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_Text.Location = new System.Drawing.Point(109, 12);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(642, 26);
            this.Name_Text.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // Manager_Combo
            // 
            this.Manager_Combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Manager_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manager_Combo.FormattingEnabled = true;
            this.Manager_Combo.Location = new System.Drawing.Point(109, 44);
            this.Manager_Combo.Name = "Manager_Combo";
            this.Manager_Combo.Size = new System.Drawing.Size(642, 28);
            this.Manager_Combo.TabIndex = 13;
            this.Manager_Combo.SelectedIndexChanged += new System.EventHandler(this.Manager_Combo_SelectedIndexChanged);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(109, 319);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(641, 40);
            this.Save_Button.TabIndex = 24;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // ManagerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 371);
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
            this.Name = "ManagerDisplay";
            this.Text = "ManagerDisplay";
            this.Load += new System.EventHandler(this.ManagerDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button Save_Button;
    }
}