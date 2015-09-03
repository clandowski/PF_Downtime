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
            Overview_Lst.Items.Add("Organization Overview");
            Overview_Lst.Items.Add("Manager: " + Data.Organization.Manager.Name + " - " + Data.Organization.Manager.Type.Display);
            Overview_Lst.Items.Add("Total Rooms: " + Data.Organization.Rooms.Count());
            Overview_Lst.Items.Add("Total Teams: " + Data.Organization.Teams.Count());

            Overview_Lst.Items.Add("---Current Income (Paid and Days Complete)---");
            Overview_Lst.Items.Add("GP Mod: " + Data.Organization.Earn_GP + " Max: " + Data.Organization.Earn_GP_Max);
            Overview_Lst.Items.Add("Goods Mod: " + Data.Organization.Earn_Goods + " Max: " + Data.Organization.Earn_Goods_Max);
            Overview_Lst.Items.Add("Influence Mod: " + Data.Organization.Earn_Influence + " Max: " + Data.Organization.Earn_Influence_Max);
            Overview_Lst.Items.Add("Labor Mod: " + Data.Organization.Earn_Labor + " Max: " + Data.Organization.Earn_Labor_Max);
            Overview_Lst.Items.Add("Magic Mod: " + Data.Organization.Earn_Magic + " Max: " + Data.Organization.Earn_Magic_Max);
            
            Overview_Lst.Items.Add("---Pending Time (Paid Only)---");
            Overview_Lst.Items.Add("Buildtime: " + Data.Organization.ConstructionDaysRemaining);
            Overview_Lst.Items.Add("Recruittime: " + Data.Organization.RecruitmentDaysRemaining);

            Overview_Lst.Items.Add("---Remaining Costs (Unpaid Only)---");
            Overview_Lst.Items.Add("GP Cost: " + Data.Organization.Cost_GP);
            Overview_Lst.Items.Add("Goods Cost: " + Data.Organization.Cost_Goods);
            Overview_Lst.Items.Add("Influence Cost: " + Data.Organization.Cost_Influence);
            Overview_Lst.Items.Add("Labor Cost: " + Data.Organization.Cost_Labor);
            Overview_Lst.Items.Add("Magic Cost: " + Data.Organization.Cost_Magic);

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
    }
}