namespace EmpireGUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabActiveAgents = new MetroFramework.Controls.MetroTabPage();
            this.btnKillAgent = new MetroFramework.Controls.MetroButton();
            this.btnEnterCommand = new MetroFramework.Controls.MetroButton();
            this.lblAgentParent = new MetroFramework.Controls.MetroLabel();
            this.lblAgentDelay = new MetroFramework.Controls.MetroLabel();
            this.txtAgentParent = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentDelay = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentWorkingHours = new MetroFramework.Controls.MetroTextBox();
            this.lblAgentWorkingHours = new MetroFramework.Controls.MetroLabel();
            this.txtAgentSessionKey = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentSessionID = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentJitter = new MetroFramework.Controls.MetroTextBox();
            this.lblAgentSessionID = new MetroFramework.Controls.MetroLabel();
            this.lblAgentSessionKey = new MetroFramework.Controls.MetroLabel();
            this.lblAgentJitter = new MetroFramework.Controls.MetroLabel();
            this.lblAgentLostLimit = new MetroFramework.Controls.MetroLabel();
            this.lblLastSeen = new MetroFramework.Controls.MetroLabel();
            this.lblLanguageVersion = new MetroFramework.Controls.MetroLabel();
            this.txtAgentLostLimit = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentLastSeen = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentLanguageVersion = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentLanguage = new MetroFramework.Controls.MetroTextBox();
            this.lblLanguage = new MetroFramework.Controls.MetroLabel();
            this.txtAgentExternalIP = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentIntegrity = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentHostname = new MetroFramework.Controls.MetroTextBox();
            this.lblIntegrity = new MetroFramework.Controls.MetroLabel();
            this.lblExternalIP = new MetroFramework.Controls.MetroLabel();
            this.lblHostName = new MetroFramework.Controls.MetroLabel();
            this.txtAgentKillDate = new MetroFramework.Controls.MetroTextBox();
            this.lblAgentKillDate = new MetroFramework.Controls.MetroLabel();
            this.btnRefreshAgents = new MetroFramework.Controls.MetroButton();
            this.lblAPIToken4 = new MetroFramework.Controls.MetroLabel();
            this.btnRenameAgent = new MetroFramework.Controls.MetroButton();
            this.btnRemoveAgent = new MetroFramework.Controls.MetroButton();
            this.btnRemoveStale = new MetroFramework.Controls.MetroButton();
            this.btnGetStale = new MetroFramework.Controls.MetroButton();
            this.lstAgents = new System.Windows.Forms.ListBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAgentUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentLastCheckin = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentProcessName = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentProcessID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAgentInternalIP = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentOperatingSystem = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentName = new MetroFramework.Controls.MetroTextBox();
            this.txtAgentListenerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtConsoleInput = new MetroFramework.Controls.MetroTextBox();
            this.txtConsoleLog = new MetroFramework.Controls.MetroTextBox();
            this.lblAgents = new MetroFramework.Controls.MetroLabel();
            this.tabOptions = new MetroFramework.Controls.MetroTabPage();
            this.btnRestartAPI = new MetroFramework.Controls.MetroButton();
            this.btnShutDown = new MetroFramework.Controls.MetroButton();
            this.btnRTJ = new MetroFramework.Controls.MetroButton();
            this.btnChangePolling = new MetroFramework.Controls.MetroButton();
            this.btnRefreshAll = new MetroFramework.Controls.MetroButton();
            this.btnChangeAPIToken = new MetroFramework.Controls.MetroButton();
            this.btnGetEmpireGUIVersion = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.tabModules = new MetroFramework.Controls.MetroTabPage();
            this.pnlModuleOptions = new MetroFramework.Controls.MetroPanel();
            this.btnSearchModules = new MetroFramework.Controls.MetroButton();
            this.lblAPIToken2 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtBackground = new MetroFramework.Controls.MetroTextBox();
            this.txtOutputExtension = new MetroFramework.Controls.MetroTextBox();
            this.txtNeedsAdmin = new MetroFramework.Controls.MetroTextBox();
            this.txtOpSecSafe = new MetroFramework.Controls.MetroTextBox();
            this.txtLanguage = new MetroFramework.Controls.MetroTextBox();
            this.txtMinLangReq = new MetroFramework.Controls.MetroTextBox();
            this.txtComments = new MetroFramework.Controls.MetroTextBox();
            this.txtModuleName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnRunModule = new MetroFramework.Controls.MetroButton();
            this.treeModules = new System.Windows.Forms.TreeView();
            this.tabListeners = new MetroFramework.Controls.MetroTabPage();
            this.cmbListenerSelect = new MetroFramework.Controls.MetroComboBox();
            this.ctrlListeners = new MetroFramework.Controls.MetroPanel();
            this.lblModuleType = new MetroFramework.Controls.MetroLabel();
            this.lblListID = new MetroFramework.Controls.MetroLabel();
            this.lblListenerCategory = new MetroFramework.Controls.MetroLabel();
            this.lblListenerID = new MetroFramework.Controls.MetroLabel();
            this.lblListCat = new MetroFramework.Controls.MetroLabel();
            this.lblModType = new MetroFramework.Controls.MetroLabel();
            this.txtListID = new MetroFramework.Controls.MetroTextBox();
            this.txtListCatVal = new MetroFramework.Controls.MetroTextBox();
            this.txtModTypeValue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.btnkillAllListeners = new MetroFramework.Controls.MetroButton();
            this.btnDeleteListener = new MetroFramework.Controls.MetroButton();
            this.metroLabel41 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel40 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel39 = new MetroFramework.Controls.MetroLabel();
            this.btnClearListenerOptions = new MetroFramework.Controls.MetroButton();
            this.btnNewListener = new MetroFramework.Controls.MetroButton();
            this.lstListeners = new System.Windows.Forms.ListBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tabGenerateStager = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.lblAPIToken1 = new MetroFramework.Controls.MetroLabel();
            this.btnCreateNewListener = new MetroFramework.Controls.MetroButton();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.lstStagers = new System.Windows.Forms.ListBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.btnClearOptions = new MetroFramework.Controls.MetroButton();
            this.btnGenerateStager = new MetroFramework.Controls.MetroButton();
            this.tabCredentials = new MetroFramework.Controls.MetroTabPage();
            this.lblAPIToken3 = new MetroFramework.Controls.MetroLabel();
            this.btnSyncCredentials = new MetroFramework.Controls.MetroButton();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.lblLoremIpsum = new MetroFramework.Controls.MetroLabel();
            this.lblCredentials = new MetroFramework.Controls.MetroLabel();
            this.btnCopyCredential = new MetroFramework.Controls.MetroButton();
            this.btnDeleteCredential = new MetroFramework.Controls.MetroButton();
            this.btnAddCredential = new MetroFramework.Controls.MetroButton();
            this.dgCredentials = new System.Windows.Forms.DataGridView();
            this.colCredID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLCredDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.tabActiveAgents.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabModules.SuspendLayout();
            this.tabListeners.SuspendLayout();
            this.ctrlListeners.SuspendLayout();
            this.tabGenerateStager.SuspendLayout();
            this.tabCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCredentials)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabActiveAgents);
            this.metroTabControl1.Controls.Add(this.tabListeners);
            this.metroTabControl1.Controls.Add(this.tabModules);
            this.metroTabControl1.Controls.Add(this.tabCredentials);
            this.metroTabControl1.Controls.Add(this.tabGenerateStager);
            this.metroTabControl1.Controls.Add(this.tabOptions);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 6);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 5;
            this.metroTabControl1.Size = new System.Drawing.Size(1139, 670);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabActiveAgents
            // 
            this.tabActiveAgents.Controls.Add(this.btnKillAgent);
            this.tabActiveAgents.Controls.Add(this.btnEnterCommand);
            this.tabActiveAgents.Controls.Add(this.lblAgentParent);
            this.tabActiveAgents.Controls.Add(this.lblAgentDelay);
            this.tabActiveAgents.Controls.Add(this.txtAgentParent);
            this.tabActiveAgents.Controls.Add(this.txtAgentDelay);
            this.tabActiveAgents.Controls.Add(this.txtAgentWorkingHours);
            this.tabActiveAgents.Controls.Add(this.lblAgentWorkingHours);
            this.tabActiveAgents.Controls.Add(this.txtAgentSessionKey);
            this.tabActiveAgents.Controls.Add(this.txtAgentSessionID);
            this.tabActiveAgents.Controls.Add(this.txtAgentJitter);
            this.tabActiveAgents.Controls.Add(this.lblAgentSessionID);
            this.tabActiveAgents.Controls.Add(this.lblAgentSessionKey);
            this.tabActiveAgents.Controls.Add(this.lblAgentJitter);
            this.tabActiveAgents.Controls.Add(this.lblAgentLostLimit);
            this.tabActiveAgents.Controls.Add(this.lblLastSeen);
            this.tabActiveAgents.Controls.Add(this.lblLanguageVersion);
            this.tabActiveAgents.Controls.Add(this.txtAgentLostLimit);
            this.tabActiveAgents.Controls.Add(this.txtAgentLastSeen);
            this.tabActiveAgents.Controls.Add(this.txtAgentLanguageVersion);
            this.tabActiveAgents.Controls.Add(this.txtAgentLanguage);
            this.tabActiveAgents.Controls.Add(this.lblLanguage);
            this.tabActiveAgents.Controls.Add(this.txtAgentExternalIP);
            this.tabActiveAgents.Controls.Add(this.txtAgentIntegrity);
            this.tabActiveAgents.Controls.Add(this.txtAgentHostname);
            this.tabActiveAgents.Controls.Add(this.lblIntegrity);
            this.tabActiveAgents.Controls.Add(this.lblExternalIP);
            this.tabActiveAgents.Controls.Add(this.lblHostName);
            this.tabActiveAgents.Controls.Add(this.txtAgentKillDate);
            this.tabActiveAgents.Controls.Add(this.lblAgentKillDate);
            this.tabActiveAgents.Controls.Add(this.btnRefreshAgents);
            this.tabActiveAgents.Controls.Add(this.lblAPIToken4);
            this.tabActiveAgents.Controls.Add(this.btnRenameAgent);
            this.tabActiveAgents.Controls.Add(this.btnRemoveAgent);
            this.tabActiveAgents.Controls.Add(this.btnRemoveStale);
            this.tabActiveAgents.Controls.Add(this.btnGetStale);
            this.tabActiveAgents.Controls.Add(this.lstAgents);
            this.tabActiveAgents.Controls.Add(this.metroLabel8);
            this.tabActiveAgents.Controls.Add(this.metroLabel7);
            this.tabActiveAgents.Controls.Add(this.metroLabel6);
            this.tabActiveAgents.Controls.Add(this.txtAgentUserName);
            this.tabActiveAgents.Controls.Add(this.txtAgentLastCheckin);
            this.tabActiveAgents.Controls.Add(this.txtAgentProcessName);
            this.tabActiveAgents.Controls.Add(this.txtAgentProcessID);
            this.tabActiveAgents.Controls.Add(this.metroLabel5);
            this.tabActiveAgents.Controls.Add(this.txtAgentInternalIP);
            this.tabActiveAgents.Controls.Add(this.txtAgentOperatingSystem);
            this.tabActiveAgents.Controls.Add(this.txtAgentName);
            this.tabActiveAgents.Controls.Add(this.txtAgentListenerName);
            this.tabActiveAgents.Controls.Add(this.metroLabel4);
            this.tabActiveAgents.Controls.Add(this.metroLabel3);
            this.tabActiveAgents.Controls.Add(this.metroLabel2);
            this.tabActiveAgents.Controls.Add(this.metroLabel1);
            this.tabActiveAgents.Controls.Add(this.txtConsoleInput);
            this.tabActiveAgents.Controls.Add(this.txtConsoleLog);
            this.tabActiveAgents.Controls.Add(this.lblAgents);
            this.tabActiveAgents.HorizontalScrollbarBarColor = true;
            this.tabActiveAgents.Location = new System.Drawing.Point(4, 35);
            this.tabActiveAgents.Name = "tabActiveAgents";
            this.tabActiveAgents.Size = new System.Drawing.Size(1131, 631);
            this.tabActiveAgents.TabIndex = 4;
            this.tabActiveAgents.Text = "Agent Menu";
            this.tabActiveAgents.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabActiveAgents.VerticalScrollbarBarColor = true;
            // 
            // btnKillAgent
            // 
            this.btnKillAgent.Location = new System.Drawing.Point(516, 346);
            this.btnKillAgent.Name = "btnKillAgent";
            this.btnKillAgent.Size = new System.Drawing.Size(120, 23);
            this.btnKillAgent.TabIndex = 68;
            this.btnKillAgent.Text = "Kill Agent";
            this.btnKillAgent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnKillAgent.Click += new System.EventHandler(this.btnKillAgent_Click);
            // 
            // btnEnterCommand
            // 
            this.btnEnterCommand.Location = new System.Drawing.Point(1090, 375);
            this.btnEnterCommand.Name = "btnEnterCommand";
            this.btnEnterCommand.Size = new System.Drawing.Size(33, 23);
            this.btnEnterCommand.TabIndex = 67;
            this.btnEnterCommand.Text = ">>";
            this.btnEnterCommand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEnterCommand.Click += new System.EventHandler(this.btnEnterCommand_Click);
            // 
            // lblAgentParent
            // 
            this.lblAgentParent.AutoSize = true;
            this.lblAgentParent.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentParent.Location = new System.Drawing.Point(858, 188);
            this.lblAgentParent.Name = "lblAgentParent";
            this.lblAgentParent.Size = new System.Drawing.Size(53, 19);
            this.lblAgentParent.TabIndex = 66;
            this.lblAgentParent.Text = "Parent";
            this.lblAgentParent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgentParent.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAgentDelay
            // 
            this.lblAgentDelay.AutoSize = true;
            this.lblAgentDelay.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentDelay.Location = new System.Drawing.Point(572, 45);
            this.lblAgentDelay.Name = "lblAgentDelay";
            this.lblAgentDelay.Size = new System.Drawing.Size(47, 19);
            this.lblAgentDelay.TabIndex = 65;
            this.lblAgentDelay.Text = "Delay";
            this.lblAgentDelay.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentParent
            // 
            this.txtAgentParent.Location = new System.Drawing.Point(976, 190);
            this.txtAgentParent.Name = "txtAgentParent";
            this.txtAgentParent.Size = new System.Drawing.Size(133, 23);
            this.txtAgentParent.TabIndex = 63;
            this.txtAgentParent.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentDelay
            // 
            this.txtAgentDelay.Location = new System.Drawing.Point(700, 45);
            this.txtAgentDelay.Name = "txtAgentDelay";
            this.txtAgentDelay.Size = new System.Drawing.Size(133, 23);
            this.txtAgentDelay.TabIndex = 62;
            this.txtAgentDelay.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentWorkingHours
            // 
            this.txtAgentWorkingHours.Location = new System.Drawing.Point(976, 161);
            this.txtAgentWorkingHours.Name = "txtAgentWorkingHours";
            this.txtAgentWorkingHours.Size = new System.Drawing.Size(133, 23);
            this.txtAgentWorkingHours.TabIndex = 61;
            this.txtAgentWorkingHours.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAgentWorkingHours.UseWaitCursor = true;
            // 
            // lblAgentWorkingHours
            // 
            this.lblAgentWorkingHours.AutoSize = true;
            this.lblAgentWorkingHours.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentWorkingHours.Location = new System.Drawing.Point(858, 159);
            this.lblAgentWorkingHours.Name = "lblAgentWorkingHours";
            this.lblAgentWorkingHours.Size = new System.Drawing.Size(111, 19);
            this.lblAgentWorkingHours.TabIndex = 60;
            this.lblAgentWorkingHours.Text = "Working Hours";
            this.lblAgentWorkingHours.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentSessionKey
            // 
            this.txtAgentSessionKey.Location = new System.Drawing.Point(976, 132);
            this.txtAgentSessionKey.Name = "txtAgentSessionKey";
            this.txtAgentSessionKey.Size = new System.Drawing.Size(133, 23);
            this.txtAgentSessionKey.TabIndex = 59;
            this.txtAgentSessionKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentSessionID
            // 
            this.txtAgentSessionID.Location = new System.Drawing.Point(976, 103);
            this.txtAgentSessionID.Name = "txtAgentSessionID";
            this.txtAgentSessionID.Size = new System.Drawing.Size(133, 23);
            this.txtAgentSessionID.TabIndex = 58;
            this.txtAgentSessionID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentJitter
            // 
            this.txtAgentJitter.Location = new System.Drawing.Point(976, 74);
            this.txtAgentJitter.Name = "txtAgentJitter";
            this.txtAgentJitter.Size = new System.Drawing.Size(133, 23);
            this.txtAgentJitter.TabIndex = 57;
            this.txtAgentJitter.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAgentSessionID
            // 
            this.lblAgentSessionID.AutoSize = true;
            this.lblAgentSessionID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentSessionID.Location = new System.Drawing.Point(858, 101);
            this.lblAgentSessionID.Name = "lblAgentSessionID";
            this.lblAgentSessionID.Size = new System.Drawing.Size(76, 19);
            this.lblAgentSessionID.TabIndex = 56;
            this.lblAgentSessionID.Text = "Session ID";
            this.lblAgentSessionID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAgentSessionKey
            // 
            this.lblAgentSessionKey.AutoSize = true;
            this.lblAgentSessionKey.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentSessionKey.Location = new System.Drawing.Point(858, 130);
            this.lblAgentSessionKey.Name = "lblAgentSessionKey";
            this.lblAgentSessionKey.Size = new System.Drawing.Size(87, 19);
            this.lblAgentSessionKey.TabIndex = 55;
            this.lblAgentSessionKey.Text = "Session Key";
            this.lblAgentSessionKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAgentJitter
            // 
            this.lblAgentJitter.AutoSize = true;
            this.lblAgentJitter.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentJitter.Location = new System.Drawing.Point(858, 72);
            this.lblAgentJitter.Name = "lblAgentJitter";
            this.lblAgentJitter.Size = new System.Drawing.Size(43, 19);
            this.lblAgentJitter.TabIndex = 54;
            this.lblAgentJitter.Text = "Jitter";
            this.lblAgentJitter.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAgentLostLimit
            // 
            this.lblAgentLostLimit.AutoSize = true;
            this.lblAgentLostLimit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentLostLimit.Location = new System.Drawing.Point(572, 246);
            this.lblAgentLostLimit.Name = "lblAgentLostLimit";
            this.lblAgentLostLimit.Size = new System.Drawing.Size(73, 19);
            this.lblAgentLostLimit.TabIndex = 53;
            this.lblAgentLostLimit.Text = "Lost Limit";
            this.lblAgentLostLimit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLastSeen
            // 
            this.lblLastSeen.AutoSize = true;
            this.lblLastSeen.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLastSeen.Location = new System.Drawing.Point(572, 217);
            this.lblLastSeen.Name = "lblLastSeen";
            this.lblLastSeen.Size = new System.Drawing.Size(71, 19);
            this.lblLastSeen.TabIndex = 52;
            this.lblLastSeen.Text = "Last Seen";
            this.lblLastSeen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastSeen.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLanguageVersion
            // 
            this.lblLanguageVersion.AutoSize = true;
            this.lblLanguageVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLanguageVersion.Location = new System.Drawing.Point(572, 188);
            this.lblLanguageVersion.Name = "lblLanguageVersion";
            this.lblLanguageVersion.Size = new System.Drawing.Size(127, 19);
            this.lblLanguageVersion.TabIndex = 51;
            this.lblLanguageVersion.Text = "Language Version";
            this.lblLanguageVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentLostLimit
            // 
            this.txtAgentLostLimit.Location = new System.Drawing.Point(700, 248);
            this.txtAgentLostLimit.Name = "txtAgentLostLimit";
            this.txtAgentLostLimit.Size = new System.Drawing.Size(133, 23);
            this.txtAgentLostLimit.TabIndex = 50;
            this.txtAgentLostLimit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentLastSeen
            // 
            this.txtAgentLastSeen.Location = new System.Drawing.Point(700, 219);
            this.txtAgentLastSeen.Name = "txtAgentLastSeen";
            this.txtAgentLastSeen.Size = new System.Drawing.Size(133, 23);
            this.txtAgentLastSeen.TabIndex = 49;
            this.txtAgentLastSeen.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentLanguageVersion
            // 
            this.txtAgentLanguageVersion.Location = new System.Drawing.Point(700, 190);
            this.txtAgentLanguageVersion.Name = "txtAgentLanguageVersion";
            this.txtAgentLanguageVersion.Size = new System.Drawing.Size(133, 23);
            this.txtAgentLanguageVersion.TabIndex = 48;
            this.txtAgentLanguageVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentLanguage
            // 
            this.txtAgentLanguage.Location = new System.Drawing.Point(700, 161);
            this.txtAgentLanguage.Name = "txtAgentLanguage";
            this.txtAgentLanguage.Size = new System.Drawing.Size(133, 23);
            this.txtAgentLanguage.TabIndex = 47;
            this.txtAgentLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLanguage.Location = new System.Drawing.Point(572, 159);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(74, 19);
            this.lblLanguage.TabIndex = 46;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentExternalIP
            // 
            this.txtAgentExternalIP.Location = new System.Drawing.Point(700, 132);
            this.txtAgentExternalIP.Name = "txtAgentExternalIP";
            this.txtAgentExternalIP.Size = new System.Drawing.Size(133, 23);
            this.txtAgentExternalIP.TabIndex = 45;
            this.txtAgentExternalIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentIntegrity
            // 
            this.txtAgentIntegrity.Location = new System.Drawing.Point(700, 103);
            this.txtAgentIntegrity.Name = "txtAgentIntegrity";
            this.txtAgentIntegrity.Size = new System.Drawing.Size(133, 23);
            this.txtAgentIntegrity.TabIndex = 44;
            this.txtAgentIntegrity.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentHostname
            // 
            this.txtAgentHostname.Location = new System.Drawing.Point(700, 74);
            this.txtAgentHostname.Name = "txtAgentHostname";
            this.txtAgentHostname.Size = new System.Drawing.Size(133, 23);
            this.txtAgentHostname.TabIndex = 43;
            this.txtAgentHostname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblIntegrity
            // 
            this.lblIntegrity.AutoSize = true;
            this.lblIntegrity.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIntegrity.Location = new System.Drawing.Point(572, 101);
            this.lblIntegrity.Name = "lblIntegrity";
            this.lblIntegrity.Size = new System.Drawing.Size(66, 19);
            this.lblIntegrity.TabIndex = 42;
            this.lblIntegrity.Text = "Integrity";
            this.lblIntegrity.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblExternalIP
            // 
            this.lblExternalIP.AutoSize = true;
            this.lblExternalIP.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblExternalIP.Location = new System.Drawing.Point(572, 130);
            this.lblExternalIP.Name = "lblExternalIP";
            this.lblExternalIP.Size = new System.Drawing.Size(80, 19);
            this.lblExternalIP.TabIndex = 41;
            this.lblExternalIP.Text = "External IP";
            this.lblExternalIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHostName.Location = new System.Drawing.Point(572, 72);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(84, 19);
            this.lblHostName.TabIndex = 40;
            this.lblHostName.Text = "Host Name";
            this.lblHostName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentKillDate
            // 
            this.txtAgentKillDate.Location = new System.Drawing.Point(976, 45);
            this.txtAgentKillDate.Name = "txtAgentKillDate";
            this.txtAgentKillDate.Size = new System.Drawing.Size(133, 23);
            this.txtAgentKillDate.TabIndex = 39;
            this.txtAgentKillDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAgentKillDate
            // 
            this.lblAgentKillDate.AutoSize = true;
            this.lblAgentKillDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAgentKillDate.Location = new System.Drawing.Point(858, 45);
            this.lblAgentKillDate.Name = "lblAgentKillDate";
            this.lblAgentKillDate.Size = new System.Drawing.Size(65, 19);
            this.lblAgentKillDate.TabIndex = 38;
            this.lblAgentKillDate.Text = "Kill Date";
            this.lblAgentKillDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnRefreshAgents
            // 
            this.btnRefreshAgents.Location = new System.Drawing.Point(264, 346);
            this.btnRefreshAgents.Name = "btnRefreshAgents";
            this.btnRefreshAgents.Size = new System.Drawing.Size(120, 23);
            this.btnRefreshAgents.TabIndex = 35;
            this.btnRefreshAgents.Text = "Refresh Agents";
            this.btnRefreshAgents.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRefreshAgents.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblAPIToken4
            // 
            this.lblAPIToken4.AutoSize = true;
            this.lblAPIToken4.Location = new System.Drawing.Point(1043, 612);
            this.lblAPIToken4.Name = "lblAPIToken4";
            this.lblAPIToken4.Size = new System.Drawing.Size(66, 19);
            this.lblAPIToken4.TabIndex = 34;
            this.lblAPIToken4.Text = "API Token";
            this.lblAPIToken4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnRenameAgent
            // 
            this.btnRenameAgent.Location = new System.Drawing.Point(390, 346);
            this.btnRenameAgent.Name = "btnRenameAgent";
            this.btnRenameAgent.Size = new System.Drawing.Size(120, 23);
            this.btnRenameAgent.TabIndex = 28;
            this.btnRenameAgent.Text = "Rename Agent (NOT DONE)";
            this.btnRenameAgent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRenameAgent.Click += new System.EventHandler(this.btnRenameAgent_Click);
            // 
            // btnRemoveAgent
            // 
            this.btnRemoveAgent.Location = new System.Drawing.Point(642, 346);
            this.btnRemoveAgent.Name = "btnRemoveAgent";
            this.btnRemoveAgent.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveAgent.TabIndex = 27;
            this.btnRemoveAgent.Text = "Remove Agent";
            this.btnRemoveAgent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveAgent.Click += new System.EventHandler(this.btnRemoveAgent_Click);
            // 
            // btnRemoveStale
            // 
            this.btnRemoveStale.Location = new System.Drawing.Point(894, 346);
            this.btnRemoveStale.Name = "btnRemoveStale";
            this.btnRemoveStale.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveStale.TabIndex = 26;
            this.btnRemoveStale.Text = "Remove Stale Agents";
            this.btnRemoveStale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveStale.Click += new System.EventHandler(this.btnRemoveStale_Click);
            // 
            // btnGetStale
            // 
            this.btnGetStale.Location = new System.Drawing.Point(768, 346);
            this.btnGetStale.Name = "btnGetStale";
            this.btnGetStale.Size = new System.Drawing.Size(120, 23);
            this.btnGetStale.TabIndex = 25;
            this.btnGetStale.Text = "Get Stale Agents";
            this.btnGetStale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGetStale.Click += new System.EventHandler(this.btnGetStale_Click);
            // 
            // lstAgents
            // 
            this.lstAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstAgents.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstAgents.FormattingEnabled = true;
            this.lstAgents.ItemHeight = 15;
            this.lstAgents.Location = new System.Drawing.Point(17, 45);
            this.lstAgents.Name = "lstAgents";
            this.lstAgents.Size = new System.Drawing.Size(224, 574);
            this.lstAgents.TabIndex = 24;
            this.lstAgents.SelectedIndexChanged += new System.EventHandler(this.lstAgents_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(264, 246);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(39, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "User";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(264, 217);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Last Check-In";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(264, 188);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(104, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Process Name";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentUserName
            // 
            this.txtAgentUserName.Location = new System.Drawing.Point(417, 248);
            this.txtAgentUserName.Name = "txtAgentUserName";
            this.txtAgentUserName.Size = new System.Drawing.Size(133, 23);
            this.txtAgentUserName.TabIndex = 18;
            this.txtAgentUserName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentLastCheckin
            // 
            this.txtAgentLastCheckin.Location = new System.Drawing.Point(417, 219);
            this.txtAgentLastCheckin.Name = "txtAgentLastCheckin";
            this.txtAgentLastCheckin.Size = new System.Drawing.Size(133, 23);
            this.txtAgentLastCheckin.TabIndex = 17;
            this.txtAgentLastCheckin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentProcessName
            // 
            this.txtAgentProcessName.Location = new System.Drawing.Point(417, 190);
            this.txtAgentProcessName.Name = "txtAgentProcessName";
            this.txtAgentProcessName.Size = new System.Drawing.Size(133, 23);
            this.txtAgentProcessName.TabIndex = 16;
            this.txtAgentProcessName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentProcessID
            // 
            this.txtAgentProcessID.Location = new System.Drawing.Point(417, 161);
            this.txtAgentProcessID.Name = "txtAgentProcessID";
            this.txtAgentProcessID.Size = new System.Drawing.Size(133, 23);
            this.txtAgentProcessID.TabIndex = 15;
            this.txtAgentProcessID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(264, 159);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Process ID";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentInternalIP
            // 
            this.txtAgentInternalIP.Location = new System.Drawing.Point(417, 132);
            this.txtAgentInternalIP.Name = "txtAgentInternalIP";
            this.txtAgentInternalIP.Size = new System.Drawing.Size(133, 23);
            this.txtAgentInternalIP.TabIndex = 13;
            this.txtAgentInternalIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentOperatingSystem
            // 
            this.txtAgentOperatingSystem.Location = new System.Drawing.Point(417, 103);
            this.txtAgentOperatingSystem.Name = "txtAgentOperatingSystem";
            this.txtAgentOperatingSystem.Size = new System.Drawing.Size(133, 23);
            this.txtAgentOperatingSystem.TabIndex = 12;
            this.txtAgentOperatingSystem.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(417, 74);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(133, 23);
            this.txtAgentName.TabIndex = 11;
            this.txtAgentName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAgentListenerName
            // 
            this.txtAgentListenerName.Location = new System.Drawing.Point(417, 45);
            this.txtAgentListenerName.Name = "txtAgentListenerName";
            this.txtAgentListenerName.Size = new System.Drawing.Size(133, 23);
            this.txtAgentListenerName.TabIndex = 10;
            this.txtAgentListenerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(264, 45);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Listener Name";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(264, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Operating System";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(264, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Internal IP Address";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(264, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Agent Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.Location = new System.Drawing.Point(264, 375);
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(820, 23);
            this.txtConsoleInput.TabIndex = 5;
            this.txtConsoleInput.Text = "Select an Agent";
            this.txtConsoleInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsoleInput_KeyDown);
            // 
            // txtConsoleLog
            // 
            this.txtConsoleLog.Location = new System.Drawing.Point(264, 404);
            this.txtConsoleLog.Multiline = true;
            this.txtConsoleLog.Name = "txtConsoleLog";
            this.txtConsoleLog.ReadOnly = true;
            this.txtConsoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsoleLog.Size = new System.Drawing.Size(859, 205);
            this.txtConsoleLog.TabIndex = 4;
            this.txtConsoleLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAgents
            // 
            this.lblAgents.AutoSize = true;
            this.lblAgents.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAgents.Location = new System.Drawing.Point(78, 17);
            this.lblAgents.Name = "lblAgents";
            this.lblAgents.Size = new System.Drawing.Size(64, 25);
            this.lblAgents.TabIndex = 3;
            this.lblAgents.Text = "Agents";
            this.lblAgents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgents.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.btnRestartAPI);
            this.tabOptions.Controls.Add(this.btnShutDown);
            this.tabOptions.Controls.Add(this.btnRTJ);
            this.tabOptions.Controls.Add(this.btnChangePolling);
            this.tabOptions.Controls.Add(this.btnRefreshAll);
            this.tabOptions.Controls.Add(this.btnChangeAPIToken);
            this.tabOptions.Controls.Add(this.btnGetEmpireGUIVersion);
            this.tabOptions.Controls.Add(this.btnExit);
            this.tabOptions.HorizontalScrollbarBarColor = true;
            this.tabOptions.Location = new System.Drawing.Point(4, 35);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(1131, 631);
            this.tabOptions.TabIndex = 5;
            this.tabOptions.Text = "EmpireGUI Options";
            this.tabOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabOptions.VerticalScrollbarBarColor = true;
            // 
            // btnRestartAPI
            // 
            this.btnRestartAPI.Location = new System.Drawing.Point(3, 384);
            this.btnRestartAPI.Name = "btnRestartAPI";
            this.btnRestartAPI.Size = new System.Drawing.Size(148, 48);
            this.btnRestartAPI.TabIndex = 9;
            this.btnRestartAPI.Text = "Restart API";
            this.btnRestartAPI.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRestartAPI.Click += new System.EventHandler(this.btnRestartAPI_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.Location = new System.Drawing.Point(3, 330);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(148, 48);
            this.btnShutDown.TabIndex = 8;
            this.btnShutDown.Text = "Shutdown REST API";
            this.btnShutDown.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnRTJ
            // 
            this.btnRTJ.Location = new System.Drawing.Point(3, 276);
            this.btnRTJ.Name = "btnRTJ";
            this.btnRTJ.Size = new System.Drawing.Size(148, 48);
            this.btnRTJ.TabIndex = 7;
            this.btnRTJ.Text = "Run the Jewels";
            this.btnRTJ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRTJ.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // btnChangePolling
            // 
            this.btnChangePolling.Location = new System.Drawing.Point(3, 222);
            this.btnChangePolling.Name = "btnChangePolling";
            this.btnChangePolling.Size = new System.Drawing.Size(148, 48);
            this.btnChangePolling.TabIndex = 6;
            this.btnChangePolling.Text = "Change Polling Value";
            this.btnChangePolling.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnChangePolling.Click += new System.EventHandler(this.btnChangePolling_Click);
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Location = new System.Drawing.Point(3, 168);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(148, 48);
            this.btnRefreshAll.TabIndex = 5;
            this.btnRefreshAll.Text = "Refresh All Data";
            this.btnRefreshAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // btnChangeAPIToken
            // 
            this.btnChangeAPIToken.Location = new System.Drawing.Point(3, 114);
            this.btnChangeAPIToken.Name = "btnChangeAPIToken";
            this.btnChangeAPIToken.Size = new System.Drawing.Size(148, 48);
            this.btnChangeAPIToken.TabIndex = 4;
            this.btnChangeAPIToken.Text = "Change API Token";
            this.btnChangeAPIToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnChangeAPIToken.Click += new System.EventHandler(this.btnChangeAPIToken_Click);
            // 
            // btnGetEmpireGUIVersion
            // 
            this.btnGetEmpireGUIVersion.Location = new System.Drawing.Point(3, 6);
            this.btnGetEmpireGUIVersion.Name = "btnGetEmpireGUIVersion";
            this.btnGetEmpireGUIVersion.Size = new System.Drawing.Size(148, 48);
            this.btnGetEmpireGUIVersion.TabIndex = 3;
            this.btnGetEmpireGUIVersion.Text = "Get EmpireGUI Version";
            this.btnGetEmpireGUIVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGetEmpireGUIVersion.Click += new System.EventHandler(this.btnGetEmpireGUIVersion_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 60);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Empire GUI";
            this.btnExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabModules
            // 
            this.tabModules.Controls.Add(this.pnlModuleOptions);
            this.tabModules.Controls.Add(this.btnSearchModules);
            this.tabModules.Controls.Add(this.lblAPIToken2);
            this.tabModules.Controls.Add(this.btnClear);
            this.tabModules.Controls.Add(this.metroLabel23);
            this.tabModules.Controls.Add(this.metroLabel21);
            this.tabModules.Controls.Add(this.txtAuthor);
            this.tabModules.Controls.Add(this.txtDescription);
            this.tabModules.Controls.Add(this.txtBackground);
            this.tabModules.Controls.Add(this.txtOutputExtension);
            this.tabModules.Controls.Add(this.txtNeedsAdmin);
            this.tabModules.Controls.Add(this.txtOpSecSafe);
            this.tabModules.Controls.Add(this.txtLanguage);
            this.tabModules.Controls.Add(this.txtMinLangReq);
            this.tabModules.Controls.Add(this.txtComments);
            this.tabModules.Controls.Add(this.txtModuleName);
            this.tabModules.Controls.Add(this.metroLabel20);
            this.tabModules.Controls.Add(this.metroLabel19);
            this.tabModules.Controls.Add(this.metroLabel18);
            this.tabModules.Controls.Add(this.metroLabel17);
            this.tabModules.Controls.Add(this.metroLabel16);
            this.tabModules.Controls.Add(this.metroLabel15);
            this.tabModules.Controls.Add(this.metroLabel14);
            this.tabModules.Controls.Add(this.metroLabel13);
            this.tabModules.Controls.Add(this.metroLabel12);
            this.tabModules.Controls.Add(this.metroLabel11);
            this.tabModules.Controls.Add(this.btnRunModule);
            this.tabModules.Controls.Add(this.treeModules);
            this.tabModules.HorizontalScrollbarBarColor = true;
            this.tabModules.Location = new System.Drawing.Point(4, 35);
            this.tabModules.Name = "tabModules";
            this.tabModules.Size = new System.Drawing.Size(1131, 631);
            this.tabModules.TabIndex = 1;
            this.tabModules.Text = "Use Module";
            this.tabModules.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabModules.VerticalScrollbarBarColor = true;
            // 
            // pnlModuleOptions
            // 
            this.pnlModuleOptions.AutoScroll = true;
            this.pnlModuleOptions.HorizontalScrollbar = true;
            this.pnlModuleOptions.HorizontalScrollbarBarColor = true;
            this.pnlModuleOptions.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlModuleOptions.HorizontalScrollbarSize = 5;
            this.pnlModuleOptions.Location = new System.Drawing.Point(273, 282);
            this.pnlModuleOptions.Name = "pnlModuleOptions";
            this.pnlModuleOptions.Size = new System.Drawing.Size(647, 346);
            this.pnlModuleOptions.Style = MetroFramework.MetroColorStyle.Black;
            this.pnlModuleOptions.TabIndex = 33;
            this.pnlModuleOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlModuleOptions.VerticalScrollbar = true;
            this.pnlModuleOptions.VerticalScrollbarBarColor = true;
            this.pnlModuleOptions.VerticalScrollbarHighlightOnWheel = false;
            this.pnlModuleOptions.VerticalScrollbarSize = 5;
            // 
            // btnSearchModules
            // 
            this.btnSearchModules.Location = new System.Drawing.Point(926, 416);
            this.btnSearchModules.Name = "btnSearchModules";
            this.btnSearchModules.Size = new System.Drawing.Size(174, 61);
            this.btnSearchModules.TabIndex = 32;
            this.btnSearchModules.Text = "Search Modules";
            this.btnSearchModules.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearchModules.Click += new System.EventHandler(this.btnSearchModules_Click);
            // 
            // lblAPIToken2
            // 
            this.lblAPIToken2.AutoSize = true;
            this.lblAPIToken2.Location = new System.Drawing.Point(1034, 612);
            this.lblAPIToken2.Name = "lblAPIToken2";
            this.lblAPIToken2.Size = new System.Drawing.Size(66, 19);
            this.lblAPIToken2.TabIndex = 31;
            this.lblAPIToken2.Text = "API Token";
            this.lblAPIToken2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(926, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 61);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear Options";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel23.Location = new System.Drawing.Point(314, 13);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(184, 25);
            this.metroLabel23.TabIndex = 28;
            this.metroLabel23.Text = "Module Information";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.Location = new System.Drawing.Point(314, 254);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(149, 25);
            this.metroLabel21.TabIndex = 24;
            this.metroLabel21.Text = "Module Options";
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(407, 76);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(127, 23);
            this.txtAuthor.TabIndex = 23;
            this.txtAuthor.Tag = "NoSend";
            this.txtAuthor.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(407, 105);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(255, 57);
            this.txtDescription.TabIndex = 22;
            this.txtDescription.Tag = "NoSend";
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtBackground
            // 
            this.txtBackground.Location = new System.Drawing.Point(407, 168);
            this.txtBackground.Multiline = true;
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.ReadOnly = true;
            this.txtBackground.Size = new System.Drawing.Size(127, 23);
            this.txtBackground.TabIndex = 21;
            this.txtBackground.Tag = "NoSend";
            this.txtBackground.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtOutputExtension
            // 
            this.txtOutputExtension.Location = new System.Drawing.Point(407, 197);
            this.txtOutputExtension.Multiline = true;
            this.txtOutputExtension.Name = "txtOutputExtension";
            this.txtOutputExtension.ReadOnly = true;
            this.txtOutputExtension.Size = new System.Drawing.Size(127, 23);
            this.txtOutputExtension.TabIndex = 20;
            this.txtOutputExtension.Tag = "NoSend";
            this.txtOutputExtension.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtNeedsAdmin
            // 
            this.txtNeedsAdmin.Location = new System.Drawing.Point(827, 47);
            this.txtNeedsAdmin.Multiline = true;
            this.txtNeedsAdmin.Name = "txtNeedsAdmin";
            this.txtNeedsAdmin.ReadOnly = true;
            this.txtNeedsAdmin.Size = new System.Drawing.Size(127, 23);
            this.txtNeedsAdmin.TabIndex = 19;
            this.txtNeedsAdmin.Tag = "NoSend";
            this.txtNeedsAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtOpSecSafe
            // 
            this.txtOpSecSafe.Location = new System.Drawing.Point(827, 76);
            this.txtOpSecSafe.Multiline = true;
            this.txtOpSecSafe.Name = "txtOpSecSafe";
            this.txtOpSecSafe.ReadOnly = true;
            this.txtOpSecSafe.Size = new System.Drawing.Size(127, 23);
            this.txtOpSecSafe.TabIndex = 18;
            this.txtOpSecSafe.Tag = "NoSend";
            this.txtOpSecSafe.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(827, 172);
            this.txtLanguage.Multiline = true;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(127, 23);
            this.txtLanguage.TabIndex = 17;
            this.txtLanguage.Tag = "NoSend";
            this.txtLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMinLangReq
            // 
            this.txtMinLangReq.Location = new System.Drawing.Point(827, 201);
            this.txtMinLangReq.Multiline = true;
            this.txtMinLangReq.Name = "txtMinLangReq";
            this.txtMinLangReq.ReadOnly = true;
            this.txtMinLangReq.Size = new System.Drawing.Size(127, 23);
            this.txtMinLangReq.TabIndex = 16;
            this.txtMinLangReq.Tag = "NoSend";
            this.txtMinLangReq.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(827, 105);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(226, 57);
            this.txtComments.TabIndex = 15;
            this.txtComments.Tag = "NoSend";
            this.txtComments.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(407, 47);
            this.txtModuleName.Multiline = true;
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.ReadOnly = true;
            this.txtModuleName.Size = new System.Drawing.Size(255, 23);
            this.txtModuleName.TabIndex = 14;
            this.txtModuleName.Tag = "NoSend";
            this.txtModuleName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(730, 105);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(76, 19);
            this.metroLabel20.TabIndex = 13;
            this.metroLabel20.Text = "Comments";
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(724, 201);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(97, 19);
            this.metroLabel19.TabIndex = 12;
            this.metroLabel19.Text = "Min Language";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(730, 172);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(69, 19);
            this.metroLabel18.TabIndex = 11;
            this.metroLabel18.Text = "Language";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(730, 76);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(76, 19);
            this.metroLabel17.TabIndex = 10;
            this.metroLabel17.Text = "Opsec Safe";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(730, 47);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(91, 19);
            this.metroLabel16.TabIndex = 9;
            this.metroLabel16.Text = "Needs Admin";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(287, 197);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(116, 19);
            this.metroLabel15.TabIndex = 8;
            this.metroLabel15.Text = "Output Extension";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(287, 168);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(82, 19);
            this.metroLabel14.TabIndex = 7;
            this.metroLabel14.Text = "Background";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(287, 105);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(78, 19);
            this.metroLabel13.TabIndex = 6;
            this.metroLabel13.Text = "Description";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(287, 76);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(52, 19);
            this.metroLabel12.TabIndex = 5;
            this.metroLabel12.Text = "Author";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(287, 47);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(96, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Module Name";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnRunModule
            // 
            this.btnRunModule.Location = new System.Drawing.Point(926, 282);
            this.btnRunModule.Name = "btnRunModule";
            this.btnRunModule.Size = new System.Drawing.Size(174, 61);
            this.btnRunModule.TabIndex = 3;
            this.btnRunModule.Text = "Run Module";
            this.btnRunModule.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRunModule.Click += new System.EventHandler(this.btnRunModule_Click);
            // 
            // treeModules
            // 
            this.treeModules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.treeModules.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeModules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.treeModules.HideSelection = false;
            this.treeModules.Location = new System.Drawing.Point(3, 13);
            this.treeModules.Name = "treeModules";
            this.treeModules.Size = new System.Drawing.Size(264, 611);
            this.treeModules.TabIndex = 2;
            this.treeModules.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeModules_AfterSelect);
            // 
            // tabListeners
            // 
            this.tabListeners.Controls.Add(this.cmbListenerSelect);
            this.tabListeners.Controls.Add(this.ctrlListeners);
            this.tabListeners.Controls.Add(this.metroLabel26);
            this.tabListeners.Controls.Add(this.btnkillAllListeners);
            this.tabListeners.Controls.Add(this.btnDeleteListener);
            this.tabListeners.Controls.Add(this.metroLabel41);
            this.tabListeners.Controls.Add(this.metroLabel40);
            this.tabListeners.Controls.Add(this.metroLabel39);
            this.tabListeners.Controls.Add(this.btnClearListenerOptions);
            this.tabListeners.Controls.Add(this.btnNewListener);
            this.tabListeners.Controls.Add(this.lstListeners);
            this.tabListeners.Controls.Add(this.metroLabel10);
            this.tabListeners.Controls.Add(this.metroLabel9);
            this.tabListeners.HorizontalScrollbarBarColor = true;
            this.tabListeners.Location = new System.Drawing.Point(4, 35);
            this.tabListeners.Name = "tabListeners";
            this.tabListeners.Size = new System.Drawing.Size(1131, 631);
            this.tabListeners.TabIndex = 0;
            this.tabListeners.Text = "Listeners";
            this.tabListeners.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabListeners.VerticalScrollbarBarColor = true;
            // 
            // cmbListenerSelect
            // 
            this.cmbListenerSelect.FormattingEnabled = true;
            this.cmbListenerSelect.ItemHeight = 23;
            this.cmbListenerSelect.Location = new System.Drawing.Point(17, 47);
            this.cmbListenerSelect.Name = "cmbListenerSelect";
            this.cmbListenerSelect.Size = new System.Drawing.Size(224, 29);
            this.cmbListenerSelect.TabIndex = 101;
            this.cmbListenerSelect.SelectedIndexChanged += new System.EventHandler(this.cmbListenerSelect_SelectedIndexChanged);
            // 
            // ctrlListeners
            // 
            this.ctrlListeners.AutoScroll = true;
            this.ctrlListeners.Controls.Add(this.lblModuleType);
            this.ctrlListeners.Controls.Add(this.lblListID);
            this.ctrlListeners.Controls.Add(this.lblListenerCategory);
            this.ctrlListeners.Controls.Add(this.lblListenerID);
            this.ctrlListeners.Controls.Add(this.lblListCat);
            this.ctrlListeners.Controls.Add(this.lblModType);
            this.ctrlListeners.Controls.Add(this.txtListID);
            this.ctrlListeners.Controls.Add(this.txtListCatVal);
            this.ctrlListeners.Controls.Add(this.txtModTypeValue);
            this.ctrlListeners.HorizontalScrollbar = true;
            this.ctrlListeners.HorizontalScrollbarBarColor = true;
            this.ctrlListeners.HorizontalScrollbarHighlightOnWheel = false;
            this.ctrlListeners.HorizontalScrollbarSize = 10;
            this.ctrlListeners.Location = new System.Drawing.Point(247, 37);
            this.ctrlListeners.Name = "ctrlListeners";
            this.ctrlListeners.Size = new System.Drawing.Size(656, 572);
            this.ctrlListeners.TabIndex = 100;
            this.ctrlListeners.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ctrlListeners.VerticalScrollbar = true;
            this.ctrlListeners.VerticalScrollbarBarColor = true;
            this.ctrlListeners.VerticalScrollbarHighlightOnWheel = false;
            this.ctrlListeners.VerticalScrollbarSize = 10;
            // 
            // lblModuleType
            // 
            this.lblModuleType.AutoSize = true;
            this.lblModuleType.Location = new System.Drawing.Point(155, 67);
            this.lblModuleType.Name = "lblModuleType";
            this.lblModuleType.Size = new System.Drawing.Size(201, 19);
            this.lblModuleType.TabIndex = 99;
            this.lblModuleType.Text = "The Module used for the Listener";
            this.lblModuleType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblListID
            // 
            this.lblListID.AutoSize = true;
            this.lblListID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblListID.Location = new System.Drawing.Point(3, 9);
            this.lblListID.Name = "lblListID";
            this.lblListID.Size = new System.Drawing.Size(79, 19);
            this.lblListID.TabIndex = 93;
            this.lblListID.Tag = "AlwaysShow";
            this.lblListID.Text = "Listener ID";
            this.lblListID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblListenerCategory
            // 
            this.lblListenerCategory.AutoSize = true;
            this.lblListenerCategory.Location = new System.Drawing.Point(155, 38);
            this.lblListenerCategory.Name = "lblListenerCategory";
            this.lblListenerCategory.Size = new System.Drawing.Size(175, 19);
            this.lblListenerCategory.TabIndex = 97;
            this.lblListenerCategory.Text = "The Category of the Listener";
            this.lblListenerCategory.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblListenerID
            // 
            this.lblListenerID.AutoSize = true;
            this.lblListenerID.Location = new System.Drawing.Point(153, 9);
            this.lblListenerID.Name = "lblListenerID";
            this.lblListenerID.Size = new System.Drawing.Size(207, 19);
            this.lblListenerID.TabIndex = 95;
            this.lblListenerID.Text = "The ID associated with the Listener";
            this.lblListenerID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblListCat
            // 
            this.lblListCat.AutoSize = true;
            this.lblListCat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblListCat.Location = new System.Drawing.Point(3, 38);
            this.lblListCat.Name = "lblListCat";
            this.lblListCat.Size = new System.Drawing.Size(128, 19);
            this.lblListCat.TabIndex = 27;
            this.lblListCat.Tag = "AlwaysShow";
            this.lblListCat.Text = "Listener Category";
            this.lblListCat.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblModType
            // 
            this.lblModType.AutoSize = true;
            this.lblModType.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblModType.Location = new System.Drawing.Point(3, 66);
            this.lblModType.Name = "lblModType";
            this.lblModType.Size = new System.Drawing.Size(96, 19);
            this.lblModType.TabIndex = 43;
            this.lblModType.Tag = "AlwaysShow";
            this.lblModType.Text = "Module Type";
            this.lblModType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtListID
            // 
            this.txtListID.Location = new System.Drawing.Point(471, 9);
            this.txtListID.Name = "txtListID";
            this.txtListID.Size = new System.Drawing.Size(182, 23);
            this.txtListID.TabIndex = 94;
            this.txtListID.Tag = "NoSend";
            this.txtListID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtListCatVal
            // 
            this.txtListCatVal.Location = new System.Drawing.Point(471, 38);
            this.txtListCatVal.Name = "txtListCatVal";
            this.txtListCatVal.Size = new System.Drawing.Size(182, 23);
            this.txtListCatVal.TabIndex = 46;
            this.txtListCatVal.Tag = "NoSend";
            this.txtListCatVal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtModTypeValue
            // 
            this.txtModTypeValue.Location = new System.Drawing.Point(471, 67);
            this.txtModTypeValue.Name = "txtModTypeValue";
            this.txtModTypeValue.Size = new System.Drawing.Size(182, 23);
            this.txtModTypeValue.TabIndex = 48;
            this.txtModTypeValue.Tag = "NoSend";
            this.txtModTypeValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(1034, 612);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(66, 19);
            this.metroLabel26.TabIndex = 80;
            this.metroLabel26.Text = "API Token";
            this.metroLabel26.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnkillAllListeners
            // 
            this.btnkillAllListeners.Location = new System.Drawing.Point(909, 464);
            this.btnkillAllListeners.Name = "btnkillAllListeners";
            this.btnkillAllListeners.Size = new System.Drawing.Size(209, 145);
            this.btnkillAllListeners.TabIndex = 79;
            this.btnkillAllListeners.Text = "Kill All Listeners";
            this.btnkillAllListeners.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnkillAllListeners.Click += new System.EventHandler(this.btnkillAllListeners_Click);
            // 
            // btnDeleteListener
            // 
            this.btnDeleteListener.Location = new System.Drawing.Point(909, 313);
            this.btnDeleteListener.Name = "btnDeleteListener";
            this.btnDeleteListener.Size = new System.Drawing.Size(209, 145);
            this.btnDeleteListener.TabIndex = 78;
            this.btnDeleteListener.Text = "Delete Listener";
            this.btnDeleteListener.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteListener.Click += new System.EventHandler(this.btnDeleteListener_Click);
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.Location = new System.Drawing.Point(712, 14);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(39, 19);
            this.metroLabel41.TabIndex = 77;
            this.metroLabel41.Tag = "AlwaysShow";
            this.metroLabel41.Text = "Value";
            this.metroLabel41.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.Location = new System.Drawing.Point(397, 14);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(74, 19);
            this.metroLabel40.TabIndex = 76;
            this.metroLabel40.Tag = "AlwaysShow";
            this.metroLabel40.Text = "Description";
            this.metroLabel40.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Location = new System.Drawing.Point(264, 14);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(50, 19);
            this.metroLabel39.TabIndex = 75;
            this.metroLabel39.Tag = "AlwaysShow";
            this.metroLabel39.Text = "Option";
            this.metroLabel39.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClearListenerOptions
            // 
            this.btnClearListenerOptions.Location = new System.Drawing.Point(909, 162);
            this.btnClearListenerOptions.Name = "btnClearListenerOptions";
            this.btnClearListenerOptions.Size = new System.Drawing.Size(209, 145);
            this.btnClearListenerOptions.TabIndex = 31;
            this.btnClearListenerOptions.Text = "Clear Options";
            this.btnClearListenerOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearListenerOptions.Click += new System.EventHandler(this.btnClearListenerOptions_Click);
            // 
            // btnNewListener
            // 
            this.btnNewListener.Location = new System.Drawing.Point(909, 11);
            this.btnNewListener.Name = "btnNewListener";
            this.btnNewListener.Size = new System.Drawing.Size(209, 145);
            this.btnNewListener.TabIndex = 30;
            this.btnNewListener.Text = "Add New Listener";
            this.btnNewListener.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNewListener.Click += new System.EventHandler(this.btnNewListener_Click);
            // 
            // lstListeners
            // 
            this.lstListeners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstListeners.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListeners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstListeners.FormattingEnabled = true;
            this.lstListeners.ItemHeight = 15;
            this.lstListeners.Items.AddRange(new object[] {
            "Listener1",
            "Listener2",
            "Listener3"});
            this.lstListeners.Location = new System.Drawing.Point(17, 127);
            this.lstListeners.Name = "lstListeners";
            this.lstListeners.Size = new System.Drawing.Size(224, 484);
            this.lstListeners.TabIndex = 25;
            this.lstListeners.SelectedIndexChanged += new System.EventHandler(this.lstListeners_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(34, 98);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(168, 25);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Tag = "AlwaysShow";
            this.metroLabel10.Text = "View Active Listeners";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(39, 19);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(163, 25);
            this.metroLabel9.TabIndex = 102;
            this.metroLabel9.Text = "Create New Listener";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabGenerateStager
            // 
            this.tabGenerateStager.Controls.Add(this.metroLabel27);
            this.tabGenerateStager.Controls.Add(this.lblAPIToken1);
            this.tabGenerateStager.Controls.Add(this.btnCreateNewListener);
            this.tabGenerateStager.Controls.Add(this.metroLabel25);
            this.tabGenerateStager.Controls.Add(this.lstStagers);
            this.tabGenerateStager.Controls.Add(this.metroLabel22);
            this.tabGenerateStager.Controls.Add(this.btnClearOptions);
            this.tabGenerateStager.Controls.Add(this.btnGenerateStager);
            this.tabGenerateStager.HorizontalScrollbarBarColor = true;
            this.tabGenerateStager.Location = new System.Drawing.Point(4, 35);
            this.tabGenerateStager.Name = "tabGenerateStager";
            this.tabGenerateStager.Size = new System.Drawing.Size(1131, 631);
            this.tabGenerateStager.TabIndex = 2;
            this.tabGenerateStager.Text = "Generate Stager";
            this.tabGenerateStager.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabGenerateStager.VerticalScrollbarBarColor = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(944, 19);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(156, 95);
            this.metroLabel27.TabIndex = 31;
            this.metroLabel27.Text = "To Do:\r\nBack Color - 34,34,34\r\nFore Color - 172, 179, 181\r\n\r\n(On listboxes)";
            this.metroLabel27.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblAPIToken1
            // 
            this.lblAPIToken1.AutoSize = true;
            this.lblAPIToken1.Location = new System.Drawing.Point(1034, 612);
            this.lblAPIToken1.Name = "lblAPIToken1";
            this.lblAPIToken1.Size = new System.Drawing.Size(66, 19);
            this.lblAPIToken1.TabIndex = 30;
            this.lblAPIToken1.Text = "API Token";
            this.lblAPIToken1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCreateNewListener
            // 
            this.btnCreateNewListener.Location = new System.Drawing.Point(956, 425);
            this.btnCreateNewListener.Name = "btnCreateNewListener";
            this.btnCreateNewListener.Size = new System.Drawing.Size(153, 106);
            this.btnCreateNewListener.TabIndex = 29;
            this.btnCreateNewListener.Text = "Create New Listener";
            this.btnCreateNewListener.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreateNewListener.Click += new System.EventHandler(this.btnCreateNewListener_Click);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel25.Location = new System.Drawing.Point(436, 22);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(104, 25);
            this.metroLabel25.TabIndex = 28;
            this.metroLabel25.Text = "Set Options:";
            this.metroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lstStagers
            // 
            this.lstStagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstStagers.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStagers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstStagers.FormattingEnabled = true;
            this.lstStagers.ItemHeight = 15;
            this.lstStagers.Items.AddRange(new object[] {
            "Supported Stager Types"});
            this.lstStagers.Location = new System.Drawing.Point(189, 22);
            this.lstStagers.Name = "lstStagers";
            this.lstStagers.Size = new System.Drawing.Size(224, 574);
            this.lstStagers.Sorted = true;
            this.lstStagers.TabIndex = 25;
            this.lstStagers.SelectedIndexChanged += new System.EventHandler(this.lstStagers_SelectedIndexChanged);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel22.Location = new System.Drawing.Point(17, 19);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(166, 25);
            this.metroLabel22.TabIndex = 5;
            this.metroLabel22.Text = "Select a Stager Type:";
            this.metroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClearOptions
            // 
            this.btnClearOptions.Location = new System.Drawing.Point(956, 313);
            this.btnClearOptions.Name = "btnClearOptions";
            this.btnClearOptions.Size = new System.Drawing.Size(153, 106);
            this.btnClearOptions.TabIndex = 3;
            this.btnClearOptions.Text = "Clear Options";
            this.btnClearOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearOptions.Click += new System.EventHandler(this.btnClearOptions_Click);
            // 
            // btnGenerateStager
            // 
            this.btnGenerateStager.Location = new System.Drawing.Point(956, 201);
            this.btnGenerateStager.Name = "btnGenerateStager";
            this.btnGenerateStager.Size = new System.Drawing.Size(153, 106);
            this.btnGenerateStager.TabIndex = 2;
            this.btnGenerateStager.Text = "Generate Stager";
            this.btnGenerateStager.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGenerateStager.Click += new System.EventHandler(this.btnGenerateStager_Click);
            // 
            // tabCredentials
            // 
            this.tabCredentials.Controls.Add(this.lblAPIToken3);
            this.tabCredentials.Controls.Add(this.btnSyncCredentials);
            this.tabCredentials.Controls.Add(this.metroLabel24);
            this.tabCredentials.Controls.Add(this.lblLoremIpsum);
            this.tabCredentials.Controls.Add(this.lblCredentials);
            this.tabCredentials.Controls.Add(this.btnCopyCredential);
            this.tabCredentials.Controls.Add(this.btnDeleteCredential);
            this.tabCredentials.Controls.Add(this.btnAddCredential);
            this.tabCredentials.Controls.Add(this.dgCredentials);
            this.tabCredentials.HorizontalScrollbarBarColor = true;
            this.tabCredentials.Location = new System.Drawing.Point(4, 35);
            this.tabCredentials.Name = "tabCredentials";
            this.tabCredentials.Size = new System.Drawing.Size(1131, 631);
            this.tabCredentials.TabIndex = 3;
            this.tabCredentials.Text = "Credentials";
            this.tabCredentials.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCredentials.VerticalScrollbarBarColor = true;
            // 
            // lblAPIToken3
            // 
            this.lblAPIToken3.AutoSize = true;
            this.lblAPIToken3.Location = new System.Drawing.Point(1034, 612);
            this.lblAPIToken3.Name = "lblAPIToken3";
            this.lblAPIToken3.Size = new System.Drawing.Size(66, 19);
            this.lblAPIToken3.TabIndex = 32;
            this.lblAPIToken3.Text = "API Token";
            this.lblAPIToken3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnSyncCredentials
            // 
            this.btnSyncCredentials.Location = new System.Drawing.Point(728, 605);
            this.btnSyncCredentials.Name = "btnSyncCredentials";
            this.btnSyncCredentials.Size = new System.Drawing.Size(154, 23);
            this.btnSyncCredentials.TabIndex = 9;
            this.btnSyncCredentials.Text = "Sync Credentials";
            this.btnSyncCredentials.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSyncCredentials.Click += new System.EventHandler(this.btnSyncCredentials_Click);
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(34, 64);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(956, 76);
            this.metroLabel24.TabIndex = 8;
            this.metroLabel24.Text = resources.GetString("metroLabel24.Text");
            this.metroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblLoremIpsum
            // 
            this.lblLoremIpsum.AutoSize = true;
            this.lblLoremIpsum.Location = new System.Drawing.Point(-1649, 86);
            this.lblLoremIpsum.Name = "lblLoremIpsum";
            this.lblLoremIpsum.Size = new System.Drawing.Size(1342, 57);
            this.lblLoremIpsum.TabIndex = 7;
            this.lblLoremIpsum.Text = resources.GetString("lblLoremIpsum.Text");
            this.lblLoremIpsum.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCredentials.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCredentials.Location = new System.Drawing.Point(17, 19);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(99, 25);
            this.lblCredentials.TabIndex = 6;
            this.lblCredentials.Text = "Credentials";
            this.lblCredentials.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCopyCredential
            // 
            this.btnCopyCredential.Location = new System.Drawing.Point(568, 605);
            this.btnCopyCredential.Name = "btnCopyCredential";
            this.btnCopyCredential.Size = new System.Drawing.Size(154, 23);
            this.btnCopyCredential.TabIndex = 5;
            this.btnCopyCredential.Text = "Copy Credential";
            this.btnCopyCredential.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCopyCredential.Click += new System.EventHandler(this.btnCopyCredential_Click);
            // 
            // btnDeleteCredential
            // 
            this.btnDeleteCredential.Location = new System.Drawing.Point(408, 605);
            this.btnDeleteCredential.Name = "btnDeleteCredential";
            this.btnDeleteCredential.Size = new System.Drawing.Size(154, 23);
            this.btnDeleteCredential.TabIndex = 4;
            this.btnDeleteCredential.Text = "Delete Credential";
            this.btnDeleteCredential.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteCredential.Click += new System.EventHandler(this.btnDeleteCredential_Click);
            // 
            // btnAddCredential
            // 
            this.btnAddCredential.Location = new System.Drawing.Point(248, 605);
            this.btnAddCredential.Name = "btnAddCredential";
            this.btnAddCredential.Size = new System.Drawing.Size(154, 23);
            this.btnAddCredential.TabIndex = 3;
            this.btnAddCredential.Text = "Add Credential";
            this.btnAddCredential.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddCredential.Click += new System.EventHandler(this.btnAddCredential_Click);
            // 
            // dgCredentials
            // 
            this.dgCredentials.AllowUserToAddRows = false;
            this.dgCredentials.AllowUserToDeleteRows = false;
            this.dgCredentials.AllowUserToResizeColumns = false;
            this.dgCredentials.AllowUserToResizeRows = false;
            this.dgCredentials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCredentials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dgCredentials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCredentials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCredentials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCredentials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCredID,
            this.colCredType,
            this.coLCredDomain,
            this.colCredUsername,
            this.colCredHost,
            this.colCredPassword});
            this.dgCredentials.GridColor = System.Drawing.Color.Black;
            this.dgCredentials.Location = new System.Drawing.Point(3, 210);
            this.dgCredentials.Name = "dgCredentials";
            this.dgCredentials.ReadOnly = true;
            this.dgCredentials.RowHeadersVisible = false;
            this.dgCredentials.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dgCredentials.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgCredentials.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgCredentials.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgCredentials.RowTemplate.ReadOnly = true;
            this.dgCredentials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCredentials.Size = new System.Drawing.Size(1125, 389);
            this.dgCredentials.TabIndex = 2;
            this.dgCredentials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCredentials_CellContentClick);
            // 
            // colCredID
            // 
            this.colCredID.HeaderText = "CredID";
            this.colCredID.Name = "colCredID";
            this.colCredID.ReadOnly = true;
            // 
            // colCredType
            // 
            this.colCredType.HeaderText = "Cred Type";
            this.colCredType.Name = "colCredType";
            this.colCredType.ReadOnly = true;
            // 
            // coLCredDomain
            // 
            this.coLCredDomain.HeaderText = "Domain";
            this.coLCredDomain.Name = "coLCredDomain";
            this.coLCredDomain.ReadOnly = true;
            // 
            // colCredUsername
            // 
            this.colCredUsername.HeaderText = "UserName";
            this.colCredUsername.Name = "colCredUsername";
            this.colCredUsername.ReadOnly = true;
            // 
            // colCredHost
            // 
            this.colCredHost.HeaderText = "Host";
            this.colCredHost.Name = "colCredHost";
            this.colCredHost.ReadOnly = true;
            // 
            // colCredPassword
            // 
            this.colCredPassword.HeaderText = "Password";
            this.colCredPassword.Name = "colCredPassword";
            this.colCredPassword.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 676);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmMain";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabActiveAgents.ResumeLayout(false);
            this.tabActiveAgents.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabModules.ResumeLayout(false);
            this.tabModules.PerformLayout();
            this.tabListeners.ResumeLayout(false);
            this.tabListeners.PerformLayout();
            this.ctrlListeners.ResumeLayout(false);
            this.ctrlListeners.PerformLayout();
            this.tabGenerateStager.ResumeLayout(false);
            this.tabGenerateStager.PerformLayout();
            this.tabCredentials.ResumeLayout(false);
            this.tabCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCredentials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabModules;
        private MetroFramework.Controls.MetroTabPage tabGenerateStager;
        private MetroFramework.Controls.MetroTabPage tabCredentials;
        private MetroFramework.Controls.MetroTabPage tabActiveAgents;
        private MetroFramework.Controls.MetroTabPage tabListeners;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtConsoleInput;
        private MetroFramework.Controls.MetroTextBox txtConsoleLog;
        private MetroFramework.Controls.MetroLabel lblAgents;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtAgentUserName;
        private MetroFramework.Controls.MetroTextBox txtAgentLastCheckin;
        private MetroFramework.Controls.MetroTextBox txtAgentProcessName;
        private MetroFramework.Controls.MetroTextBox txtAgentProcessID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtAgentInternalIP;
        private MetroFramework.Controls.MetroTextBox txtAgentOperatingSystem;
        private MetroFramework.Controls.MetroTextBox txtAgentName;
        private MetroFramework.Controls.MetroTextBox txtAgentListenerName;
        private System.Windows.Forms.TreeView treeModules;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txtAuthor;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtBackground;
        private MetroFramework.Controls.MetroTextBox txtOutputExtension;
        private MetroFramework.Controls.MetroTextBox txtNeedsAdmin;
        private MetroFramework.Controls.MetroTextBox txtOpSecSafe;
        private MetroFramework.Controls.MetroTextBox txtLanguage;
        private MetroFramework.Controls.MetroTextBox txtMinLangReq;
        private MetroFramework.Controls.MetroTextBox txtComments;
        private MetroFramework.Controls.MetroTextBox txtModuleName;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton btnRunModule;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroButton btnClearOptions;
        private MetroFramework.Controls.MetroButton btnGenerateStager;
        private System.Windows.Forms.ListBox lstAgents;
        private MetroFramework.Controls.MetroButton btnDeleteListener;
        private MetroFramework.Controls.MetroLabel metroLabel41;
        private MetroFramework.Controls.MetroLabel metroLabel40;
        private MetroFramework.Controls.MetroLabel metroLabel39;
        private MetroFramework.Controls.MetroTextBox txtModTypeValue;
        private MetroFramework.Controls.MetroTextBox txtListCatVal;
        private MetroFramework.Controls.MetroLabel lblModType;
        private MetroFramework.Controls.MetroButton btnClearListenerOptions;
        private MetroFramework.Controls.MetroButton btnNewListener;
        private MetroFramework.Controls.MetroLabel lblListCat;
        private System.Windows.Forms.ListBox lstListeners;
        private System.Windows.Forms.DataGridView dgCredentials;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredType;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLCredDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredPassword;
        private MetroFramework.Controls.MetroLabel lblCredentials;
        private MetroFramework.Controls.MetroButton btnCopyCredential;
        private MetroFramework.Controls.MetroButton btnDeleteCredential;
        private MetroFramework.Controls.MetroButton btnAddCredential;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel lblLoremIpsum;
        private MetroFramework.Controls.MetroButton btnSyncCredentials;
        private MetroFramework.Controls.MetroButton btnRemoveAgent;
        private MetroFramework.Controls.MetroButton btnRemoveStale;
        private MetroFramework.Controls.MetroButton btnGetStale;
        private System.Windows.Forms.ListBox lstStagers;
        private MetroFramework.Controls.MetroButton btnRenameAgent;
        private MetroFramework.Controls.MetroButton btnkillAllListeners;
        private MetroFramework.Controls.MetroLabel lblAPIToken2;
        private MetroFramework.Controls.MetroLabel lblAPIToken1;
        private MetroFramework.Controls.MetroButton btnCreateNewListener;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel lblAPIToken3;
        private MetroFramework.Controls.MetroLabel lblAPIToken4;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroButton btnSearchModules;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroTextBox txtListID;
        private MetroFramework.Controls.MetroLabel lblListID;
        private MetroFramework.Controls.MetroButton btnRefreshAgents;
        private MetroFramework.Controls.MetroLabel lblAgentParent;
        private MetroFramework.Controls.MetroLabel lblAgentDelay;
        private MetroFramework.Controls.MetroTextBox txtAgentParent;
        private MetroFramework.Controls.MetroTextBox txtAgentDelay;
        private MetroFramework.Controls.MetroTextBox txtAgentWorkingHours;
        private MetroFramework.Controls.MetroLabel lblAgentWorkingHours;
        private MetroFramework.Controls.MetroTextBox txtAgentSessionKey;
        private MetroFramework.Controls.MetroTextBox txtAgentSessionID;
        private MetroFramework.Controls.MetroTextBox txtAgentJitter;
        private MetroFramework.Controls.MetroLabel lblAgentSessionID;
        private MetroFramework.Controls.MetroLabel lblAgentSessionKey;
        private MetroFramework.Controls.MetroLabel lblAgentJitter;
        private MetroFramework.Controls.MetroLabel lblAgentLostLimit;
        private MetroFramework.Controls.MetroLabel lblLastSeen;
        private MetroFramework.Controls.MetroLabel lblLanguageVersion;
        private MetroFramework.Controls.MetroTextBox txtAgentLostLimit;
        private MetroFramework.Controls.MetroTextBox txtAgentLastSeen;
        private MetroFramework.Controls.MetroTextBox txtAgentLanguageVersion;
        private MetroFramework.Controls.MetroTextBox txtAgentLanguage;
        private MetroFramework.Controls.MetroLabel lblLanguage;
        private MetroFramework.Controls.MetroTextBox txtAgentExternalIP;
        private MetroFramework.Controls.MetroTextBox txtAgentIntegrity;
        private MetroFramework.Controls.MetroTextBox txtAgentHostname;
        private MetroFramework.Controls.MetroLabel lblIntegrity;
        private MetroFramework.Controls.MetroLabel lblExternalIP;
        private MetroFramework.Controls.MetroLabel lblHostName;
        private MetroFramework.Controls.MetroTextBox txtAgentKillDate;
        private MetroFramework.Controls.MetroLabel lblAgentKillDate;
        private MetroFramework.Controls.MetroLabel lblListenerID;
        private MetroFramework.Controls.MetroLabel lblListenerCategory;
        private MetroFramework.Controls.MetroLabel lblModuleType;
        private MetroFramework.Controls.MetroPanel pnlModuleOptions;
        private MetroFramework.Controls.MetroPanel ctrlListeners;
        private MetroFramework.Controls.MetroComboBox cmbListenerSelect;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTabPage tabOptions;
        private MetroFramework.Controls.MetroButton btnRTJ;
        private MetroFramework.Controls.MetroButton btnChangePolling;
        private MetroFramework.Controls.MetroButton btnRefreshAll;
        private MetroFramework.Controls.MetroButton btnChangeAPIToken;
        private MetroFramework.Controls.MetroButton btnGetEmpireGUIVersion;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnShutDown;
        private MetroFramework.Controls.MetroButton btnRestartAPI;
        private MetroFramework.Controls.MetroButton btnEnterCommand;
        private MetroFramework.Controls.MetroButton btnKillAgent;
    }
}