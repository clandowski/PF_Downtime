using System;
using System.Windows.Forms;

namespace PF_Downtime
{
    /// <summary>
    /// Allows user to edit Organization information
    /// </summary>
    public partial class OrgDisplay : Form
    {
        /// <summary>
        /// Instantiates
        /// </summary>
        public OrgDisplay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads information to the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrgDisplay_Load(object sender, EventArgs e)
        {
            PopulateLimitCombo();
            PopulateBMCombo();
            PopulateSettlementInfo();

            if (Data.Organization.Parallel)
            {
                ParallelCheck.CheckState = CheckState.Checked;
            }

        }

        /// <summary>
        /// Populates the Settlement combo
        /// </summary>
        private void PopulateLimitCombo()
        {
            Settlement_Combo.DataSource = Data.SettlementList;
            Settlement_Combo.DisplayMember = "Info";
            Settlement_Combo.ValueMember = null;
        }

        /// <summary>
        /// Populates the BlackMarket combo
        /// </summary>
        private void PopulateBMCombo()
        {
            BlackMarketCombo.DataSource = Data.BlackMarketList;
            BlackMarketCombo.DisplayMember = "Info";
            BlackMarketCombo.ValueMember = null;
        }

        /// <summary>
        /// Populates Settlement info to the screen
        /// </summary>
        private void PopulateSettlementInfo()
        {
            Location_Text.Text = Data.Organization.Settlement.Location;
            Settlement_Combo.SelectedIndex = (Int32)Data.Organization.Settlement.Settlement.Limit_ID;
            BlackMarketCombo.SelectedIndex = (Int32)Data.Organization.Settlement.BlackMarket.Limit_ID;
            Notes_Text.Text = Data.Organization.Notes;
        }

        /// <summary>
        /// Shows the manager popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Manager_Button_Click(object sender, EventArgs e)
        {
            ManagerDisplay Manager = new ManagerDisplay();
            Manager.ShowDialog();
        }

        /// <summary>
        /// Saves user editable information back to the organization record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            Data.Organization.Settlement.Location = Location_Text.Text;
            Data.Organization.Settlement.Settlement = (Models.BaseSettlement)Settlement_Combo.SelectedValue;
            Data.Organization.Settlement.BlackMarket = (Models.BaseBlackMarket)BlackMarketCombo.SelectedValue;
            Data.Organization.Settlement.Notes = Notes_Text.Text;
            Data.Organization.Parallel = ParallelCheck.Checked;
            Close();
        }
    }
}
