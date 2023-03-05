﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Robot_Interface
{
    public class Controller
    {
        //變數宣告
        RobotAdapter myRobotAdapter = null;
        
        public Robotnum Robot { get; set; } = Robotnum.None;
        public enum Robotnum { None, Fanuc, Nexcom, Ourarm }
        public Coordinatenum Coordinate { get; set; } = Coordinatenum.Cartesian;
        public enum Coordinatenum { Cartesian, Joint }
        public Stepnum Step { get; set; } = Stepnum.One;
        public enum Stepnum : int { One = 1, Five = 5, Ten = 10, Cont = 20 }

        #region <共用>
        public bool Connect()
        {
            switch (Robot)
            {
                case Robotnum.Fanuc:
                    myRobotAdapter = new FanucAdapter();
                    return myRobotAdapter.Connect();
                case Robotnum.Nexcom:
                    myRobotAdapter = new NexcomAdapter();
                    return myRobotAdapter.Connect();
                case Robotnum.Ourarm:
                    return false;
                default:
                    return false;
            }
        }
        public bool Disconnect()
        {
            return myRobotAdapter.Disconnect();
        }
        public bool Alarm()
        {
            return myRobotAdapter.Alarm();
        }
        public bool Reset()
        {
            return myRobotAdapter.Reset();
        }
        public bool GetOverride()
        {
            return myRobotAdapter.GetOverride();
        }
        public bool SetOverride()
        {
            return myRobotAdapter.SetOverride();
        }
        public bool GetCPosition()
        {
            return myRobotAdapter.GetCPosition();
        }
        public bool GetJPosition()
        {
            return myRobotAdapter.GetJPosition();
        }
        public bool PTPC()
        {
            return myRobotAdapter.PTPC();
        }
        public bool PTPJ()
        {
            return myRobotAdapter.PTPJ();
        }
        public bool Line()
        {
            return myRobotAdapter.Line();
        }
        public bool Home()
        {
            return myRobotAdapter.Home();
        }
        public bool GetVelocity()
        {
            return myRobotAdapter.GetVelocity();
        }
        public bool SetVelocity()
        {
            return myRobotAdapter.SetVelocity();
        }
        public bool JogC()
        {
            return myRobotAdapter.JogC();
        }
        public bool JogJ()
        {
            return myRobotAdapter.JogJ();
        }
        public bool IncC()
        {
            return myRobotAdapter.IncC();
        }
        public bool IncJ()
        {
            return myRobotAdapter.IncJ();
        }
        public bool GetInformation1()
        {
            return myRobotAdapter.GetInformation1();
        }
        public bool GetInformation2()
        {
            return myRobotAdapter.GetInformation2();
        }
        public bool GetInformation3()
        {
            return myRobotAdapter.GetInformation3();
        }
        public bool GetInformation4()
        {
            return myRobotAdapter.GetInformation4();
        }
        #endregion

        #region <Fanuc>
        public bool Refresh()
        {
            return myRobotAdapter.Refresh();
        }
        public bool GetRegister()
        {
            return myRobotAdapter.GetRegister();
        }
        public bool SetRegister()
        {
            return myRobotAdapter.SetRegister();
        }
        #endregion

        #region <Nexcom>
        public bool Enable()
        {
            return myRobotAdapter.Enable();
        }
        public bool Disable()
        {
            return myRobotAdapter.Disable();
        }
        public bool Hold()
        {
            return myRobotAdapter.Hold();
        }
        #endregion
    }
}
