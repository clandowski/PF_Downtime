using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_Downtime.GUI
{
    public partial class ManagersDisplay : Form
    {

        /// <summary>
        /// Temporary OrgObject list to be written to the organization
        /// </summary>
        public List<Models.OrgManager> Managers { get; set; } = new List<Models.OrgManager>();
        /// <summary>
        /// Temporary OrgObject object to be added to the rooms list
        /// </summary>
        public Models.OrgManager TempObject { get; set; } = new Models.OrgManager();

        public ManagersDisplay(List<Models.OrgManager> ManagersList)
        {
            InitializeComponent();
            Managers.Clear();
            Managers.AddRange(ManagersList.ConvertAll(x => (Models.OrgManager)x));
        }

        private void ManagersDisplay_Load(object sender, EventArgs e)
        {
            PopulateManagerCombo();
            PopulateResourceCombo();
            PopulateManagerstList();
            LoadManagerData();
        }

        /// <summary>
        /// Clears the Organization's Managers list and repopulates it from this screen
        /// </summary>
        private void UpdateOrgManagerList()
        {
            Data.Organization.Managers.Clear();
            Data.Organization.Managers.AddRange(Managers.ConvertAll(x => (Models.OrgManager)x));
        }

        

        /// <summary>
        /// Populates organization objects into the roomlist
        /// </summary>
        public void PopulateManagerstList()
        {
            if (Managers != null)
            {
                ManagerList.Items.Clear();
                ManagerList.Columns.Clear();
                ManagerList.Columns.Add("Name");
                ManagerList.Columns.Add("Type");
                ManagerList.Columns.Add("Notes");
                foreach (Models.OrgManager @manager in Managers)
                {
                    ManagerList.Items.Add(new ListViewItem(new string[] { @manager.Name, @manager.Name, @manager.Notes }));
                }
                ManagerList.Columns[0].Width = 150;
                ManagerList.Columns[1].Width = 120;
                ManagerList.Columns[2].Width = 200;
            }
        }

        /// <summary>
        /// Populatess managers into the Manager combobox
        /// </summary>
        private void PopulateManagerCombo()
        {
            Manager_Combo.DataSource = Data.ManagerList;
            Manager_Combo.DisplayMember = "Display";
            Manager_Combo.ValueMember = null;
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
        /// Loads manager data into textboxes
        /// </summary>
        private void LoadManagerData()
        {

            if (ManagerList.SelectedIndices.Count > 0)
            {
                TempObject = Managers[ManagerList.SelectedIndices[0]];

                Name_Text.Text              = TempObject.Name;
                Description_Text.Text       = TempObject.Type.Description;
                Skills_Text.Text            = TempObject.Type.Skills;
                Notes_Text.Text             = TempObject.Notes;
                Manager_Combo.SelectedIndex = (int)TempObject.Type.ManagerID;
                GoodsNum.Value              = TempObject.Earn_Goods;
                InfNum.Value                = TempObject.Earn_Influence;
                LaborNum.Value              = TempObject.Earn_Labor;
                MagicNum.Value              = TempObject.Earn_Magic;
                GPNum.Value                 = TempObject.Earn_GP;
                Focus_Combo.SelectedIndex   = (int)TempObject.ActiveResource.Resource_ID;


            }
            else
            {
                //New_Button.PerformClick();
            }

        }

        /// <summary>
        /// Saves user editable information back to the organization manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            TempObject.Name = Name_Text.Text;
            TempObject.Notes = Notes_Text.Text;
            TempObject.Type = (Models.BaseManager)Manager_Combo.SelectedValue;
            TempObject.ActiveResource = (Models.BaseResource)Focus_Combo.SelectedValue;

            int x = 0;
            int.TryParse(GoodsNum.Text, out x);
            TempObject.Earn_Goods = x;
            int.TryParse(InfNum.Text, out x);
            TempObject.Earn_Influence = x;
            int.TryParse(LaborNum.Text, out x);
            TempObject.Earn_Labor = x;
            int.TryParse(MagicNum.Text, out x);
            TempObject.Earn_Magic = x;
            int.TryParse(GPNum.Text, out x);
            TempObject.Earn_GP = x;

            if (ManagerList.SelectedIndices.Count > 0)
            {
                Managers[ManagerList.SelectedIndices[0]] = TempObject;
            }
            else
            {
                Managers.Add(TempObject);
            }

            UpdateOrgManagerList();

            PopulateManagerstList();
            New_Button.PerformClick();
        }

        /// <summary>
        /// Loads changed managers information to the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Manager_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Description_Text.Text = ((Models.BaseManager)Manager_Combo.SelectedValue).Description;
            Skills_Text.Text = ((Models.BaseManager)Manager_Combo.SelectedValue).Skills;
        }

        private void ManagerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadManagerData();
        }

        /// <summary>
        /// Reinstantiates the TempRoom object
        /// </summary>
        private void RespawnTempObject()
        {
            TempObject = new Models.OrgManager();
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            ManagerList.SelectedItems.Clear();
            Manager_Combo.SelectedIndex = 0;
            Focus_Combo.SelectedIndex = 0;

            GoodsNum.Value = 0;
            InfNum.Value = 0;
            LaborNum.Value = 0;
            MagicNum.Value = 0;
            GPNum.Value = 0;

            Name_Text.Text = "";
            Notes_Text.Text = "";

            RespawnTempObject();
            TempObject.Type = (Models.BaseManager)Manager_Combo.SelectedValue;
            TempObject.ActiveResource = (Models.BaseResource)Focus_Combo.SelectedValue;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (ManagerList.SelectedIndices.Count > 0)
            {
                Managers.RemoveAt(ManagerList.SelectedIndices[0]);

                RespawnTempObject();

                PopulateManagerstList();

                New_Button.PerformClick();

                UpdateOrgManagerList();
                //BusinessLayer.Organization.Rooms = Objects;
            }
            else
            {
                MessageBox.Show("Maybe select something before hitting this?");
            }
        }
    }
}
