namespace PF_Downtime
{
    partial class OrgDisplay
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
            this.Settlement_Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Manager_Button = new System.Windows.Forms.Button();
            this.Location_Text = new System.Windows.Forms.TextBox();
            this.Location_Label = new System.Windows.Forms.Label();
            this.Notes_Text = new System.Windows.Forms.TextBox();
            this.Notes_Label = new System.Windows.Forms.Label();
            this.Manager_Label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.ParallelCheck = new System.Windows.Forms.CheckBox();
            this.BlackMarketCombo = new System.Windows.Forms.ComboBox();
            this.BMLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Settlement_Combo
            // 
            this.Settlement_Combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settlement_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Settlement_Combo.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settlement_Combo.FormattingEnabled = true;
            this.Settlement_Combo.Location = new System.Drawing.Point(88, 44);
            this.Settlement_Combo.Name = "Settlement_Combo";
            this.Settlement_Combo.Size = new System.Drawing.Size(644, 26);
            this.Settlement_Combo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // Manager_Button
            // 
            this.Manager_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Manager_Button.Location = new System.Drawing.Point(88, 108);
            this.Manager_Button.Name = "Manager_Button";
            this.Manager_Button.Size = new System.Drawing.Size(644, 43);
            this.Manager_Button.TabIndex = 4;
            this.Manager_Button.Text = "Manager";
            this.Manager_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Manager_Button.UseVisualStyleBackColor = true;
            this.Manager_Button.Click += new System.EventHandler(this.Manager_Button_Click);
            // 
            // Location_Text
            // 
            this.Location_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Location_Text.Location = new System.Drawing.Point(88, 12);
            this.Location_Text.Name = "Location_Text";
            this.Location_Text.Size = new System.Drawing.Size(644, 26);
            this.Location_Text.TabIndex = 5;
            // 
            // Location_Label
            // 
            this.Location_Label.AutoSize = true;
            this.Location_Label.Location = new System.Drawing.Point(12, 15);
            this.Location_Label.Name = "Location_Label";
            this.Location_Label.Size = new System.Drawing.Size(70, 20);
            this.Location_Label.TabIndex = 6;
            this.Location_Label.Text = "Location";
            // 
            // Notes_Text
            // 
            this.Notes_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_Text.Location = new System.Drawing.Point(88, 157);
            this.Notes_Text.Multiline = true;
            this.Notes_Text.Name = "Notes_Text";
            this.Notes_Text.Size = new System.Drawing.Size(644, 222);
            this.Notes_Text.TabIndex = 7;
            // 
            // Notes_Label
            // 
            this.Notes_Label.AutoSize = true;
            this.Notes_Label.Location = new System.Drawing.Point(31, 160);
            this.Notes_Label.Name = "Notes_Label";
            this.Notes_Label.Size = new System.Drawing.Size(51, 20);
            this.Notes_Label.TabIndex = 8;
            this.Notes_Label.Text = "Notes";
            // 
            // Manager_Label
            // 
            this.Manager_Label.AutoSize = true;
            this.Manager_Label.Location = new System.Drawing.Point(10, 119);
            this.Manager_Label.Name = "Manager_Label";
            this.Manager_Label.Size = new System.Drawing.Size(72, 20);
            this.Manager_Label.TabIndex = 9;
            this.Manager_Label.Text = "Manager";
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(88, 416);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(644, 41);
            this.Save_Button.TabIndex = 10;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // ParallelCheck
            // 
            this.ParallelCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParallelCheck.AutoSize = true;
            this.ParallelCheck.Location = new System.Drawing.Point(88, 386);
            this.ParallelCheck.Name = "ParallelCheck";
            this.ParallelCheck.Size = new System.Drawing.Size(186, 24);
            this.ParallelCheck.TabIndex = 11;
            this.ParallelCheck.Text = "Construct in Parralel?";
            this.ParallelCheck.UseVisualStyleBackColor = true;
            // 
            // BlackMarketCombo
            // 
            this.BlackMarketCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackMarketCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BlackMarketCombo.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackMarketCombo.FormattingEnabled = true;
            this.BlackMarketCombo.Location = new System.Drawing.Point(88, 76);
            this.BlackMarketCombo.Name = "BlackMarketCombo";
            this.BlackMarketCombo.Size = new System.Drawing.Size(644, 26);
            this.BlackMarketCombo.TabIndex = 12;
            // 
            // BMLabel
            // 
            this.BMLabel.AutoSize = true;
            this.BMLabel.Location = new System.Drawing.Point(14, 77);
            this.BMLabel.Name = "BMLabel";
            this.BMLabel.Size = new System.Drawing.Size(68, 20);
            this.BMLabel.TabIndex = 13;
            this.BMLabel.Text = "BM Size";
            // 
            // OrgDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 476);
            this.Controls.Add(this.BMLabel);
            this.Controls.Add(this.BlackMarketCombo);
            this.Controls.Add(this.ParallelCheck);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Manager_Label);
            this.Controls.Add(this.Notes_Label);
            this.Controls.Add(this.Notes_Text);
            this.Controls.Add(this.Location_Label);
            this.Controls.Add(this.Location_Text);
            this.Controls.Add(this.Manager_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Settlement_Combo);
            this.Name = "OrgDisplay";
            this.Text = "OrgDisplay";
            this.Load += new System.EventHandler(this.OrgDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Settlement_Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Manager_Button;
        private System.Windows.Forms.TextBox Location_Text;
        private System.Windows.Forms.Label Location_Label;
        private System.Windows.Forms.TextBox Notes_Text;
        private System.Windows.Forms.Label Notes_Label;
        private System.Windows.Forms.Label Manager_Label;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.CheckBox ParallelCheck;
        private System.Windows.Forms.ComboBox BlackMarketCombo;
        private System.Windows.Forms.Label BMLabel;
    }
}