namespace PF_Downtime
{
    partial class Organizaion_frm
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
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.load_Btn = new System.Windows.Forms.Button();
            this.save_Btn = new System.Windows.Forms.Button();
            this.Overview_Lst = new System.Windows.Forms.ListBox();
            this.Rooms_Btn = new System.Windows.Forms.Button();
            this.Export_Btn = new System.Windows.Forms.Button();
            this.Teams_Btn = new System.Windows.Forms.Button();
            this.Org_Button = new System.Windows.Forms.Button();
            this.QuickText = new System.Windows.Forms.TextBox();
            this.advanceButton = new System.Windows.Forms.Button();
            this.Paid_Button = new System.Windows.Forms.Button();
            this.Unpaid_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Text
            // 
            this.Name_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_Text.Location = new System.Drawing.Point(13, 55);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(604, 26);
            this.Name_Text.TabIndex = 0;
            // 
            // load_Btn
            // 
            this.load_Btn.Location = new System.Drawing.Point(13, 13);
            this.load_Btn.Name = "load_Btn";
            this.load_Btn.Size = new System.Drawing.Size(212, 36);
            this.load_Btn.TabIndex = 2;
            this.load_Btn.Text = "Load";
            this.load_Btn.UseVisualStyleBackColor = true;
            this.load_Btn.Click += new System.EventHandler(this.load_Btn_Click);
            // 
            // save_Btn
            // 
            this.save_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_Btn.Location = new System.Drawing.Point(404, 12);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.Size = new System.Drawing.Size(212, 37);
            this.save_Btn.TabIndex = 3;
            this.save_Btn.Text = "Save";
            this.save_Btn.UseVisualStyleBackColor = true;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // Overview_Lst
            // 
            this.Overview_Lst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Overview_Lst.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview_Lst.FormattingEnabled = true;
            this.Overview_Lst.ItemHeight = 18;
            this.Overview_Lst.Location = new System.Drawing.Point(14, 88);
            this.Overview_Lst.Name = "Overview_Lst";
            this.Overview_Lst.Size = new System.Drawing.Size(603, 418);
            this.Overview_Lst.TabIndex = 4;
            // 
            // Rooms_Btn
            // 
            this.Rooms_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rooms_Btn.Location = new System.Drawing.Point(14, 630);
            this.Rooms_Btn.Name = "Rooms_Btn";
            this.Rooms_Btn.Size = new System.Drawing.Size(211, 45);
            this.Rooms_Btn.TabIndex = 5;
            this.Rooms_Btn.Text = "Rooms";
            this.Rooms_Btn.UseVisualStyleBackColor = true;
            this.Rooms_Btn.Click += new System.EventHandler(this.Rooms_Btn_Click);
            // 
            // Export_Btn
            // 
            this.Export_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Export_Btn.Location = new System.Drawing.Point(231, 629);
            this.Export_Btn.Name = "Export_Btn";
            this.Export_Btn.Size = new System.Drawing.Size(167, 45);
            this.Export_Btn.TabIndex = 6;
            this.Export_Btn.Text = "Export";
            this.Export_Btn.UseVisualStyleBackColor = true;
            this.Export_Btn.Click += new System.EventHandler(this.Export_Btn_Click);
            // 
            // Teams_Btn
            // 
            this.Teams_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Teams_Btn.Location = new System.Drawing.Point(404, 630);
            this.Teams_Btn.Name = "Teams_Btn";
            this.Teams_Btn.Size = new System.Drawing.Size(212, 45);
            this.Teams_Btn.TabIndex = 7;
            this.Teams_Btn.Text = "Teams";
            this.Teams_Btn.UseVisualStyleBackColor = true;
            this.Teams_Btn.Click += new System.EventHandler(this.Teams_Btn_Click);
            // 
            // Org_Button
            // 
            this.Org_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Org_Button.Location = new System.Drawing.Point(231, 13);
            this.Org_Button.Name = "Org_Button";
            this.Org_Button.Size = new System.Drawing.Size(167, 36);
            this.Org_Button.TabIndex = 8;
            this.Org_Button.Text = "Organization";
            this.Org_Button.UseVisualStyleBackColor = true;
            this.Org_Button.Click += new System.EventHandler(this.Org_Button_Click);
            // 
            // QuickText
            // 
            this.QuickText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuickText.Location = new System.Drawing.Point(13, 574);
            this.QuickText.Name = "QuickText";
            this.QuickText.Size = new System.Drawing.Size(384, 26);
            this.QuickText.TabIndex = 9;
            this.QuickText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuickText_KeyPress);
            // 
            // advanceButton
            // 
            this.advanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advanceButton.Location = new System.Drawing.Point(406, 574);
            this.advanceButton.Name = "advanceButton";
            this.advanceButton.Size = new System.Drawing.Size(211, 50);
            this.advanceButton.TabIndex = 10;
            this.advanceButton.Text = "Quick Advance Days";
            this.advanceButton.UseVisualStyleBackColor = true;
            this.advanceButton.Click += new System.EventHandler(this.advanceButton_Click);
            // 
            // Paid_Button
            // 
            this.Paid_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Paid_Button.Location = new System.Drawing.Point(404, 517);
            this.Paid_Button.Name = "Paid_Button";
            this.Paid_Button.Size = new System.Drawing.Size(212, 51);
            this.Paid_Button.TabIndex = 11;
            this.Paid_Button.Text = "Mark All Paid";
            this.Paid_Button.UseVisualStyleBackColor = true;
            this.Paid_Button.Click += new System.EventHandler(this.Paid_Button_Click);
            // 
            // Unpaid_Button
            // 
            this.Unpaid_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Unpaid_Button.Location = new System.Drawing.Point(231, 516);
            this.Unpaid_Button.Name = "Unpaid_Button";
            this.Unpaid_Button.Size = new System.Drawing.Size(167, 51);
            this.Unpaid_Button.TabIndex = 12;
            this.Unpaid_Button.Text = "Mark All Unpaid";
            this.Unpaid_Button.UseVisualStyleBackColor = true;
            this.Unpaid_Button.Click += new System.EventHandler(this.Unpaid_Button_Click);
            // 
            // Organizaion_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 686);
            this.Controls.Add(this.Unpaid_Button);
            this.Controls.Add(this.Paid_Button);
            this.Controls.Add(this.advanceButton);
            this.Controls.Add(this.QuickText);
            this.Controls.Add(this.Org_Button);
            this.Controls.Add(this.Teams_Btn);
            this.Controls.Add(this.Export_Btn);
            this.Controls.Add(this.Rooms_Btn);
            this.Controls.Add(this.Overview_Lst);
            this.Controls.Add(this.save_Btn);
            this.Controls.Add(this.load_Btn);
            this.Controls.Add(this.Name_Text);
            this.Name = "Organizaion_frm";
            this.Text = "Organization";
            this.Load += new System.EventHandler(this.SummaryDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Button load_Btn;
        private System.Windows.Forms.Button save_Btn;
        private System.Windows.Forms.ListBox Overview_Lst;
        private System.Windows.Forms.Button Rooms_Btn;
        private System.Windows.Forms.Button Export_Btn;
        private System.Windows.Forms.Button Teams_Btn;
        private System.Windows.Forms.Button Org_Button;
        private System.Windows.Forms.TextBox QuickText;
        private System.Windows.Forms.Button advanceButton;
        private System.Windows.Forms.Button Paid_Button;
        private System.Windows.Forms.Button Unpaid_Button;
    }
}

