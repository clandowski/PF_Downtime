using System;
using System.Linq;
using System.Windows.Forms;

namespace PF_Downtime
{
    /// <summary>
    /// Organization Form allows users to edit information about the Organization, its manager, and its settlement.
    /// </summary>
    public partial class Organizaion_frm : Form
    {
        /// <summary>
        /// Instantiates the BusinessLayer object
        /// </summary>
        private Data data = new Data();
        /// <summary>
        /// Instantiates the File_Interface to allow reading and writting to xml files
        /// </summary>
        private File_Interface parser = new File_Interface();

        /// <summary>
        /// Instantiates the form
        /// </summary>
        public Organizaion_frm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load event fills the overview text box and loads the base data into the data object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SummaryDisplay_Load(object sender, EventArgs e)
        {
            data.LoadBaseData();

            FillOverview();
        }

        /// <summary>
        /// Clears all text from the overview listbox and repopulates it with relevent organization info
        /// </summary>
        public void FillOverview()
        {
            Overview_Lst.Items.Clear();
            Overview_Lst.Items.Add($"Organization Overview:  Max GP Mod: {Data.Organization.Managers.Sum(x => x.Org_Earn_GP + x.Earn_GP)}");

            if (Data.Organization.Rooms.Where(x => !Data.Organization.Managers.Any(p => x.ManagerID == p.ID)).Count() > 0)
            {
                Overview_Lst.Items.Add("");
                Overview_Lst.Items.Add("Warning:  You have Rooms with no Manager!");
                Overview_Lst.Items.Add("");
            }
            if (Data.Organization.Teams.Where(x => !Data.Organization.Managers.Any(p => x.ManagerID == p.ID)).Count() > 0)
            {
                Overview_Lst.Items.Add("");
                Overview_Lst.Items.Add("Warning:  You have Teams with no Manager!");
                Overview_Lst.Items.Add("");
            }

            int width = Data.Organization.Managers.Count > 0 ? Math.Max(Data.Organization.Managers.Max(x => x.Name.Length) + 3 + Data.Organization.Managers.Max(x => x.Type.Display.Length), 50) : 50;

            foreach (Models.OrgManager man in Data.Organization.Managers)
            {
                Overview_Lst.Items.Add($"{("__________" + man.Name + " - " +man.Type.Display).ToString().PadRight(width, '_')}");
                if (man.Room_Count > 0) Overview_Lst.Items.Add("Total Rooms:    " + man.Room_Count);
                if (man.Team_Count > 0) Overview_Lst.Items.Add("Total Teams:    " + man.Team_Count);

                Overview_Lst.Items.Add($"Current Resource:  {man.ActiveResource.Name}");
                Overview_Lst.Items.Add($"GP Mod:            {(man.Org_Earn_GP        + man.Earn_GP           ).ToString().PadRight(2)}");
                Overview_Lst.Items.Add($"Goods Mod:         {(man.Org_Earn_Goods     + man.Earn_Goods        ).ToString().PadRight(2)}");
                Overview_Lst.Items.Add($"Influence Mod:     {(man.Org_Earn_Influence + man.Org_Earn_Influence).ToString().PadRight(2)}");
                Overview_Lst.Items.Add($"Labor Mod:         {(man.Org_Earn_Labor     + man.Org_Earn_Labor    ).ToString().PadRight(2)}");
                Overview_Lst.Items.Add($"Magic Mod:         {(man.Org_Earn_Magic     + man.Org_Earn_Magic    ).ToString().PadRight(2)}");

                if (man.ConstructionDaysRemaining != 0 || man.RecruitmentDaysRemaining != 0)
                {
                    Overview_Lst.Items.Add("---Pending Time (Paid Only)---");
                    Overview_Lst.Items.Add("Buildtime:      " + man.ConstructionDaysRemaining);
                    Overview_Lst.Items.Add("Recruittime:    " + man.RecruitmentDaysRemaining);
                }

                if (man.Cost_GP != 0 || man.Cost_Goods != 0 || man.Cost_Influence != 0 || man.Cost_Labor != 0 || man.Cost_Magic != 0)
                {
                    Overview_Lst.Items.Add("---Remaining Costs (Unpaid Only)---");
                    Overview_Lst.Items.Add("Buyout GP Cost: " + man.Cost_GP);
                    Overview_Lst.Items.Add("Goods Cost:     " + man.Cost_Goods);
                    Overview_Lst.Items.Add("Influence Cost: " + man.Cost_Influence);
                    Overview_Lst.Items.Add("Labor Cost:     " + man.Cost_Labor);
                    Overview_Lst.Items.Add("Magic Cost:     " + man.Cost_Magic);
                }
                Overview_Lst.Items.Add("");
            }
            
        }

        /// <summary>
        /// Allows the user to select a file to load and calls the file parser to load it into memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void load_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Properties.Settings.Default.FilePath;
            openFileDialog1.Filter = "ORG files (*.ORG)|*.ORG|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Data.Organization = parser.DeSerializeObject<Models.Organization>(openFileDialog1.FileName);
                Name_Text.Text = Data.Organization.Name;
            }

            FillOverview();
        }

        /// <summary>
        /// Allows the user to save an xml file to their drive representing a there organization 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Properties.Settings.Default.FilePath;
            saveFileDialog1.Filter = "ORG files (*.ORG)|*.ORG|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Data.Organization.Name = Name_Text.Text;
                parser.SerializeObject(Data.Organization, saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Instantiates a TeamDisplay popup to edit team information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Teams_Btn_Click(object sender, EventArgs e)
        {
            Data.Organization.Name = Name_Text.Text;
            TeamDisplay Team = new TeamDisplay(Data.Organization.Teams);
            Team.ShowDialog();

            FillOverview();
        }

        /// <summary>
        /// Instantiates a RoomDisplay object to edit room information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rooms_Btn_Click(object sender, EventArgs e)
        {
            Data.Organization.Name = Name_Text.Text;
            RoomDisplay Room = new RoomDisplay(Data.Organization.Rooms);
            Room.ShowDialog();

            FillOverview();
        }

        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Export_Btn_Click(object sender, EventArgs e)
        {
            //Export to Excel
            MessageBox.Show("Not yet implemented");
        }

        /// <summary>
        /// Instantiates a OrgDisplay object to edit Organization information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Org_Button_Click(object sender, EventArgs e)
        {
            OrgDisplay Org = new OrgDisplay();
            Org.ShowDialog();

            FillOverview();
        }

        /// <summary>
        /// Advances consturction/training for unfinished objects in the organization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void advanceButton_Click(object sender, EventArgs e)
        {
            Data.Organization.AdvanceDays(Int32.Parse(QuickText.Text));
            QuickText.Text = "0";
            FillOverview();
        }

        /// <summary>
        /// Prevent non-numeric entrees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuickText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Marks all rooms and teams in the organization as Paid = true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paid_Button_Click(object sender, EventArgs e)
        {
            Data.Organization.PayAll();
            FillOverview();
        }

        /// <summary>
        /// Marks all rooms and teams in the organization as Paid != true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Unpaid_Button_Click(object sender, EventArgs e)
        {
            Data.Organization.UnPayAll();
            FillOverview();
        }

        private void Man_BTN_Click(object sender, EventArgs e)
        {
            Data.Organization.Name = Name_Text.Text;
            GUI.ManagersDisplay Managers = new GUI.ManagersDisplay(Data.Organization.Managers);
            Managers.ShowDialog();

            FillOverview();
        }
    }
}