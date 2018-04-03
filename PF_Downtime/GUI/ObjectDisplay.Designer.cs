using System.Collections.Generic;
using PF_Downtime.Models;

namespace PF_Downtime
{
    partial class ObjectDisplay
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
        public void InitializeComponent()
        {
            this.Org_Label = new System.Windows.Forms.Label();
            this.ObjectList = new System.Windows.Forms.ListView();
            this.name_Label = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Type_Label = new System.Windows.Forms.Label();
            this.Type_Combo = new System.Windows.Forms.ComboBox();
            this.Augments_Label = new System.Windows.Forms.Label();
            this.Augment_List = new System.Windows.Forms.ListBox();
            this.Income_Text = new System.Windows.Forms.TextBox();
            this.Income_Label = new System.Windows.Forms.Label();
            this.Cost_Label = new System.Windows.Forms.Label();
            this.Costs_Text = new System.Windows.Forms.TextBox();
            this.Names_Label = new System.Windows.Forms.Label();
            this.Earn_Label = new System.Windows.Forms.Label();
            this.Costs_Label = new System.Windows.Forms.Label();
            this.Benefits_Label = new System.Windows.Forms.Label();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Description_Text = new System.Windows.Forms.TextBox();
            this.Size_Text = new System.Windows.Forms.TextBox();
            this.Size_Label = new System.Windows.Forms.Label();
            this.Time_Text = new System.Windows.Forms.TextBox();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Notes_Text = new System.Windows.Forms.TextBox();
            this.Notes_Label = new System.Windows.Forms.Label();
            this.New_Button = new System.Windows.Forms.Button();
            this.Benefit_Text = new System.Windows.Forms.TextBox();
            this.Benefit_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Focus_Combo = new System.Windows.Forms.ComboBox();
            this.focus_Label = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.DaysComplete_Text = new System.Windows.Forms.TextBox();
            this.PaidCheck = new System.Windows.Forms.CheckBox();
            this.Aug_Max = new System.Windows.Forms.Label();
            this.Aug_Max_Text = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Org_Label
            // 
            this.Org_Label.AutoSize = true;
            this.Org_Label.Location = new System.Drawing.Point(9, 8);
            this.Org_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Org_Label.Name = "Org_Label";
            this.Org_Label.Size = new System.Drawing.Size(190, 13);
            this.Org_Label.TabIndex = 0;
            this.Org_Label.Text = "Load Organazation Name Here Rooms";
            // 
            // ObjectList
            // 
            this.ObjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectList.FullRowSelect = true;
            this.ObjectList.Location = new System.Drawing.Point(11, 24);
            this.ObjectList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ObjectList.MultiSelect = false;
            this.ObjectList.Name = "ObjectList";
            this.ObjectList.Size = new System.Drawing.Size(519, 100);
            this.ObjectList.TabIndex = 1;
            this.ObjectList.UseCompatibleStateImageBehavior = false;
            this.ObjectList.SelectedIndexChanged += new System.EventHandler(this.ObjectList_SelectedIndexChanged);
            this.ObjectList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectList_MouseDown);
            this.ObjectList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectList_MouseMove);
            this.ObjectList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectList_MouseUp);
            // 
            // name_Label
            // 
            this.name_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(31, 156);
            this.name_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(35, 13);
            this.name_Label.TabIndex = 2;
            this.name_Label.Text = "Name";
            // 
            // Name_Text
            // 
            this.Name_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_Text.Location = new System.Drawing.Point(69, 154);
            this.Name_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(269, 20);
            this.Name_Text.TabIndex = 3;
            // 
            // Type_Label
            // 
            this.Type_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Type_Label.AutoSize = true;
            this.Type_Label.Location = new System.Drawing.Point(36, 198);
            this.Type_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(31, 13);
            this.Type_Label.TabIndex = 4;
            this.Type_Label.Text = "Type";
            // 
            // Type_Combo
            // 
            this.Type_Combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Type_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_Combo.Font = new System.Drawing.Font("Courier New", 8F);
            this.Type_Combo.FormattingEnabled = true;
            this.Type_Combo.Location = new System.Drawing.Point(69, 197);
            this.Type_Combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Type_Combo.Name = "Type_Combo";
            this.Type_Combo.Size = new System.Drawing.Size(463, 22);
            this.Type_Combo.TabIndex = 5;
            this.Type_Combo.SelectedIndexChanged += new System.EventHandler(this.Object_Or_Augment_Changed);
            // 
            // Augments_Label
            // 
            this.Augments_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Augments_Label.AutoSize = true;
            this.Augments_Label.Location = new System.Drawing.Point(10, 224);
            this.Augments_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Augments_Label.Name = "Augments_Label";
            this.Augments_Label.Size = new System.Drawing.Size(54, 13);
            this.Augments_Label.TabIndex = 7;
            this.Augments_Label.Text = "Augments";
            // 
            // Augment_List
            // 
            this.Augment_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Augment_List.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Augment_List.FormattingEnabled = true;
            this.Augment_List.ItemHeight = 14;
            this.Augment_List.Location = new System.Drawing.Point(69, 224);
            this.Augment_List.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Augment_List.Name = "Augment_List";
            this.Augment_List.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Augment_List.Size = new System.Drawing.Size(463, 74);
            this.Augment_List.TabIndex = 8;
            this.Augment_List.SelectedIndexChanged += new System.EventHandler(this.Object_Or_Augment_Changed);
            // 
            // Income_Text
            // 
            this.Income_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Income_Text.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income_Text.Location = new System.Drawing.Point(69, 306);
            this.Income_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Income_Text.Name = "Income_Text";
            this.Income_Text.ReadOnly = true;
            this.Income_Text.Size = new System.Drawing.Size(463, 20);
            this.Income_Text.TabIndex = 9;
            // 
            // Income_Label
            // 
            this.Income_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Income_Label.AutoSize = true;
            this.Income_Label.Location = new System.Drawing.Point(18, 308);
            this.Income_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Income_Label.Name = "Income_Label";
            this.Income_Label.Size = new System.Drawing.Size(47, 13);
            this.Income_Label.TabIndex = 10;
            this.Income_Label.Text = "Incomes";
            // 
            // Cost_Label
            // 
            this.Cost_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cost_Label.AutoSize = true;
            this.Cost_Label.Location = new System.Drawing.Point(31, 360);
            this.Cost_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cost_Label.Name = "Cost_Label";
            this.Cost_Label.Size = new System.Drawing.Size(33, 13);
            this.Cost_Label.TabIndex = 12;
            this.Cost_Label.Text = "Costs";
            // 
            // Costs_Text
            // 
            this.Costs_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Costs_Text.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costs_Text.Location = new System.Drawing.Point(69, 358);
            this.Costs_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Costs_Text.Name = "Costs_Text";
            this.Costs_Text.ReadOnly = true;
            this.Costs_Text.Size = new System.Drawing.Size(463, 20);
            this.Costs_Text.TabIndex = 11;
            // 
            // Names_Label
            // 
            this.Names_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Names_Label.AutoSize = true;
            this.Names_Label.Location = new System.Drawing.Point(66, 182);
            this.Names_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Names_Label.Name = "Names_Label";
            this.Names_Label.Size = new System.Drawing.Size(35, 13);
            this.Names_Label.TabIndex = 13;
            this.Names_Label.Text = "Name";
            // 
            // Earn_Label
            // 
            this.Earn_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Earn_Label.AutoSize = true;
            this.Earn_Label.Location = new System.Drawing.Point(217, 182);
            this.Earn_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Earn_Label.Name = "Earn_Label";
            this.Earn_Label.Size = new System.Drawing.Size(29, 13);
            this.Earn_Label.TabIndex = 14;
            this.Earn_Label.Text = "Earn";
            // 
            // Costs_Label
            // 
            this.Costs_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Costs_Label.AutoSize = true;
            this.Costs_Label.Location = new System.Drawing.Point(318, 182);
            this.Costs_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Costs_Label.Name = "Costs_Label";
            this.Costs_Label.Size = new System.Drawing.Size(33, 13);
            this.Costs_Label.TabIndex = 15;
            this.Costs_Label.Text = "Costs";
            // 
            // Benefits_Label
            // 
            this.Benefits_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Benefits_Label.AutoSize = true;
            this.Benefits_Label.Location = new System.Drawing.Point(488, 182);
            this.Benefits_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Benefits_Label.Name = "Benefits_Label";
            this.Benefits_Label.Size = new System.Drawing.Size(42, 13);
            this.Benefits_Label.TabIndex = 16;
            this.Benefits_Label.Text = "Special";
            // 
            // Description_Label
            // 
            this.Description_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_Label.AutoSize = true;
            this.Description_Label.Location = new System.Drawing.Point(5, 445);
            this.Description_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(60, 13);
            this.Description_Label.TabIndex = 17;
            this.Description_Label.Text = "Description";
            // 
            // Description_Text
            // 
            this.Description_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_Text.Location = new System.Drawing.Point(69, 443);
            this.Description_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Description_Text.Multiline = true;
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.ReadOnly = true;
            this.Description_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description_Text.Size = new System.Drawing.Size(463, 131);
            this.Description_Text.TabIndex = 18;
            // 
            // Size_Text
            // 
            this.Size_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Size_Text.Location = new System.Drawing.Point(69, 379);
            this.Size_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Size_Text.Name = "Size_Text";
            this.Size_Text.ReadOnly = true;
            this.Size_Text.Size = new System.Drawing.Size(179, 20);
            this.Size_Text.TabIndex = 19;
            // 
            // Size_Label
            // 
            this.Size_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Size_Label.AutoSize = true;
            this.Size_Label.Location = new System.Drawing.Point(36, 381);
            this.Size_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Size_Label.Name = "Size_Label";
            this.Size_Label.Size = new System.Drawing.Size(27, 13);
            this.Size_Label.TabIndex = 20;
            this.Size_Label.Text = "Size";
            // 
            // Time_Text
            // 
            this.Time_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_Text.Location = new System.Drawing.Point(152, 400);
            this.Time_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Time_Text.Name = "Time_Text";
            this.Time_Text.ReadOnly = true;
            this.Time_Text.Size = new System.Drawing.Size(380, 20);
            this.Time_Text.TabIndex = 21;
            // 
            // Time_Label
            // 
            this.Time_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_Label.AutoSize = true;
            this.Time_Label.Location = new System.Drawing.Point(33, 402);
            this.Time_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(31, 13);
            this.Time_Label.TabIndex = 22;
            this.Time_Label.Text = "Days";
            // 
            // Notes_Text
            // 
            this.Notes_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_Text.Location = new System.Drawing.Point(67, 577);
            this.Notes_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Notes_Text.Name = "Notes_Text";
            this.Notes_Text.Size = new System.Drawing.Size(463, 20);
            this.Notes_Text.TabIndex = 23;
            // 
            // Notes_Label
            // 
            this.Notes_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes_Label.AutoSize = true;
            this.Notes_Label.Location = new System.Drawing.Point(27, 579);
            this.Notes_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Notes_Label.Name = "Notes_Label";
            this.Notes_Label.Size = new System.Drawing.Size(35, 13);
            this.Notes_Label.TabIndex = 24;
            this.Notes_Label.Text = "Notes";
            // 
            // New_Button
            // 
            this.New_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Button.Location = new System.Drawing.Point(341, 126);
            this.New_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(189, 26);
            this.New_Button.TabIndex = 25;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // Benefit_Text
            // 
            this.Benefit_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Benefit_Text.Location = new System.Drawing.Point(69, 422);
            this.Benefit_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Benefit_Text.Name = "Benefit_Text";
            this.Benefit_Text.ReadOnly = true;
            this.Benefit_Text.Size = new System.Drawing.Size(463, 20);
            this.Benefit_Text.TabIndex = 26;
            // 
            // Benefit_Label
            // 
            this.Benefit_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Benefit_Label.AutoSize = true;
            this.Benefit_Label.Location = new System.Drawing.Point(25, 424);
            this.Benefit_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Benefit_Label.Name = "Benefit_Label";
            this.Benefit_Label.Size = new System.Drawing.Size(40, 13);
            this.Benefit_Label.TabIndex = 27;
            this.Benefit_Label.Text = "Benefit";
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Button.Location = new System.Drawing.Point(67, 599);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(462, 21);
            this.Add_Button.TabIndex = 28;
            this.Add_Button.Text = "Add/Update";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Focus_Combo
            // 
            this.Focus_Combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Focus_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Focus_Combo.FormattingEnabled = true;
            this.Focus_Combo.Location = new System.Drawing.Point(69, 328);
            this.Focus_Combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Focus_Combo.Name = "Focus_Combo";
            this.Focus_Combo.Size = new System.Drawing.Size(463, 21);
            this.Focus_Combo.TabIndex = 29;
            // 
            // focus_Label
            // 
            this.focus_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.focus_Label.AutoSize = true;
            this.focus_Label.Location = new System.Drawing.Point(25, 330);
            this.focus_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.focus_Label.Name = "focus_Label";
            this.focus_Label.Size = new System.Drawing.Size(36, 13);
            this.focus_Label.TabIndex = 30;
            this.focus_Label.Text = "Focus";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_Button.Location = new System.Drawing.Point(187, 126);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(151, 26);
            this.Delete_Button.TabIndex = 31;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // DaysComplete_Text
            // 
            this.DaysComplete_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DaysComplete_Text.Location = new System.Drawing.Point(69, 400);
            this.DaysComplete_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DaysComplete_Text.Name = "DaysComplete_Text";
            this.DaysComplete_Text.Size = new System.Drawing.Size(81, 20);
            this.DaysComplete_Text.TabIndex = 56;
            this.DaysComplete_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DaysComplete_Text_KeyPress);
            // 
            // PaidCheck
            // 
            this.PaidCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaidCheck.AutoSize = true;
            this.PaidCheck.Location = new System.Drawing.Point(69, 131);
            this.PaidCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaidCheck.Name = "PaidCheck";
            this.PaidCheck.Size = new System.Drawing.Size(65, 17);
            this.PaidCheck.TabIndex = 57;
            this.PaidCheck.Text = "Paid For";
            this.PaidCheck.UseVisualStyleBackColor = true;
            this.PaidCheck.CheckedChanged += new System.EventHandler(this.PaidCheck_CheckedChanged);
            // 
            // Aug_Max
            // 
            this.Aug_Max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Aug_Max.AutoSize = true;
            this.Aug_Max.Location = new System.Drawing.Point(250, 381);
            this.Aug_Max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Aug_Max.Name = "Aug_Max";
            this.Aug_Max.Size = new System.Drawing.Size(95, 13);
            this.Aug_Max.TabIndex = 58;
            this.Aug_Max.Text = "Augment Max Size";
            // 
            // Aug_Max_Text
            // 
            this.Aug_Max_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Aug_Max_Text.Location = new System.Drawing.Point(349, 379);
            this.Aug_Max_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Aug_Max_Text.Name = "Aug_Max_Text";
            this.Aug_Max_Text.ReadOnly = true;
            this.Aug_Max_Text.Size = new System.Drawing.Size(183, 20);
            this.Aug_Max_Text.TabIndex = 59;
            // 
            // qtyLabel
            // 
            this.qtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(343, 156);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(46, 13);
            this.qtyLabel.TabIndex = 60;
            this.qtyLabel.Text = "Quantity";
            // 
            // qtyNum
            // 
            this.qtyNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyNum.Location = new System.Drawing.Point(395, 154);
            this.qtyNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtyNum.Name = "qtyNum";
            this.qtyNum.Size = new System.Drawing.Size(135, 20);
            this.qtyNum.TabIndex = 0;
            // 
            // ObjectDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 627);
            this.Controls.Add(this.qtyNum);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.Aug_Max_Text);
            this.Controls.Add(this.Aug_Max);
            this.Controls.Add(this.PaidCheck);
            this.Controls.Add(this.DaysComplete_Text);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.focus_Label);
            this.Controls.Add(this.Focus_Combo);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Benefit_Label);
            this.Controls.Add(this.Benefit_Text);
            this.Controls.Add(this.New_Button);
            this.Controls.Add(this.Notes_Label);
            this.Controls.Add(this.Notes_Text);
            this.Controls.Add(this.Time_Label);
            this.Controls.Add(this.Time_Text);
            this.Controls.Add(this.Size_Label);
            this.Controls.Add(this.Size_Text);
            this.Controls.Add(this.Description_Text);
            this.Controls.Add(this.Description_Label);
            this.Controls.Add(this.Benefits_Label);
            this.Controls.Add(this.Costs_Label);
            this.Controls.Add(this.Earn_Label);
            this.Controls.Add(this.Names_Label);
            this.Controls.Add(this.Cost_Label);
            this.Controls.Add(this.Costs_Text);
            this.Controls.Add(this.Income_Label);
            this.Controls.Add(this.Income_Text);
            this.Controls.Add(this.Augment_List);
            this.Controls.Add(this.Augments_Label);
            this.Controls.Add(this.Type_Combo);
            this.Controls.Add(this.Type_Label);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.ObjectList);
            this.Controls.Add(this.Org_Label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ObjectDisplay";
            this.Text = "ObjectDisplay";
            this.Load += new System.EventHandler(this.RoomDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtyNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Org_Label;
        private System.Windows.Forms.ListView ObjectList;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Label Type_Label;
        private System.Windows.Forms.ComboBox Type_Combo;
        private System.Windows.Forms.Label Augments_Label;
        private System.Windows.Forms.ListBox Augment_List;
        private System.Windows.Forms.TextBox Income_Text;
        private System.Windows.Forms.Label Income_Label;
        private System.Windows.Forms.Label Cost_Label;
        private System.Windows.Forms.TextBox Costs_Text;
        private System.Windows.Forms.Label Names_Label;
        private System.Windows.Forms.Label Earn_Label;
        private System.Windows.Forms.Label Costs_Label;
        private System.Windows.Forms.Label Benefits_Label;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.TextBox Description_Text;
        private System.Windows.Forms.TextBox Size_Text;
        private System.Windows.Forms.Label Size_Label;
        private System.Windows.Forms.TextBox Time_Text;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.TextBox Notes_Text;
        private System.Windows.Forms.Label Notes_Label;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.TextBox Benefit_Text;
        private System.Windows.Forms.Label Benefit_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.ComboBox Focus_Combo;
        private System.Windows.Forms.Label focus_Label;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox DaysComplete_Text;
        private System.Windows.Forms.CheckBox PaidCheck;
        private System.Windows.Forms.Label Aug_Max;
        private System.Windows.Forms.TextBox Aug_Max_Text;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.NumericUpDown qtyNum;
    }
}