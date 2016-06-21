using log4net;
using SKYPE4COMLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushStartup_Skypebot
{
    public partial class Form1 : Form
    {
        public static List<SKYPE4COMLib.Skype> skypeInstanceList = new List<SKYPE4COMLib.Skype>();
        public SKYPE4COMLib.Skype skypeMain;
        public DataSet dataSet = new DataSet();
        public static string tablenameSkypeUSer = "skypeUserTable";
        public static string tablenameMessageTemplate = "MessageTemplateTable";
        Dictionary<string, string> dictionaryMessageTemplate =
        new Dictionary<string, string>();

        private static readonly ILog log = LogManager.GetLogger(
         System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private const string trigger = "msg="; // Say !help
        private const string nick = "BOT";
        private String strAutoReply = ConfigurationManager.AppSettings["AutoReplyMessage"];
        public Form1()
        {
            InitializeComponent();
            LoadMessageTemplates();
            skypeMain = new Skype();

            if (skypeMain.Client.IsRunning)
            {
                log.Info("Skype is running");
                skypeMain.Client.Start(true, true);
                       foreach (IChatMessage msg in skypeMain.MissedMessages)
                       {
                           string handle = msg.Sender.Handle;
                           string message = "This is an auto response message.";
                           //skypeMain.SendMessage(handle, message);
                       }
                       System.Threading.Thread.Sleep(2000);
                skypeMain.MessageStatus +=
                 new _ISkypeEvents_MessageStatusEventHandler(skype_MessageStatus);

            }
            else
            {
                skypeMain.Client.Start(false, true);
                //  skypeMain.Application.

                log.Info("Skype is not running. Please login to Skype");
                return;
            }
            skypeMain.Attach(skypeMain.Protocol, true);
            // Block to responde to un attended messages

        }
        private void skype_MessageStatus(ChatMessage msg,
                     TChatMessageStatus status)
        {
            if (status == TChatMessageStatus.cmsReceived)
            {
                // string command = msg.Body.Remove(0, trigger.Length).ToLower();
                //skypeMain.SendMessage(msg.Sender.Handle, nick +
                //   " Says: " + ProcessCommand(command));

                skypeMain.SendMessage(msg.Sender.Handle, ProcessCommand(msg.Body));
            }

            // Proceed only if the incoming message is a trigger
            /*- if (msg.Body.IndexOf(trigger) == 0)
             {
                 // Remove trigger string and make lower case
                 string command = msg.Body.Remove(0, trigger.Length).ToLower();

                 // Send processed message back to skype chat window
                 skypeMain.SendMessage(msg.Sender.Handle, nick +
                       " Says: " + ProcessCommand(command));
             }   */
        }

        private string ProcessCommand(string struserMessage)
        {
            String botMessage = strAutoReply;

            if (dictionaryMessageTemplate.ContainsKey(struserMessage))
            {
                botMessage = dictionaryMessageTemplate[struserMessage];
            }

            foreach (String strkey in dictionaryMessageTemplate.Keys)
            {
                if (strkey.ToLower().Contains(struserMessage.ToLower()))
                {
                    if (!dictionaryMessageTemplate.TryGetValue(struserMessage, out botMessage))
                    {
                        botMessage = "Internal Error-- Auto Reply Message";
                    }

                }

            }
            return botMessage;
        }


        public void LoadSkypeUsers()
        {

            string delimiter = ",";


            StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["skypeuserFile"]);
            string csv = File.ReadAllText(ConfigurationManager.AppSettings["skypeuserFile"]);
            if (dataSet.Tables[tablenameSkypeUSer] == null)
            {

                dataSet.Tables.Add(tablenameSkypeUSer);

                dataSet.Tables[tablenameSkypeUSer].Columns.Add("SL#");
                dataSet.Tables[tablenameSkypeUSer].Columns.Add("User Name");
                dataSet.Tables[tablenameSkypeUSer].Columns.Add("Password");
                dataSet.Tables[tablenameSkypeUSer].Columns.Add("Active");
                // dataset.Tables[tablename].Columns.Add("Date Filled");
            }
            string allData = sr.ReadToEnd();
            string[] rows = allData.Split("\r".ToCharArray());

            foreach (string r in rows)
            {
                string[] items = r.Split(delimiter.ToCharArray());
                dataSet.Tables[tablenameSkypeUSer].Rows.Add(items);
            }
            this.dataGridViewSkypeUsers.DataSource = dataSet.Tables[0].DefaultView;

        }

        public void LoadMessageTemplates()
        {

            string delimiter = ",";

            StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["ActiveMessageTemplate"]);
            string csv = File.ReadAllText(ConfigurationManager.AppSettings["ActiveMessageTemplate"]);
            if (dataSet.Tables[tablenameMessageTemplate] == null)
            {

                dataSet.Tables.Add(tablenameMessageTemplate);

                dataSet.Tables[tablenameMessageTemplate].Columns.Add("SL#");
                dataSet.Tables[tablenameMessageTemplate].Columns.Add("Contact Messages");
                dataSet.Tables[tablenameMessageTemplate].Columns.Add("Auto Replies");
                dataSet.Tables[tablenameMessageTemplate].Columns.Add("Active");
                // dataset.Tables[tablename].Columns.Add("Date Filled");

                string allData = sr.ReadToEnd();
                string[] rows = allData.Split("\r".ToCharArray());

                foreach (string r in rows)
                {
                    string[] items = r.Split(delimiter.ToCharArray());
                    if (items.Length > 3)
                    {
                        dataSet.Tables[tablenameMessageTemplate].Rows.Add(items);
                        if (dictionaryMessageTemplate.ContainsKey(items[1].ToString()) == false)
                            dictionaryMessageTemplate.Add(items[1].ToString(), items[2].ToString());
                    }
                }
            }
            this.dataGridView1.DataSource = dataSet.Tables[0].DefaultView;

        }
        public void LoadReports()
        {
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControlMain.SelectedIndex == 4)//your specific tabname
            {
                LoadSkypeUsers();
                // your stuff
            }
            else if (tabControlMain.SelectedIndex == 2)
            {
                LoadMessageTemplates();
            }
            else if (tabControlMain.SelectedIndex == 3)
            {
                listBoxReports.Items.Clear();
                listBoxReports.Items.AddRange(ConfigurationManager.AppSettings["Reports"].Split(new char[] { ';' }));

            }
            //listBoxReports.Items.Add(new List<string>(ConfigurationManager.AppSettings["Reports"].Split(new char[] { ';' })).ToList<String>());
        }

        private void buttonSkypeSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearchStr.Text.Length <= 0)
            {
                MessageBox.Show("Search string cannot be blank");
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            try { 
            foreach (User user in skypeMain.SearchForUsers(textBoxSearchStr.Text))
            {


                String userString = String.Format("{0} {1} {2} {3} {4}", user.Handle, user.City, user.Country, user.Timezone, user.Birthday);
                checkedListBoxSearchUsers.Items.Add(userString, CheckState.Checked);
            }
            }catch(Exception ex)
            {
                log.Info("Exception in buttonSkypeSearch_Click " + ex.StackTrace);
            }
            this.Cursor = Cursors.Default;
        }

        private void toolStripButtonlogin_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in dataSet.Tables[tablenameSkypeUSer].Rows)
            {
                if (row[3].ToString() == "TRUE")
                {
                    System.Console.WriteLine(row[1] + " - " + row[2]);
                    Skype skype = new Skype();
                    SKYPE4COMLib.Profile profile = new Profile();
                    SKYPE4COMLib.User user = new User();
                    skype.Client.Start(false, false);

                }
            }

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (checkedListBoxSearchUsers.Items.Count == 0)
            {
                MessageBox.Show("No Skype user listed to Send Message");
            }
            this.Cursor = Cursors.WaitCursor;
            foreach (object itemChecked in checkedListBoxSearchUsers.CheckedItems)
            {

                string[] rows = itemChecked.ToString().Split(" ".ToCharArray());
                // string comapnyName = castedItem["CompanyName"];
                // int? id = castedItem["ID"];
                skypeMain.SendMessage(rows[0], richTextBoxWelcomeMessage.Text);
            }
            System.Threading.Thread.Sleep(1000);
            this.Cursor = Cursors.Default;
        }

        private void buttonAddContacts_Click(object sender, EventArgs e)
        {
            if (checkedListBoxSearchUsers.Items.Count == 0)
            {
                MessageBox.Show("No Skype user To Add to contacts");
            }
            this.Cursor = Cursors.WaitCursor;
            foreach (object itemChecked in checkedListBoxSearchUsers.CheckedItems)
            {

                string[] rows = itemChecked.ToString().Split(" ".ToCharArray());
                // string comapnyName = castedItem["CompanyName"];
                // int? id = castedItem["ID"];
                //  skypeMain.UsersWaitingAuthorization
                skypeMain.SendMessage(rows[0], richTextBoxWelcomeMessage.Text);
                //skypeMain.
            }
            System.Threading.Thread.Sleep(1000);
            this.Cursor = Cursors.Default;
        }
    }
}
