﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Robot_Interface
{
    public partial class FrmMain : Form
    {
        //變數宣告
        Controller myController = new Controller();
        public bool fgConnectionStatus { get; set; } = false;



        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 500;
            txtIP.Enabled = false;
            string[] Robot = new string[] { Controller.Robotnum.None.ToString(), Controller.Robotnum.Fanuc.ToString(),
                                            Controller.Robotnum.Nexcom.ToString(), Controller.Robotnum.Ourarm.ToString()};
            cboRobot.Items.AddRange(Robot);
            cboRobot.SelectedIndex = (int)Controller.Robotnum.None;
            string[] Coordinate = new string[] { Controller.Coordinatenum.Cartesian.ToString(), Controller.Coordinatenum.Joint.ToString() };
            cboCoordinate.Items.AddRange(Coordinate);
            cboCoordinate.SelectedIndex = (int)Controller.Coordinatenum.Cartesian;
        }

        #region <object status>
        private void Initialize()
        {
            timer1.Enabled = false;
            txtIP.Enabled = false;
            fgConnectionStatus = false;
            cboRobot.Enabled = true;
            cboRobot.SelectedIndex = (int)Controller.Robotnum.None;
            cboCoordinate.SelectedIndex = (int)Controller.Coordinatenum.Cartesian;
            gbEnbleControl(false);
            txtInitialize();
        }

        private void gbEnbleControl(bool tf)
        {
            gbOverride.Enabled = tf;
            gbCurrentPosition.Enabled = tf;
            gbPositionSet.Enabled = tf;
        }

        private void txtInitialize()
        {
            btnConnection.Text = "Connect";
            lblConnectionStatus.Text = "Connection Status : Disconnected";
            lblXyzwpr.Text = "Cartesian\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            lblJoint.Text = "Joint\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            lblOverride.Text = "";
        }
        #endregion

        #region <gbConnection>
        private void cboRobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboRobot.SelectedIndex)
            {
                case (int)Controller.Robotnum.Fanuc:
                    myController.Robot = (int)Controller.Robotnum.Fanuc;
                    txtIP.Enabled = true;
                    break;
                case (int)Controller.Robotnum.Nexcom:
                    myController.Robot = (int)Controller.Robotnum.Nexcom;
                    txtIP.Enabled = false;
                    break;
                case (int)Controller.Robotnum.Ourarm:
                    myController.Robot = (int)Controller.Robotnum.Ourarm;
                    txtIP.Enabled = false;
                    break;
                default:
                    myController.Robot = (int)Controller.Robotnum.None;
                    txtIP.Enabled = false;
                    break;
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (!fgConnectionStatus)
            {
                switch (myController.Robot)
                {
                    case (int)Controller.Robotnum.Fanuc:
                        RobotAdapter.IP = txtIP.Text;
                        break;
                    case (int)Controller.Robotnum.Nexcom:
                        break;
                    case (int)Controller.Robotnum.Ourarm:
                        break;
                    default:
                        richTextBox1.Text += "請選擇手臂型號\r\n";
                        MessageBox.Show("請選擇手臂型號");
                        return;
                }
                if (myController.Connect())
                {
                    fgConnectionStatus = true;
                    lblConnectionStatus.Text = "Connection Status : Connected";
                    btnConnection.Text = "Disconnect";
                    cboRobot.Enabled = false;
                    timer1.Enabled = true;
                    txtIP.Enabled = false;
                    richTextBox1.Clear();
                    richTextBox1.Text += "手臂連線成功\r\n";
                    MessageBox.Show("手臂連線成功");
                }
                else
                {
                    richTextBox1.Text += "手臂連線失敗\r\n";
                    MessageBox.Show("手臂連線失敗");
                }
            }
            else
            {
                if (myController.Disconnect())
                {
                    Initialize();
                    richTextBox1.Text += "手臂離線成功\r\n";
                    MessageBox.Show("手臂離線成功");
                }
                else
                {
                    richTextBox1.Text += "手臂離線失敗\r\n";
                    MessageBox.Show("手臂離線失敗");
                }
            }
        }
        #endregion

        #region <NOgb>
        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!myController.Refresh())
            {
                ShowMessage("刷新失敗", "取得刷新狀態");
            }

            if (!myController.Alarm())
            {
                ShowMessage("讀取警示失敗", "讀取警示狀態");
            }
            else
            {
                if (RobotAdapter.AlarmText != "")
                {
                    ShowMessage($"{RobotAdapter.AlarmText}", "讀取警示狀態");
                }
            }

            if (!myController.CPosition())
            {
                ShowMessage("讀取卡氏座標失敗", "讀取卡氏座標狀態");
                lblXyzwpr.Text = "Cartesian\r\n";
                lblXyzwpr.Text += $"X : Error\r\n";
                lblXyzwpr.Text += $"Y : Error\r\n";
                lblXyzwpr.Text += $"Z : Error\r\n";
                lblXyzwpr.Text += $"W: Error\r\n";
                lblXyzwpr.Text += $"P : Error\r\n";
                lblXyzwpr.Text += $"R : Error\r\n";
            }
            else
            {
                lblXyzwpr.Text = "Cartesian\r\n";
                lblXyzwpr.Text += $"X : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Y : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"Z : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"W: {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"P : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblXyzwpr.Text += $"R : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(5)).ToString("###0.000"))}\r\n";
            }

            if (!myController.JPosition())
            {
                ShowMessage("讀取軸座標失敗", "讀取軸座標狀態");
                lblJoint.Text = "Joint\r\n";
                lblJoint.Text += $"J1 : Error\r\n";
                lblJoint.Text += $"J2 : Error\r\n";
                lblJoint.Text += $"J3 : Error\r\n";
                lblJoint.Text += $"J4 : Error\r\n";
                lblJoint.Text += $"J5 : Error\r\n";
                lblJoint.Text += $"J6 : Error\r\n";
            }
            else
            {
                lblJoint.Text = "Joint\r\n";
                lblJoint.Text += $"J1 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(0)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J2 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(1)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J3 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(2)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J4 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(3)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J5 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(4)).ToString("###0.000"))}\r\n";
                lblJoint.Text += $"J6 : {string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(5)).ToString("###0.000"))}\r\n";
            }

            if (!myController.Override())
            {
                ShowMessage("讀取速度百分比失敗", "讀取速度百分比狀態");
                lblOverride.Text = "Error";
            }
            else
            {
                lblOverride.Text = RobotAdapter.OverrideText;
            }
        }
        private void ShowMessage(string content, string title)
        {
            DialogResult result;
            timer1.Enabled = false;
            richTextBox1.Text += $"{content}\r\n";
            result = MessageBox.Show($"{content}", $"{title}", MessageBoxButtons.AbortRetryIgnore);
            if (result == DialogResult.Abort)
            {
                if (myController.Disconnect())
                {
                    Initialize();
                    richTextBox1.Text += "手臂離線成功\r\n";
                    MessageBox.Show("手臂離線成功");
                }
                else
                {
                    timer1.Enabled = true;
                    richTextBox1.Text += "手臂離線失敗\r\n";
                    MessageBox.Show("手臂離線失敗");
                }
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        #endregion

        #region <gbPositionSet>
        private void cboCoordinate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCoordinate.SelectedIndex)
            {
                case (int)Controller.Coordinatenum.Cartesian:
                    myController.Coordinate = (int)Controller.Coordinatenum.Cartesian;
                    lblXJ1Set.Text = "X :";
                    lblYJ2Set.Text = "Y :";
                    lblZJ3Set.Text = "Z :";
                    lblWJ4Set.Text = "W:";
                    lblPJ5Set.Text = "P :";
                    lblRJ6Set.Text = "R :";
                    break;
                case (int)Controller.Coordinatenum.Joint:
                    myController.Coordinate = (int)Controller.Coordinatenum.Joint;
                    lblXJ1Set.Text = "J1 :";
                    lblYJ2Set.Text = "J2 :";
                    lblZJ3Set.Text = "J3 :";
                    lblWJ4Set.Text = "J4 :";
                    lblPJ5Set.Text = "J5 :";
                    lblRJ6Set.Text = "J6 :";
                    break;
            }
        }

        private void btnPositionCopy_Click(object sender, EventArgs e)
        {
            switch (myController.Coordinate)
            {
                case (int)Controller.Coordinatenum.Cartesian:
                    tbXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(0)).ToString("###0.000"))}";
                    tbYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(1)).ToString("###0.000"))}";
                    tbZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(2)).ToString("###0.000"))}";
                    tbWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(3)).ToString("###0.000"))}";
                    tbPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(4)).ToString("###0.000"))}";
                    tbRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Cposition.GetValue(5)).ToString("###0.000"))}";
                    break;
                case (int)Controller.Coordinatenum.Joint:
                    tbXJ1Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(0)).ToString("###0.000"))}";
                    tbYJ2Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(1)).ToString("###0.000"))}";
                    tbZJ3Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(2)).ToString("###0.000"))}";
                    tbWJ4Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(3)).ToString("###0.000"))}";
                    tbPJ5Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(4)).ToString("###0.000"))}";
                    tbRJ6Set.Text = $"{string.Format("{0,10}", Convert.ToSingle(RobotAdapter.Jposition.GetValue(5)).ToString("###0.000"))}";
                    break;
            }
        }

        private void btnPositionSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbXJ1Set.Text) || string.IsNullOrEmpty(tbYJ2Set.Text) || string.IsNullOrEmpty(tbZJ3Set.Text) ||
                    string.IsNullOrEmpty(tbWJ4Set.Text) || string.IsNullOrEmpty(tbPJ5Set.Text) || string.IsNullOrEmpty(tbRJ6Set.Text))   // || string.IsNullOrEmpty(VelocitySet_tb.Text)
                {
                    MessageBox.Show("座標值和速度值不可有空白");
                }
                else
                {
                    switch (myController.Coordinate)
                    {
                        case (int)Controller.Coordinatenum.Cartesian:
                            if (Convert.ToSingle(tbXJ1Set.Text) <= 0 || Convert.ToSingle(tbXJ1Set.Text) >= 700 ||
                                Convert.ToSingle(tbYJ2Set.Text) <= -500 || Convert.ToSingle(tbYJ2Set.Text) >= 600 ||
                                Convert.ToSingle(tbZJ3Set.Text) <= -130 || Convert.ToSingle(tbZJ3Set.Text) >= 500)
                            {
                                MessageBox.Show("座標超出安全範圍");
                            }
                            else
                            {
                                RobotAdapter.CpositionSet.SetValue(Convert.ToSingle(tbXJ1Set.Text), 0);
                                RobotAdapter.CpositionSet.SetValue(Convert.ToSingle(tbYJ2Set.Text), 1);
                                RobotAdapter.CpositionSet.SetValue(Convert.ToSingle(tbZJ3Set.Text), 2);
                                RobotAdapter.CpositionSet.SetValue(Convert.ToSingle(tbWJ4Set.Text), 3);
                                RobotAdapter.CpositionSet.SetValue(Convert.ToSingle(tbPJ5Set.Text), 4);
                                RobotAdapter.CpositionSet.SetValue(Convert.ToSingle(tbRJ6Set.Text), 5);
                                if (!myController.CPositionSet())
                                {
                                    ShowMessage("座標設定失敗", "點到點移動狀態");
                                }
                            }
                            break;
                        case (int)Controller.Coordinatenum.Joint:
                            if (Convert.ToSingle(tbXJ1Set.Text) <= -180 || Convert.ToSingle(tbXJ1Set.Text) >= 180 ||
                                Convert.ToSingle(tbYJ2Set.Text) <= -180 || Convert.ToSingle(tbYJ2Set.Text) >= 180 ||
                                Convert.ToSingle(tbZJ3Set.Text) <= -180 || Convert.ToSingle(tbZJ3Set.Text) >= 180 ||
                                Convert.ToSingle(tbWJ4Set.Text) <= -180 || Convert.ToSingle(tbWJ4Set.Text) >= 180 ||
                                Convert.ToSingle(tbPJ5Set.Text) <= -180 || Convert.ToSingle(tbPJ5Set.Text) >= 180 ||
                                Convert.ToSingle(tbRJ6Set.Text) <= -180 || Convert.ToSingle(tbRJ6Set.Text) >= 180)
                            {
                                MessageBox.Show("座標超出安全範圍");
                            }
                            else
                            {
                                RobotAdapter.JpositionSet.SetValue(Convert.ToSingle(tbXJ1Set.Text), 0);
                                RobotAdapter.JpositionSet.SetValue(Convert.ToSingle(tbYJ2Set.Text), 1);
                                RobotAdapter.JpositionSet.SetValue(Convert.ToSingle(tbZJ3Set.Text), 2);
                                RobotAdapter.JpositionSet.SetValue(Convert.ToSingle(tbWJ4Set.Text), 3);
                                RobotAdapter.JpositionSet.SetValue(Convert.ToSingle(tbPJ5Set.Text), 4);
                                RobotAdapter.JpositionSet.SetValue(Convert.ToSingle(tbRJ6Set.Text), 5);
                                if (!myController.JPositionSet())
                                {
                                    ShowMessage("座標設定失敗", "點到點移動狀態");
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數值");
            }
        }

        #endregion

    }
}
