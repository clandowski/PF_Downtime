using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PF_Downtime
{
    /// <summary>
    /// Allows users to edit the organizations objects
    /// </summary>
    public abstract partial class ObjectDisplay : Form
    {
        /// <summary>
        /// Temporary OrgObject object to be added to the rooms list
        /// </summary>
        public Models.OrgObject TempObject { get; set; } = new Models.OrgObject();
        /// <summary>
        /// Temporary OrgObject list to be written to the organization
        /// </summary>
        public List<Models.OrgObject> Objects { get; set; } = new List<Models.OrgObject>();
        /// <summary>
        /// Temporary Room_Augmentations list to be written to the OrgRoom
        /// </summary>
        public List<Models.Base_Augmentation> Selected_Augments { get; set; } = new List<Models.Base_Augmentation>();
        /// <summary>
        /// ListViewItem record to support reordering
        /// </summary>
        private ListViewItem _itemDnD = null;

        /// <summary>
        /// Instantiates
        /// </summary>
        /// <param name="Objects"></param>
        public ObjectDisplay(List<Models.OrgObject> Objects)
        {
            InitializeComponent();
            this.Objects = Objects;
        }

        public ObjectDisplay()
        {
            
        }

        /// <summary>
        /// This should reinstance TempObject as an instance of a non-base OgObject
        /// </summary>
        public abstract void RespawnTempObject();

        /// <summary>
        /// Builds a string for the Description textbox, showing object and augmentation descriptions
        /// </summary>
        /// <returns></returns>
        public string BuildDescription()
        {
            String Description = TempObject.Object.Description;

            foreach (Models.BaseRoom_Augmentation Augment in TempObject.Augmentations)
            {
                Description = Description + Environment.NewLine + Environment.NewLine + "---" + Augment.Name + "---" + Environment.NewLine + Augment.Benefit;
            }

            return Description;
        }

        /// <summary>
        /// Populates Augments into the augment list
        /// </summary>
        public void PopulateAugmentList()
        {
            Augment_List.DataSource = BaseAugmentList();
            Augment_List.DisplayMember = "Info";
            Augment_List.ValueMember = null;
            Augment_List.ClearSelected();
        }

        /// <summary>
        /// Populates object types into the type combo
        /// </summary>
        public void PopulateBaseObjectCombo()
        {
            Type_Combo.DataSource = BaseObjectList();
            Type_Combo.DisplayMember = "Info";
            Type_Combo.ValueMember = null;
        }

        /// <summary>
        /// This list should reference the BaseObject type that this screen is editing, such as BaseRoom
        /// </summary>
        /// <returns></returns>
        public abstract List<Models.BaseObject> BaseObjectList();

        /// <summary>
        /// This list should reference the BaseAugment type that this screen is editing, such as BaseRoom_Augment
        /// </summary>
        /// <returns></returns>
        public abstract List<Models.Base_Augmentation> BaseAugmentList();

        /// <summary>
        /// Populates organization objects into the roomlist
        /// </summary>
        public void PopulateObjectList()
        {
            if (Objects != null)
            {
                ObjectList.Items.Clear();
                ObjectList.Columns.Clear();
                ObjectList.Columns.Add("Name");
                ObjectList.Columns.Add("Type");
                ObjectList.Columns.Add("Notes");
                foreach (Models.OrgObject @object in Objects)
                {
                    ObjectList.Items.Add(new ListViewItem(new string[] { @object.Name, @object.Object.Name, @object.Notes }));
                }
                ObjectList.Columns[0].Width = 150;
                ObjectList.Columns[1].Width = 120;
                ObjectList.Columns[2].Width = 200;
            }
        }

        /// <summary>
        /// Populates resources into the focus_combo
        /// </summary>
        public void PopulateResourceCombo()
        {
            Focus_Combo.DataSource = Data.ResourceList;
            Focus_Combo.DisplayMember = "Name";
            Focus_Combo.ValueMember = null;
        }

        /// <summary>
        /// Saves to tempobject to the object list, then saves the object list to the organization
        /// Has some minor interaction issues with onchange events for lists on this screen, may want to refactor later to be more clean
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
            TempObject.Name = Name_Text.Text;
            TempObject.Object = (Models.BaseObject)Type_Combo.SelectedValue;
            TempObject.Augmentations.Clear();
            TempObject.Augmentations.AddRange(Augment_List.SelectedItems.OfType<Models.Base_Augmentation>().ToList());
            TempObject.Notes = Notes_Text.Text;
            TempObject.ActiveResource = (Models.BaseResource)Focus_Combo.SelectedValue;
            TempObject.Paid = PaidCheck.Checked;

            if (String.IsNullOrWhiteSpace(DaysComplete_Text.Text))
            {
                TempObject.DaysComplete = 0;
            }
            else
            {
                TempObject.DaysComplete = Int64.Parse(DaysComplete_Text.Text);
            }


            if (ObjectList.SelectedIndices.Count == 0)
            {
                Objects.Add(TempObject);
            }
            else
            {
                Objects[ObjectList.SelectedIndices[0]] = TempObject;
            }

            RespawnTempObject();
            UpdateObjectList();

            PopulateObjectList();
            New_Button.PerformClick();

        }

        /// <summary>
        /// Overwrite this to save the Objects list to the relevent List in the organization object.
        /// This is generally the Rooms and Teams list.
        /// BusinessLayer.Organization.Rooms = Objects;
        /// </summary>
        public abstract void UpdateObjectList();

        /// <summary>
        /// Clears most of the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Button_Click(object sender, EventArgs e)
        {
            ObjectList.SelectedItems.Clear();
            Type_Combo.SelectedIndex = 0;
            Augment_List.ClearSelected();
            Focus_Combo.SelectedIndex = 0;
            PaidCheck.CheckState = CheckState.Unchecked;

            Name_Text.Text = "";
            Notes_Text.Text = "";
            DaysComplete_Text.Text = "0";

            RespawnTempObject();
            TempObject.Object = (Models.BaseObject)Type_Combo.SelectedValue;
            TempObject.Augmentations = Augment_List.SelectedItems.OfType<Models.Base_Augmentation>().ToList();
            TempObject.ActiveResource = (Models.BaseResource)Focus_Combo.SelectedValue;
        }

        /// <summary>
        /// Repopulates fields according to changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Object_Or_Augment_Changed(object sender, EventArgs e)
        {
            RespawnTempObject();
            TempObject.Object = (Models.BaseObject)Type_Combo.SelectedValue;
            TempObject.Augmentations = Augment_List.SelectedItems.OfType<Models.Base_Augmentation>().ToList();
            TempObject.ActiveResource = (Models.BaseResource)Focus_Combo.SelectedValue;

            Income_Text.Text = TempObject.BuildIncome();
            Costs_Text.Text = TempObject.BuildCosts();
            Size_Text.Text = BuildSizeText();//TempObject.Size_Range;
            Aug_Max_Text.Text = MaxSizeText();
            if (Aug_Max_Text.Text == "None") { Aug_Max_Text.BackColor = System.Drawing.Color.Empty; } else { Aug_Max_Text.BackColor = System.Drawing.Color.Red; }
            Time_Text.Text = TempObject.TotalDays.ToString();
            Benefit_Text.Text = TempObject.Object.Benefit;

            Description_Text.Text = BuildDescription();
        }

        /// <summary>
        /// Populates Size_Text with size info based on TempObject.Size
        /// </summary>
        public abstract String BuildSizeText();

        /// <summary>
        /// Populates Max_Size_Text with size info based on TempObject.Max_Size
        /// </summary>
        public abstract String MaxSizeText();

        /// <summary>
        /// Populates initial data to the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomDisplay_Load(object sender, EventArgs e)
        {
            Org_Label.Text = Data.Organization.Name;
            RespawnTempObject();

            ObjectList.View = View.Details;
            PopulateObjectList();
            PopulateBaseObjectCombo();
            PopulateAugmentList();
            PopulateResourceCombo();
        }

        /// <summary>
        /// Repopulates selected objects info to the screen
        /// Should be refactored to handle changing other indexes with index changed events later
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ObjectList.SelectedIndices.Count > 0)
            {
                TempObject = Objects[ObjectList.SelectedIndices[0]];
                Boolean paid = TempObject.Paid;
                Focus_Combo.SelectedIndex = (int)TempObject.ActiveResource.Resource_ID;
                Type_Combo.SelectedIndex = (int)TempObject.Object.ID - 1;
                TempObject.Paid = paid;

                Augment_List.SelectedItems.Clear();
                Name_Text.Text = Objects[ObjectList.SelectedIndices[0]].Name;
                Notes_Text.Text = Objects[ObjectList.SelectedIndices[0]].Notes;
                DaysComplete_Text.Text = Objects[ObjectList.SelectedIndices[0]].DaysComplete.ToString();

                if (paid)
                {
                    PaidCheck.CheckState = CheckState.Checked;
                }
                else
                {
                    PaidCheck.CheckState = CheckState.Unchecked;
                }

                foreach (Models.BaseRoom_Augmentation Augment in Objects[ObjectList.SelectedIndices[0]].Augmentations)
                {
                    Augment_List.SetSelected((Int32)Augment.Augment_ID - 1, true);
                }

                Object_Or_Augment_Changed(null, null);

                
            }
            else
            {
                New_Button.PerformClick();
            }
        }

        /// <summary>
        /// Removes an object from the object list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (ObjectList.SelectedIndices.Count > 0)
            {
                 Objects.RemoveAt(ObjectList.SelectedIndices[0]);

                RespawnTempObject();

                PopulateObjectList();
                New_Button.PerformClick();

                UpdateObjectList();
                //BusinessLayer.Organization.Rooms = Objects;
            }
            else
            {
                MessageBox.Show("Maybe select something before hitting this?");
            }
        }

        /// <summary>
        /// Disallow non-numeric information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DaysComplete_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Used to support reordering of ObjectList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjectList_MouseDown(object sender, MouseEventArgs e)
        {
            _itemDnD = ObjectList.GetItemAt(e.X, e.Y);
        }
        /// <summary>
        /// Used to support reordering of ObjectList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjectList_MouseMove(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null)
                return;

            Cursor = Cursors.Hand;
        }
        /// <summary>
        /// Used to support reordering of ObjectList
        /// Also reorders the Objects list to match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjectList_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewItem itemOver = ObjectList.GetItemAt(0, e.Y);

            if (itemOver == null)
                return;

            //Determines if we drop before or after current item
            System.Drawing.Rectangle rc = itemOver.GetBounds(ItemBoundsPortion.Entire);

            bool insertBefore;
            if (e.Y < rc.Top + (rc.Height / 2))
                insertBefore = true;
            else
                insertBefore = false;

            if (_itemDnD != itemOver)
            {
                Int32 start = _itemDnD.Index;
                Int32 end = itemOver.Index;
                RespawnTempObject();
                TempObject = Objects[_itemDnD.Index];
                if (insertBefore)
                {
                    Objects.RemoveAt(start);
                    Objects.Insert(end, TempObject);
                    ObjectList.Items.Remove(_itemDnD);
                    ObjectList.Items.Insert(itemOver.Index, _itemDnD);
                    
                }
                else
                {
                    Objects.RemoveAt(start);
                    Objects.Insert(end, TempObject);
                    ObjectList.Items.Remove(_itemDnD);
                    ObjectList.Items.Insert(itemOver.Index + 1, _itemDnD);
                }
            }

            Cursor = Cursors.Default;
        }
    }
}