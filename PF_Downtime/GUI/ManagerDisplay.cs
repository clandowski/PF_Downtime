using System;
using System.Windows.Forms;

namespace PF_Downtime
{
    /// <summary>
    /// Allows user editing of Manager information for this organization
    /// </summary>
    public partial class ManagerDisplay : Form
    {
        /// <summary>
        /// Instantiates this form
        /// </summary>
        public ManagerDisplay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populates information to the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerDisplay_Load(object sender, EventArgs e)
        {
            PopulateManagerCombo();
            LoadManagerData();
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
        /// Loads manager data into textboxes
        /// </summary>
        private void LoadManagerData()
        {
            Name_Text.Text = Data.Organization.Manager.Name;
            Description_Text.Text = Data.Organization.Manager.Type.Description;
            Skills_Text.Text = Data.Organization.Manager.Type.Skills;
            Notes_Text.Text = Data.Organization.Manager.Notes;
            Manager_Combo.SelectedIndex = (Int32)Data.Organization.Manager.Type.ManagerID;
            GoodsNum.Value = Data.Organization.Manager.GoodsBonus;
            InfNum.Value = Data.Organization.Manager.InfluenceBonus;
            LaborNum.Value = Data.Organization.Manager.LaborBonus;
            MagicNum.Value = Data.Organization.Manager.MagicBonus;
            GPNum.Value = Data.Organization.Manager.GPBonus;
        }

        /// <summary>
        /// Saves user editable information back to the organization manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            Data.Organization.Manager.Name = Name_Text.Text;
            Data.Organization.Manager.Notes = Notes_Text.Text;
            Data.Organization.Manager.Type = (Models.BaseManager)Manager_Combo.SelectedValue;
            int x = 0;
            int.TryParse(GoodsNum.Text, out x);
            Data.Organization.Manager.GoodsBonus = x;
            int.TryParse(InfNum.Text, out x);
            Data.Organization.Manager.InfluenceBonus = x;
            int.TryParse(LaborNum.Text, out x);
            Data.Organization.Manager.LaborBonus = x;
            int.TryParse(MagicNum.Text, out x);
            Data.Organization.Manager.MagicBonus = x;
            int.TryParse(GPNum.Text, out x);
            Data.Organization.Manager.GPBonus = x;
            Close();
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
    }
}
