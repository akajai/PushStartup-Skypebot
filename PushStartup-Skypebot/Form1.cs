using log4net;
using PushStartup_Skypebot.DB;
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
using System.Xml.Serialization;

namespace PushStartup_Skypebot
{
    public partial class Form1 : Form
    {
        public static List<SKYPE4COMLib.Skype> skypeInstanceList = new List<SKYPE4COMLib.Skype>();
        public SKYPE4COMLib.Skype skypeMain;
        public DataSet dataSet = new DataSet();
        public static string tablenameSkypeUSer = "skypeUserTable";
        public static string tablenameMessageTemplate = "MessageTemplateTable";

        private static string tablecampaignreport = ConfigurationManager.AppSettings["TableCampaignReport"];
        Dictionary<string, string> dictionaryMessageTemplate =
        new Dictionary<string, string>();

        private static readonly ILog log = LogManager.GetLogger(
         System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // private static var workbook = ExcelFile.Load();
        private String strAutoReply = ConfigurationManager.AppSettings["AutoReplyMessage"];
        private static ReportList reportList;
        public Form1()
        {
            InitializeComponent();

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
                System.Threading.Thread.Sleep(1000);
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

            LoadMessageTemplates();
            LoadSkypeUsers();
            ReloadReportList();
            // Block to responde to un attended messages

        }
        private void skype_MessageStatus(IChatMessage msg,
                     TChatMessageStatus status)
        {

            if ((status == TChatMessageStatus.cmsReceived))
            {
                //   msg.Chat.SendMessage(ProcessCommand(msg.Body));
                skypeMain.SendMessage(msg.Sender.Handle, ProcessCommand(msg.Body));
                // msg.Seen = true;
            }
            /*if ((status == TChatMessageStatus.cmsRead))
            {
                //   msg.Chat.SendMessage(ProcessCommand(msg.Body));
                skypeMain.SendMessage(msg.FromHandle, ProcessCommand(msg.Body));
                msg.Seen = true;



                // skypeMain.SendMessage(msg.Users)
            }*/

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
                    if (!dictionaryMessageTemplate.TryGetValue(strkey, out botMessage))
                    {
                        botMessage = "Internal Error-- Auto Reply Message";
                    }

                }

            }
            return botMessage;
        }


        public void LoadSkypeUsers()
        {
            try
            {
                int index_skypeuser = 0;
                string delimiter = ",";
                StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["skypeuserFile"]);
                string csv = File.ReadAllText(ConfigurationManager.AppSettings["skypeuserFile"]);
                if (dataSet.Tables[tablenameSkypeUSer] == null)
                {

                    dataSet.Tables.Add(tablenameSkypeUSer);
                    dataSet.Tables[tablenameSkypeUSer].Columns.Add("SL#");
                    dataSet.Tables[tablenameSkypeUSer].Columns.Add("User Name", typeof(string));
                    dataSet.Tables[tablenameSkypeUSer].Columns.Add("Password", typeof(string));
                    dataSet.Tables[tablenameSkypeUSer].Columns.Add("Active", typeof(bool));
                }
                string allData = sr.ReadToEnd();
                string[] rows = allData.Split("\r".ToCharArray());

                foreach (string r in rows)
                {
                    if (index_skypeuser > 0)
                    {
                        string[] items = r.Split(delimiter.ToCharArray());
                        dataSet.Tables[tablenameSkypeUSer].Rows.Add(items);
                    }
                    else
                    {
                        index_skypeuser++;
                    }
                }
                this.dataGridViewSkypeUsers.DataSource = dataSet.Tables[tablenameSkypeUSer].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Load Skype Users.");
                log.Info("Unable to Load Skype Users " + ex.StackTrace);
            }
        }

        public void LoadMessageTemplates()
        {
            try
            {

                string delimiter = ",";

                StreamReader sr = new StreamReader(ConfigurationManager.AppSettings["ActiveMessageTemplate"]);
                string csv = File.ReadAllText(ConfigurationManager.AppSettings["ActiveMessageTemplate"]);
                if (dataSet.Tables[tablenameMessageTemplate] == null)
                {

                    dataSet.Tables.Add(tablenameMessageTemplate);
                    dataSet.Tables[tablenameMessageTemplate].Columns.Add("SL#", typeof(int));
                    dataSet.Tables[tablenameMessageTemplate].Columns.Add("Contact Messages", typeof(String));
                    dataSet.Tables[tablenameMessageTemplate].Columns.Add("Auto Replies", typeof(String));
                    dataSet.Tables[tablenameMessageTemplate].Columns.Add("Active", typeof(bool));
                    string allData = sr.ReadToEnd();
                    string[] rows = allData.Split("\r".ToCharArray());
                    int index_message = 0;
                    foreach (string r in rows)
                    {
                        if (index_message > 0)
                        {
                            string[] items = r.Split(delimiter.ToCharArray());
                            if (items.Length > 3)
                            {
                                dataSet.Tables[tablenameMessageTemplate].Rows.Add(items);
                                if (dictionaryMessageTemplate.ContainsKey(items[1].ToString()) == false)
                                    dictionaryMessageTemplate.Add(items[1].ToString(), items[2].ToString());
                            }
                        }
                        else
                        {
                            index_message++;
                        }
                    }
                }
                this.dataGridViewMessages.DataSource = dataSet.Tables[tablenameMessageTemplate].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Load Message Template.");
                log.Info("Unable to Load Message Template " + ex.StackTrace);
            }

        }
    
       

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControlMain.SelectedIndex == 3)//your specific tabname
            {
                // LoadSkypeUsers();
                // your stuff
            }
            else if (tabControlMain.SelectedIndex == 1)
            {
                // LoadMessageTemplates();
            }
            else if (tabControlMain.SelectedIndex == 2)
            {
                ReloadReportList();


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

            Campaign campaign = new Campaign();
            campaign.ShowDialog();

            if (campaign.DialogResult == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                Command co = new Command();
                String cmdMessage = ConfigurationManager.AppSettings["AddContactcommand"];

                checkedListBoxSearchUsers.Items.Clear();
                try
                {
                    ReportListReportName item = new ReportListReportName();
                    item.campaignName = campaign.strCampaignName;
                    item.searchString = textBoxSearchStr.Text;
                    item.UserDetails = new List<ReportListReportNameUserDetails>();
                    foreach (User user in skypeMain.SearchForUsers(textBoxSearchStr.Text))
                    {
                        String userString = String.Format("{0} {1} {2} {3}", user.Handle, user.City, user.Country, user.Birthday);
                        checkedListBoxSearchUsers.Items.Add(userString, CheckState.Checked);
                        
                        skypeMain.SendMessage(user.Handle, richTextBoxWelcomeMessage.Text);
                        co.Command = String.Format(cmdMessage, user.Handle);
                        skypeMain.SendCommand(co);
                        user.BuddyStatus = TBuddyStatus.budPendingAuthorization;
                        ReportListReportNameUserDetails userdetails = new ReportListReportNameUserDetails();
                        userdetails.Message = richTextBoxWelcomeMessage.Text;
                        userdetails.userhandle = user.Handle;
                        userdetails.timestamp = DateTime.Now.ToString();
                        item.UserDetails.Add(userdetails);
                    }

                    AddtoReportList(item);
                    listBoxReports.Items.Add(campaign.strCampaignName);

                    this.dataGridViewReports.DataSource = dataSet.Tables[tablecampaignreport].DefaultView;
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Contacts Completed SucessFully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Search");
                    log.Info("Exception in buttonSkypeSearch_Click " + ex.StackTrace);
                }
            }
           ;
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
                skypeMain.SendMessage(rows[0], richTextBoxWelcomeMessage.Text);
            }
            System.Threading.Thread.Sleep(1000);
            this.Cursor = Cursors.Default;
            MessageBox.Show("Welcome Message Send SucessFully");
        }

        private void buttonAddContacts_Click(object sender, EventArgs e)
        {
            //if (checkedListBoxSearchUsers.Items.Count == 0)
            //{
            //    MessageBox.Show("No Skype user To Add to contacts");
            //}
            this.Cursor = Cursors.WaitCursor;
            Command co = new Command();

            String cmdMessage = ConfigurationManager.AppSettings["AddContactcommand"];
            foreach (object itemChecked in checkedListBoxSearchUsers.CheckedItems)
            {
                string[] rows = itemChecked.ToString().Split(" ".ToCharArray());
                co.Command = String.Format(cmdMessage, rows[0]);
                skypeMain.SendCommand(co);
                skypeMain.User[rows[0]].BuddyStatus = TBuddyStatus.budPendingAuthorization;
            }
            System.Threading.Thread.Sleep(1000);
            this.Cursor = Cursors.Default;

            MessageBox.Show("Contacts Added SucessFully");
        }
        private void DataTabletoCSV(DataTable dataTable, String strFilePath, string strHeader)
        {
            File.WriteAllText(strFilePath, strHeader + "\n");
            foreach (DataRow row in dataTable.Rows)
            {
                String strrow = "";
                foreach (Object str in row.ItemArray)
                {
                    strrow += str + ",";

                }
                strrow.Remove(strrow.Length - 1);
                strrow += "\n";
                File.AppendAllText(strFilePath, strrow);
            }

        }
        private void CampaignToCSV(DataTable dataTable, String strFilePath, string strHeader)
        {
            File.WriteAllText(strFilePath, strHeader + "\n");
            foreach (DataRow row in dataTable.Rows)
            {
                String strrow = "";
                foreach (Object str in row.ItemArray)
                {
                    strrow += str + ",";

                }
                strrow.Remove(strrow.Length - 1);
                strrow += "\n";
                File.AppendAllText(strFilePath, strrow);
            }

        }

        //Problem with overwrite
        private void toolStripButtonskypeusers_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialogcsv.ShowDialog() == DialogResult.OK)
                {
                    File.Delete(saveFileDialogcsv.FileName);
                    DataTabletoCSV(dataSet.Tables[tablenameSkypeUSer], saveFileDialogcsv.FileName, ConfigurationManager.AppSettings["skypeusercsvheader"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Export Skype User Faied");
                log.Info(" Export Skype User Faied " + ex.StackTrace);
            }
        }

        private void toolStripButtonSaveReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialogcsv.ShowDialog() == DialogResult.OK)
                {
                    File.Delete(saveFileDialogcsv.FileName);
                    DataTabletoCSV(dataSet.Tables[tablecampaignreport], saveFileDialogcsv.FileName, ConfigurationManager.AppSettings["CampaignReportheader"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Export Reports Faied");
                log.Info(" Export Reports Faied " + ex.StackTrace);
            }
        }

        private void toolStripButtonSaveMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialogcsv.ShowDialog() == DialogResult.OK)
                {
                    File.Delete(saveFileDialogcsv.FileName);
                    DataTabletoCSV(dataSet.Tables[tablenameMessageTemplate], saveFileDialogcsv.FileName, ConfigurationManager.AppSettings["skypeusercsvheader"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Export Message Faied");
                log.Info(" Export Message " + ex.StackTrace);
            }
        }

        private void listBoxReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ReportListReportNameUserDetails> userDetails = reportList.ReportName[listBoxReports.SelectedIndex].UserDetails;
            LoadReportsGrid(userDetails);
        }
        private void AddtoReportList(ReportListReportName reportitem)
        {
            reportList.ReportName.Add(reportitem);
            String strPath = ConfigurationManager.AppSettings["Reportlogxml"];
            XmlSerializer serializer = new XmlSerializer(typeof(ReportList));
            StreamWriter streamwriter = new StreamWriter(strPath);
            serializer.Serialize(streamwriter, reportList);
            streamwriter.Close();

        }

        public void ReloadReportList()
        {
            String strPath = ConfigurationManager.AppSettings["Reportlogxml"];
            XmlSerializer serializer = new XmlSerializer(typeof(ReportList));
            if (!File.Exists(strPath))
            {
                StreamWriter streamwriter = new StreamWriter(strPath);
                serializer.Serialize(streamwriter, reportList);
                streamwriter.Close();
            }
            StreamReader reader = new StreamReader(strPath);
            reportList = (ReportList)serializer.Deserialize(reader);
            reader.Close();
            listBoxReports.Items.Clear();
            foreach (ReportListReportName reportName in reportList.ReportName)
            {
                listBoxReports.Items.Add(reportName.campaignName);

            }
            LoadReportsGrid(reportList.ReportName[0].UserDetails);

        }
        /* Loads the Report grid with XML from FIle*/
        public void LoadReportsGrid(List<ReportListReportNameUserDetails> userDetails)
        {
            if (dataSet.Tables[tablecampaignreport] == null)
            {
                dataSet.Tables.Add(tablecampaignreport);
                dataSet.Tables[tablecampaignreport].Columns.Add("User Handle", typeof(String));
                dataSet.Tables[tablecampaignreport].Columns.Add("Message", typeof(String));
                dataSet.Tables[tablecampaignreport].Columns.Add("TimeStamp", typeof(String));

            }
            dataSet.Tables[tablecampaignreport].Rows.Clear();
            foreach (ReportListReportNameUserDetails item in userDetails)
            {

                dataSet.Tables[tablecampaignreport].Rows.Add(new String[] { item.userhandle, item.Message, item.timestamp });
            }
            this.dataGridViewReports.DataSource = dataSet.Tables[tablecampaignreport].DefaultView;
        }
        public void LoadReportsGrid(String[] items)
        {
            string delimiter = ",";

            if (dataSet.Tables[tablecampaignreport] == null)
            {
                dataSet.Tables.Add(tablecampaignreport);
                dataSet.Tables[tablecampaignreport].Columns.Add("userhandle", typeof(String));
                dataSet.Tables[tablecampaignreport].Columns.Add("Message", typeof(String));
                dataSet.Tables[tablecampaignreport].Columns.Add("timestamp", typeof(String));

            }
            else
            {

            }
            this.dataGridViewReports.DataSource = dataSet.Tables[tablecampaignreport].DefaultView;
        }
    }
}
