using System;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.ComponentModel;
using EmpireGUI.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
//https://stackoverflow.com/questions/1862590/how-to-update-gui-with-backgroundworker <<< using background worker to continually update in background.

namespace EmpireGUI
{

    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        //Import to hide the blinking cursor from the textbox.
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);


        private List<Control> DrawnStagerControls = new List<Control>();
        private List<Control> DrawnListenerControls = new List<Control>();
        private List<Control> DrawnModuleControls = new List<Control>();
        private List<Control> DrawnAgentControls = new List<Control>();
        private Dictionary<string, List<string>> agentConsoles = new Dictionary<string, List<string>>();
        private List<string> Agents = new List<string>();
        public frmMain()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Implement background workers for common functionality.
            lstListeners.Items.Clear();

            //Not hiding cursor correctly, por que?
            HideCaret(txtConsoleLog.Handle);
            getListeners();
            getModules();
            syncCreds();
            getStagers();
            getAgents();
            //Load Modules and import them into the treeModules TreeView.
            //string[] words = { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla lorem mi, laoreet nec feugiat at, blandit vehicula ex. Donec sit amet sem finibus nibh gravida tincidunt ac eget ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla lorem mi, laoreet nec feugiat at, blandit vehicula ex. Donec sit amet sem finibus nibh gravida tincidunt ac eget ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla lorem mi, laoreet nec feugiat at, blandit vehicula ex. Donec sit amet sem finibus nibh gravida tincidunt ac eget ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla lorem mi, laoreet nec feugiat at, blandit vehicula ex. Donec sit amet sem finibus nibh gravida tincidunt ac eget ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla lorem mi, laoreet nec feugiat at, blandit vehicula ex. Donec sit amet sem finibus nibh gravida tincidunt ac eget ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla lorem mi, laoreet nec feugiat at, blandit vehicula ex. Donec sit amet sem finibus nibh gravida tincidunt ac eget ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla lorem mi, laoreet nec feugiat at, blandit vehicula ex. Donec sit amet sem finibus nibh gravida tincidunt ac eget ante." };
            //foreach (string word in words)
            //{
            //    txtConsoleLog.AppendText(word + "\r\n");
            //}
        }
        private void AddModuleToTree(List<string> modules)
        {
            TreeNode lastNode = null;
            string subPathAgg;
            char pathSeparator = '/';
            foreach (string path in modules)
            {
                subPathAgg = string.Empty;
                foreach (string subPath in path.Split(pathSeparator))
                {
                    subPathAgg += subPath + pathSeparator;
                    TreeNode[] nodes = treeModules.Nodes.Find(subPathAgg, true);
                    if (nodes.Length == 0)
                        if (lastNode == null)
                            lastNode = treeModules.Nodes.Add(subPathAgg, subPath);
                        else
                            lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                    else
                        lastNode = nodes[0];
                }
            }
        }
        private void lstListeners_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtListID.Visible = true;
            lblListID.Visible = true;
            lblListenerID.Visible = true;
            lblListCat.Visible = true;
            lblListenerCategory.Visible = true;
            lblModType.Visible = true;
            lblModuleType.Visible = true;
            txtModTypeValue.Visible = true;
            txtListCatVal.Visible = true;

            //Get Listbox Tokens
            try
            {
                JObject token = JObject.Parse(Globals.listenersJSON);
                JObject match = token["listeners"].Values<JObject>().Where(m => m["name"].Value<string>() == lstListeners.SelectedItem.ToString()).FirstOrDefault();
                JToken options = match["options"];
                txtListID.Text = match["ID"].ToString();
                txtModTypeValue.Text = match["module"].ToString();
                txtListCatVal.Text = match["listener_category"].ToString();
                Dictionary<string, ModuleOptions.Options> listopts = new Dictionary<string, ModuleOptions.Options>();
                if (options != null)
                {
                    foreach (var option in options)
                    {
                        string optionName = option.Path.Replace(match.Path + ".options.", "");
                        JObject JSONOptions = JObject.Parse(options.SelectToken(optionName).ToString());


                        // Creates an Options object based on the current object values.
                        ModuleOptions.Options listenerOptions = new ModuleOptions.Options(JSONOptions["Description"].ToString(), JSONOptions["Value"].ToString(), JSONOptions["Required"].ToString());

                        // Add this option to the dictionary (OptionName, Options Object)
                        listopts.Add(optionName, listenerOptions);
                    }
                }
                drawListenerOptionTextBoxes(listopts, false);
            }
            catch (TimeoutException)
            {
                displayCustomAlert("Could not connect to Empire Server. Check to make sure it's still reachable!");
            }
            catch (NullReferenceException)
            {
                //Do nothing. Fail silently (for now)
            }

            // This isn't too slow, but it could get slower for bigger objects. Need to do more testing, and maybe re-write this to update in the same way the modules update.
            // Use C# reflection in order to enumerate the Module Options.
            // Replaced with a faster JSON implementation, keeping for information purposes.
            /**try { 
                foreach (var prop in find.options.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    try
                    {
                        if (prop.GetValue(find.options).ToString() != "")
                        {
                            strproperties += prop.Name;
                            properties.Add(prop.Name);
                        }
                    }
                    catch { }
                }
                drawListenerOptionTextBoxes(find, properties);
            }
            catch
            {
                Console.WriteLine("Hello from Error Handling");
            }
            **/
        }
        private void treeModules_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //var find = Globals.modulesList.modules.FirstOrDefault(x => x.Name == treeModules.SelectedNode.FullPath.ToString());
            //Need to update this to a JSON check (might be quicker?)
            var find = new Modules.Module();
            treeModules.PathSeparator = @"/";
            try
            {
                find = Globals.modulesList.modules.FirstOrDefault(x => x.Name == treeModules.SelectedNode.FullPath);
                txtModuleName.Text = find.Name;
            }
            catch
            {
                // 
            }
            //Draw and populate Textboxes for Module Options.
            //Fill Author Textbox
            try
            {
                int Count = 0;
                string Authors = "";
                if (find.Author.Count == 1)
                {
                    Authors = find.Author[0];
                }
                else if (find.Author.Count > 1)
                {
                    foreach (string Author in find.Author)
                    {
                        Count += 1;
                        if (Count >= find.Author.Count)
                        {
                            Authors += Author;
                        }
                        else
                            Authors += Author + ",";
                    }
                }
                else if (find.Author.Count == 0)
                    Authors = "";
                txtAuthor.Text = Authors;
            }
            catch
            {
                //nothing because a nullreferenceexception will catch when selecting non final nodes.
            }
            //Fill Module Description TextBox
            try { txtDescription.Text = find.Description.ToString(); }
            catch { txtDescription.Text = ""; }

            //Fill Background TextBox
            try { txtBackground.Text = find.Background.ToString(); }
            catch { txtBackground.Text = ""; }

            //Fill OutputExtension TextBox
            try { txtOutputExtension.Text = find.OutputExtension.ToString(); }
            catch { txtOutputExtension.Text = ""; }

            //Fill NeedsAdmin TextBox
            try { txtNeedsAdmin.Text = find.NeedsAdmin.ToString(); }
            catch { txtNeedsAdmin.Text = ""; }

            //Fill OpSecSafe TextBox
            try { txtOpSecSafe.Text = find.OpsecSafe.ToString(); }
            catch { txtOpSecSafe.Text = ""; }

            //Fill Comments TextBox
            try
            {
                string comments = "";
                foreach (string comment in find.Comments)
                {
                    comments += comment + "\r\n";
                }
                txtComments.Text = comments;
            }
            catch { txtComments.Text = ""; }

            //Fill Language TextBox
            try { txtLanguage.Text = find.Language.ToString(); }
            catch { txtLanguage.Text = ""; }

            //Fill Minimum Language TextBox
            try { txtMinLangReq.Text = find.MinLanguageVersion.ToString(); }
            catch { txtMinLangReq.Text = ""; }

            //Fill AgentName ComboBox
            //FILL ME

            /** OLD CODE Keeping for reference in case I need to look at reflection again.
             * 
             * 
             * 
                        //Enumerate Properties from the selected object.
                        List<string> properties = new List<string>();
                        string strproperties = "";
                        if (find != null)
                        {
                            foreach (var prop in find.options.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
                            {
                                try
                                {
                                    if (prop.GetValue(find.options).ToString() != "")
                                    {
                                        strproperties += prop.Name;
                                        properties.Add(prop.Name);
                                    }
                                }
                                catch { }
                            }
                        }
                        //Draw TextBoxes based on what properties are found.

                        if (find != null)
                        {
                            drawModuleOptionTextBoxes(find, properties);
                        }
                        //lblLoading.Visible = false;
                        //spnLoading.Visible = false;         
             * 
             * 
             * **/


            //Gets a list of options for each module.
            try
            {
                JObject token = JObject.Parse(Globals.modulesJSON);
                JObject match = token["modules"].Values<JObject>().Where(m => m["Name"].Value<string>() == treeModules.SelectedNode.FullPath.ToString()).FirstOrDefault();
                JToken options = match["options"];
                Dictionary<string, ModuleOptions.Options> modopts = new Dictionary<string, ModuleOptions.Options>();
                if (options != null)
                {
                    foreach (var option in options)
                    {
                        String optionName = option.Path.Replace(match.Path + ".options.", "");
                        JObject JSONOptions = JObject.Parse(options.SelectToken(optionName).ToString());

                        //Creates an Options object based on the current object values.
                        ModuleOptions.Options moduleOptions = new ModuleOptions.Options(JSONOptions["Description"].ToString(), JSONOptions["Value"].ToString(), JSONOptions["Required"].ToString());

                        //Add this option to the dictionary (OptionName, Options Object)
                        modopts.Add(optionName, moduleOptions);
                    }
                }
                drawModuleOptionTextBoxes(modopts);
            }
            catch (TimeoutException)
            {
                displayCustomAlert("Could not connect to Empire Server. Check to make sure it's still reachable!");
            }
            catch (NullReferenceException)
            {
                //Do nothing. Fail silently (for now)
            }

        }
        private void drawListenerOptionTextBoxes(Dictionary<string, ModuleOptions.Options> options, bool newlistener)
        {
            int i = 0;
            if (DrawnListenerControls.Count != 0)
            {
                foreach (Control control in DrawnListenerControls)
                {
                    control.Dispose();
                }
                DrawnListenerControls.Clear();

            }
            foreach (KeyValuePair<string, ModuleOptions.Options> pair in options)
            {
                int ycoord;
                if (newlistener == true)
                {
                    ycoord = 0 + (i * 29);
                }
                else
                {
                    ycoord = 95 + (i * 29);
                }
                MetroLabel lbl = new MetroLabel();
                MetroLabel lbldesc = new MetroLabel();
                MetroTextBox tbval = new MetroTextBox();
                lbl.AutoSize = true;
                lbl.Height = 19;
                lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
                lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
                lbl.Location = new Point(3, ycoord);
                lbl.Name = "lblListOpt" + pair.Key;
                lbl.Text = pair.Key;
                //Generate Text Box Properties
                lbldesc.Text = pair.Value.optionDescription;
                lbldesc.Name = "txtListOpt" + pair.Key;
                lbldesc.Width = 312;
                lbldesc.Height = 23;
                lbldesc.Theme = MetroFramework.MetroThemeStyle.Dark;
                lbldesc.Location = new Point(155, ycoord);
                // This check is included because the API automagically defaults to using https:// which casues issues if you don't submit CertPath.
                // This replaces the https:// with http:// in order to make it easier for the users generating http listeners.
                // Will this cause issues with other listeners? Needs more testing. - Deosn't seem to cause any issues with other listeners.
                if (newlistener == true && pair.Value.ToString().Contains("https://") && string.IsNullOrEmpty(options["CertPath"].ToString()))
                    tbval.Text = pair.Value.optionValue.Replace("https://", "http://");
                else
                    tbval.Text = pair.Value.optionValue;
                tbval.Name = "tbOptVal" + pair.Key;
                tbval.Width = 182;
                tbval.Height = 23;
                tbval.Theme = MetroFramework.MetroThemeStyle.Dark;
                tbval.Location = new Point(471, ycoord);
                ctrlListeners.Controls.Add(lbldesc);
                ctrlListeners.Controls.Add(tbval);
                ctrlListeners.Controls.Add(lbl);
                i++;
                DrawnListenerControls.Add(lbldesc);
                DrawnListenerControls.Add(tbval);
                DrawnListenerControls.Add(lbl);
            }
        }
        private void drawStagerOptionTextBoxes(Dictionary<string,ModuleOptions.Options> options)
        {
            int i = 1;
            if (DrawnStagerControls.Count != 0)
            {
                foreach (Control control in DrawnStagerControls)
                {
                    control.Dispose();
                }
                DrawnStagerControls.Clear();

            }
            foreach (KeyValuePair<string, ModuleOptions.Options> pair in options)
            {
                int ycoord = 22 + (i * 29);
                if (pair.Key == "Listener")
                {
                    MetroLabel lbl = new MetroLabel();
                    MetroComboBox cb = new MetroComboBox();
                    lbl.AutoSize = true;
                    lbl.Height = 19;
                    lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
                    lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
                    lbl.Location = new Point(436, ycoord);
                    lbl.Name = "lblGenStag" + pair.Key;
                    lbl.Text = pair.Key;
                    // This check is included because the API automagically defaults to using https:// which casues issues if you don't submit CertPath.
                    // This replaces the https:// with http:// in order to make it easier for the users generating http listeners.
                    // Will this cause issues with other listeners? Needs more testing. - Deosn't seem to cause any issues with other listeners.
                    cb.Name = "cbGenStag" + pair.Key;
                    cb.Width = 182;
                    foreach( var listener in Globals.activelisteners.listeners)
                    {
                        cb.Items.Add(listener.name);
                    }
                    cb.Height = 23;
                    cb.Theme = MetroFramework.MetroThemeStyle.Dark;
                    cb.Location = new Point(600, ycoord);
                    tabGenerateStager.Controls.Add(cb);
                    tabGenerateStager.Controls.Add(lbl);
                    DrawnStagerControls.Add(cb);
                    DrawnStagerControls.Add(lbl);
                    i++;
                }
                else
                {
                    MetroLabel lbl = new MetroLabel();
                    MetroTextBox tbval = new MetroTextBox();
                    lbl.AutoSize = true;
                    lbl.Height = 19;
                    lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
                    lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
                    lbl.Location = new Point(436, ycoord);
                    lbl.Name = "lblGenStag" + pair.Key;
                    lbl.Text = pair.Key;
                    // This check is included because the API automagically defaults to using https:// which casues issues if you don't submit CertPath.
                    // This replaces the https:// with http:// in order to make it easier for the users generating http listeners.
                    // Will this cause issues with other listeners? Needs more testing. - Deosn't seem to cause any issues with other listeners.
                    tbval.Name = "txtGenStag" + pair.Key;
                    tbval.Width = 182;
                    tbval.Text = pair.Value.optionValue;
                    tbval.Height = 23;
                    tbval.Theme = MetroFramework.MetroThemeStyle.Dark;
                    tbval.Location = new Point(600, ycoord);
                    tabGenerateStager.Controls.Add(tbval);
                    tabGenerateStager.Controls.Add(lbl);
                    i++;
                    DrawnStagerControls.Add(tbval);
                    DrawnStagerControls.Add(lbl);
                }
            }
        }
        private void drawModuleOptionTextBoxes(Dictionary<string, ModuleOptions.Options> options)
        {
            if (DrawnModuleControls.Count != 0)
            {
                foreach (Control control in DrawnModuleControls)
                {
                    control.Dispose();
                }
                DrawnModuleControls.Clear();

            }

            List<string> properties = new List<string>();
            List<string> drawnControls = new List<string>();
            int i = 0;
            int j = 0;
            foreach (KeyValuePair<String, ModuleOptions.Options> pair in options)
            {
                int ycoord = 10 + (i * 29);
                int ycoord2 = 10 + (j * 29);
                int xcoordTB = 114;
                int xcoordLBL = 17;
                //TODO:
                //Add Listener and 
                if (pair.Key.ToLower() == "agent")
                {

                    MetroLabel lbl = new MetroLabel();
                    MetroComboBox cb = new MetroComboBox();
                    cb.Name = "cbModOpt" + pair.Key;
                    cb.Width = 127;
                    cb.Height = 23;
                    cb.Theme = MetroFramework.MetroThemeStyle.Dark;
                    cb.Location = new Point(xcoordTB, ycoord);
                    cb.Text = pair.Value.optionValue;
                    foreach (string agent in Globals.Agents)
                    {
                        cb.Items.Add(agent);
                    }
                    //Generate Label Properties
                    lbl.Width = 93;
                    lbl.Height = 19;
                    lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
                    lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
                    lbl.Location = new Point(xcoordLBL, ycoord);
                    lbl.Name = "lblModOpt" + pair.Key;
                    lbl.Text = pair.Key;
                    DrawnModuleControls.Add(lbl);
                    DrawnModuleControls.Add(cb);
                    pnlModuleOptions.Controls.Add(cb);
                    pnlModuleOptions.Controls.Add(lbl);
                    i++;
                }
                else
                {
                    MetroTextBox tb = new MetroTextBox();
                    MetroLabel lbl = new MetroLabel();
                    if (options.Count() >= 12)
                    {
                        if (i > options.Count() / 2)
                        {
                            xcoordLBL = 324;
                            xcoordTB = 421;
                            ycoord = ycoord2;
                            j++;
                        }
                    }

                    //Generate Label Properties
                    lbl.Width = 93;
                    lbl.Height = 19;
                    lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
                    lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
                    lbl.Location = new Point(xcoordLBL, ycoord);
                    lbl.Name = "lblModOpt" + pair.Key;
                    lbl.Text = pair.Key;

                    //Generate Text Box Properties
                    tb.Name = "txtModOpt" + pair.Key;
                    tb.Width = 127;
                    tb.Height = 23;
                    tb.Theme = MetroFramework.MetroThemeStyle.Dark;
                    tb.Location = new Point(xcoordTB, ycoord);
                    tb.Text = pair.Value.optionValue;
                    i++;
                    DrawnModuleControls.Add(lbl);
                    DrawnModuleControls.Add(tb);
                    pnlModuleOptions.Controls.Add(tb);
                    pnlModuleOptions.Controls.Add(lbl);

                }
            }
        }
        private void syncCreds()
        {
            dgCredentials.Rows.Clear();
            dgCredentials.Refresh();
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/creds?token=" + Globals.apitoken;

            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                //This may cause security concerns, might need to find a way to obfuscate this (although they're being stored cleartext in the app anyways?
                Globals.credsJSON = submitJSONRequest(uri, "", "GET");

                Globals.credsList = JsonConvert.DeserializeObject<Credential.RootObject>(Globals.credsJSON);
                foreach (var cred in Globals.credsList.creds)
                {
                    //DataGridViewRow row = (DataGridViewRow)dgCredential;
                    string[] row = new string[] { cred.ID.ToString(), cred.credtype, cred.domain, cred.username, cred.host, cred.password };
                    dgCredentials.Rows.Add(row);
                }
            }
            catch (Exception error)
            {
                displayCustomAlert(error.ToString());
            }
        }
        private void getListeners()
        {
            lstListeners.Items.Clear();
            cmbListenerSelect.Items.Clear();
            string[] listenerTypes = { "dbx", "http", "http_com", "http_foreign", "http_hop", "http_mapi", "meterpreter" };
            //EmpireAPI Feature Request: Endpoint to provide what listeners are available.
            try
            {
                string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/listeners?token=" + Globals.apitoken;
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                Globals.listenersJSON = submitJSONRequest(uri, "", "GET");

                Globals.activelisteners = JsonConvert.DeserializeObject<listeners.RootObject>(Globals.listenersJSON);
                foreach (var subject in Globals.activelisteners.listeners)
                {
                    lstListeners.Items.Add(subject.name);
                }
                foreach (string listener in listenerTypes)
                {
                    cmbListenerSelect.Items.Add(listener);
                }
            }
            catch (Exception error)
            {
                displayCustomAlert(error.ToString());
            }
        }
        private void getModules()
        {
            try
            {
                string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/modules?token=" + Globals.apitoken;
                Globals.modulesJSON = submitJSONRequest(uri, "", "GET");
                Globals.modulesList = JsonConvert.DeserializeObject<Modules.RootObject>(Globals.modulesJSON);
                List<string> powershellModules = new List<string>();
                List<string> pythonModules = new List<string>();
                List<string> exfiltrationModules = new List<string>();
                List<string> externalModules = new List<string>();
                foreach (var module in Globals.modulesList.modules)
                {
                    List<string> usedRoots = new List<string>();
                    String[] pathParts = module.Name.Split('/');
                    switch (pathParts[0])
                    {
                        case "powershell":
                            powershellModules.Add(module.Name.ToString());
                            break;
                        case "python":
                            pythonModules.Add(module.Name.ToString());
                            break;
                        case "exfiltration":
                            exfiltrationModules.Add(module.Name.ToString());
                            break;
                        case "external":
                            externalModules.Add(module.Name.ToString());
                            break;
                    }
                }
                AddModuleToTree(powershellModules);
                AddModuleToTree(pythonModules);
                AddModuleToTree(exfiltrationModules);
                AddModuleToTree(externalModules);
            }
            catch (Exception error)
            {
                displayCustomAlert(error.ToString());
            }
        }
        private void getStagers()
        {
            lstStagers.Items.Clear();
            //Stagers don't change, so I don't think I'll need to create Stager Options. This may change in a future release or if I find a reason for it.
            try
            {
                string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/stagers?token=" + Globals.apitoken;
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                Globals.stagersJSON = submitJSONRequest(uri, "", "GET");

                JObject token = JObject.Parse(Globals.stagersJSON);
                JToken stagers = token["stagers"];
                try
                {
                    if (stagers != null)
                    {
                        foreach (var stager in stagers)
                        {
                            lstStagers.Items.Add(stager["Name"]);
                        }
                    }

                }

                catch (NullReferenceException)
                {
                    Console.WriteLine("null");
                }
            }
            catch (Exception error)
            {
                displayCustomAlert(error.ToString());
            }

            //550, 54 Label Location
            //635, 56 Text Box Location
        }
        private void lstStagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //drawStagerOptionTextBoxes();
            //Gets a list of options for each module.
            try
            {
                string selectedStager = lstStagers.SelectedItem.ToString();
                JObject token = JObject.Parse(Globals.stagersJSON);

                JObject match = token["stagers"].Values<JObject>().Where(m => m["Name"].Value<string>() == selectedStager).FirstOrDefault();
                JToken options = match["options"];
                Dictionary<string, ModuleOptions.Options> stagOpts = new Dictionary<string, ModuleOptions.Options>();
                if (options != null)
                {
                    foreach (var option in options)
                    {
                        string optionName = option.Path.Replace(match.Path + ".options.", "");
                        JObject JSONOptions = JObject.Parse(options.SelectToken(optionName).ToString());
                        //Console.WriteLine(lstStagers.SelectedItem.text);

                        //Creates an Options object based on the current object values.
                        ModuleOptions.Options moduleOptions = new ModuleOptions.Options(JSONOptions["Description"].ToString(), JSONOptions["Value"].ToString(), JSONOptions["Required"].ToString());

                        //Add this option to the dictionary (OptionName, Options Object)
                        stagOpts.Add(optionName, moduleOptions);
                    }
                    drawStagerOptionTextBoxes(stagOpts);
                }
            }
            catch (TimeoutException)
            {
                displayCustomAlert("Could not connect to Empire Server. Check to make sure it's still reachable!");
            }
            catch (NullReferenceException)
            {
                displayCustomAlert("nullref");
                //Do nothing. Fail silently (for now)
            }
        }
        private void btnSyncCredentials_Click(object sender, EventArgs e)
        {
            syncCreds();
        }
        private void btnCopyCredential_Click(object sender, EventArgs e)
        {
            if (dgCredentials.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(dgCredentials.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    displayCustomAlert("Could not access Clipboard. Try again later :(");
                }
            }
        }
        private void dgCredentials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgCredentials.Rows[index].Selected = true;
        }
        private void btnDeleteCredential_Click(object sender, EventArgs e)
        {
            displayCustomAlert("Caution: This will delete the credential from the table, however it will not delete it from the Empire server since that method has not been added yet.");
            if (dgCredentials.SelectedRows.Count > 0)
            {
                dgCredentials.Rows.RemoveAt(dgCredentials.SelectedRows[0].Index);
            }
        }
        private void btnAddCredential_Click(object sender, EventArgs e)
        {
            displayCustomAlert("Sorry this Method has not been abled in the Empire REST API as of yet");
        }
        private void btnGenerateStager_Click(object sender, EventArgs e)
        {
            //Generate Request URI.
            if (lstStagers.SelectedItem == null)
            {
                displayCustomAlert("Please select a valid stager!");
                return;
            }
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/stagers?token=" + Globals.apitoken;

            //Generate Dictionary of Options in order to convert to JSON and submit to Empire Server.
            Dictionary<string, string> POSTOptions = new Dictionary<string, string>();
            //Add StagerName to the POST request, because it doesn't get an option generated automatically.
            POSTOptions.Add("StagerName", lstStagers.SelectedItem.ToString());
            //Add Available Options to Dictionary. (Sometimes doesn't do it correctly)
            foreach (var tb in tabGenerateStager.Controls.OfType<MetroTextBox>())
            {
                POSTOptions.Add(tb.Name.Replace("txtGenStag", ""), tb.Text);
            }
            foreach (var cb in tabGenerateStager.Controls.OfType<MetroComboBox>())
            {
                POSTOptions.Add(cb.Name.Replace("cbGenStag", ""), cb.Text);
            }

            //Generate JSON String and submit the POST Request
            string JSONString = JsonConvert.SerializeObject(POSTOptions);
            string results = submitJSONRequest(uri, JSONString, "POST");
            if (results != "")
            {
                JObject token = JObject.Parse(results);
                /**
                 * ========================================
                 * Needs to be tested again
                 * ========================================
                 **/
                //JToken msgResult2 = token[0]["Output"];
                JToken msgResult = token[lstStagers.SelectedItem.ToString()]["Output"];
                displayStagerOutput(msgResult.ToString());
            }
        }
        private string submitJSONRequest(string uri, string json, string sendMethod)
        {
            string results;
            if (sendMethod.ToUpper() == "POST")
            {
                try
                {
                    //displayCustomAlert("Hello from POST");
                    WebClient wc = new WebClient();
                    //displayCustomAlert(uri + "\r\n\r\n" + json);
                    wc.Headers[HttpRequestHeader.ContentType] = @"application/json";
                    wc.Headers[HttpRequestHeader.UserAgent] = "Empire GUI 1.0";
                    results = wc.UploadString(uri, json);
                    //displayCustomAlert(results);
                    return results;
                }
                catch (WebException ex)
                {
                    //displayCustomAlert(ex.ToString());
                    handleWebException(ex);
                }
            }
            else if (sendMethod.ToUpper() == "GET")
            {
                try
                {
                    WebClient wc = new WebClient();
                    wc.Headers[HttpRequestHeader.ContentType] = @"application/json";
                    wc.Headers[HttpRequestHeader.UserAgent] = "Empire GUI 1.0";
                    results = wc.DownloadString(uri);
                    return results;
                }
                catch (WebException ex)
                {
                    handleWebException(ex);
                }
            }
            else if (sendMethod.ToUpper() == "DELETE")
            {
                var request = WebRequest.Create(uri);
                request.Method = "DELETE";
                WebResponse response = null;
                try
                {
                    response = request.GetResponse();
                }
                catch (WebException ex)
                {
                    handleWebException(ex);
                }
                if (response != null)
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    results = reader.ReadToEnd();
                    return results;
                }
            }
            else
            {
                //This should never be called but just in case...
                results = "";
                return results;
            }
            //This should never be called but just in case...
            return "";
        }
        private void clearForm(string tab, List<Control> drawnControls)
        {
            switch (tab)
            {
                case "GenerateStager":
                    if (drawnControls.Count != 0)
                    {
                        foreach (Control control in drawnControls)
                        {
                            tabGenerateStager.Controls.Remove(control);
                        }
                    }
                    break;
                case "ListenersOptions":
                    if (drawnControls.Count != 0)
                    {
                        foreach (Control control in drawnControls)
                        {
                            tabListeners.Controls.Remove(control);
                        }
                    }
                    break;
                case "ModuleOptions":
                    if (drawnControls.Count != 0)
                    {
                        foreach (Control control in drawnControls)
                        {
                            tabModules.Controls.Remove(control);
                        }
                    }
                    break;
                case "ActiveAgents":
                    if (drawnControls.Count != 0)
                    {
                        foreach (Control control in drawnControls)
                        {
                            tabActiveAgents.Controls.Remove(control);
                        }
                    }
                    break;
            }
        }
        private void btnRunModule_Click(object sender, EventArgs e)
        {
            string uri;
            if (treeModules.SelectedNode != null)
            {
                uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/modules/" + treeModules.SelectedNode.FullPath + "?token=" + Globals.apitoken;
            }
            else
            {
                displayCustomAlert("Please select a valid Module!");
                return;
            }
            Dictionary<string, string> POSTOptions = new Dictionary<string, string>();
            //This isn't right 
            //POSTOptions.Add("agent", treeModules.SelectedNode.FullPath);
            //Add Available Options to Dictionary. (Sometimes doesn't do it correctly)
            foreach (var tb in pnlModuleOptions.Controls.OfType<MetroTextBox>())
            {
                if ((string)tb.Tag != "NoSend")
                {
                    POSTOptions.Add(tb.Name.Replace("lblDescListOpt", ""), tb.Text);
                }
            }
            foreach (var cb in pnlModuleOptions.Controls.OfType<MetroComboBox>())
            {
                if ((string)cb.Tag != "NoSend")
                {
                    POSTOptions.Add(cb.Name.Replace("cbModOpt", ""), cb.Text);
                }
            }

            string JSONString = JsonConvert.SerializeObject(POSTOptions);
            string results = submitJSONRequest(uri, JSONString, "POST");
            if (results != "")
            {
                JObject token = JObject.Parse(results);
                JToken msgResult = token["msg"];
                displayCustomAlert(msgResult.ToString());
            }
            //string results = submitJSONRequest(uri, JSONString);
        }
        private void getAgents()
        {
            lstAgents.Items.Clear();
            //Stagers don't change, so I don't think I'll need to create Stager Options. This may change in a future release or if I find a reason for it.
            try
            {
                string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents?token=" + Globals.apitoken;
                Globals.agentsJSON = submitJSONRequest(uri, "", "GET");

                JObject token = JObject.Parse(Globals.agentsJSON);
                JToken agents = token["agents"];
                try
                {
                    if (agents != null)
                    {
                        foreach (var agent in agents)
                        {
                            //Add Agent to Agents list for use later.
                            Globals.Agents.Add(agent["name"].ToString());
                            //Add Agent to Listbox
                            lstAgents.Items.Add(agent["name"]);
                            if (!agentConsoles.ContainsKey(agent["name"].ToString())){
                                agentConsoles.Add(agent["name"].ToString(), new List<string>());
                            }
                        }
                    }

                }

                catch (NullReferenceException)
                {
                    Console.WriteLine("null");
                }
            }
            catch (Exception error)
            {
                displayCustomAlert(error.ToString());
            }
        }
        private void drawAgentTextboxes(string agentJSON)
        {
            foreach (Control control in tabActiveAgents.Controls)
            {
                if (control is MetroTextBox)
                {
                    control.Text = "";
                }
            }
            JObject token = JObject.Parse(agentJSON);
            JToken agents = token["agents"];
            try
            {
                if (agents != null)
                {
                    txtAgentLastCheckin.Text = agents[0]["checkin_time"].ToString();
                    txtAgentDelay.Text = agents[0]["delay"].ToString();
                    txtAgentExternalIP.Text = agents[0]["external_ip"].ToString();
                    txtAgentIntegrity.Text = agents[0]["high_integrity"].ToString();
                    txtAgentHostname.Text = agents[0]["hostname"].ToString();
                    txtAgentInternalIP.Text = agents[0]["internal_ip"].ToString();
                    txtAgentJitter.Text = agents[0]["jitter"].ToString();
                    txtAgentKillDate.Text = agents[0]["kill_date"].ToString();
                    txtAgentLanguage.Text = agents[0]["language"].ToString();
                    txtAgentLanguageVersion.Text = agents[0]["language_version"].ToString();
                    txtAgentLastSeen.Text = agents[0]["lastseen_time"].ToString();
                    txtAgentListenerName.Text = agents[0]["listener"].ToString();
                    txtAgentLostLimit.Text = agents[0]["lost_limit"].ToString();
                    txtAgentName.Text = agents[0]["name"].ToString();
                    txtAgentOperatingSystem.Text = agents[0]["os_details"].ToString();
                    txtAgentParent.Text = agents[0]["parent"].ToString();
                    txtAgentProcessID.Text = agents[0]["process_id"].ToString();
                    txtAgentProcessName.Text = agents[0]["process_name"].ToString();
                    txtAgentSessionID.Text = agents[0]["session_id"].ToString();
                    txtAgentSessionKey.Text = agents[0]["session_key"].ToString();
                    txtAgentUserName.Text = agents[0]["username"].ToString();
                    txtAgentWorkingHours.Text = agents[0]["working_hours"].ToString();

                }

            }
            catch (NullReferenceException)
            {
                Console.Write("null");
            }


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getAgents();
        }
        private void lstAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsoleInput.Text = "";
            string AgentName = lstAgents.SelectedItem.ToString().Replace(" (STALE)", "");
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/" + AgentName + "?token=" + Globals.apitoken;
            try
            {
                string agentJSON = submitJSONRequest(uri, "", "GET");
                drawAgentTextboxes(agentJSON);
                foreach (string line in agentConsoles[AgentName])
                {
                    //Would a stringbuilder object be quicker for this than a foreach loop?
                    txtConsoleLog.AppendText(line + Environment.NewLine);
                }
            }
            catch
            {

            }
            //How do I want to deal with the console when updating the Agent Selection?
            //Need to figure out how to continually update specific controls (THIS may involve making the Agent object which shouldn't be a huge issue)

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in DrawnModuleControls)
            {
                if (control is MetroTextBox)
                {
                    control.Text = "";
                }
            }
        }
        private void btnNewListener_Click(object sender, EventArgs e)
        {
            string selectedListener = cmbListenerSelect.Text;
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/listeners/" + selectedListener + "?token=" + Globals.apitoken;
            Dictionary<string, string> POSTOptions = new Dictionary<string, string>();
            //This isn't right 
            //POSTOptions.Add("agent", treeModules.SelectedNode.FullPath);
            //Add Available Options to Dictionary. (Sometimes doesn't do it correctly)
            foreach (var tb in ctrlListeners.Controls.OfType<MetroTextBox>())
            {
                if ((string)tb.Tag != "NoSend" && !string.IsNullOrEmpty(tb.Text))
                {
                    POSTOptions.Add(tb.Name.Replace("tbOptVal", ""), tb.Text);
                }
            }
            string JSONString = JsonConvert.SerializeObject(POSTOptions);
            displayStagerOutput(uri + "\r\n\r\n" + JSONString);
            string results = submitJSONRequest(uri, JSONString, "POST");
            if (results != "")
            {
                JObject token = JObject.Parse(results);

                JToken msgResult;
                if (token["success"] != null)
                    msgResult = token["success"];
                else
                    msgResult = token["error"];

                displayCustomAlert(msgResult.ToString());
            }

            getListeners();
        }
        private void btnClearListenerOptions_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabListeners.Controls)
            {
                if (control is MetroTextBox)
                {
                    control.Text = "";
                }
            }
        }
        private void btnDeleteListener_Click(object sender, EventArgs e)
        {
            string currentListener = "";
            try
            {
                currentListener = lstListeners.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
            }
            if (!string.IsNullOrEmpty(currentListener))
            {
                try
                {
                    displayCustomAlert("Delete Listener: " + currentListener + "?");
                    string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/listeners/" + currentListener + "?token=" + Globals.apitoken;
                    string results = submitJSONRequest(uri, "", "DELETE");
                    JObject token = JObject.Parse(results);
                    JToken msgResult = token["success"];
                    if (msgResult.ToString().ToLower() == "true")
                    {
                        displayCustomAlert("Successfully Removed Listener");
                    }
                    else
                    {
                        displayCustomAlert("Could Not Remove Listener");
                    }
                }
                catch
                {

                }
            }
            else if (string.IsNullOrEmpty(currentListener))
            {
                displayCustomAlert("Please select a Listener.");
            }
        }
        private void btnkillAllListeners_Click(object sender, EventArgs e)
        {
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/listeners/all?token=" + Globals.apitoken;
            string results = submitJSONRequest(uri, "", "DELETE");
            JObject token = JObject.Parse(results);
            JToken msgResult = token["success"];
            if (msgResult.ToString().ToLower() == "true")
            {
                displayCustomAlert("Successfully Removed All Listeners");
            }
            else
            {
                displayCustomAlert("Could Not Remove All Listeners");
            }

        }
        private void btnClearOptions_Click(object sender, EventArgs e)
        {
            foreach (Control control in DrawnStagerControls)
            {
                if (control is MetroTextBox)
                {
                    control.Text = "";
                }
            }
        }
        private void btnCreateNewListener_Click(object sender, EventArgs e)
        {

        }
        private void displayCustomAlert(string Message)
        {
            MetroFramework.Forms.MetroMessageBox AlertBox = new MetroFramework.Forms.MetroMessageBox();
            MetroLabel lbl = new MetroLabel();
            lbl.Name = "test";
            lbl.Text = Message;
            lbl.AutoSize = true;
            lbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            lbl.Location = new Point(10, 40);
            AlertBox.Controls.Add(lbl);
            AlertBox.AutoSize = true;
            AlertBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AlertBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            AlertBox.Show();
        }
        private void displayStagerOutput(string Output)
        {
            MetroTextBox tb = new MetroTextBox();
            tb.AutoSize = true;
            tb.Name = "txtGeneratedPayload";
            tb.Text = Output;
            tb.Height = 300;
            tb.Width = 300;
            tb.Location = new Point(10, 40);
            tb.Theme = MetroFramework.MetroThemeStyle.Dark;
            tb.Multiline = true;
            MetroFramework.Forms.MetroMessageBox outBox = new MetroFramework.Forms.MetroMessageBox();
            outBox.Controls.Add(tb);
            outBox.AutoSize = true;
            outBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            outBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            outBox.Show();
        }
        private void btnSearchModules_Click(object sender, EventArgs e)
        {

        }
        private void btnGetStale_Click(object sender, EventArgs e)
        {
            //Update the Agents and Re-Write them to remove the (STALE) text in case any of them have come back since last check.
            getAgents();

            //Get Stale Agent Requests
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/stale?token=" + Globals.apitoken;
            string staleAgents = submitJSONRequest(uri, "", "GET");
            if (staleAgents != "")
            {
                JObject token = JObject.Parse(staleAgents);
                JToken agents = token["agents"];
                if (agents != null)
                {
                    foreach (var agent in agents)
                    {
                        int index = lstAgents.FindString(agent["name"].ToString());
                        lstAgents.Items[index] = agent["name"].ToString() + " (STALE)";
                    }
                }
            }

        }
        private void btnRemoveStale_Click(object sender, EventArgs e)
        {
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/stale?token=" + Globals.apitoken;
            string results = submitJSONRequest(uri, "", "DELETE");
            JObject token = JObject.Parse(results);
            JToken msgResult = token["success"];
            if (msgResult.ToString().ToLower() == "true")
            {
                displayCustomAlert("Successfully removed Stale Agents");
            }
            else
            {
                displayCustomAlert("Could not remove Stale Agents");
            }

        }
        private void btnRemoveAgent_Click(object sender, EventArgs e)
        {
            string currentAgent = "";
            if (lstAgents.SelectedItem != null)
                currentAgent = lstAgents.SelectedItem.ToString().Replace(" (STALE)", "");
            else
            {
                displayCustomAlert("Please select an agent!");
                return;
            }
                string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/" + currentAgent + "?token=" + Globals.apitoken;
                string results = submitJSONRequest(uri, "", "DELETE");
            if (results != null)
            {
                JObject token = JObject.Parse(results);
                JToken msgResult = token["success"];
                if (msgResult.ToString().ToLower() == "true")
                {
                    displayCustomAlert("Successfully removed Agent: " + currentAgent);
                }
                else
                {
                    displayCustomAlert("Could not remove Agent: " + currentAgent);
                }
            }
            //Re-Draw agents and check if they're stale.
            //Should I put this inside the If statement?
            getAgents();
            btnGetStale.PerformClick();
        }
        private void btnRenameAgent_Click(object sender, EventArgs e)
        {
            //Need to get actual value from User.
            //Should probably create a custom dialog box asking for input.
            //Also need to add an "OK" button to the current displayCustomDialog function.
            //Having this here temporarily.
            string currentAgent = "";
            if (lstAgents.SelectedItem != null)
                currentAgent = lstAgents.SelectedItem.ToString().Replace(" (STALE)", "");
            else
                displayCustomAlert("Please select an agent!");

        }
        private string killAgent(string agentName)
        {
            string uri;
            if (!string.IsNullOrEmpty(agentName))
                uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/" + agentName + "/kill" + "?token=" + Globals.apitoken;

            else
                uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/all/kill" + "?token=" + Globals.apitoken;

            string results = submitJSONRequest(uri, "", "GET");
            string messageResult;
            JObject token = JObject.Parse(results);
            JToken msgResult = token["success"];
            if (msgResult.ToString().ToLower() == "true")
            {
                messageResult = "Killed All Agents";
            }
            else if (msgResult.ToString().ToLower() == "false")
            {
                messageResult = "Could Not Kill Agents! (Success = False)";
            }
            else
            {
                messageResult = "An Error occured and listeners could not be killed";
            }
            return messageResult;
        }
        private void handleWebException(WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
            {
                var webresponse = (HttpWebResponse)ex.Response;
                switch (webresponse.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        //Add an option to Change the API Token. Maybe pop up a box to ask for the current API token.
                        displayCustomAlert("Unauthorized Error (401) from Empire Server, has the API Token changed?");
                        break;
                    case HttpStatusCode.MethodNotAllowed:
                        displayCustomAlert("Method Not Allowed (405) received from Empire Server");
                        break;
                    case HttpStatusCode.NotFound:
                        displayCustomAlert("File Not Found (404) Error received from the Empire Server.");
                        break;
                    case HttpStatusCode.BadRequest:
                        displayCustomAlert("Bad Request (400) Received from the Empire Server.");
                        break;
                    case HttpStatusCode.Forbidden:
                        displayCustomAlert("Forbidden (403) Received from the Empire Server, has the API Token changed?");
                        break;
                    case HttpStatusCode.GatewayTimeout:
                        displayCustomAlert("Gateway Timeout (503) Received from the Empire Server. Check your Internet Connection!");
                        break;
                    case HttpStatusCode.InternalServerError:
                        displayCustomAlert("Internal Server Error (500) Received from the Empire Server.");
                        break;
                    case HttpStatusCode.RequestTimeout:
                        displayCustomAlert("Request Timeout (408)");
                        break;
                }
            }
            else
            {
                displayCustomAlert("An error occured when contacting Empire Server");
            }
        }
        private void metroButton5_Click(object sender, EventArgs e)
        {
            rtj();
        }
        private void cmbListenerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Unselect any selected listeners.
            lstListeners.ClearSelected();
            //Hide fields that aren't required by the "New Listener" functionality and clear out any old listener names that might be left over.
            txtListID.Visible = false;
            lblListID.Visible = false;
            lblListenerID.Visible = false;
            lblListCat.Visible = false;
            lblListenerCategory.Visible = false;
            lblModType.Visible = false;
            lblModuleType.Visible = false;
            txtModTypeValue.Visible = false;
            txtListCatVal.Visible = false;


            //Get listener selection to generate options and eventually create
            string selectedListener = cmbListenerSelect.Text;


            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/listeners/options/" + selectedListener + "?token=" + Globals.apitoken;
            string results = submitJSONRequest(uri, "", "GET");
            try
            {
                //Parse the token in order to get the available options for the selected listener (comes back in a different format than the other listeners function)
                JObject token = JObject.Parse(results);
                JToken options = token["listeneroptions"];

                //Enumerate through the list of options and add them to a dictionary in order to draw the textboxes.
                Dictionary<string, ModuleOptions.Options> listopts = new Dictionary<string, ModuleOptions.Options>();
                if (options != null)
                {
                    foreach (var option in options)
                    {
                        //This was the best way I could figure out how to get the actual option name, I'm sure there's a better way but at the time of writing this I couldn't figure it out.
                        string optionName = option.Path.Replace("listeneroptions.", "");
                        JObject JSONOptions = JObject.Parse(options.SelectToken(optionName).ToString());

                        //Creates an Options object based on the current object value.
                        //Would this cause a memory leak after a certain amount of uses? Will need to investigate more.
                        ModuleOptions.Options listenerOptions = new ModuleOptions.Options(JSONOptions["Description"].ToString(), JSONOptions["Value"].ToString(), JSONOptions["Required"].ToString());

                        //Add this option to the dictionary (OptionName, Options Object)
                        listopts.Add(optionName, listenerOptions);
                    }
                }
                drawListenerOptionTextBoxes(listopts, true);
            }
            catch (TimeoutException)
            {
                displayCustomAlert("Could not connect to Empire Server. Check to make sure it's still reachable!");
            }
            catch (NullReferenceException)
            {
                //do nothing
            }
        }
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/admin/shutdown?token=" + Globals.apitoken;
            displayCustomAlert("Shutting down API Server!");
            string results = submitJSONRequest(uri, "", "GET");
            if (results != null)
            {
                JObject token = JObject.Parse(results);
                if (token["success"] != null)
                {
                    if (token["success"].ToString().ToLower() == "true")
                    {
                        displayCustomAlert("Successfully shutdown REST API Server");
                    }
                }
                else
                    displayCustomAlert("Could not shutdown REST API Server!");
            }
        }
        private void btnEnterCommand_Click(object sender, EventArgs e)
        {
            submitConsoleCommand();
        }
        private void submitConsoleCommand()
        {
            //For Drawing in the Console, do I need to use a stringbuilder object? Will that give me better performance? (From Microsoft Coding Conventions Recommendations)
            string fullcommand = "";
            string selectedAgent = "";
            //Check if selected agent is null, if not then 
            if (lstAgents.SelectedItem != null)
            {
                selectedAgent = lstAgents.SelectedItem.ToString().Replace(" (STALE)", "");
                agentConsoles[selectedAgent].Add("user > " + txtConsoleInput.Text);
            }
            else
            {
                displayCustomAlert("Please select an agent!");
                txtConsoleInput.Text = "Select an Agent.";
                return;
            }

            //Add Userinput to console storage.
            //What do I do if no Agent is selected? 

            txtConsoleLog.AppendText("user > " + txtConsoleInput.Text + "\r\n");
            string[] commandString = txtConsoleInput.Text.Trim().Split(' ');


            switch (commandString[0].ToLower())
            {
                case "help":
                    //string helpText = "[-] Please enter one of the following commands \r\n help \r\nshell: Allows you to run a shell command on the selected Agent. \r\n placeholder";
                    string helpText = @"[!] The following commands are supported by EMPIRE GUI
    shell - Runs a shell command on the selected Agent.
    allshell - Runs a shell command on all Agents.
    renameagent - Changes the name of the Agent.
    kill - kills the selected Agent.
    remove - removes the selected Agent.
    killall - kills all Agents.
    cleartasking - Clears the tasks queue of the selected agent.
    clear - clears out the console log.
    rtj - ?";

                    agentConsoles[selectedAgent].Add(helpText);
                    txtConsoleLog.AppendText(helpText + Environment.NewLine);
                    break;
                case "shell": //DONE
                    for (int i = 1; i <= commandString.Length - 1; i++) { fullcommand += commandString[i] + " "; }
                    string commandText = @"[+] Tasked Agent to run shell command: """ + fullcommand.Trim() + @"""";
                    agentConsoles[selectedAgent].Add(commandText);
                    txtConsoleLog.AppendText(commandText + Environment.NewLine);
                    runShellCommand(selectedAgent, fullcommand.Trim());
                    break;
                case "allshell": //DONE
                    for (int i = 1; i <= commandString.Length - 1; i++) { fullcommand += commandString[i] + " "; };
                    string allcommandText = @"[+] Tasked all Agents to run shell command: """ + fullcommand.Trim() + @"""";
                    txtConsoleLog.AppendText(allcommandText + Environment.NewLine);
                    agentConsoles[selectedAgent].Add(allcommandText);
                    break;
                case "renameagent": //DONE
                    string renameText = "[+] Renaming Agent " + selectedAgent + " to " + commandString[1];
                    txtConsoleLog.AppendText(renameText);
                    agentConsoles[selectedAgent].Add(renameText);
                    renameAgent(selectedAgent, commandString[1]);
                    break;
                case "kill": //DONE
                    string killMessage = "[+] Killing Agent " + selectedAgent + " (RIP)";
                    txtConsoleLog.AppendText("[+] " + killMessage + Environment.NewLine);
                    agentConsoles[selectedAgent].Add("[+] " + killMessage);
                    string killresult = killAgent(selectedAgent);
                    txtConsoleLog.AppendText(killresult + Environment.NewLine);
                    agentConsoles[selectedAgent].Add(killresult);
                    break;
                case "remove":
                    
                    break;
                case "killall": //DONE
                    string killAllMessage = "[+] Killing all Agents (RIP)";
                    txtConsoleLog.AppendText("[+] " + killAllMessage + Environment.NewLine);
                    agentConsoles[selectedAgent].Add("[+] " + killAllMessage);
                    string killAllresult = killAgent("");
                    txtConsoleLog.AppendText(killAllresult + Environment.NewLine);
                    agentConsoles[selectedAgent].Add(killAllresult);
                    break;
                case "usemodule": //NOT IMPLEMENTED
                    //Do I even want to implement this?
                    //If I do, most likely just change active tab to use module and autoselect for user and agent.
                    break;
                case "cleartasking": //DONE
                    string clearMessage = "[+] Clearing Agent taskings for " + selectedAgent;
                    txtConsoleLog.AppendText("[+] " + clearMessage + Environment.NewLine);
                    agentConsoles[selectedAgent].Add("[+] " + clearMessage);
                    clearAgentTaskings(selectedAgent);
                    //Clear agent taskings
                    break;
                case "clear": //DONE
                    //Clear text from console
                    txtConsoleLog.Text = "";
                    agentConsoles[selectedAgent].Clear();
                    break;
                case "rtj":
                    rtj();
                    break;
                default:
                    string notFoundText = "[-] Command: " + @"""" + commandString[0] + @""" not found. Use ""help"" to list available commands.";
                    txtConsoleLog.AppendText(notFoundText + Environment.NewLine);
                    agentConsoles[selectedAgent].Add(notFoundText);
                    break;

            }
            txtConsoleInput.Text = "";
        }
        private void GetReporting()
        {
            //Submit JSON request to endpoint API.
            //Store Reporting function in Array.
            //How to check for dupes? Store last request? Re-fill dictionary every time?
            //This could be useful when checking checkin times. But other than that not really necessary (for now)
        }
        private void txtConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                //btnEnterCommand_Click(this, new EventArgs());
                submitConsoleCommand();
            }
        }
        private void runShellCommand(string agentName, string fullCommand)
        {
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/" + agentName + "/shell?token=" + Globals.apitoken;
            JObject commandJSON = new JObject(new JProperty("command", fullCommand));
            string results = submitJSONRequest(uri, commandJSON.ToString(), "POST");
            if (results != null)
            {
                JObject token = JObject.Parse(results);

                JToken msgResult;
                if (token["success"] != null)
                {
                    if (token["success"].ToString().ToLower() == "true")
                    {
                        getResults(agentName);
                    }
                }
                else
                    msgResult = token["error"];
            }
            //TODO: Maybe store log containing all actions performed and their output. Maybe also use this file to fill contents of the console everytime the application is launched.

        }
        private void getResults(string agentName)
        {
            int sleeptime = int.Parse(txtAgentDelay.Text) + int.Parse(txtAgentJitter.Text);
            //Need to background This thread so that the UI doesn't freeze. But overall it seems to work.
            //Implemented using https://msdn.microsoft.com/en-us/library/system.componentmodel.backgroundworker(v=vs.110).aspx
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_GetResults);
            List<object> arguments = new List<object>();
            arguments.Add(agentName);
            arguments.Add(sleeptime);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.RunWorkerAsync(arguments);
            bgw.Dispose();
            agentConsoles[agentName].Add("[!] Waiting " + sleeptime + "s for Agent to call back...");
            txtConsoleLog.AppendText("[!] Waiting " + sleeptime + "s for Agent to call back..." + Environment.NewLine);
            //This should work, but the buffer isn't deleting. May be an issue with Empire. Need to look into it/ask Xorrior.
            //displayCustomAlert(results.ToString());
            //string resultMessage = results[0]["results"].ToString();
            //Delete the Results Buffer for easier access later. There may be a better way to do this. (ex. Foreach accessing last item).
            //string testResults = submitJSONRequest(uri, "", "DELETE");
            //return resultMessage;
            //return results[0]["results"].ToString() ;
        }
        private void bgw_GetResults(object sender, DoWorkEventArgs e)
        {
            List<object> argList = e.Argument as List<object>;
            string agentName = argList[0].ToString();
            int sleeptime = int.Parse(argList[1].ToString());
            Thread.Sleep(sleeptime * 1000);
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/" + agentName + "/results?token=" + Globals.apitoken;
            string resultsJSON = submitJSONRequest(uri, null, "GET");
            JObject token = JObject.Parse(resultsJSON);
            JToken results = token["results"];
            //Not being used as a string yet, void this? Delete the Results buffer for easier access later. There may be better options.
            string deleteResults = submitJSONRequest(uri, "", "DELETE");;
            e.Result = results[0]["results"];
        }
        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                displayCustomAlert(e.Error.ToString());
            }
            else
            {
                txtConsoleLog.AppendText(e.Result.ToString() + Environment.NewLine);
                agentConsoles[lstAgents.SelectedItem.ToString().Replace(" (STALE)", "")].Add(e.Result.ToString());
            }
        }
        private void btnKillAgent_Click(object sender, EventArgs e)
        {
            if (lstAgents.SelectedItem != null)
                killAgent(lstAgents.SelectedItem.ToString().Replace(" (STALE)", ""));
            else
                displayCustomAlert("Please select an agent!");
        }
        private void drawConsole(string agentName)
        {
            //Store console as Dictionary<string agentName, List<string> consoleLines>
            //For Console drawing use stringbuilder https://stackoverflow.com/questions/19387388/quickest-way-to-update-multiline-textbox-with-large-amount-of-text
            for (int i = 0; i < 10000; i++)
            {
                txtConsoleLog.AppendText(i.ToString() + Environment.NewLine);
            }


        }
        private void rtj()
        {
            string[] urls = { "https://www.youtube.com/watch?v=eaJmgMuYNjc", "https://www.youtube.com/watch?v=h9_31bUYHvA", "https://www.youtube.com/watch?v=q6GyTBVAF4w", "https://www.youtube.com/watch?v=vWaljXUiCaE", "https://www.youtube.com/watch?v=6k7kk1lUnis", "https://www.youtube.com/watch?v=NUC2EQvdzmY", "https://www.youtube.com/watch?v=G-S9mtYowPY", "https://www.youtube.com/watch?v=uuWQyfGa1yI", "https://www.youtube.com/watch?v=OQ5rI461KNE", "https://www.youtube.com/watch?v=oNh2ndOeVFU", "https://www.youtube.com/watch?v=BEOximWoFd0", "https://www.youtube.com/watch?v=aES4SbFTH2Y", "https://www.youtube.com/watch?v=pJJyKlRxyvA" };
            int index = new Random().Next(0, urls.Length);
            string url = urls[index];
            string command = @"powershell.exe $ie=New-Object -com ""InternetExplorer.Application"";$ie.Navigate\(""" + url + @"""\)";
        }
        private void renameAgent(string oldAgent, string newAgent)
        {
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/" + oldAgent + "/rename?token=" + Globals.apitoken;
            JObject commandJSON = new JObject(new JProperty("newname", newAgent));
            string results = submitJSONRequest(uri, commandJSON.ToString(), "POST");
            if (results != null)
            {
                JObject token = JObject.Parse(results);
                if (token["success"] != null)
                {
                    if (token["success"].ToString().ToLower() == "true")
                    {
                        string changesuccessful = "[+] Successfully renamed agent to " + newAgent;
                        txtConsoleLog.AppendText(changesuccessful + Environment.NewLine);
                        agentConsoles[oldAgent].Add(changesuccessful);

                        //TODO: Make sure works.
                        getAgents();
                    }
                }
                else
                {
                    string changefail = "[+] Error occured when renaming Agent";
                    txtConsoleLog.AppendText(changefail + Environment.NewLine);
                    agentConsoles[oldAgent].Add(changefail);
                }
            }
        }
        private void clearAgentTaskings(string agentName)
        {
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/agents/" + agentName + "/clear?token=" + Globals.apitoken;
            string results = submitJSONRequest(uri, null, "GET");
            if (results != null)
            {
                JObject token = JObject.Parse(results);
                if (token["success"] != null)
                {
                    if (token["success"].ToString().ToLower() == "true")
                    {
                        string clearsuccessful = "[+] Successfully cleared Agent taskings";
                        txtConsoleLog.AppendText(clearsuccessful + Environment.NewLine);
                        agentConsoles[agentName].Add(clearsuccessful);

                        //TODO: Make sure works.
                        getAgents();
                    }
                }
                else
                {
                    string changefail = "[+] Error occured when clearing taskings";
                    txtConsoleLog.AppendText(changefail + Environment.NewLine);
                    agentConsoles[agentName].Add(changefail);
                }

            }
        }
        private void btnGetEmpireGUIVersion_Click(object sender, EventArgs e)
        {
            displayCustomAlert("Empire GUI Version 1.0");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnChangeAPIToken_Click(object sender, EventArgs e)
        {
            Globals.apitoken = getInput("New Token");
        }
        private string getInput(string requestMessage)
        {
            Size size = new Size(200, 70);
            MetroFramework.Forms.MetroForm inputBox = new MetroFramework.Forms.MetroForm();

     
            inputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            inputBox.Size = new Size(250, 150);
            inputBox.Text = requestMessage;

            MetroTextBox textBox = new MetroTextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            textBox.Location = new Point(40, 60);
            textBox.Text = "";
            inputBox.Controls.Add(textBox);

            MetroButton okButton = new MetroButton();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            okButton.Size = new Size(75, 23);
            okButton.Text = "OK";
            okButton.Location = new Point(40, 100);
            inputBox.Controls.Add(okButton);

            MetroButton cancelButton = new MetroButton();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "Cancel";
            cancelButton.Location = new Point(125 ,100);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;
            DialogResult result = inputBox.ShowDialog();
            //Return new option, or default to original.
            if (result.ToString() == "OK" && !string.IsNullOrEmpty(textBox.Text))
                return textBox.Text;
            else if (string.IsNullOrEmpty(textBox.Text))
                return Globals.apitoken;
            else
                return Globals.apitoken;
        }
        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            //Seems to work? Could I implementt his as a background agent? And then call it on form load.
            lstListeners.Items.Clear();
            getListeners();
            getModules();
            syncCreds();
            getStagers();
            getAgents();
        }
        private void btnChangePolling_Click(object sender, EventArgs e)
        {
            string poll;
            int value;
            do
            {
                poll = getInput("New Polling Value");
            }
            while (!int.TryParse(poll, out value));
        }
        private void btnRestartAPI_Click(object sender, EventArgs e)
        {
            string uri = "https://" + Globals.serverIP + ":" + Globals.serverPort + "/api/admin/restart?token=" + Globals.apitoken;
            displayCustomAlert("Restarting API Server!");
            string results = submitJSONRequest(uri, "", "GET");
            Thread.Sleep(10000);

            if (results != null)
            {
                JObject token = JObject.Parse(results);
                if (token["success"] != null)
                {
                    if (token["success"].ToString().ToLower() == "true")
                    {
                        displayCustomAlert("Successfully Restarted REST API Server.");
                        string poll;
                        int value;
                        do
                        {
                            poll = getInput("Updpate API Token");
                        }
                        while (!int.TryParse(poll, out value));
                    }
                }
                else
                    displayCustomAlert("Could not Restart REST API Server!");
            }
        }
    }
}

