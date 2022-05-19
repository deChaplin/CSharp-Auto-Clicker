namespace trackBarTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.sliderMinCps = new MaterialSkin.Controls.MaterialSlider();
            this.sliderMaxCps = new MaterialSkin.Controls.MaterialSlider();
            this.lblNoClicks = new MaterialSkin.Controls.MaterialLabel();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.rButtonLeft = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblMspc1 = new System.Windows.Forms.Label();
            this.lblMspc2 = new System.Windows.Forms.Label();
            this.rButtonRight = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblRandomDelay = new MaterialSkin.Controls.MaterialLabel();
            this.lblPcName1 = new System.Windows.Forms.Label();
            this.lblCoreCount1 = new System.Windows.Forms.Label();
            this.lblOs1 = new System.Windows.Forms.Label();
            this.lblProcessID = new System.Windows.Forms.Label();
            this.lblRunning = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenu = new MaterialSkin.Controls.MaterialLabel();
            this.lblHideGuiKey = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(764, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(734, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 31);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "—";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // sliderMinCps
            // 
            this.sliderMinCps.Depth = 0;
            this.sliderMinCps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderMinCps.Location = new System.Drawing.Point(9, 80);
            this.sliderMinCps.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliderMinCps.Name = "sliderMinCps";
            this.sliderMinCps.RangeMax = 50;
            this.sliderMinCps.RangeMin = 1;
            this.sliderMinCps.Size = new System.Drawing.Size(353, 40);
            this.sliderMinCps.TabIndex = 8;
            this.sliderMinCps.Text = "Min CPS";
            this.sliderMinCps.Value = 1;
            this.sliderMinCps.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.sliderMinCps_onValueChanged);
            // 
            // sliderMaxCps
            // 
            this.sliderMaxCps.BackColor = System.Drawing.Color.White;
            this.sliderMaxCps.Depth = 0;
            this.sliderMaxCps.ForeColor = System.Drawing.Color.White;
            this.sliderMaxCps.Location = new System.Drawing.Point(9, 126);
            this.sliderMaxCps.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliderMaxCps.Name = "sliderMaxCps";
            this.sliderMaxCps.RangeMax = 50;
            this.sliderMaxCps.RangeMin = 1;
            this.sliderMaxCps.Size = new System.Drawing.Size(353, 40);
            this.sliderMaxCps.TabIndex = 9;
            this.sliderMaxCps.Text = "Max CPS";
            this.sliderMaxCps.Value = 2;
            this.sliderMaxCps.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.sliderMaxCps_onValueChanged);
            // 
            // lblNoClicks
            // 
            this.lblNoClicks.AutoSize = true;
            this.lblNoClicks.Depth = 0;
            this.lblNoClicks.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoClicks.Location = new System.Drawing.Point(9, 378);
            this.lblNoClicks.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoClicks.Name = "lblNoClicks";
            this.lblNoClicks.Size = new System.Drawing.Size(124, 19);
            this.lblNoClicks.TabIndex = 10;
            this.lblNoClicks.Text = "Number of clicks:";
            // 
            // btnStart
            // 
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(11, 403);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStart.Size = new System.Drawing.Size(67, 36);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStart.UseAccentColor = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = null;
            this.btnStop.Location = new System.Drawing.Point(93, 403);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStop.Size = new System.Drawing.Size(64, 36);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop.UseAccentColor = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rButtonLeft
            // 
            this.rButtonLeft.AutoSize = true;
            this.rButtonLeft.Depth = 0;
            this.rButtonLeft.ForeColor = System.Drawing.Color.White;
            this.rButtonLeft.Location = new System.Drawing.Point(6, 40);
            this.rButtonLeft.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonLeft.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonLeft.Name = "rButtonLeft";
            this.rButtonLeft.Ripple = true;
            this.rButtonLeft.Size = new System.Drawing.Size(101, 37);
            this.rButtonLeft.TabIndex = 20;
            this.rButtonLeft.TabStop = true;
            this.rButtonLeft.Text = "Left Click";
            this.rButtonLeft.UseVisualStyleBackColor = true;
            // 
            // lblMspc1
            // 
            this.lblMspc1.AutoSize = true;
            this.lblMspc1.Location = new System.Drawing.Point(368, 93);
            this.lblMspc1.Name = "lblMspc1";
            this.lblMspc1.Size = new System.Drawing.Size(42, 15);
            this.lblMspc1.TabIndex = 22;
            this.lblMspc1.Text = "MSPC:";
            // 
            // lblMspc2
            // 
            this.lblMspc2.AutoSize = true;
            this.lblMspc2.Location = new System.Drawing.Point(368, 139);
            this.lblMspc2.Name = "lblMspc2";
            this.lblMspc2.Size = new System.Drawing.Size(42, 15);
            this.lblMspc2.TabIndex = 23;
            this.lblMspc2.Text = "MSPC:";
            // 
            // rButtonRight
            // 
            this.rButtonRight.AutoSize = true;
            this.rButtonRight.Depth = 0;
            this.rButtonRight.ForeColor = System.Drawing.Color.White;
            this.rButtonRight.Location = new System.Drawing.Point(116, 40);
            this.rButtonRight.Margin = new System.Windows.Forms.Padding(0);
            this.rButtonRight.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rButtonRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.rButtonRight.Name = "rButtonRight";
            this.rButtonRight.Ripple = true;
            this.rButtonRight.Size = new System.Drawing.Size(110, 37);
            this.rButtonRight.TabIndex = 25;
            this.rButtonRight.TabStop = true;
            this.rButtonRight.Text = "Right Click";
            this.rButtonRight.UseVisualStyleBackColor = true;
            // 
            // lblRandomDelay
            // 
            this.lblRandomDelay.AutoSize = true;
            this.lblRandomDelay.Depth = 0;
            this.lblRandomDelay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRandomDelay.Location = new System.Drawing.Point(9, 359);
            this.lblRandomDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRandomDelay.Name = "lblRandomDelay";
            this.lblRandomDelay.Size = new System.Drawing.Size(107, 19);
            this.lblRandomDelay.TabIndex = 26;
            this.lblRandomDelay.Text = "Random delay:";
            // 
            // lblPcName1
            // 
            this.lblPcName1.AutoSize = true;
            this.lblPcName1.ForeColor = System.Drawing.Color.White;
            this.lblPcName1.Location = new System.Drawing.Point(662, 388);
            this.lblPcName1.Name = "lblPcName1";
            this.lblPcName1.Size = new System.Drawing.Size(39, 15);
            this.lblPcName1.TabIndex = 30;
            this.lblPcName1.Text = "Name";
            // 
            // lblCoreCount1
            // 
            this.lblCoreCount1.AutoSize = true;
            this.lblCoreCount1.ForeColor = System.Drawing.Color.White;
            this.lblCoreCount1.Location = new System.Drawing.Point(662, 403);
            this.lblCoreCount1.Name = "lblCoreCount1";
            this.lblCoreCount1.Size = new System.Drawing.Size(66, 15);
            this.lblCoreCount1.TabIndex = 31;
            this.lblCoreCount1.Text = "Core count";
            // 
            // lblOs1
            // 
            this.lblOs1.AutoSize = true;
            this.lblOs1.ForeColor = System.Drawing.Color.White;
            this.lblOs1.Location = new System.Drawing.Point(662, 418);
            this.lblOs1.Name = "lblOs1";
            this.lblOs1.Size = new System.Drawing.Size(22, 15);
            this.lblOs1.TabIndex = 32;
            this.lblOs1.Text = "OS";
            // 
            // lblProcessID
            // 
            this.lblProcessID.AutoSize = true;
            this.lblProcessID.ForeColor = System.Drawing.Color.White;
            this.lblProcessID.Location = new System.Drawing.Point(662, 433);
            this.lblProcessID.Name = "lblProcessID";
            this.lblProcessID.Size = new System.Drawing.Size(18, 15);
            this.lblProcessID.TabIndex = 33;
            this.lblProcessID.Text = "ID";
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.ForeColor = System.Drawing.Color.Lime;
            this.lblRunning.Location = new System.Drawing.Point(166, 415);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(52, 15);
            this.lblRunning.TabIndex = 34;
            this.lblRunning.Text = "Running";
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.ForeColor = System.Drawing.Color.Red;
            this.lblOff.Location = new System.Drawing.Point(166, 418);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(75, 15);
            this.lblOff.TabIndex = 35;
            this.lblOff.Text = "Not Running";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::trackBarTest.Properties.Resources.rainbow;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Depth = 0;
            this.lblMenu.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMenu.Location = new System.Drawing.Point(9, 178);
            this.lblMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(94, 19);
            this.lblMenu.TabIndex = 37;
            this.lblMenu.Text = "Hide GUI key:";
            // 
            // lblHideGuiKey
            // 
            this.lblHideGuiKey.AutoSize = true;
            this.lblHideGuiKey.Depth = 0;
            this.lblHideGuiKey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHideGuiKey.Location = new System.Drawing.Point(109, 178);
            this.lblHideGuiKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHideGuiKey.Name = "lblHideGuiKey";
            this.lblHideGuiKey.Size = new System.Drawing.Size(86, 19);
            this.lblHideGuiKey.TabIndex = 38;
            this.lblHideGuiKey.Text = "{Not Bound}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHideGuiKey);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOff);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.lblProcessID);
            this.Controls.Add(this.lblOs1);
            this.Controls.Add(this.lblCoreCount1);
            this.Controls.Add(this.lblPcName1);
            this.Controls.Add(this.lblRandomDelay);
            this.Controls.Add(this.rButtonRight);
            this.Controls.Add(this.lblMspc2);
            this.Controls.Add(this.lblMspc1);
            this.Controls.Add(this.rButtonLeft);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNoClicks);
            this.Controls.Add(this.sliderMaxCps);
            this.Controls.Add(this.sliderMinCps);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClose;
        private Button btnMin;
        private MaterialSkin.Controls.MaterialSlider sliderMinCps;
        private MaterialSkin.Controls.MaterialSlider sliderMaxCps;
        private MaterialSkin.Controls.MaterialLabel lblNoClicks;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private MaterialSkin.Controls.MaterialButton btnStop;
        private MaterialSkin.Controls.MaterialRadioButton rButtonLeft;
        private Label lblMspc1;
        private Label lblMspc2;
        private MaterialSkin.Controls.MaterialRadioButton rButtonRight;
        private MaterialSkin.Controls.MaterialLabel lblRandomDelay;
        private Label lblPcName1;
        private Label lblCoreCount1;
        private Label lblOs1;
        private Label lblProcessID;
        private Label lblRunning;
        private Label lblOff;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblMenu;
        private MaterialSkin.Controls.MaterialLabel lblHideGuiKey;
    }
}