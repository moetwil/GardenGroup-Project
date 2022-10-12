using Garden_Group.Forms;
using GardenGroupLogica;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garden_Group.UserControls
{
    public partial class MenuStripUC : UserControl
    {
        private User user;
        private Form oldForm;
        public MenuStripUC(User user, Form form)
        {
            this.user = user;
            this.oldForm = form;
            InitializeComponent();
        }

        private void MenuStripUC_Load(object sender, EventArgs e)
        {
            // Get role of the logged in user
            /*RoleService roleService = new RoleService();
            this.user.JobInfo.Role = roleService.GetRoleById(this.user.JobInfo.RoleId);*/
            LoadMenuItems(this.user.JobInfo);
            
            // Add logout button to the menu
            this.menuStrip.Items.Add(new ToolStripMenuItem("Logout") { Tag = new LoginForm() });
        }

        // Load the correct menu
        private void LoadMenuItems(JobInfo jobInfo)
        {
            switch (jobInfo.Role.ToString())
            {
                case "Employee":
                    LoadEmployeeMenu();
                    break;
                case "ServiceDeskEmployee":
                    LoadServiceDeskEmployeeMenu();
                    break;
            }
        }

        // Create Employee menu items
        private void LoadEmployeeMenu()
        {
            // Create menu items for the employee
            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();
            menuItems.Add(new ToolStripMenuItem("Dashboard") { Tag = new DashboardForm(this.user)});
            menuItems.Add(new ToolStripMenuItem("Ticket overview") { Tag = new TicketOverviewForm(this.user) });
            menuItems.Add(new ToolStripMenuItem("Add ticket") { Tag = new TicketAddingForm(this.user) });

            // Add all the menu items to the menuStrip
            foreach (ToolStripMenuItem item in menuItems)
                menuStrip.Items.Add(item);
        }

        // Create ServiceDeskEmployee menu items
        private void LoadServiceDeskEmployeeMenu()
        {
            // Create menu items for the ServiceDeskEmployee
            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();
            menuItems.Add(new ToolStripMenuItem("Dashboard") { Tag = new DashboardForm(this.user) });
            menuItems.Add(new ToolStripMenuItem("Incident Management") { Tag = new IncidentManagementForm(this.user) });
            menuItems.Add(new ToolStripMenuItem("User Management") { Tag = new UserManagementForm(this.user) });
            menuItems.Add(new ToolStripMenuItem("Create User") { Tag = new CreateUserForm(this.user) });

            // Add all the menu items to the menuStrip
            foreach (ToolStripMenuItem item in menuItems)
                menuStrip.Items.Add(item);
        }
        
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clickedItem = e.ClickedItem;
            OpenNewForm((Form)clickedItem.Tag);
        }

        // Open new form methods
        private void OpenNewForm(Form form)
        {
            this.oldForm.Hide();
            form.ShowDialog();
            this.oldForm.Close();
        }

        
    }
}
