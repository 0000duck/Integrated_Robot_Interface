﻿namespace Integrated_Robot_Interface
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btnEsc = new System.Windows.Forms.Button();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.cboRobot = new System.Windows.Forms.ComboBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCurrentPosition = new System.Windows.Forms.GroupBox();
            this.lblJoint = new System.Windows.Forms.Label();
            this.lblXyzwpr = new System.Windows.Forms.Label();
            this.btnPositionHome = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbOverride = new System.Windows.Forms.GroupBox();
            this.btnPercentdown = new System.Windows.Forms.Button();
            this.btnPercentup = new System.Windows.Forms.Button();
            this.lblOverride = new System.Windows.Forms.Label();
            this.gbPointMove = new System.Windows.Forms.GroupBox();
            this.lblPTPRJ6Unit = new System.Windows.Forms.Label();
            this.lblPTPPJ5Unit = new System.Windows.Forms.Label();
            this.lblPTPWJ4Unit = new System.Windows.Forms.Label();
            this.lblPTPZJ3Unit = new System.Windows.Forms.Label();
            this.lblPTPYJ2Unit = new System.Windows.Forms.Label();
            this.lblPTPXJ1Unit = new System.Windows.Forms.Label();
            this.btnPTPSet = new System.Windows.Forms.Button();
            this.btnPTPGet = new System.Windows.Forms.Button();
            this.lblPTPYJ2 = new System.Windows.Forms.Label();
            this.lblPTPRJ6 = new System.Windows.Forms.Label();
            this.lblPTPWJ4 = new System.Windows.Forms.Label();
            this.lblPTPPJ5 = new System.Windows.Forms.Label();
            this.lblPTPZJ3 = new System.Windows.Forms.Label();
            this.lblPTPXJ1 = new System.Windows.Forms.Label();
            this.txtPTPRJ6 = new System.Windows.Forms.TextBox();
            this.txtPTPPJ5 = new System.Windows.Forms.TextBox();
            this.txtPTPWJ4 = new System.Windows.Forms.TextBox();
            this.txtPTPZJ3 = new System.Windows.Forms.TextBox();
            this.txtPTPYJ2 = new System.Windows.Forms.TextBox();
            this.txtPTPXJ1 = new System.Windows.Forms.TextBox();
            this.lblCoordinate = new System.Windows.Forms.Label();
            this.cboCoordinate = new System.Windows.Forms.ComboBox();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.btnRegisterSet = new System.Windows.Forms.Button();
            this.txtR5 = new System.Windows.Forms.TextBox();
            this.txtR4 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.lblSetR5 = new System.Windows.Forms.Label();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.lblSetR4 = new System.Windows.Forms.Label();
            this.lblSetR3 = new System.Windows.Forms.Label();
            this.lblSetR1 = new System.Windows.Forms.Label();
            this.lblSetR2 = new System.Windows.Forms.Label();
            this.gbJogMove = new System.Windows.Forms.GroupBox();
            this.cboJogStep = new System.Windows.Forms.ComboBox();
            this.lblJogStep = new System.Windows.Forms.Label();
            this.btnJogRJ6Positive = new System.Windows.Forms.Button();
            this.btnJogRJ6Negative = new System.Windows.Forms.Button();
            this.btnJogPJ5Positive = new System.Windows.Forms.Button();
            this.btnJogPJ5Negative = new System.Windows.Forms.Button();
            this.btnJogWJ4Positive = new System.Windows.Forms.Button();
            this.btnJogWJ4Negative = new System.Windows.Forms.Button();
            this.btnJogZJ3Positive = new System.Windows.Forms.Button();
            this.btnJogZJ3Negative = new System.Windows.Forms.Button();
            this.btnJogYJ2Positive = new System.Windows.Forms.Button();
            this.btnJogYJ2Negative = new System.Windows.Forms.Button();
            this.btnJogXJ1Positive = new System.Windows.Forms.Button();
            this.btnJogXJ1Negative = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.gbLineMove = new System.Windows.Forms.GroupBox();
            this.lblLineVelocityUnit = new System.Windows.Forms.Label();
            this.lblLineRJ6Unit = new System.Windows.Forms.Label();
            this.txtLineVelocity = new System.Windows.Forms.TextBox();
            this.lblLinePJ5Unit = new System.Windows.Forms.Label();
            this.lblLineVelocity = new System.Windows.Forms.Label();
            this.lblLineWJ4Unit = new System.Windows.Forms.Label();
            this.btnLineSet = new System.Windows.Forms.Button();
            this.lblLineZJ3Unit = new System.Windows.Forms.Label();
            this.btnLineGet = new System.Windows.Forms.Button();
            this.lblLineYJ2Unit = new System.Windows.Forms.Label();
            this.lblLineXJ1Unit = new System.Windows.Forms.Label();
            this.lblLineYJ2 = new System.Windows.Forms.Label();
            this.lblLineRJ6 = new System.Windows.Forms.Label();
            this.lblLineWJ4 = new System.Windows.Forms.Label();
            this.lblLinePJ5 = new System.Windows.Forms.Label();
            this.lblLineZJ3 = new System.Windows.Forms.Label();
            this.lblLineXJ1 = new System.Windows.Forms.Label();
            this.txtLineRJ6 = new System.Windows.Forms.TextBox();
            this.txtLinePJ5 = new System.Windows.Forms.TextBox();
            this.txtLineWJ4 = new System.Windows.Forms.TextBox();
            this.txtLineZJ3 = new System.Windows.Forms.TextBox();
            this.txtLineYJ2 = new System.Windows.Forms.TextBox();
            this.txtLineXJ1 = new System.Windows.Forms.TextBox();
            this.gbSafeRange = new System.Windows.Forms.GroupBox();
            this.txtSafeRangeVelocitymax = new System.Windows.Forms.TextBox();
            this.txtSafeRangeVelocitymin = new System.Windows.Forms.TextBox();
            this.lblSafeRangeVelocity = new System.Windows.Forms.Label();
            this.txtSafeRangeRJ6max = new System.Windows.Forms.TextBox();
            this.txtSafeRangePJ5max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeWJ4max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeRJ6min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeRJ6 = new System.Windows.Forms.Label();
            this.txtSafeRangeWJ4min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeWJ4 = new System.Windows.Forms.Label();
            this.txtSafeRangePJ5min = new System.Windows.Forms.TextBox();
            this.lblSafeRangePJ5 = new System.Windows.Forms.Label();
            this.txtSafeRangeZJ3max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeYJ2max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeXJ1max = new System.Windows.Forms.TextBox();
            this.txtSafeRangeZJ3min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeZJ3 = new System.Windows.Forms.Label();
            this.txtSafeRangeXJ1min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeXJ1 = new System.Windows.Forms.Label();
            this.txtSafeRangeYJ2min = new System.Windows.Forms.TextBox();
            this.lblSafeRangeYJ2 = new System.Windows.Forms.Label();
            this.btnSafeRangeSet = new System.Windows.Forms.Button();
            this.gbPoints = new System.Windows.Forms.GroupBox();
            this.btnPointsSave = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnPointsSet = new System.Windows.Forms.Button();
            this.btnPointsLoad = new System.Windows.Forms.Button();
            this.btnPointsGet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.btnProgramCopy = new System.Windows.Forms.Button();
            this.lblProgramValue = new System.Windows.Forms.Label();
            this.txtProgramValue = new System.Windows.Forms.TextBox();
            this.lblProgramUnit = new System.Windows.Forms.Label();
            this.lblProgramInstruction = new System.Windows.Forms.Label();
            this.btnProgramGet = new System.Windows.Forms.Button();
            this.btnProgramCompile = new System.Windows.Forms.Button();
            this.btnProgramClear = new System.Windows.Forms.Button();
            this.btnProgramDelete = new System.Windows.Forms.Button();
            this.btnProgramEdit = new System.Windows.Forms.Button();
            this.btnProgramInsert = new System.Windows.Forms.Button();
            this.btnProgramAdd = new System.Windows.Forms.Button();
            this.cboProgramInstruction = new System.Windows.Forms.ComboBox();
            this.lblProgramYJ2 = new System.Windows.Forms.Label();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.lblProgramRJ6 = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblProgramWJ4 = new System.Windows.Forms.Label();
            this.lstProgram = new System.Windows.Forms.ListBox();
            this.lblProgramPJ5 = new System.Windows.Forms.Label();
            this.txtProgramXJ1 = new System.Windows.Forms.TextBox();
            this.lblProgramZJ3 = new System.Windows.Forms.Label();
            this.txtProgramYJ2 = new System.Windows.Forms.TextBox();
            this.lblProgramXJ1 = new System.Windows.Forms.Label();
            this.txtProgramZJ3 = new System.Windows.Forms.TextBox();
            this.txtProgramRJ6 = new System.Windows.Forms.TextBox();
            this.txtProgramWJ4 = new System.Windows.Forms.TextBox();
            this.txtProgramPJ5 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPMove = new System.Windows.Forms.TabPage();
            this.tPInformation = new System.Windows.Forms.TabPage();
            this.gbInformation1 = new System.Windows.Forms.GroupBox();
            this.lblInformation1 = new System.Windows.Forms.Label();
            this.gbInformation3 = new System.Windows.Forms.GroupBox();
            this.lblInformation3 = new System.Windows.Forms.Label();
            this.gbInformation2 = new System.Windows.Forms.GroupBox();
            this.lblInformation2 = new System.Windows.Forms.Label();
            this.tPProgram = new System.Windows.Forms.TabPage();
            this.tPOther = new System.Windows.Forms.TabPage();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGetRegister = new System.Windows.Forms.Label();
            this.lblTool = new System.Windows.Forms.Label();
            this.lblUFrame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.gbCurrentPosition.SuspendLayout();
            this.gbOverride.SuspendLayout();
            this.gbPointMove.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbJogMove.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbLineMove.SuspendLayout();
            this.gbSafeRange.SuspendLayout();
            this.gbPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProgram.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tPMove.SuspendLayout();
            this.tPInformation.SuspendLayout();
            this.gbInformation1.SuspendLayout();
            this.gbInformation3.SuspendLayout();
            this.gbInformation2.SuspendLayout();
            this.tPProgram.SuspendLayout();
            this.tPOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Integrated_Robot_Interface.Properties.Resources.lion;
            this.pblogo.Location = new System.Drawing.Point(12, 12);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(125, 125);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // btnEsc
            // 
            this.btnEsc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEsc.Location = new System.Drawing.Point(1108, 58);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(100, 50);
            this.btnEsc.TabIndex = 1;
            this.btnEsc.Text = "ESC";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lblIP);
            this.gbConnection.Controls.Add(this.cboRobot);
            this.gbConnection.Controls.Add(this.lblConnectionStatus);
            this.gbConnection.Controls.Add(this.btnConnection);
            this.gbConnection.Controls.Add(this.txtIP);
            this.gbConnection.Controls.Add(this.lblSelect);
            this.gbConnection.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbConnection.Location = new System.Drawing.Point(146, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(294, 125);
            this.gbConnection.TabIndex = 2;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 88);
            this.lblIP.Margin = new System.Windows.Forms.Padding(3);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(38, 21);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "IP :";
            // 
            // cboRobot
            // 
            this.cboRobot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRobot.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboRobot.FormattingEnabled = true;
            this.cboRobot.ItemHeight = 16;
            this.cboRobot.Location = new System.Drawing.Point(128, 31);
            this.cboRobot.Name = "cboRobot";
            this.cboRobot.Size = new System.Drawing.Size(155, 24);
            this.cboRobot.TabIndex = 8;
            this.cboRobot.SelectedIndexChanged += new System.EventHandler(this.cboRobot_SelectedIndexChanged);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(6, 61);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(277, 21);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Connection Status : Disconnected";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnection.Location = new System.Drawing.Point(167, 88);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(116, 27);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIP.Location = new System.Drawing.Point(50, 88);
            this.txtIP.Name = "txtIP";
            this.txtIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIP.Size = new System.Drawing.Size(111, 27);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelect.Location = new System.Drawing.Point(6, 31);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(126, 21);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "Select Robot : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(446, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 125);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbCurrentPosition
            // 
            this.gbCurrentPosition.Controls.Add(this.lblUFrame);
            this.gbCurrentPosition.Controls.Add(this.lblTool);
            this.gbCurrentPosition.Controls.Add(this.lblState);
            this.gbCurrentPosition.Controls.Add(this.lblJoint);
            this.gbCurrentPosition.Controls.Add(this.lblXyzwpr);
            this.gbCurrentPosition.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbCurrentPosition.Location = new System.Drawing.Point(12, 324);
            this.gbCurrentPosition.Name = "gbCurrentPosition";
            this.gbCurrentPosition.Size = new System.Drawing.Size(324, 231);
            this.gbCurrentPosition.TabIndex = 4;
            this.gbCurrentPosition.TabStop = false;
            this.gbCurrentPosition.Text = "Current Position";
            // 
            // lblJoint
            // 
            this.lblJoint.AutoSize = true;
            this.lblJoint.Location = new System.Drawing.Point(141, 77);
            this.lblJoint.Name = "lblJoint";
            this.lblJoint.Size = new System.Drawing.Size(48, 147);
            this.lblJoint.TabIndex = 1;
            this.lblJoint.Text = "Joint\r\nJ1 :\r\nJ2 :\r\nJ3 :\r\nJ4 :\r\nJ5 :\r\nJ6 :";
            // 
            // lblXyzwpr
            // 
            this.lblXyzwpr.AutoSize = true;
            this.lblXyzwpr.Location = new System.Drawing.Point(6, 77);
            this.lblXyzwpr.Name = "lblXyzwpr";
            this.lblXyzwpr.Size = new System.Drawing.Size(85, 147);
            this.lblXyzwpr.TabIndex = 0;
            this.lblXyzwpr.Text = "Cartesian\r\nX :\r\nY :\r\nZ :\r\nW:\r\nP :\r\nR :";
            // 
            // btnPositionHome
            // 
            this.btnPositionHome.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPositionHome.Location = new System.Drawing.Point(218, 116);
            this.btnPositionHome.Name = "btnPositionHome";
            this.btnPositionHome.Size = new System.Drawing.Size(100, 50);
            this.btnPositionHome.TabIndex = 15;
            this.btnPositionHome.Text = "Home";
            this.btnPositionHome.UseVisualStyleBackColor = true;
            this.btnPositionHome.Click += new System.EventHandler(this.btnPositionHome_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(218, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbOverride
            // 
            this.gbOverride.Controls.Add(this.btnPercentdown);
            this.gbOverride.Controls.Add(this.btnPercentup);
            this.gbOverride.Controls.Add(this.lblOverride);
            this.gbOverride.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbOverride.Location = new System.Drawing.Point(812, 12);
            this.gbOverride.Name = "gbOverride";
            this.gbOverride.Size = new System.Drawing.Size(110, 125);
            this.gbOverride.TabIndex = 5;
            this.gbOverride.TabStop = false;
            this.gbOverride.Text = "Override";
            // 
            // btnPercentdown
            // 
            this.btnPercentdown.Location = new System.Drawing.Point(6, 74);
            this.btnPercentdown.Name = "btnPercentdown";
            this.btnPercentdown.Size = new System.Drawing.Size(45, 45);
            this.btnPercentdown.TabIndex = 2;
            this.btnPercentdown.Text = "-%";
            this.btnPercentdown.UseVisualStyleBackColor = true;
            this.btnPercentdown.Click += new System.EventHandler(this.btnPercentdown_Click);
            // 
            // btnPercentup
            // 
            this.btnPercentup.Location = new System.Drawing.Point(59, 74);
            this.btnPercentup.Name = "btnPercentup";
            this.btnPercentup.Size = new System.Drawing.Size(45, 45);
            this.btnPercentup.TabIndex = 1;
            this.btnPercentup.Text = "+%";
            this.btnPercentup.UseVisualStyleBackColor = true;
            this.btnPercentup.Click += new System.EventHandler(this.btnPercentup_Click);
            // 
            // lblOverride
            // 
            this.lblOverride.AutoSize = true;
            this.lblOverride.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOverride.Location = new System.Drawing.Point(6, 29);
            this.lblOverride.Name = "lblOverride";
            this.lblOverride.Size = new System.Drawing.Size(0, 37);
            this.lblOverride.TabIndex = 0;
            // 
            // gbPointMove
            // 
            this.gbPointMove.Controls.Add(this.lblPTPRJ6Unit);
            this.gbPointMove.Controls.Add(this.lblPTPPJ5Unit);
            this.gbPointMove.Controls.Add(this.lblPTPWJ4Unit);
            this.gbPointMove.Controls.Add(this.lblPTPZJ3Unit);
            this.gbPointMove.Controls.Add(this.lblPTPYJ2Unit);
            this.gbPointMove.Controls.Add(this.lblPTPXJ1Unit);
            this.gbPointMove.Controls.Add(this.btnPTPSet);
            this.gbPointMove.Controls.Add(this.btnPTPGet);
            this.gbPointMove.Controls.Add(this.lblPTPYJ2);
            this.gbPointMove.Controls.Add(this.lblPTPRJ6);
            this.gbPointMove.Controls.Add(this.lblPTPWJ4);
            this.gbPointMove.Controls.Add(this.lblPTPPJ5);
            this.gbPointMove.Controls.Add(this.lblPTPZJ3);
            this.gbPointMove.Controls.Add(this.lblPTPXJ1);
            this.gbPointMove.Controls.Add(this.txtPTPRJ6);
            this.gbPointMove.Controls.Add(this.txtPTPPJ5);
            this.gbPointMove.Controls.Add(this.txtPTPWJ4);
            this.gbPointMove.Controls.Add(this.txtPTPZJ3);
            this.gbPointMove.Controls.Add(this.txtPTPYJ2);
            this.gbPointMove.Controls.Add(this.txtPTPXJ1);
            this.gbPointMove.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPointMove.Location = new System.Drawing.Point(3, 3);
            this.gbPointMove.Name = "gbPointMove";
            this.gbPointMove.Size = new System.Drawing.Size(226, 293);
            this.gbPointMove.TabIndex = 6;
            this.gbPointMove.TabStop = false;
            this.gbPointMove.Text = "Point Move";
            // 
            // lblPTPRJ6Unit
            // 
            this.lblPTPRJ6Unit.AutoSize = true;
            this.lblPTPRJ6Unit.Location = new System.Drawing.Point(176, 174);
            this.lblPTPRJ6Unit.Name = "lblPTPRJ6Unit";
            this.lblPTPRJ6Unit.Size = new System.Drawing.Size(39, 21);
            this.lblPTPRJ6Unit.TabIndex = 24;
            this.lblPTPRJ6Unit.Text = "deg";
            // 
            // lblPTPPJ5Unit
            // 
            this.lblPTPPJ5Unit.AutoSize = true;
            this.lblPTPPJ5Unit.Location = new System.Drawing.Point(177, 145);
            this.lblPTPPJ5Unit.Name = "lblPTPPJ5Unit";
            this.lblPTPPJ5Unit.Size = new System.Drawing.Size(39, 21);
            this.lblPTPPJ5Unit.TabIndex = 23;
            this.lblPTPPJ5Unit.Text = "deg";
            // 
            // lblPTPWJ4Unit
            // 
            this.lblPTPWJ4Unit.AutoSize = true;
            this.lblPTPWJ4Unit.Location = new System.Drawing.Point(177, 116);
            this.lblPTPWJ4Unit.Name = "lblPTPWJ4Unit";
            this.lblPTPWJ4Unit.Size = new System.Drawing.Size(39, 21);
            this.lblPTPWJ4Unit.TabIndex = 22;
            this.lblPTPWJ4Unit.Text = "deg";
            // 
            // lblPTPZJ3Unit
            // 
            this.lblPTPZJ3Unit.AutoSize = true;
            this.lblPTPZJ3Unit.Location = new System.Drawing.Point(176, 87);
            this.lblPTPZJ3Unit.Name = "lblPTPZJ3Unit";
            this.lblPTPZJ3Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPZJ3Unit.TabIndex = 21;
            this.lblPTPZJ3Unit.Text = "mm";
            // 
            // lblPTPYJ2Unit
            // 
            this.lblPTPYJ2Unit.AutoSize = true;
            this.lblPTPYJ2Unit.Location = new System.Drawing.Point(176, 58);
            this.lblPTPYJ2Unit.Name = "lblPTPYJ2Unit";
            this.lblPTPYJ2Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPYJ2Unit.TabIndex = 20;
            this.lblPTPYJ2Unit.Text = "mm";
            // 
            // lblPTPXJ1Unit
            // 
            this.lblPTPXJ1Unit.AutoSize = true;
            this.lblPTPXJ1Unit.Location = new System.Drawing.Point(176, 29);
            this.lblPTPXJ1Unit.Name = "lblPTPXJ1Unit";
            this.lblPTPXJ1Unit.Size = new System.Drawing.Size(40, 21);
            this.lblPTPXJ1Unit.TabIndex = 19;
            this.lblPTPXJ1Unit.Text = "mm";
            // 
            // btnPTPSet
            // 
            this.btnPTPSet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPTPSet.Location = new System.Drawing.Point(116, 203);
            this.btnPTPSet.Name = "btnPTPSet";
            this.btnPTPSet.Size = new System.Drawing.Size(100, 50);
            this.btnPTPSet.TabIndex = 14;
            this.btnPTPSet.Text = "Set";
            this.btnPTPSet.UseVisualStyleBackColor = true;
            this.btnPTPSet.Click += new System.EventHandler(this.btnPTPSet_Click);
            // 
            // btnPTPGet
            // 
            this.btnPTPGet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPTPGet.Location = new System.Drawing.Point(10, 203);
            this.btnPTPGet.Name = "btnPTPGet";
            this.btnPTPGet.Size = new System.Drawing.Size(100, 50);
            this.btnPTPGet.TabIndex = 13;
            this.btnPTPGet.Text = "Get";
            this.btnPTPGet.UseVisualStyleBackColor = true;
            this.btnPTPGet.Click += new System.EventHandler(this.btnPTPGet_Click);
            // 
            // lblPTPYJ2
            // 
            this.lblPTPYJ2.AutoSize = true;
            this.lblPTPYJ2.Location = new System.Drawing.Point(6, 58);
            this.lblPTPYJ2.Name = "lblPTPYJ2";
            this.lblPTPYJ2.Size = new System.Drawing.Size(34, 21);
            this.lblPTPYJ2.TabIndex = 12;
            this.lblPTPYJ2.Text = "Y :";
            // 
            // lblPTPRJ6
            // 
            this.lblPTPRJ6.AutoSize = true;
            this.lblPTPRJ6.Location = new System.Drawing.Point(6, 174);
            this.lblPTPRJ6.Name = "lblPTPRJ6";
            this.lblPTPRJ6.Size = new System.Drawing.Size(33, 21);
            this.lblPTPRJ6.TabIndex = 11;
            this.lblPTPRJ6.Text = "R :";
            // 
            // lblPTPWJ4
            // 
            this.lblPTPWJ4.AutoSize = true;
            this.lblPTPWJ4.Location = new System.Drawing.Point(6, 116);
            this.lblPTPWJ4.Name = "lblPTPWJ4";
            this.lblPTPWJ4.Size = new System.Drawing.Size(34, 21);
            this.lblPTPWJ4.TabIndex = 10;
            this.lblPTPWJ4.Text = "W:";
            // 
            // lblPTPPJ5
            // 
            this.lblPTPPJ5.AutoSize = true;
            this.lblPTPPJ5.Location = new System.Drawing.Point(6, 145);
            this.lblPTPPJ5.Name = "lblPTPPJ5";
            this.lblPTPPJ5.Size = new System.Drawing.Size(31, 21);
            this.lblPTPPJ5.TabIndex = 9;
            this.lblPTPPJ5.Text = "P :";
            // 
            // lblPTPZJ3
            // 
            this.lblPTPZJ3.AutoSize = true;
            this.lblPTPZJ3.Location = new System.Drawing.Point(6, 87);
            this.lblPTPZJ3.Name = "lblPTPZJ3";
            this.lblPTPZJ3.Size = new System.Drawing.Size(32, 21);
            this.lblPTPZJ3.TabIndex = 8;
            this.lblPTPZJ3.Text = "Z :";
            // 
            // lblPTPXJ1
            // 
            this.lblPTPXJ1.AutoSize = true;
            this.lblPTPXJ1.Location = new System.Drawing.Point(6, 29);
            this.lblPTPXJ1.Name = "lblPTPXJ1";
            this.lblPTPXJ1.Size = new System.Drawing.Size(34, 21);
            this.lblPTPXJ1.TabIndex = 7;
            this.lblPTPXJ1.Text = "X :";
            // 
            // txtPTPRJ6
            // 
            this.txtPTPRJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPRJ6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPRJ6.Location = new System.Drawing.Point(46, 174);
            this.txtPTPRJ6.Name = "txtPTPRJ6";
            this.txtPTPRJ6.Size = new System.Drawing.Size(124, 23);
            this.txtPTPRJ6.TabIndex = 6;
            this.txtPTPRJ6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPPJ5
            // 
            this.txtPTPPJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPPJ5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPPJ5.Location = new System.Drawing.Point(46, 145);
            this.txtPTPPJ5.Name = "txtPTPPJ5";
            this.txtPTPPJ5.Size = new System.Drawing.Size(124, 23);
            this.txtPTPPJ5.TabIndex = 5;
            this.txtPTPPJ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPWJ4
            // 
            this.txtPTPWJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPWJ4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPWJ4.Location = new System.Drawing.Point(46, 116);
            this.txtPTPWJ4.Name = "txtPTPWJ4";
            this.txtPTPWJ4.Size = new System.Drawing.Size(124, 23);
            this.txtPTPWJ4.TabIndex = 4;
            this.txtPTPWJ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPZJ3
            // 
            this.txtPTPZJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPZJ3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPZJ3.Location = new System.Drawing.Point(46, 87);
            this.txtPTPZJ3.Name = "txtPTPZJ3";
            this.txtPTPZJ3.Size = new System.Drawing.Size(124, 23);
            this.txtPTPZJ3.TabIndex = 3;
            this.txtPTPZJ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPYJ2
            // 
            this.txtPTPYJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPYJ2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPYJ2.Location = new System.Drawing.Point(46, 58);
            this.txtPTPYJ2.Name = "txtPTPYJ2";
            this.txtPTPYJ2.Size = new System.Drawing.Size(124, 23);
            this.txtPTPYJ2.TabIndex = 2;
            this.txtPTPYJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTPXJ1
            // 
            this.txtPTPXJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPXJ1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPTPXJ1.Location = new System.Drawing.Point(46, 29);
            this.txtPTPXJ1.Name = "txtPTPXJ1";
            this.txtPTPXJ1.Size = new System.Drawing.Size(124, 23);
            this.txtPTPXJ1.TabIndex = 1;
            this.txtPTPXJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCoordinate
            // 
            this.lblCoordinate.AutoSize = true;
            this.lblCoordinate.Location = new System.Drawing.Point(6, 29);
            this.lblCoordinate.Name = "lblCoordinate";
            this.lblCoordinate.Size = new System.Drawing.Size(108, 21);
            this.lblCoordinate.TabIndex = 18;
            this.lblCoordinate.Text = "Coordinate :";
            // 
            // cboCoordinate
            // 
            this.cboCoordinate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCoordinate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCoordinate.FormattingEnabled = true;
            this.cboCoordinate.Location = new System.Drawing.Point(120, 30);
            this.cboCoordinate.Name = "cboCoordinate";
            this.cboCoordinate.Size = new System.Drawing.Size(198, 24);
            this.cboCoordinate.TabIndex = 0;
            this.cboCoordinate.SelectedIndexChanged += new System.EventHandler(this.cboCoordinate_SelectedIndexChanged);
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.lblGetRegister);
            this.gbRegister.Controls.Add(this.btnRegisterSet);
            this.gbRegister.Controls.Add(this.txtR5);
            this.gbRegister.Controls.Add(this.txtR4);
            this.gbRegister.Controls.Add(this.txtR3);
            this.gbRegister.Controls.Add(this.txtR2);
            this.gbRegister.Controls.Add(this.lblSetR5);
            this.gbRegister.Controls.Add(this.txtR1);
            this.gbRegister.Controls.Add(this.lblSetR4);
            this.gbRegister.Controls.Add(this.lblSetR3);
            this.gbRegister.Controls.Add(this.lblSetR1);
            this.gbRegister.Controls.Add(this.lblSetR2);
            this.gbRegister.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbRegister.Location = new System.Drawing.Point(224, 3);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(226, 290);
            this.gbRegister.TabIndex = 7;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // btnRegisterSet
            // 
            this.btnRegisterSet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegisterSet.Location = new System.Drawing.Point(114, 174);
            this.btnRegisterSet.Name = "btnRegisterSet";
            this.btnRegisterSet.Size = new System.Drawing.Size(100, 50);
            this.btnRegisterSet.TabIndex = 25;
            this.btnRegisterSet.Text = "Set";
            this.btnRegisterSet.UseVisualStyleBackColor = true;
            this.btnRegisterSet.Click += new System.EventHandler(this.btnRegisterSet_Click);
            // 
            // txtR5
            // 
            this.txtR5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR5.Location = new System.Drawing.Point(165, 145);
            this.txtR5.Name = "txtR5";
            this.txtR5.Size = new System.Drawing.Size(49, 23);
            this.txtR5.TabIndex = 24;
            this.txtR5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtR4
            // 
            this.txtR4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR4.Location = new System.Drawing.Point(165, 116);
            this.txtR4.Name = "txtR4";
            this.txtR4.Size = new System.Drawing.Size(49, 23);
            this.txtR4.TabIndex = 23;
            this.txtR4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtR3
            // 
            this.txtR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR3.Location = new System.Drawing.Point(165, 87);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(49, 23);
            this.txtR3.TabIndex = 22;
            this.txtR3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtR2
            // 
            this.txtR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR2.Location = new System.Drawing.Point(165, 58);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(49, 23);
            this.txtR2.TabIndex = 21;
            this.txtR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSetR5
            // 
            this.lblSetR5.AutoSize = true;
            this.lblSetR5.Location = new System.Drawing.Point(110, 145);
            this.lblSetR5.Name = "lblSetR5";
            this.lblSetR5.Size = new System.Drawing.Size(49, 21);
            this.lblSetR5.TabIndex = 20;
            this.lblSetR5.Text = "R5 =";
            // 
            // txtR1
            // 
            this.txtR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtR1.Location = new System.Drawing.Point(165, 29);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(49, 23);
            this.txtR1.TabIndex = 16;
            this.txtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSetR4
            // 
            this.lblSetR4.AutoSize = true;
            this.lblSetR4.Location = new System.Drawing.Point(110, 116);
            this.lblSetR4.Name = "lblSetR4";
            this.lblSetR4.Size = new System.Drawing.Size(49, 21);
            this.lblSetR4.TabIndex = 19;
            this.lblSetR4.Text = "R4 =";
            // 
            // lblSetR3
            // 
            this.lblSetR3.AutoSize = true;
            this.lblSetR3.Location = new System.Drawing.Point(110, 87);
            this.lblSetR3.Name = "lblSetR3";
            this.lblSetR3.Size = new System.Drawing.Size(49, 21);
            this.lblSetR3.TabIndex = 18;
            this.lblSetR3.Text = "R3 =";
            // 
            // lblSetR1
            // 
            this.lblSetR1.AutoSize = true;
            this.lblSetR1.Location = new System.Drawing.Point(110, 29);
            this.lblSetR1.Name = "lblSetR1";
            this.lblSetR1.Size = new System.Drawing.Size(49, 21);
            this.lblSetR1.TabIndex = 16;
            this.lblSetR1.Text = "R1 =";
            // 
            // lblSetR2
            // 
            this.lblSetR2.AutoSize = true;
            this.lblSetR2.Location = new System.Drawing.Point(110, 58);
            this.lblSetR2.Name = "lblSetR2";
            this.lblSetR2.Size = new System.Drawing.Size(49, 21);
            this.lblSetR2.TabIndex = 17;
            this.lblSetR2.Text = "R2 =";
            // 
            // gbJogMove
            // 
            this.gbJogMove.Controls.Add(this.cboJogStep);
            this.gbJogMove.Controls.Add(this.lblJogStep);
            this.gbJogMove.Controls.Add(this.btnJogRJ6Positive);
            this.gbJogMove.Controls.Add(this.btnJogRJ6Negative);
            this.gbJogMove.Controls.Add(this.btnJogPJ5Positive);
            this.gbJogMove.Controls.Add(this.btnJogPJ5Negative);
            this.gbJogMove.Controls.Add(this.btnJogWJ4Positive);
            this.gbJogMove.Controls.Add(this.btnJogWJ4Negative);
            this.gbJogMove.Controls.Add(this.btnJogZJ3Positive);
            this.gbJogMove.Controls.Add(this.btnJogZJ3Negative);
            this.gbJogMove.Controls.Add(this.btnJogYJ2Positive);
            this.gbJogMove.Controls.Add(this.btnJogYJ2Negative);
            this.gbJogMove.Controls.Add(this.btnJogXJ1Positive);
            this.gbJogMove.Controls.Add(this.btnJogXJ1Negative);
            this.gbJogMove.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbJogMove.Location = new System.Drawing.Point(235, 3);
            this.gbJogMove.Name = "gbJogMove";
            this.gbJogMove.Size = new System.Drawing.Size(227, 293);
            this.gbJogMove.TabIndex = 8;
            this.gbJogMove.TabStop = false;
            this.gbJogMove.Text = "Jog Move";
            // 
            // cboJogStep
            // 
            this.cboJogStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJogStep.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboJogStep.FormattingEnabled = true;
            this.cboJogStep.Location = new System.Drawing.Point(67, 30);
            this.cboJogStep.Name = "cboJogStep";
            this.cboJogStep.Size = new System.Drawing.Size(149, 24);
            this.cboJogStep.TabIndex = 13;
            this.cboJogStep.SelectedIndexChanged += new System.EventHandler(this.cboStep_SelectedIndexChanged);
            // 
            // lblJogStep
            // 
            this.lblJogStep.AutoSize = true;
            this.lblJogStep.Location = new System.Drawing.Point(6, 29);
            this.lblJogStep.Name = "lblJogStep";
            this.lblJogStep.Size = new System.Drawing.Size(55, 21);
            this.lblJogStep.TabIndex = 12;
            this.lblJogStep.Text = "Step :";
            // 
            // btnJogRJ6Positive
            // 
            this.btnJogRJ6Positive.Location = new System.Drawing.Point(116, 240);
            this.btnJogRJ6Positive.Name = "btnJogRJ6Positive";
            this.btnJogRJ6Positive.Size = new System.Drawing.Size(100, 30);
            this.btnJogRJ6Positive.TabIndex = 11;
            this.btnJogRJ6Positive.Tag = "10";
            this.btnJogRJ6Positive.Text = "+R";
            this.btnJogRJ6Positive.UseVisualStyleBackColor = true;
            this.btnJogRJ6Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogRJ6Negative
            // 
            this.btnJogRJ6Negative.Location = new System.Drawing.Point(10, 240);
            this.btnJogRJ6Negative.Name = "btnJogRJ6Negative";
            this.btnJogRJ6Negative.Size = new System.Drawing.Size(100, 30);
            this.btnJogRJ6Negative.TabIndex = 10;
            this.btnJogRJ6Negative.Tag = "11";
            this.btnJogRJ6Negative.Text = "-R";
            this.btnJogRJ6Negative.UseVisualStyleBackColor = true;
            this.btnJogRJ6Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogPJ5Positive
            // 
            this.btnJogPJ5Positive.Location = new System.Drawing.Point(116, 204);
            this.btnJogPJ5Positive.Name = "btnJogPJ5Positive";
            this.btnJogPJ5Positive.Size = new System.Drawing.Size(100, 30);
            this.btnJogPJ5Positive.TabIndex = 9;
            this.btnJogPJ5Positive.Tag = "8";
            this.btnJogPJ5Positive.Text = "+P";
            this.btnJogPJ5Positive.UseVisualStyleBackColor = true;
            this.btnJogPJ5Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogPJ5Negative
            // 
            this.btnJogPJ5Negative.Location = new System.Drawing.Point(10, 204);
            this.btnJogPJ5Negative.Name = "btnJogPJ5Negative";
            this.btnJogPJ5Negative.Size = new System.Drawing.Size(100, 30);
            this.btnJogPJ5Negative.TabIndex = 8;
            this.btnJogPJ5Negative.Tag = "9";
            this.btnJogPJ5Negative.Text = "-P";
            this.btnJogPJ5Negative.UseVisualStyleBackColor = true;
            this.btnJogPJ5Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogWJ4Positive
            // 
            this.btnJogWJ4Positive.Location = new System.Drawing.Point(116, 168);
            this.btnJogWJ4Positive.Name = "btnJogWJ4Positive";
            this.btnJogWJ4Positive.Size = new System.Drawing.Size(100, 30);
            this.btnJogWJ4Positive.TabIndex = 7;
            this.btnJogWJ4Positive.Tag = "6";
            this.btnJogWJ4Positive.Text = "+W";
            this.btnJogWJ4Positive.UseVisualStyleBackColor = true;
            this.btnJogWJ4Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogWJ4Negative
            // 
            this.btnJogWJ4Negative.Location = new System.Drawing.Point(10, 168);
            this.btnJogWJ4Negative.Name = "btnJogWJ4Negative";
            this.btnJogWJ4Negative.Size = new System.Drawing.Size(100, 30);
            this.btnJogWJ4Negative.TabIndex = 6;
            this.btnJogWJ4Negative.Tag = "7";
            this.btnJogWJ4Negative.Text = "-W";
            this.btnJogWJ4Negative.UseVisualStyleBackColor = true;
            this.btnJogWJ4Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogZJ3Positive
            // 
            this.btnJogZJ3Positive.Location = new System.Drawing.Point(116, 132);
            this.btnJogZJ3Positive.Name = "btnJogZJ3Positive";
            this.btnJogZJ3Positive.Size = new System.Drawing.Size(100, 30);
            this.btnJogZJ3Positive.TabIndex = 5;
            this.btnJogZJ3Positive.Tag = "4";
            this.btnJogZJ3Positive.Text = "+Z";
            this.btnJogZJ3Positive.UseVisualStyleBackColor = true;
            this.btnJogZJ3Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogZJ3Negative
            // 
            this.btnJogZJ3Negative.Location = new System.Drawing.Point(10, 132);
            this.btnJogZJ3Negative.Name = "btnJogZJ3Negative";
            this.btnJogZJ3Negative.Size = new System.Drawing.Size(100, 30);
            this.btnJogZJ3Negative.TabIndex = 4;
            this.btnJogZJ3Negative.Tag = "5";
            this.btnJogZJ3Negative.Text = "-Z";
            this.btnJogZJ3Negative.UseVisualStyleBackColor = true;
            this.btnJogZJ3Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogYJ2Positive
            // 
            this.btnJogYJ2Positive.Location = new System.Drawing.Point(116, 96);
            this.btnJogYJ2Positive.Name = "btnJogYJ2Positive";
            this.btnJogYJ2Positive.Size = new System.Drawing.Size(100, 30);
            this.btnJogYJ2Positive.TabIndex = 3;
            this.btnJogYJ2Positive.Tag = "2";
            this.btnJogYJ2Positive.Text = "+Y";
            this.btnJogYJ2Positive.UseVisualStyleBackColor = true;
            this.btnJogYJ2Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogYJ2Negative
            // 
            this.btnJogYJ2Negative.Location = new System.Drawing.Point(10, 96);
            this.btnJogYJ2Negative.Name = "btnJogYJ2Negative";
            this.btnJogYJ2Negative.Size = new System.Drawing.Size(100, 30);
            this.btnJogYJ2Negative.TabIndex = 2;
            this.btnJogYJ2Negative.Tag = "3";
            this.btnJogYJ2Negative.Text = "-Y";
            this.btnJogYJ2Negative.UseVisualStyleBackColor = true;
            this.btnJogYJ2Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogXJ1Positive
            // 
            this.btnJogXJ1Positive.Location = new System.Drawing.Point(116, 60);
            this.btnJogXJ1Positive.Name = "btnJogXJ1Positive";
            this.btnJogXJ1Positive.Size = new System.Drawing.Size(100, 30);
            this.btnJogXJ1Positive.TabIndex = 1;
            this.btnJogXJ1Positive.Tag = "0";
            this.btnJogXJ1Positive.Text = "+X";
            this.btnJogXJ1Positive.UseVisualStyleBackColor = true;
            this.btnJogXJ1Positive.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnJogXJ1Negative
            // 
            this.btnJogXJ1Negative.Location = new System.Drawing.Point(10, 60);
            this.btnJogXJ1Negative.Name = "btnJogXJ1Negative";
            this.btnJogXJ1Negative.Size = new System.Drawing.Size(100, 30);
            this.btnJogXJ1Negative.TabIndex = 0;
            this.btnJogXJ1Negative.Tag = "1";
            this.btnJogXJ1Negative.Text = "-X";
            this.btnJogXJ1Negative.UseVisualStyleBackColor = true;
            this.btnJogXJ1Negative.Click += new System.EventHandler(this.btnJogXJ1Positive_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(6, 116);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(100, 50);
            this.btnDisable.TabIndex = 15;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(6, 60);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(100, 50);
            this.btnEnable.TabIndex = 14;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnStop);
            this.gbControl.Controls.Add(this.btnHold);
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.btnDisable);
            this.gbControl.Controls.Add(this.btnEnable);
            this.gbControl.Controls.Add(this.btnPositionHome);
            this.gbControl.Controls.Add(this.lblCoordinate);
            this.gbControl.Controls.Add(this.cboCoordinate);
            this.gbControl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbControl.Location = new System.Drawing.Point(12, 146);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(324, 172);
            this.gbControl.TabIndex = 9;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(112, 116);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 50);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(112, 60);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(100, 50);
            this.btnHold.TabIndex = 16;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // gbLineMove
            // 
            this.gbLineMove.Controls.Add(this.lblLineVelocityUnit);
            this.gbLineMove.Controls.Add(this.lblLineRJ6Unit);
            this.gbLineMove.Controls.Add(this.txtLineVelocity);
            this.gbLineMove.Controls.Add(this.lblLinePJ5Unit);
            this.gbLineMove.Controls.Add(this.lblLineVelocity);
            this.gbLineMove.Controls.Add(this.lblLineWJ4Unit);
            this.gbLineMove.Controls.Add(this.btnLineSet);
            this.gbLineMove.Controls.Add(this.lblLineZJ3Unit);
            this.gbLineMove.Controls.Add(this.btnLineGet);
            this.gbLineMove.Controls.Add(this.lblLineYJ2Unit);
            this.gbLineMove.Controls.Add(this.lblLineXJ1Unit);
            this.gbLineMove.Controls.Add(this.lblLineYJ2);
            this.gbLineMove.Controls.Add(this.lblLineRJ6);
            this.gbLineMove.Controls.Add(this.lblLineWJ4);
            this.gbLineMove.Controls.Add(this.lblLinePJ5);
            this.gbLineMove.Controls.Add(this.lblLineZJ3);
            this.gbLineMove.Controls.Add(this.lblLineXJ1);
            this.gbLineMove.Controls.Add(this.txtLineRJ6);
            this.gbLineMove.Controls.Add(this.txtLinePJ5);
            this.gbLineMove.Controls.Add(this.txtLineWJ4);
            this.gbLineMove.Controls.Add(this.txtLineZJ3);
            this.gbLineMove.Controls.Add(this.txtLineYJ2);
            this.gbLineMove.Controls.Add(this.txtLineXJ1);
            this.gbLineMove.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbLineMove.Location = new System.Drawing.Point(468, 3);
            this.gbLineMove.Name = "gbLineMove";
            this.gbLineMove.Size = new System.Drawing.Size(227, 293);
            this.gbLineMove.TabIndex = 18;
            this.gbLineMove.TabStop = false;
            this.gbLineMove.Text = "Line Move";
            // 
            // lblLineVelocityUnit
            // 
            this.lblLineVelocityUnit.AutoSize = true;
            this.lblLineVelocityUnit.Location = new System.Drawing.Point(145, 203);
            this.lblLineVelocityUnit.Name = "lblLineVelocityUnit";
            this.lblLineVelocityUnit.Size = new System.Drawing.Size(71, 21);
            this.lblLineVelocityUnit.TabIndex = 31;
            this.lblLineVelocityUnit.Text = "unit/sec";
            // 
            // lblLineRJ6Unit
            // 
            this.lblLineRJ6Unit.AutoSize = true;
            this.lblLineRJ6Unit.Location = new System.Drawing.Point(176, 174);
            this.lblLineRJ6Unit.Name = "lblLineRJ6Unit";
            this.lblLineRJ6Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLineRJ6Unit.TabIndex = 30;
            this.lblLineRJ6Unit.Text = "deg";
            // 
            // txtLineVelocity
            // 
            this.txtLineVelocity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineVelocity.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineVelocity.Location = new System.Drawing.Point(46, 203);
            this.txtLineVelocity.Name = "txtLineVelocity";
            this.txtLineVelocity.Size = new System.Drawing.Size(93, 23);
            this.txtLineVelocity.TabIndex = 17;
            this.txtLineVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLinePJ5Unit
            // 
            this.lblLinePJ5Unit.AutoSize = true;
            this.lblLinePJ5Unit.Location = new System.Drawing.Point(176, 145);
            this.lblLinePJ5Unit.Name = "lblLinePJ5Unit";
            this.lblLinePJ5Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLinePJ5Unit.TabIndex = 29;
            this.lblLinePJ5Unit.Text = "deg";
            // 
            // lblLineVelocity
            // 
            this.lblLineVelocity.AutoSize = true;
            this.lblLineVelocity.Location = new System.Drawing.Point(6, 203);
            this.lblLineVelocity.Name = "lblLineVelocity";
            this.lblLineVelocity.Size = new System.Drawing.Size(34, 21);
            this.lblLineVelocity.TabIndex = 16;
            this.lblLineVelocity.Text = "V :";
            // 
            // lblLineWJ4Unit
            // 
            this.lblLineWJ4Unit.AutoSize = true;
            this.lblLineWJ4Unit.Location = new System.Drawing.Point(176, 116);
            this.lblLineWJ4Unit.Name = "lblLineWJ4Unit";
            this.lblLineWJ4Unit.Size = new System.Drawing.Size(39, 21);
            this.lblLineWJ4Unit.TabIndex = 28;
            this.lblLineWJ4Unit.Text = "deg";
            // 
            // btnLineSet
            // 
            this.btnLineSet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLineSet.Location = new System.Drawing.Point(116, 232);
            this.btnLineSet.Name = "btnLineSet";
            this.btnLineSet.Size = new System.Drawing.Size(100, 50);
            this.btnLineSet.TabIndex = 14;
            this.btnLineSet.Text = "Set";
            this.btnLineSet.UseVisualStyleBackColor = true;
            this.btnLineSet.Click += new System.EventHandler(this.btnLineSet_Click);
            // 
            // lblLineZJ3Unit
            // 
            this.lblLineZJ3Unit.AutoSize = true;
            this.lblLineZJ3Unit.Location = new System.Drawing.Point(176, 87);
            this.lblLineZJ3Unit.Name = "lblLineZJ3Unit";
            this.lblLineZJ3Unit.Size = new System.Drawing.Size(40, 21);
            this.lblLineZJ3Unit.TabIndex = 27;
            this.lblLineZJ3Unit.Text = "mm";
            // 
            // btnLineGet
            // 
            this.btnLineGet.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLineGet.Location = new System.Drawing.Point(10, 232);
            this.btnLineGet.Name = "btnLineGet";
            this.btnLineGet.Size = new System.Drawing.Size(100, 50);
            this.btnLineGet.TabIndex = 13;
            this.btnLineGet.Text = "Get";
            this.btnLineGet.UseVisualStyleBackColor = true;
            this.btnLineGet.Click += new System.EventHandler(this.btnLineGet_Click);
            // 
            // lblLineYJ2Unit
            // 
            this.lblLineYJ2Unit.AutoSize = true;
            this.lblLineYJ2Unit.Location = new System.Drawing.Point(176, 58);
            this.lblLineYJ2Unit.Name = "lblLineYJ2Unit";
            this.lblLineYJ2Unit.Size = new System.Drawing.Size(40, 21);
            this.lblLineYJ2Unit.TabIndex = 26;
            this.lblLineYJ2Unit.Text = "mm";
            // 
            // lblLineXJ1Unit
            // 
            this.lblLineXJ1Unit.AutoSize = true;
            this.lblLineXJ1Unit.Location = new System.Drawing.Point(176, 29);
            this.lblLineXJ1Unit.Name = "lblLineXJ1Unit";
            this.lblLineXJ1Unit.Size = new System.Drawing.Size(40, 21);
            this.lblLineXJ1Unit.TabIndex = 25;
            this.lblLineXJ1Unit.Text = "mm";
            // 
            // lblLineYJ2
            // 
            this.lblLineYJ2.AutoSize = true;
            this.lblLineYJ2.Location = new System.Drawing.Point(6, 58);
            this.lblLineYJ2.Name = "lblLineYJ2";
            this.lblLineYJ2.Size = new System.Drawing.Size(34, 21);
            this.lblLineYJ2.TabIndex = 12;
            this.lblLineYJ2.Text = "Y :";
            // 
            // lblLineRJ6
            // 
            this.lblLineRJ6.AutoSize = true;
            this.lblLineRJ6.Location = new System.Drawing.Point(6, 174);
            this.lblLineRJ6.Name = "lblLineRJ6";
            this.lblLineRJ6.Size = new System.Drawing.Size(33, 21);
            this.lblLineRJ6.TabIndex = 11;
            this.lblLineRJ6.Text = "R :";
            // 
            // lblLineWJ4
            // 
            this.lblLineWJ4.AutoSize = true;
            this.lblLineWJ4.Location = new System.Drawing.Point(6, 116);
            this.lblLineWJ4.Name = "lblLineWJ4";
            this.lblLineWJ4.Size = new System.Drawing.Size(34, 21);
            this.lblLineWJ4.TabIndex = 10;
            this.lblLineWJ4.Text = "W:";
            // 
            // lblLinePJ5
            // 
            this.lblLinePJ5.AutoSize = true;
            this.lblLinePJ5.Location = new System.Drawing.Point(6, 145);
            this.lblLinePJ5.Name = "lblLinePJ5";
            this.lblLinePJ5.Size = new System.Drawing.Size(31, 21);
            this.lblLinePJ5.TabIndex = 9;
            this.lblLinePJ5.Text = "P :";
            // 
            // lblLineZJ3
            // 
            this.lblLineZJ3.AutoSize = true;
            this.lblLineZJ3.Location = new System.Drawing.Point(6, 87);
            this.lblLineZJ3.Name = "lblLineZJ3";
            this.lblLineZJ3.Size = new System.Drawing.Size(32, 21);
            this.lblLineZJ3.TabIndex = 8;
            this.lblLineZJ3.Text = "Z :";
            // 
            // lblLineXJ1
            // 
            this.lblLineXJ1.AutoSize = true;
            this.lblLineXJ1.Location = new System.Drawing.Point(6, 29);
            this.lblLineXJ1.Name = "lblLineXJ1";
            this.lblLineXJ1.Size = new System.Drawing.Size(34, 21);
            this.lblLineXJ1.TabIndex = 7;
            this.lblLineXJ1.Text = "X :";
            // 
            // txtLineRJ6
            // 
            this.txtLineRJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineRJ6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineRJ6.Location = new System.Drawing.Point(46, 174);
            this.txtLineRJ6.Name = "txtLineRJ6";
            this.txtLineRJ6.Size = new System.Drawing.Size(124, 23);
            this.txtLineRJ6.TabIndex = 6;
            this.txtLineRJ6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLinePJ5
            // 
            this.txtLinePJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLinePJ5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLinePJ5.Location = new System.Drawing.Point(46, 145);
            this.txtLinePJ5.Name = "txtLinePJ5";
            this.txtLinePJ5.Size = new System.Drawing.Size(124, 23);
            this.txtLinePJ5.TabIndex = 5;
            this.txtLinePJ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineWJ4
            // 
            this.txtLineWJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineWJ4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineWJ4.Location = new System.Drawing.Point(46, 116);
            this.txtLineWJ4.Name = "txtLineWJ4";
            this.txtLineWJ4.Size = new System.Drawing.Size(124, 23);
            this.txtLineWJ4.TabIndex = 4;
            this.txtLineWJ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineZJ3
            // 
            this.txtLineZJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineZJ3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineZJ3.Location = new System.Drawing.Point(46, 87);
            this.txtLineZJ3.Name = "txtLineZJ3";
            this.txtLineZJ3.Size = new System.Drawing.Size(124, 23);
            this.txtLineZJ3.TabIndex = 3;
            this.txtLineZJ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineYJ2
            // 
            this.txtLineYJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineYJ2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineYJ2.Location = new System.Drawing.Point(46, 58);
            this.txtLineYJ2.Name = "txtLineYJ2";
            this.txtLineYJ2.Size = new System.Drawing.Size(124, 23);
            this.txtLineYJ2.TabIndex = 2;
            this.txtLineYJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineXJ1
            // 
            this.txtLineXJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineXJ1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLineXJ1.Location = new System.Drawing.Point(46, 29);
            this.txtLineXJ1.Name = "txtLineXJ1";
            this.txtLineXJ1.Size = new System.Drawing.Size(124, 23);
            this.txtLineXJ1.TabIndex = 1;
            this.txtLineXJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbSafeRange
            // 
            this.gbSafeRange.Controls.Add(this.txtSafeRangeVelocitymax);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeVelocitymin);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeVelocity);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeRJ6max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangePJ5max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeWJ4max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeRJ6min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeRJ6);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeWJ4min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeWJ4);
            this.gbSafeRange.Controls.Add(this.txtSafeRangePJ5min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangePJ5);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeZJ3max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeYJ2max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeXJ1max);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeZJ3min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeZJ3);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeXJ1min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeXJ1);
            this.gbSafeRange.Controls.Add(this.txtSafeRangeYJ2min);
            this.gbSafeRange.Controls.Add(this.lblSafeRangeYJ2);
            this.gbSafeRange.Controls.Add(this.btnSafeRangeSet);
            this.gbSafeRange.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbSafeRange.Location = new System.Drawing.Point(3, 3);
            this.gbSafeRange.Name = "gbSafeRange";
            this.gbSafeRange.Size = new System.Drawing.Size(215, 290);
            this.gbSafeRange.TabIndex = 19;
            this.gbSafeRange.TabStop = false;
            this.gbSafeRange.Text = "Safe Range";
            // 
            // txtSafeRangeVelocitymax
            // 
            this.txtSafeRangeVelocitymax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeVelocitymax.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeVelocitymax.Location = new System.Drawing.Point(144, 203);
            this.txtSafeRangeVelocitymax.Name = "txtSafeRangeVelocitymax";
            this.txtSafeRangeVelocitymax.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeVelocitymax.TabIndex = 40;
            this.txtSafeRangeVelocitymax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeVelocitymin
            // 
            this.txtSafeRangeVelocitymin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeVelocitymin.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeVelocitymin.Location = new System.Drawing.Point(46, 203);
            this.txtSafeRangeVelocitymin.Name = "txtSafeRangeVelocitymin";
            this.txtSafeRangeVelocitymin.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeVelocitymin.TabIndex = 38;
            this.txtSafeRangeVelocitymin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeVelocity
            // 
            this.lblSafeRangeVelocity.AutoSize = true;
            this.lblSafeRangeVelocity.Location = new System.Drawing.Point(6, 203);
            this.lblSafeRangeVelocity.Name = "lblSafeRangeVelocity";
            this.lblSafeRangeVelocity.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeVelocity.TabIndex = 39;
            this.lblSafeRangeVelocity.Text = "V :                 ~";
            // 
            // txtSafeRangeRJ6max
            // 
            this.txtSafeRangeRJ6max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeRJ6max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeRJ6max.Location = new System.Drawing.Point(144, 174);
            this.txtSafeRangeRJ6max.Name = "txtSafeRangeRJ6max";
            this.txtSafeRangeRJ6max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeRJ6max.TabIndex = 37;
            this.txtSafeRangeRJ6max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangePJ5max
            // 
            this.txtSafeRangePJ5max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangePJ5max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangePJ5max.Location = new System.Drawing.Point(144, 145);
            this.txtSafeRangePJ5max.Name = "txtSafeRangePJ5max";
            this.txtSafeRangePJ5max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangePJ5max.TabIndex = 36;
            this.txtSafeRangePJ5max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeWJ4max
            // 
            this.txtSafeRangeWJ4max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeWJ4max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeWJ4max.Location = new System.Drawing.Point(144, 116);
            this.txtSafeRangeWJ4max.Name = "txtSafeRangeWJ4max";
            this.txtSafeRangeWJ4max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeWJ4max.TabIndex = 35;
            this.txtSafeRangeWJ4max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeRJ6min
            // 
            this.txtSafeRangeRJ6min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeRJ6min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeRJ6min.Location = new System.Drawing.Point(46, 174);
            this.txtSafeRangeRJ6min.Name = "txtSafeRangeRJ6min";
            this.txtSafeRangeRJ6min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeRJ6min.TabIndex = 33;
            this.txtSafeRangeRJ6min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeRJ6
            // 
            this.lblSafeRangeRJ6.AutoSize = true;
            this.lblSafeRangeRJ6.Location = new System.Drawing.Point(6, 174);
            this.lblSafeRangeRJ6.Name = "lblSafeRangeRJ6";
            this.lblSafeRangeRJ6.Size = new System.Drawing.Size(129, 21);
            this.lblSafeRangeRJ6.TabIndex = 34;
            this.lblSafeRangeRJ6.Text = "R :                 ~";
            // 
            // txtSafeRangeWJ4min
            // 
            this.txtSafeRangeWJ4min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeWJ4min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeWJ4min.Location = new System.Drawing.Point(46, 116);
            this.txtSafeRangeWJ4min.Name = "txtSafeRangeWJ4min";
            this.txtSafeRangeWJ4min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeWJ4min.TabIndex = 29;
            this.txtSafeRangeWJ4min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeWJ4
            // 
            this.lblSafeRangeWJ4.AutoSize = true;
            this.lblSafeRangeWJ4.Location = new System.Drawing.Point(6, 116);
            this.lblSafeRangeWJ4.Name = "lblSafeRangeWJ4";
            this.lblSafeRangeWJ4.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeWJ4.TabIndex = 30;
            this.lblSafeRangeWJ4.Text = "W:                 ~";
            // 
            // txtSafeRangePJ5min
            // 
            this.txtSafeRangePJ5min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangePJ5min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangePJ5min.Location = new System.Drawing.Point(46, 145);
            this.txtSafeRangePJ5min.Name = "txtSafeRangePJ5min";
            this.txtSafeRangePJ5min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangePJ5min.TabIndex = 32;
            this.txtSafeRangePJ5min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangePJ5
            // 
            this.lblSafeRangePJ5.AutoSize = true;
            this.lblSafeRangePJ5.Location = new System.Drawing.Point(6, 145);
            this.lblSafeRangePJ5.Name = "lblSafeRangePJ5";
            this.lblSafeRangePJ5.Size = new System.Drawing.Size(132, 21);
            this.lblSafeRangePJ5.TabIndex = 31;
            this.lblSafeRangePJ5.Text = "P :                  ~";
            // 
            // txtSafeRangeZJ3max
            // 
            this.txtSafeRangeZJ3max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeZJ3max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeZJ3max.Location = new System.Drawing.Point(144, 87);
            this.txtSafeRangeZJ3max.Name = "txtSafeRangeZJ3max";
            this.txtSafeRangeZJ3max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeZJ3max.TabIndex = 28;
            this.txtSafeRangeZJ3max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeYJ2max
            // 
            this.txtSafeRangeYJ2max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeYJ2max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeYJ2max.Location = new System.Drawing.Point(144, 58);
            this.txtSafeRangeYJ2max.Name = "txtSafeRangeYJ2max";
            this.txtSafeRangeYJ2max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeYJ2max.TabIndex = 27;
            this.txtSafeRangeYJ2max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeXJ1max
            // 
            this.txtSafeRangeXJ1max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeXJ1max.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeXJ1max.Location = new System.Drawing.Point(144, 29);
            this.txtSafeRangeXJ1max.Name = "txtSafeRangeXJ1max";
            this.txtSafeRangeXJ1max.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeXJ1max.TabIndex = 26;
            this.txtSafeRangeXJ1max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafeRangeZJ3min
            // 
            this.txtSafeRangeZJ3min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeZJ3min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeZJ3min.Location = new System.Drawing.Point(46, 87);
            this.txtSafeRangeZJ3min.Name = "txtSafeRangeZJ3min";
            this.txtSafeRangeZJ3min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeZJ3min.TabIndex = 24;
            this.txtSafeRangeZJ3min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeZJ3
            // 
            this.lblSafeRangeZJ3.AutoSize = true;
            this.lblSafeRangeZJ3.Location = new System.Drawing.Point(6, 87);
            this.lblSafeRangeZJ3.Name = "lblSafeRangeZJ3";
            this.lblSafeRangeZJ3.Size = new System.Drawing.Size(128, 21);
            this.lblSafeRangeZJ3.TabIndex = 25;
            this.lblSafeRangeZJ3.Text = "Z :                 ~";
            // 
            // txtSafeRangeXJ1min
            // 
            this.txtSafeRangeXJ1min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeXJ1min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeXJ1min.Location = new System.Drawing.Point(46, 29);
            this.txtSafeRangeXJ1min.Name = "txtSafeRangeXJ1min";
            this.txtSafeRangeXJ1min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeXJ1min.TabIndex = 20;
            this.txtSafeRangeXJ1min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeXJ1
            // 
            this.lblSafeRangeXJ1.AutoSize = true;
            this.lblSafeRangeXJ1.Location = new System.Drawing.Point(6, 29);
            this.lblSafeRangeXJ1.Name = "lblSafeRangeXJ1";
            this.lblSafeRangeXJ1.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeXJ1.TabIndex = 21;
            this.lblSafeRangeXJ1.Text = "X :                 ~";
            // 
            // txtSafeRangeYJ2min
            // 
            this.txtSafeRangeYJ2min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSafeRangeYJ2min.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSafeRangeYJ2min.Location = new System.Drawing.Point(46, 58);
            this.txtSafeRangeYJ2min.Name = "txtSafeRangeYJ2min";
            this.txtSafeRangeYJ2min.Size = new System.Drawing.Size(60, 23);
            this.txtSafeRangeYJ2min.TabIndex = 23;
            this.txtSafeRangeYJ2min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSafeRangeYJ2
            // 
            this.lblSafeRangeYJ2.AutoSize = true;
            this.lblSafeRangeYJ2.Location = new System.Drawing.Point(6, 58);
            this.lblSafeRangeYJ2.Name = "lblSafeRangeYJ2";
            this.lblSafeRangeYJ2.Size = new System.Drawing.Size(130, 21);
            this.lblSafeRangeYJ2.TabIndex = 22;
            this.lblSafeRangeYJ2.Text = "Y :                 ~";
            // 
            // btnSafeRangeSet
            // 
            this.btnSafeRangeSet.Location = new System.Drawing.Point(56, 232);
            this.btnSafeRangeSet.Name = "btnSafeRangeSet";
            this.btnSafeRangeSet.Size = new System.Drawing.Size(100, 50);
            this.btnSafeRangeSet.TabIndex = 19;
            this.btnSafeRangeSet.Text = "Set";
            this.btnSafeRangeSet.UseVisualStyleBackColor = true;
            this.btnSafeRangeSet.Click += new System.EventHandler(this.btnSafeRangeSet_Click);
            // 
            // gbPoints
            // 
            this.gbPoints.Controls.Add(this.btnPointsSave);
            this.gbPoints.Controls.Add(this.txtFilePath);
            this.gbPoints.Controls.Add(this.lblFilePath);
            this.gbPoints.Controls.Add(this.btnPointsSet);
            this.gbPoints.Controls.Add(this.btnPointsLoad);
            this.gbPoints.Controls.Add(this.btnPointsGet);
            this.gbPoints.Controls.Add(this.dataGridView1);
            this.gbPoints.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPoints.Location = new System.Drawing.Point(3, 230);
            this.gbPoints.Name = "gbPoints";
            this.gbPoints.Size = new System.Drawing.Size(864, 262);
            this.gbPoints.TabIndex = 20;
            this.gbPoints.TabStop = false;
            this.gbPoints.Text = "Points";
            // 
            // btnPointsSave
            // 
            this.btnPointsSave.Location = new System.Drawing.Point(545, 24);
            this.btnPointsSave.Name = "btnPointsSave";
            this.btnPointsSave.Size = new System.Drawing.Size(100, 30);
            this.btnPointsSave.TabIndex = 60;
            this.btnPointsSave.Text = "Save";
            this.btnPointsSave.UseVisualStyleBackColor = true;
            this.btnPointsSave.Click += new System.EventHandler(this.btnPointsSave_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFilePath.Location = new System.Drawing.Point(102, 24);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(331, 27);
            this.txtFilePath.TabIndex = 59;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 29);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(90, 21);
            this.lblFilePath.TabIndex = 59;
            this.lblFilePath.Text = "File Path :";
            // 
            // btnPointsSet
            // 
            this.btnPointsSet.Location = new System.Drawing.Point(757, 24);
            this.btnPointsSet.Name = "btnPointsSet";
            this.btnPointsSet.Size = new System.Drawing.Size(100, 30);
            this.btnPointsSet.TabIndex = 23;
            this.btnPointsSet.Text = "Set";
            this.btnPointsSet.UseVisualStyleBackColor = true;
            this.btnPointsSet.Click += new System.EventHandler(this.btnPointsSet_Click);
            // 
            // btnPointsLoad
            // 
            this.btnPointsLoad.Location = new System.Drawing.Point(439, 24);
            this.btnPointsLoad.Name = "btnPointsLoad";
            this.btnPointsLoad.Size = new System.Drawing.Size(100, 30);
            this.btnPointsLoad.TabIndex = 22;
            this.btnPointsLoad.Text = "Load";
            this.btnPointsLoad.UseVisualStyleBackColor = true;
            this.btnPointsLoad.Click += new System.EventHandler(this.btnPointsLoad_Click);
            // 
            // btnPointsGet
            // 
            this.btnPointsGet.Location = new System.Drawing.Point(651, 24);
            this.btnPointsGet.Name = "btnPointsGet";
            this.btnPointsGet.Size = new System.Drawing.Size(100, 30);
            this.btnPointsGet.TabIndex = 21;
            this.btnPointsGet.Text = "Get";
            this.btnPointsGet.UseVisualStyleBackColor = true;
            this.btnPointsGet.Click += new System.EventHandler(this.btnPointsGet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbProgram
            // 
            this.gbProgram.Controls.Add(this.btnProgramCopy);
            this.gbProgram.Controls.Add(this.lblProgramValue);
            this.gbProgram.Controls.Add(this.txtProgramRJ6);
            this.gbProgram.Controls.Add(this.txtProgramValue);
            this.gbProgram.Controls.Add(this.lblProgramUnit);
            this.gbProgram.Controls.Add(this.lblProgramInstruction);
            this.gbProgram.Controls.Add(this.btnProgramGet);
            this.gbProgram.Controls.Add(this.btnProgramCompile);
            this.gbProgram.Controls.Add(this.btnProgramClear);
            this.gbProgram.Controls.Add(this.btnProgramDelete);
            this.gbProgram.Controls.Add(this.btnProgramEdit);
            this.gbProgram.Controls.Add(this.btnProgramInsert);
            this.gbProgram.Controls.Add(this.btnProgramAdd);
            this.gbProgram.Controls.Add(this.cboProgramInstruction);
            this.gbProgram.Controls.Add(this.lblProgramYJ2);
            this.gbProgram.Controls.Add(this.txtProgramName);
            this.gbProgram.Controls.Add(this.lblProgramRJ6);
            this.gbProgram.Controls.Add(this.lblProgramName);
            this.gbProgram.Controls.Add(this.lblProgramWJ4);
            this.gbProgram.Controls.Add(this.lstProgram);
            this.gbProgram.Controls.Add(this.lblProgramPJ5);
            this.gbProgram.Controls.Add(this.txtProgramXJ1);
            this.gbProgram.Controls.Add(this.lblProgramZJ3);
            this.gbProgram.Controls.Add(this.txtProgramYJ2);
            this.gbProgram.Controls.Add(this.lblProgramXJ1);
            this.gbProgram.Controls.Add(this.txtProgramZJ3);
            this.gbProgram.Controls.Add(this.txtProgramWJ4);
            this.gbProgram.Controls.Add(this.txtProgramPJ5);
            this.gbProgram.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbProgram.Location = new System.Drawing.Point(3, 3);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(864, 221);
            this.gbProgram.TabIndex = 21;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Program";
            // 
            // btnProgramCopy
            // 
            this.btnProgramCopy.Location = new System.Drawing.Point(324, 154);
            this.btnProgramCopy.Name = "btnProgramCopy";
            this.btnProgramCopy.Size = new System.Drawing.Size(100, 50);
            this.btnProgramCopy.TabIndex = 59;
            this.btnProgramCopy.Text = "Copy";
            this.btnProgramCopy.UseVisualStyleBackColor = true;
            this.btnProgramCopy.Click += new System.EventHandler(this.btnProgramCopy_Click);
            // 
            // lblProgramValue
            // 
            this.lblProgramValue.AutoSize = true;
            this.lblProgramValue.Location = new System.Drawing.Point(643, 32);
            this.lblProgramValue.Name = "lblProgramValue";
            this.lblProgramValue.Size = new System.Drawing.Size(67, 21);
            this.lblProgramValue.TabIndex = 58;
            this.lblProgramValue.Text = "Value :";
            // 
            // txtProgramValue
            // 
            this.txtProgramValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramValue.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramValue.Location = new System.Drawing.Point(716, 32);
            this.txtProgramValue.Name = "txtProgramValue";
            this.txtProgramValue.Size = new System.Drawing.Size(91, 23);
            this.txtProgramValue.TabIndex = 55;
            this.txtProgramValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramUnit
            // 
            this.lblProgramUnit.AutoSize = true;
            this.lblProgramUnit.Location = new System.Drawing.Point(813, 32);
            this.lblProgramUnit.Name = "lblProgramUnit";
            this.lblProgramUnit.Size = new System.Drawing.Size(40, 21);
            this.lblProgramUnit.TabIndex = 56;
            this.lblProgramUnit.Text = "(%)";
            // 
            // lblProgramInstruction
            // 
            this.lblProgramInstruction.AutoSize = true;
            this.lblProgramInstruction.Location = new System.Drawing.Point(319, 68);
            this.lblProgramInstruction.Name = "lblProgramInstruction";
            this.lblProgramInstruction.Size = new System.Drawing.Size(106, 21);
            this.lblProgramInstruction.TabIndex = 54;
            this.lblProgramInstruction.Text = "Instruction :";
            // 
            // btnProgramGet
            // 
            this.btnProgramGet.Location = new System.Drawing.Point(647, 154);
            this.btnProgramGet.Name = "btnProgramGet";
            this.btnProgramGet.Size = new System.Drawing.Size(100, 50);
            this.btnProgramGet.TabIndex = 53;
            this.btnProgramGet.Text = "Get";
            this.btnProgramGet.UseVisualStyleBackColor = true;
            this.btnProgramGet.Click += new System.EventHandler(this.btnProgramGet_Click);
            // 
            // btnProgramCompile
            // 
            this.btnProgramCompile.Location = new System.Drawing.Point(757, 154);
            this.btnProgramCompile.Name = "btnProgramCompile";
            this.btnProgramCompile.Size = new System.Drawing.Size(100, 50);
            this.btnProgramCompile.TabIndex = 52;
            this.btnProgramCompile.Text = "Compile";
            this.btnProgramCompile.UseVisualStyleBackColor = true;
            this.btnProgramCompile.Click += new System.EventHandler(this.btnProgramCompile_Click);
            // 
            // btnProgramClear
            // 
            this.btnProgramClear.Location = new System.Drawing.Point(537, 154);
            this.btnProgramClear.Name = "btnProgramClear";
            this.btnProgramClear.Size = new System.Drawing.Size(100, 50);
            this.btnProgramClear.TabIndex = 51;
            this.btnProgramClear.Text = "Clear";
            this.btnProgramClear.UseVisualStyleBackColor = true;
            this.btnProgramClear.Click += new System.EventHandler(this.btnProgramClear_Click);
            // 
            // btnProgramDelete
            // 
            this.btnProgramDelete.Location = new System.Drawing.Point(431, 154);
            this.btnProgramDelete.Name = "btnProgramDelete";
            this.btnProgramDelete.Size = new System.Drawing.Size(100, 50);
            this.btnProgramDelete.TabIndex = 50;
            this.btnProgramDelete.Text = "Delete";
            this.btnProgramDelete.UseVisualStyleBackColor = true;
            this.btnProgramDelete.Click += new System.EventHandler(this.btnProgramDelete_Click);
            // 
            // btnProgramEdit
            // 
            this.btnProgramEdit.Location = new System.Drawing.Point(537, 98);
            this.btnProgramEdit.Name = "btnProgramEdit";
            this.btnProgramEdit.Size = new System.Drawing.Size(100, 50);
            this.btnProgramEdit.TabIndex = 49;
            this.btnProgramEdit.Text = "Edit";
            this.btnProgramEdit.UseVisualStyleBackColor = true;
            this.btnProgramEdit.Click += new System.EventHandler(this.btnProgramEdit_Click);
            // 
            // btnProgramInsert
            // 
            this.btnProgramInsert.Location = new System.Drawing.Point(431, 98);
            this.btnProgramInsert.Name = "btnProgramInsert";
            this.btnProgramInsert.Size = new System.Drawing.Size(100, 50);
            this.btnProgramInsert.TabIndex = 48;
            this.btnProgramInsert.Text = "Insert";
            this.btnProgramInsert.UseVisualStyleBackColor = true;
            this.btnProgramInsert.Click += new System.EventHandler(this.btnProgramInsert_Click);
            // 
            // btnProgramAdd
            // 
            this.btnProgramAdd.Location = new System.Drawing.Point(324, 98);
            this.btnProgramAdd.Name = "btnProgramAdd";
            this.btnProgramAdd.Size = new System.Drawing.Size(100, 50);
            this.btnProgramAdd.TabIndex = 47;
            this.btnProgramAdd.Text = "Add";
            this.btnProgramAdd.UseVisualStyleBackColor = true;
            this.btnProgramAdd.Click += new System.EventHandler(this.btnProgramAdd_Click);
            // 
            // cboProgramInstruction
            // 
            this.cboProgramInstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramInstruction.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboProgramInstruction.FormattingEnabled = true;
            this.cboProgramInstruction.Location = new System.Drawing.Point(431, 68);
            this.cboProgramInstruction.Name = "cboProgramInstruction";
            this.cboProgramInstruction.Size = new System.Drawing.Size(206, 24);
            this.cboProgramInstruction.TabIndex = 3;
            this.cboProgramInstruction.SelectedIndexChanged += new System.EventHandler(this.cboProgramInstruction_SelectedIndexChanged);
            // 
            // lblProgramYJ2
            // 
            this.lblProgramYJ2.AutoSize = true;
            this.lblProgramYJ2.Location = new System.Drawing.Point(643, 90);
            this.lblProgramYJ2.Name = "lblProgramYJ2";
            this.lblProgramYJ2.Size = new System.Drawing.Size(34, 21);
            this.lblProgramYJ2.TabIndex = 44;
            this.lblProgramYJ2.Text = "Y :";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramName.Location = new System.Drawing.Point(466, 28);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(171, 27);
            this.txtProgramName.TabIndex = 2;
            // 
            // lblProgramRJ6
            // 
            this.lblProgramRJ6.AutoSize = true;
            this.lblProgramRJ6.Location = new System.Drawing.Point(753, 119);
            this.lblProgramRJ6.Name = "lblProgramRJ6";
            this.lblProgramRJ6.Size = new System.Drawing.Size(33, 21);
            this.lblProgramRJ6.TabIndex = 43;
            this.lblProgramRJ6.Text = "R :";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Location = new System.Drawing.Point(319, 32);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(141, 21);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "Program Name :";
            // 
            // lblProgramWJ4
            // 
            this.lblProgramWJ4.AutoSize = true;
            this.lblProgramWJ4.Location = new System.Drawing.Point(753, 61);
            this.lblProgramWJ4.Name = "lblProgramWJ4";
            this.lblProgramWJ4.Size = new System.Drawing.Size(34, 21);
            this.lblProgramWJ4.TabIndex = 42;
            this.lblProgramWJ4.Text = "W:";
            // 
            // lstProgram
            // 
            this.lstProgram.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstProgram.FormattingEnabled = true;
            this.lstProgram.HorizontalScrollbar = true;
            this.lstProgram.ItemHeight = 19;
            this.lstProgram.Location = new System.Drawing.Point(6, 32);
            this.lstProgram.Name = "lstProgram";
            this.lstProgram.Size = new System.Drawing.Size(307, 175);
            this.lstProgram.TabIndex = 0;
            // 
            // lblProgramPJ5
            // 
            this.lblProgramPJ5.AutoSize = true;
            this.lblProgramPJ5.Location = new System.Drawing.Point(753, 90);
            this.lblProgramPJ5.Name = "lblProgramPJ5";
            this.lblProgramPJ5.Size = new System.Drawing.Size(31, 21);
            this.lblProgramPJ5.TabIndex = 41;
            this.lblProgramPJ5.Text = "P :";
            // 
            // txtProgramXJ1
            // 
            this.txtProgramXJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramXJ1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramXJ1.Location = new System.Drawing.Point(683, 61);
            this.txtProgramXJ1.Name = "txtProgramXJ1";
            this.txtProgramXJ1.Size = new System.Drawing.Size(64, 23);
            this.txtProgramXJ1.TabIndex = 33;
            this.txtProgramXJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramZJ3
            // 
            this.lblProgramZJ3.AutoSize = true;
            this.lblProgramZJ3.Location = new System.Drawing.Point(643, 119);
            this.lblProgramZJ3.Name = "lblProgramZJ3";
            this.lblProgramZJ3.Size = new System.Drawing.Size(32, 21);
            this.lblProgramZJ3.TabIndex = 40;
            this.lblProgramZJ3.Text = "Z :";
            // 
            // txtProgramYJ2
            // 
            this.txtProgramYJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramYJ2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramYJ2.Location = new System.Drawing.Point(683, 90);
            this.txtProgramYJ2.Name = "txtProgramYJ2";
            this.txtProgramYJ2.Size = new System.Drawing.Size(64, 23);
            this.txtProgramYJ2.TabIndex = 34;
            this.txtProgramYJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgramXJ1
            // 
            this.lblProgramXJ1.AutoSize = true;
            this.lblProgramXJ1.Location = new System.Drawing.Point(643, 61);
            this.lblProgramXJ1.Name = "lblProgramXJ1";
            this.lblProgramXJ1.Size = new System.Drawing.Size(34, 21);
            this.lblProgramXJ1.TabIndex = 39;
            this.lblProgramXJ1.Text = "X :";
            // 
            // txtProgramZJ3
            // 
            this.txtProgramZJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramZJ3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramZJ3.Location = new System.Drawing.Point(683, 119);
            this.txtProgramZJ3.Name = "txtProgramZJ3";
            this.txtProgramZJ3.Size = new System.Drawing.Size(64, 23);
            this.txtProgramZJ3.TabIndex = 35;
            this.txtProgramZJ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProgramRJ6
            // 
            this.txtProgramRJ6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramRJ6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramRJ6.Location = new System.Drawing.Point(793, 119);
            this.txtProgramRJ6.Name = "txtProgramRJ6";
            this.txtProgramRJ6.Size = new System.Drawing.Size(64, 23);
            this.txtProgramRJ6.TabIndex = 38;
            this.txtProgramRJ6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProgramWJ4
            // 
            this.txtProgramWJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramWJ4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramWJ4.Location = new System.Drawing.Point(793, 61);
            this.txtProgramWJ4.Name = "txtProgramWJ4";
            this.txtProgramWJ4.Size = new System.Drawing.Size(64, 23);
            this.txtProgramWJ4.TabIndex = 36;
            this.txtProgramWJ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProgramPJ5
            // 
            this.txtProgramPJ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramPJ5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProgramPJ5.Location = new System.Drawing.Point(793, 90);
            this.txtProgramPJ5.Name = "txtProgramPJ5";
            this.txtProgramPJ5.Size = new System.Drawing.Size(64, 23);
            this.txtProgramPJ5.TabIndex = 37;
            this.txtProgramPJ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPMove);
            this.tabControl1.Controls.Add(this.tPInformation);
            this.tabControl1.Controls.Add(this.tPProgram);
            this.tabControl1.Controls.Add(this.tPOther);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(342, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 528);
            this.tabControl1.TabIndex = 22;
            // 
            // tPMove
            // 
            this.tPMove.BackColor = System.Drawing.SystemColors.Control;
            this.tPMove.Controls.Add(this.gbPointMove);
            this.tPMove.Controls.Add(this.gbJogMove);
            this.tPMove.Controls.Add(this.gbLineMove);
            this.tPMove.Location = new System.Drawing.Point(4, 31);
            this.tPMove.Name = "tPMove";
            this.tPMove.Padding = new System.Windows.Forms.Padding(3);
            this.tPMove.Size = new System.Drawing.Size(870, 493);
            this.tPMove.TabIndex = 0;
            this.tPMove.Text = "Move";
            // 
            // tPInformation
            // 
            this.tPInformation.BackColor = System.Drawing.SystemColors.Control;
            this.tPInformation.Controls.Add(this.gbInformation1);
            this.tPInformation.Controls.Add(this.gbInformation3);
            this.tPInformation.Controls.Add(this.gbInformation2);
            this.tPInformation.Location = new System.Drawing.Point(4, 31);
            this.tPInformation.Name = "tPInformation";
            this.tPInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tPInformation.Size = new System.Drawing.Size(870, 493);
            this.tPInformation.TabIndex = 1;
            this.tPInformation.Text = "Information";
            // 
            // gbInformation1
            // 
            this.gbInformation1.Controls.Add(this.lblInformation1);
            this.gbInformation1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInformation1.Location = new System.Drawing.Point(3, 3);
            this.gbInformation1.Name = "gbInformation1";
            this.gbInformation1.Size = new System.Drawing.Size(283, 487);
            this.gbInformation1.TabIndex = 2;
            this.gbInformation1.TabStop = false;
            this.gbInformation1.Text = "Information1";
            // 
            // lblInformation1
            // 
            this.lblInformation1.AutoSize = true;
            this.lblInformation1.Location = new System.Drawing.Point(6, 29);
            this.lblInformation1.Name = "lblInformation1";
            this.lblInformation1.Size = new System.Drawing.Size(115, 21);
            this.lblInformation1.TabIndex = 0;
            this.lblInformation1.Text = "Information1";
            // 
            // gbInformation3
            // 
            this.gbInformation3.Controls.Add(this.lblInformation3);
            this.gbInformation3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInformation3.Location = new System.Drawing.Point(581, 3);
            this.gbInformation3.Name = "gbInformation3";
            this.gbInformation3.Size = new System.Drawing.Size(283, 487);
            this.gbInformation3.TabIndex = 3;
            this.gbInformation3.TabStop = false;
            this.gbInformation3.Text = "Information3";
            // 
            // lblInformation3
            // 
            this.lblInformation3.AutoSize = true;
            this.lblInformation3.Location = new System.Drawing.Point(6, 29);
            this.lblInformation3.Name = "lblInformation3";
            this.lblInformation3.Size = new System.Drawing.Size(115, 21);
            this.lblInformation3.TabIndex = 1;
            this.lblInformation3.Text = "Information3";
            // 
            // gbInformation2
            // 
            this.gbInformation2.Controls.Add(this.lblInformation2);
            this.gbInformation2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInformation2.Location = new System.Drawing.Point(292, 3);
            this.gbInformation2.Name = "gbInformation2";
            this.gbInformation2.Size = new System.Drawing.Size(283, 487);
            this.gbInformation2.TabIndex = 3;
            this.gbInformation2.TabStop = false;
            this.gbInformation2.Text = "Information2";
            // 
            // lblInformation2
            // 
            this.lblInformation2.AutoSize = true;
            this.lblInformation2.Location = new System.Drawing.Point(6, 29);
            this.lblInformation2.Name = "lblInformation2";
            this.lblInformation2.Size = new System.Drawing.Size(115, 21);
            this.lblInformation2.TabIndex = 1;
            this.lblInformation2.Text = "Information2";
            // 
            // tPProgram
            // 
            this.tPProgram.BackColor = System.Drawing.SystemColors.Control;
            this.tPProgram.Controls.Add(this.gbProgram);
            this.tPProgram.Controls.Add(this.gbPoints);
            this.tPProgram.Location = new System.Drawing.Point(4, 31);
            this.tPProgram.Name = "tPProgram";
            this.tPProgram.Size = new System.Drawing.Size(870, 493);
            this.tPProgram.TabIndex = 2;
            this.tPProgram.Text = "Program";
            // 
            // tPOther
            // 
            this.tPOther.BackColor = System.Drawing.SystemColors.Control;
            this.tPOther.Controls.Add(this.gbSafeRange);
            this.tPOther.Controls.Add(this.gbRegister);
            this.tPOther.Location = new System.Drawing.Point(4, 31);
            this.tPOther.Name = "tPOther";
            this.tPOther.Size = new System.Drawing.Size(870, 493);
            this.tPOther.TabIndex = 3;
            this.tPOther.Text = "Other";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(6, 29);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(59, 21);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State :";
            // 
            // lblGetRegister
            // 
            this.lblGetRegister.AutoSize = true;
            this.lblGetRegister.Location = new System.Drawing.Point(6, 29);
            this.lblGetRegister.Name = "lblGetRegister";
            this.lblGetRegister.Size = new System.Drawing.Size(59, 210);
            this.lblGetRegister.TabIndex = 26;
            this.lblGetRegister.Text = "R1 =\r\nR2 =\r\nR3 =\r\nR4 =\r\nR5 =\r\nR6 =\r\nR7 =\r\nR8 =\r\nR9 =\r\nR10 =";
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Location = new System.Drawing.Point(6, 53);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(57, 21);
            this.lblTool.TabIndex = 3;
            this.lblTool.Text = "Tool :";
            // 
            // lblUFrame
            // 
            this.lblUFrame.AutoSize = true;
            this.lblUFrame.Location = new System.Drawing.Point(141, 53);
            this.lblUFrame.Name = "lblUFrame";
            this.lblUFrame.Size = new System.Drawing.Size(0, 21);
            this.lblUFrame.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.gbOverride);
            this.Controls.Add(this.gbCurrentPosition);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.pblogo);
            this.Name = "FrmMain";
            this.Tag = "0";
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbCurrentPosition.ResumeLayout(false);
            this.gbCurrentPosition.PerformLayout();
            this.gbOverride.ResumeLayout(false);
            this.gbOverride.PerformLayout();
            this.gbPointMove.ResumeLayout(false);
            this.gbPointMove.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbJogMove.ResumeLayout(false);
            this.gbJogMove.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbLineMove.ResumeLayout(false);
            this.gbLineMove.PerformLayout();
            this.gbSafeRange.ResumeLayout(false);
            this.gbSafeRange.PerformLayout();
            this.gbPoints.ResumeLayout(false);
            this.gbPoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProgram.ResumeLayout(false);
            this.gbProgram.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tPMove.ResumeLayout(false);
            this.tPInformation.ResumeLayout(false);
            this.gbInformation1.ResumeLayout(false);
            this.gbInformation1.PerformLayout();
            this.gbInformation3.ResumeLayout(false);
            this.gbInformation3.PerformLayout();
            this.gbInformation2.ResumeLayout(false);
            this.gbInformation2.PerformLayout();
            this.tPProgram.ResumeLayout(false);
            this.tPOther.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ComboBox cboRobot;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbCurrentPosition;
        private System.Windows.Forms.Label lblJoint;
        private System.Windows.Forms.Label lblXyzwpr;
        private System.Windows.Forms.GroupBox gbOverride;
        private System.Windows.Forms.Label lblOverride;
        private System.Windows.Forms.GroupBox gbPointMove;
        private System.Windows.Forms.ComboBox cboCoordinate;
        private System.Windows.Forms.Label lblPTPYJ2;
        private System.Windows.Forms.Label lblPTPRJ6;
        private System.Windows.Forms.Label lblPTPWJ4;
        private System.Windows.Forms.Label lblPTPPJ5;
        private System.Windows.Forms.Label lblPTPZJ3;
        private System.Windows.Forms.Label lblPTPXJ1;
        private System.Windows.Forms.TextBox txtPTPRJ6;
        private System.Windows.Forms.TextBox txtPTPPJ5;
        private System.Windows.Forms.TextBox txtPTPWJ4;
        private System.Windows.Forms.TextBox txtPTPZJ3;
        private System.Windows.Forms.TextBox txtPTPYJ2;
        private System.Windows.Forms.TextBox txtPTPXJ1;
        private System.Windows.Forms.Button btnPTPGet;
        private System.Windows.Forms.Button btnPTPSet;
        private System.Windows.Forms.Button btnPositionHome;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtR5;
        private System.Windows.Forms.TextBox txtR4;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.Label lblSetR5;
        private System.Windows.Forms.Label lblSetR4;
        private System.Windows.Forms.Label lblSetR3;
        private System.Windows.Forms.Label lblSetR1;
        private System.Windows.Forms.Label lblSetR2;
        private System.Windows.Forms.Button btnRegisterSet;
        private System.Windows.Forms.GroupBox gbJogMove;
        private System.Windows.Forms.Button btnJogRJ6Positive;
        private System.Windows.Forms.Button btnJogRJ6Negative;
        private System.Windows.Forms.Button btnJogPJ5Positive;
        private System.Windows.Forms.Button btnJogPJ5Negative;
        private System.Windows.Forms.Button btnJogWJ4Positive;
        private System.Windows.Forms.Button btnJogWJ4Negative;
        private System.Windows.Forms.Button btnJogZJ3Positive;
        private System.Windows.Forms.Button btnJogZJ3Negative;
        private System.Windows.Forms.Button btnJogYJ2Positive;
        private System.Windows.Forms.Button btnJogYJ2Negative;
        private System.Windows.Forms.Button btnJogXJ1Positive;
        private System.Windows.Forms.Button btnJogXJ1Negative;
        private System.Windows.Forms.ComboBox cboJogStep;
        private System.Windows.Forms.Label lblJogStep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnPercentdown;
        private System.Windows.Forms.Button btnPercentup;
        private System.Windows.Forms.GroupBox gbLineMove;
        private System.Windows.Forms.TextBox txtLineVelocity;
        private System.Windows.Forms.Label lblLineVelocity;
        private System.Windows.Forms.Button btnLineSet;
        private System.Windows.Forms.Button btnLineGet;
        private System.Windows.Forms.Label lblLineYJ2;
        private System.Windows.Forms.Label lblLineRJ6;
        private System.Windows.Forms.Label lblLineWJ4;
        private System.Windows.Forms.Label lblLinePJ5;
        private System.Windows.Forms.Label lblLineZJ3;
        private System.Windows.Forms.Label lblLineXJ1;
        private System.Windows.Forms.TextBox txtLineRJ6;
        private System.Windows.Forms.TextBox txtLinePJ5;
        private System.Windows.Forms.TextBox txtLineWJ4;
        private System.Windows.Forms.TextBox txtLineZJ3;
        private System.Windows.Forms.TextBox txtLineYJ2;
        private System.Windows.Forms.TextBox txtLineXJ1;
        private System.Windows.Forms.Label lblCoordinate;
        private System.Windows.Forms.Label lblPTPRJ6Unit;
        private System.Windows.Forms.Label lblPTPPJ5Unit;
        private System.Windows.Forms.Label lblPTPWJ4Unit;
        private System.Windows.Forms.Label lblPTPZJ3Unit;
        private System.Windows.Forms.Label lblPTPYJ2Unit;
        private System.Windows.Forms.Label lblPTPXJ1Unit;
        private System.Windows.Forms.Label lblLineVelocityUnit;
        private System.Windows.Forms.Label lblLineRJ6Unit;
        private System.Windows.Forms.Label lblLinePJ5Unit;
        private System.Windows.Forms.Label lblLineWJ4Unit;
        private System.Windows.Forms.Label lblLineZJ3Unit;
        private System.Windows.Forms.Label lblLineYJ2Unit;
        private System.Windows.Forms.Label lblLineXJ1Unit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.GroupBox gbSafeRange;
        private System.Windows.Forms.Label lblSafeRangeYJ2;
        private System.Windows.Forms.Label lblSafeRangeXJ1;
        private System.Windows.Forms.TextBox txtSafeRangeXJ1min;
        private System.Windows.Forms.Button btnSafeRangeSet;
        private System.Windows.Forms.TextBox txtSafeRangeZJ3max;
        private System.Windows.Forms.TextBox txtSafeRangeYJ2max;
        private System.Windows.Forms.TextBox txtSafeRangeXJ1max;
        private System.Windows.Forms.TextBox txtSafeRangeZJ3min;
        private System.Windows.Forms.Label lblSafeRangeZJ3;
        private System.Windows.Forms.TextBox txtSafeRangeYJ2min;
        private System.Windows.Forms.TextBox txtSafeRangeRJ6max;
        private System.Windows.Forms.TextBox txtSafeRangePJ5max;
        private System.Windows.Forms.TextBox txtSafeRangeWJ4max;
        private System.Windows.Forms.TextBox txtSafeRangeRJ6min;
        private System.Windows.Forms.Label lblSafeRangeRJ6;
        private System.Windows.Forms.TextBox txtSafeRangeWJ4min;
        private System.Windows.Forms.Label lblSafeRangeWJ4;
        private System.Windows.Forms.TextBox txtSafeRangePJ5min;
        private System.Windows.Forms.Label lblSafeRangePJ5;
        private System.Windows.Forms.GroupBox gbPoints;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPointsSet;
        private System.Windows.Forms.Button btnPointsLoad;
        private System.Windows.Forms.Button btnPointsGet;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.ListBox lstProgram;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.ComboBox cboProgramInstruction;
        private System.Windows.Forms.Label lblProgramYJ2;
        private System.Windows.Forms.Label lblProgramRJ6;
        private System.Windows.Forms.Label lblProgramWJ4;
        private System.Windows.Forms.Label lblProgramPJ5;
        private System.Windows.Forms.TextBox txtProgramXJ1;
        private System.Windows.Forms.Label lblProgramZJ3;
        private System.Windows.Forms.TextBox txtProgramYJ2;
        private System.Windows.Forms.Label lblProgramXJ1;
        private System.Windows.Forms.TextBox txtProgramZJ3;
        private System.Windows.Forms.TextBox txtProgramRJ6;
        private System.Windows.Forms.TextBox txtProgramWJ4;
        private System.Windows.Forms.TextBox txtProgramPJ5;
        private System.Windows.Forms.Button btnProgramCompile;
        private System.Windows.Forms.Button btnProgramClear;
        private System.Windows.Forms.Button btnProgramDelete;
        private System.Windows.Forms.Button btnProgramEdit;
        private System.Windows.Forms.Button btnProgramInsert;
        private System.Windows.Forms.Button btnProgramAdd;
        private System.Windows.Forms.Label lblProgramInstruction;
        private System.Windows.Forms.Button btnProgramGet;
        private System.Windows.Forms.TextBox txtProgramValue;
        private System.Windows.Forms.Label lblProgramUnit;
        private System.Windows.Forms.Label lblProgramValue;
        private System.Windows.Forms.TextBox txtSafeRangeVelocitymax;
        private System.Windows.Forms.TextBox txtSafeRangeVelocitymin;
        private System.Windows.Forms.Label lblSafeRangeVelocity;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPMove;
        private System.Windows.Forms.TabPage tPInformation;
        private System.Windows.Forms.TabPage tPProgram;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnPointsSave;
        private System.Windows.Forms.Button btnProgramCopy;
        private System.Windows.Forms.GroupBox gbInformation1;
        private System.Windows.Forms.Label lblInformation1;
        private System.Windows.Forms.GroupBox gbInformation2;
        private System.Windows.Forms.Label lblInformation2;
        private System.Windows.Forms.GroupBox gbInformation3;
        private System.Windows.Forms.Label lblInformation3;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TabPage tPOther;
        private System.Windows.Forms.Label lblGetRegister;
        private System.Windows.Forms.Label lblUFrame;
        private System.Windows.Forms.Label lblTool;
    }
}

