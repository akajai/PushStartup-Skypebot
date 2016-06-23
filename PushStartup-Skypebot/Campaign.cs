using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushStartup_Skypebot
{
    public partial class Campaign : Form
    {
        public string strCampaignName = "";
        public Campaign()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            strCampaignName = "";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            strCampaignName = textBoxCampaignName.Text;
        }
    }
}
