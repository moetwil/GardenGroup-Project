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
using System.Xml.Linq;

namespace Garden_Group.UserControls
{
    public partial class TicketOverviewUC : UserControl
    {
        FlowLayoutPanel listBox;
        public TicketOverviewUC()
        {
            listBox = new FlowLayoutPanel();
            InitializeComponent();
            listBox.Width = 250;
            listBox.Height = 100;
            listBox.Margin = new Padding(0,0,0,0);
            listBox.AutoSize = false;
            listBox.Dock = DockStyle.Fill;
            listBox.AutoScroll = true;
            listBox.FlowDirection = FlowDirection.TopDown;
            listBox.WrapContents = false;
            this.Controls.Add(listBox);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Padding = new Padding(0,0,0,0);
        }

        private void TicketOverviewUC_Load(object sender, EventArgs e)
        {

        }
        public void Add(Control c)
        {
            listBox.Controls.Add(c);
            setupAnchors();
        }
        public void Remove(string name)
        {
            listBox.Controls.Remove(listBox.Controls[name]);
            listBox.Controls[name].Dispose();
            setupAnchors();
        }
        public void Clear()
        {
            if (listBox.Controls.Count == 0)
            {
                listBox.Controls.Remove(listBox.Controls[0]);
                listBox.Controls[0].Dispose();
            }
        }

        private void TicketOverviewUC_Layout(object sender, LayoutEventArgs e)
        {
            setupAnchors();
        }
        private void setupAnchors()
        {
            if (listBox.Controls.Count > 0)
            {
                for(int i = 0; i < listBox.Controls.Count; i++)
                {
                    Control control = listBox.Controls[i];
                    if (control.Controls.Count == 0)
                    {
                        control.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                        control.Width = listBox.Width = SystemInformation.VerticalScrollBarWidth;
                    }
                    else
                        control.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                }
            }
        }
    }
}
