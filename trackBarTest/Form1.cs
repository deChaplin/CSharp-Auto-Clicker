using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System;
using Helper;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;

namespace trackBarTest
{
    public partial class Form1 : Form
    {
        // *************************
        // <<<< VARIABLES START >>>>
        // *************************

        // Default auto clicker values
        int minDefaultValue = 10;
        int maxDefaultValue = 20;

        // Thread
        private Thread thread;

        // CPS and MSPC for bboth sliders
        private int cps = 10;
        private int mspc = 100;
        private int cps2 = 10;
        private int mspc2 = 100;

        // Random delay
        int answer = 0;

        // The number of clicks made
        int noOfClicks = 0;

        // Used for global keybaord and mouse
        KeyHelper kh = new KeyHelper(); // Keyboard input
        MouseHelper mh = new MouseHelper(); // Mouse input

        // Hide form
        bool formHidden = false;
        string hideGuiKey = "";

        // Bool to check if autoclicker is running
        bool autoClickerRunning = false;

        // ***********************
        // <<<< VARIABLES END >>>>
        // ***********************

        public Form1()
        {
            InitializeComponent();

            // Material form colour settings
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            kh.KeyDown += Kh_KeyDown;

            sliderMinCps.Value = minDefaultValue;
            sliderMaxCps.Value = maxDefaultValue;

            system_Information();
        }

        // System information check
        private void system_Information()
        {
            string currentOS = "";

            // Operating system check
            if (myOperatingSystem.isWindows() == true)
            {
                currentOS = "Windows";
                            //System.Environment.OSVersion.ToString(); 
            }
            else if (myOperatingSystem.isMacOS() == true)
            {
                currentOS = "MacOS";
            }
            else if (myOperatingSystem.isLinux() == true)
            {
                currentOS = "Linux";
            }
            // Setting OS text
            lblOs1.Text = "Current OS: " + currentOS;

            lblCoreCount1.Text = "Core Count: " + System.Environment.ProcessorCount.ToString();
            lblPcName1.Text = "User: " + System.Environment.UserName;
            lblProcessID.Text = "ProcessID: " + System.Environment.ProcessId;
            
        }

        // Executed when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        // Checks the OS
        public static class myOperatingSystem
        {
            public static bool isWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            public static bool isMacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
            public static bool isLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }

        // Show and hide form
        private void Kh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (formHidden == false)
                {
                    formHidden = true;
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    formHidden = false;
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }
        // Closes the app
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimises the app
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //******************************
        //  <<<< Imports user32.dll >>>>
        //******************************
        public class Win32
        {
            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

            [DllImport("user32.dll")]
            public static extern bool ReleaseCapture();

            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
            public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
            //Mouse actions
            public const int MOUSEEVENTF_LEFTDOWN = 0x02;
            public const int MOUSEEVENTF_LEFTUP = 0x04;
            public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
            public const int MOUSEEVENTF_RIGHTUP = 0x10;

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }

            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
            );
        }
        //************************************
        //  <<<< End of user32.dll import >>>>
        //************************************

        // ***********************************
        // <<<< Start of draggable window >>>>
        // ***********************************

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        // *********************************
        // <<<< End of draggable window >>>>
        // *********************************

        // Min bar
        private void sliderMinCps_onValueChanged(object sender, int newValue)
        {
            if(sliderMinCps.Value < 1)
            {
                sliderMinCps.Value = 1;
            }
            if (sliderMinCps.Value > sliderMaxCps.Value)
            {
                sliderMinCps.Value = sliderMaxCps.Value - 1;
            }
            else
            {
                cps = sliderMinCps.Value;
                //label3.Text = "CPS: " + sliderMinCps.Value.ToString();
                mspc = (1000 / cps);
            }
        }

        // Max bar
        private void sliderMaxCps_onValueChanged(object sender, int newValue)
        {
            if (sliderMinCps.Value > sliderMaxCps.Value)
            {
                sliderMinCps.Value = sliderMaxCps.Value - 1;
            }
            else
            {
                cps2 = sliderMaxCps.Value;
                //label3.Text = "CPS: " + sliderMinCps.Value.ToString();
                mspc2 = (1000 / cps2);
            }
        }

        // Start
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblOff.Visible = false;
            lblRunning.Visible = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            lblMspc1.Text = mspc.ToString();
            lblMspc2.Text = mspc2.ToString();

            autoClickerRunning = true;

            thread = new Thread(this.Click);
            thread.Start();
        }

        // Stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            lblOff.Visible = true;
            lblRunning.Visible = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            autoClickerRunning = false;
            //thread.Abort();
        }

        // Click
        private new void Click()
        {
            while (autoClickerRunning == true)
            {
                // Checks if which mspc is larger to prevent crashing
                if (mspc2 > mspc)
                {
                    answer = new Random().Next(mspc, mspc2);
                }
                else if (mspc > mspc2)
                {
                    answer = new Random().Next(mspc2, mspc);
                }
                // Check window state to only click when window is minimised
                if (this.WindowState == FormWindowState.Normal)
                {
                    
                }
                else if (this.WindowState == FormWindowState.Minimized)
                {
                    if (rButtonLeft.Enabled == true)
                    {
                        Win32.mouse_event(0x0002, 0, 0, 0, 0);
                        Thread.Sleep(1);
                        Win32.mouse_event(0x0004, 0, 0, 0, 0);
                    }
                    else if (rButtonRight.Enabled == true)
                    {
                        Win32.mouse_event(0x08, 0, 0, 0, 0);
                        Thread.Sleep(1);
                        Win32.mouse_event(0x10, 0, 0, 0, 0);
                    }
                    lblRandomDelay.Invoke((MethodInvoker)(() => lblRandomDelay.Text = "Random delay: " + answer.ToString()));
                    lblNoClicks.Invoke((MethodInvoker)(() => lblNoClicks.Text = "Number of clicks: " + noOfClicks.ToString()));
                }
                Thread.Sleep(answer);
                noOfClicks++;
            }
        }
    }
}