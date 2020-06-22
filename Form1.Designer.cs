namespace TDDoSer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            STOP();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizeBoxC = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeBoxC = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TextLabel = new Guna.UI.WinForms.GunaLabel();
            this.CloseBoxC = new Guna.UI2.WinForms.Guna2ControlBox();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TargetTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.PSPingSwitch = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.CMDPing = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.banditLabel = new Guna.UI.WinForms.GunaLabel();
            this.pingLabel = new Guna.UI.WinForms.GunaLabel();
            this.PSThreads = new Guna.UI.WinForms.GunaNumeric();
            this.CMDThreads = new Guna.UI.WinForms.GunaNumeric();
            this.runButton = new Guna.UI2.WinForms.Guna2Button();
            this.notifyLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.notifyLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.stopButton = new Guna.UI2.WinForms.Guna2Button();
            this.ThreadsLabel = new Guna.UI.WinForms.GunaLabel();
            this.Packets = new Guna.UI.WinForms.GunaLabel();
            this.ddTools = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.ddThreads = new Guna.UI.WinForms.GunaNumeric();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.hardkor = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TopPanel.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.MinimizeBoxC);
            this.TopPanel.Controls.Add(this.MaximizeBoxC);
            this.TopPanel.Controls.Add(this.TextLabel);
            this.TopPanel.Controls.Add(this.CloseBoxC);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(588, 30);
            this.TopPanel.TabIndex = 0;
            // 
            // MinimizeBoxC
            // 
            this.MinimizeBoxC.Animated = true;
            this.MinimizeBoxC.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBoxC.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBoxC.FillColor = System.Drawing.Color.Black;
            this.MinimizeBoxC.HoverState.Parent = this.MinimizeBoxC;
            this.MinimizeBoxC.IconColor = System.Drawing.Color.Red;
            this.MinimizeBoxC.Location = new System.Drawing.Point(453, 0);
            this.MinimizeBoxC.Name = "MinimizeBoxC";
            this.MinimizeBoxC.PressedColor = System.Drawing.Color.Gainsboro;
            this.MinimizeBoxC.ShadowDecoration.Parent = this.MinimizeBoxC;
            this.MinimizeBoxC.Size = new System.Drawing.Size(45, 30);
            this.MinimizeBoxC.TabIndex = 7;
            // 
            // MaximizeBoxC
            // 
            this.MaximizeBoxC.Animated = true;
            this.MaximizeBoxC.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.MaximizeBoxC.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeBoxC.FillColor = System.Drawing.Color.Black;
            this.MaximizeBoxC.HoverState.Parent = this.MaximizeBoxC;
            this.MaximizeBoxC.IconColor = System.Drawing.Color.Red;
            this.MaximizeBoxC.Location = new System.Drawing.Point(498, 0);
            this.MaximizeBoxC.Name = "MaximizeBoxC";
            this.MaximizeBoxC.PressedColor = System.Drawing.Color.Gainsboro;
            this.MaximizeBoxC.ShadowDecoration.Parent = this.MaximizeBoxC;
            this.MaximizeBoxC.Size = new System.Drawing.Size(45, 30);
            this.MaximizeBoxC.TabIndex = 6;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TextLabel.Location = new System.Drawing.Point(3, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(59, 15);
            this.TextLabel.TabIndex = 4;
            this.TextLabel.Text = "{this.Text}";
            // 
            // CloseBoxC
            // 
            this.CloseBoxC.Animated = true;
            this.CloseBoxC.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBoxC.FillColor = System.Drawing.Color.Black;
            this.CloseBoxC.HoverState.Parent = this.CloseBoxC;
            this.CloseBoxC.IconColor = System.Drawing.Color.Red;
            this.CloseBoxC.Location = new System.Drawing.Point(543, 0);
            this.CloseBoxC.Name = "CloseBoxC";
            this.CloseBoxC.PressedColor = System.Drawing.Color.Gainsboro;
            this.CloseBoxC.ShadowDecoration.Parent = this.CloseBoxC;
            this.CloseBoxC.Size = new System.Drawing.Size(45, 30);
            this.CloseBoxC.TabIndex = 5;
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.TopPanel;
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.BorderColor = System.Drawing.Color.Red;
            this.TargetTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TargetTextBox.DefaultText = "127.0.0.1";
            this.TargetTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TargetTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TargetTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TargetTextBox.DisabledState.Parent = this.TargetTextBox;
            this.TargetTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TargetTextBox.FillColor = System.Drawing.Color.Black;
            this.TargetTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetTextBox.FocusedState.FillColor = System.Drawing.Color.Black;
            this.TargetTextBox.FocusedState.ForeColor = System.Drawing.Color.Red;
            this.TargetTextBox.FocusedState.Parent = this.TargetTextBox;
            this.TargetTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TargetTextBox.ForeColor = System.Drawing.Color.Red;
            this.TargetTextBox.HideSelection = false;
            this.TargetTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetTextBox.HoverState.Parent = this.TargetTextBox;
            this.TargetTextBox.Location = new System.Drawing.Point(109, 36);
            this.TargetTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TargetTextBox.MaxLength = 300;
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.PasswordChar = '\0';
            this.TargetTextBox.PlaceholderForeColor = System.Drawing.Color.Red;
            this.TargetTextBox.PlaceholderText = "";
            this.TargetTextBox.SelectedText = "";
            this.TargetTextBox.ShadowDecoration.Parent = this.TargetTextBox;
            this.TargetTextBox.Size = new System.Drawing.Size(200, 33);
            this.TargetTextBox.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(1, 38);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(88, 28);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Цель (IP)";
            // 
            // PSPingSwitch
            // 
            this.PSPingSwitch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PSPingSwitch.BaseColor = System.Drawing.SystemColors.Control;
            this.PSPingSwitch.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.PSPingSwitch.CheckedOnColor = System.Drawing.Color.Red;
            this.PSPingSwitch.FillColor = System.Drawing.Color.White;
            this.PSPingSwitch.Location = new System.Drawing.Point(9, 23);
            this.PSPingSwitch.Name = "PSPingSwitch";
            this.PSPingSwitch.Size = new System.Drawing.Size(38, 20);
            this.PSPingSwitch.TabIndex = 4;
            // 
            // CMDPing
            // 
            this.CMDPing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CMDPing.BaseColor = System.Drawing.SystemColors.Control;
            this.CMDPing.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.CMDPing.CheckedOnColor = System.Drawing.Color.Red;
            this.CMDPing.FillColor = System.Drawing.Color.White;
            this.CMDPing.Location = new System.Drawing.Point(9, 63);
            this.CMDPing.Name = "CMDPing";
            this.CMDPing.Size = new System.Drawing.Size(38, 20);
            this.CMDPing.TabIndex = 5;
            // 
            // banditLabel
            // 
            this.banditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.banditLabel.AutoSize = true;
            this.banditLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banditLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.banditLabel.ForeColor = System.Drawing.Color.White;
            this.banditLabel.Location = new System.Drawing.Point(53, 15);
            this.banditLabel.Name = "banditLabel";
            this.banditLabel.Size = new System.Drawing.Size(104, 28);
            this.banditLabel.TabIndex = 6;
            this.banditLabel.Text = "PowerShell";
            // 
            // pingLabel
            // 
            this.pingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pingLabel.AutoSize = true;
            this.pingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pingLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.pingLabel.ForeColor = System.Drawing.Color.White;
            this.pingLabel.Location = new System.Drawing.Point(53, 55);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(54, 28);
            this.pingLabel.TabIndex = 7;
            this.pingLabel.Text = "CMD";
            // 
            // PSThreads
            // 
            this.PSThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PSThreads.BaseColor = System.Drawing.Color.Black;
            this.PSThreads.BorderColor = System.Drawing.Color.DarkRed;
            this.PSThreads.ButtonColor = System.Drawing.Color.Red;
            this.PSThreads.ButtonForeColor = System.Drawing.Color.White;
            this.PSThreads.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.PSThreads.ForeColor = System.Drawing.Color.White;
            this.PSThreads.Location = new System.Drawing.Point(174, 19);
            this.PSThreads.Maximum = ((long)(5000));
            this.PSThreads.Minimum = ((long)(0));
            this.PSThreads.Name = "PSThreads";
            this.PSThreads.Size = new System.Drawing.Size(75, 30);
            this.PSThreads.TabIndex = 9;
            this.PSThreads.Text = "gunaNumeric1";
            this.PSThreads.Value = ((long)(0));
            // 
            // CMDThreads
            // 
            this.CMDThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CMDThreads.BaseColor = System.Drawing.Color.Black;
            this.CMDThreads.BorderColor = System.Drawing.Color.DarkRed;
            this.CMDThreads.ButtonColor = System.Drawing.Color.Red;
            this.CMDThreads.ButtonForeColor = System.Drawing.Color.White;
            this.CMDThreads.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.CMDThreads.ForeColor = System.Drawing.Color.White;
            this.CMDThreads.Location = new System.Drawing.Point(174, 55);
            this.CMDThreads.Maximum = ((long)(5000));
            this.CMDThreads.Minimum = ((long)(0));
            this.CMDThreads.Name = "CMDThreads";
            this.CMDThreads.Size = new System.Drawing.Size(75, 30);
            this.CMDThreads.TabIndex = 10;
            this.CMDThreads.Value = ((long)(0));
            // 
            // runButton
            // 
            this.runButton.BorderColor = System.Drawing.Color.DarkRed;
            this.runButton.CheckedState.Parent = this.runButton;
            this.runButton.CustomBorderColor = System.Drawing.Color.DarkRed;
            this.runButton.CustomImages.Parent = this.runButton;
            this.runButton.FillColor = System.Drawing.Color.Red;
            this.runButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.runButton.HoverState.FillColor = System.Drawing.Color.Brown;
            this.runButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.runButton.HoverState.Parent = this.runButton;
            this.runButton.Location = new System.Drawing.Point(81, 249);
            this.runButton.Name = "runButton";
            this.runButton.PressedColor = System.Drawing.Color.DarkRed;
            this.runButton.ShadowDecoration.Parent = this.runButton;
            this.runButton.Size = new System.Drawing.Size(91, 36);
            this.runButton.TabIndex = 13;
            this.runButton.Text = "ПОЕХАЛИ!";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // notifyLabel1
            // 
            this.notifyLabel1.AutoSize = true;
            this.notifyLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyLabel1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.notifyLabel1.ForeColor = System.Drawing.Color.White;
            this.notifyLabel1.Location = new System.Drawing.Point(331, 41);
            this.notifyLabel1.Name = "notifyLabel1";
            this.notifyLabel1.Size = new System.Drawing.Size(126, 25);
            this.notifyLabel1.TabIndex = 14;
            this.notifyLabel1.Text = " - Себя ДДоСь";
            // 
            // notifyLabel2
            // 
            this.notifyLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyLabel2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.notifyLabel2.ForeColor = System.Drawing.Color.White;
            this.notifyLabel2.Location = new System.Drawing.Point(352, 86);
            this.notifyLabel2.Name = "notifyLabel2";
            this.notifyLabel2.Size = new System.Drawing.Size(236, 86);
            this.notifyLabel2.TabIndex = 15;
            this.notifyLabel2.Text = " - ВНИМАНИЕ! \r\nПинг, если больше 500, убьёт ВАШ комп";
            // 
            // stopButton
            // 
            this.stopButton.BorderColor = System.Drawing.Color.DarkRed;
            this.stopButton.CheckedState.Parent = this.stopButton;
            this.stopButton.CustomBorderColor = System.Drawing.Color.DarkRed;
            this.stopButton.CustomImages.Parent = this.stopButton;
            this.stopButton.FillColor = System.Drawing.Color.Red;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.HoverState.BorderColor = System.Drawing.Color.DarkRed;
            this.stopButton.HoverState.FillColor = System.Drawing.Color.Brown;
            this.stopButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.stopButton.HoverState.Parent = this.stopButton;
            this.stopButton.Location = new System.Drawing.Point(255, 249);
            this.stopButton.Name = "stopButton";
            this.stopButton.PressedColor = System.Drawing.Color.DarkRed;
            this.stopButton.ShadowDecoration.Parent = this.stopButton;
            this.stopButton.Size = new System.Drawing.Size(91, 36);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "СТОП!";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreadsLabel.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.ThreadsLabel.ForeColor = System.Drawing.Color.Red;
            this.ThreadsLabel.Location = new System.Drawing.Point(2, 286);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(0, 20);
            this.ThreadsLabel.TabIndex = 18;
            // 
            // Packets
            // 
            this.Packets.AutoSize = true;
            this.Packets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Packets.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Packets.ForeColor = System.Drawing.Color.Red;
            this.Packets.Location = new System.Drawing.Point(353, 286);
            this.Packets.Name = "Packets";
            this.Packets.Size = new System.Drawing.Size(0, 20);
            this.Packets.TabIndex = 19;
            // 
            // ddTools
            // 
            this.ddTools.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddTools.BaseColor = System.Drawing.SystemColors.Control;
            this.ddTools.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.ddTools.CheckedOnColor = System.Drawing.Color.Red;
            this.ddTools.FillColor = System.Drawing.Color.White;
            this.ddTools.Location = new System.Drawing.Point(9, 24);
            this.ddTools.Name = "ddTools";
            this.ddTools.Size = new System.Drawing.Size(38, 20);
            this.ddTools.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(53, 19);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(108, 28);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "DDoS-TooL";
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DarkRed;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.ddThreads);
            this.xuiCustomGroupbox1.Controls.Add(this.ddTools);
            this.xuiCustomGroupbox1.Controls.Add(this.gunaLabel2);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(81, 178);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(265, 65);
            this.xuiCustomGroupbox1.TabIndex = 21;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Другое(самое эфф.)";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.Red;
            // 
            // ddThreads
            // 
            this.ddThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddThreads.BaseColor = System.Drawing.Color.Black;
            this.ddThreads.BorderColor = System.Drawing.Color.DarkRed;
            this.ddThreads.ButtonColor = System.Drawing.Color.Red;
            this.ddThreads.ButtonForeColor = System.Drawing.Color.White;
            this.ddThreads.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.ddThreads.ForeColor = System.Drawing.Color.White;
            this.ddThreads.Location = new System.Drawing.Point(174, 19);
            this.ddThreads.Maximum = ((long)(5000));
            this.ddThreads.Minimum = ((long)(0));
            this.ddThreads.Name = "ddThreads";
            this.ddThreads.Size = new System.Drawing.Size(75, 30);
            this.ddThreads.TabIndex = 11;
            this.ddThreads.Value = ((long)(0));
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.DarkRed;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.CMDThreads);
            this.xuiCustomGroupbox2.Controls.Add(this.PSPingSwitch);
            this.xuiCustomGroupbox2.Controls.Add(this.CMDPing);
            this.xuiCustomGroupbox2.Controls.Add(this.pingLabel);
            this.xuiCustomGroupbox2.Controls.Add(this.PSThreads);
            this.xuiCustomGroupbox2.Controls.Add(this.banditLabel);
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(81, 77);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(265, 95);
            this.xuiCustomGroupbox2.TabIndex = 22;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "PING";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.Red;
            // 
            // hardkor
            // 
            this.hardkor.Animated = true;
            this.hardkor.AutoSize = true;
            this.hardkor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hardkor.CheckedState.BorderRadius = 2;
            this.hardkor.CheckedState.BorderThickness = 0;
            this.hardkor.CheckedState.FillColor = System.Drawing.Color.Red;
            this.hardkor.FlatAppearance.BorderSize = 0;
            this.hardkor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hardkor.ForeColor = System.Drawing.Color.White;
            this.hardkor.Location = new System.Drawing.Point(357, 202);
            this.hardkor.Name = "hardkor";
            this.hardkor.Size = new System.Drawing.Size(75, 19);
            this.hardkor.TabIndex = 23;
            this.hardkor.Text = "ХаРдКОР";
            this.hardkor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hardkor.UncheckedState.BorderRadius = 2;
            this.hardkor.UncheckedState.BorderThickness = 0;
            this.hardkor.UncheckedState.FillColor = System.Drawing.Color.DarkRed;
            this.hardkor.UseVisualStyleBackColor = true;
            this.hardkor.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(588, 315);
            this.ControlBox = false;
            this.Controls.Add(this.hardkor);
            this.Controls.Add(this.xuiCustomGroupbox2);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.Packets);
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.notifyLabel2);
            this.Controls.Add(this.notifyLabel1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TargetTextBox);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(588, 259);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TDDoSer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBoxC;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeBoxC;
        private Guna.UI.WinForms.GunaLabel TextLabel;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBoxC;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2TextBox TargetTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGoogleSwitch PSPingSwitch;
        private Guna.UI.WinForms.GunaGoogleSwitch CMDPing;
        private Guna.UI.WinForms.GunaLabel banditLabel;
        private Guna.UI.WinForms.GunaLabel pingLabel;
        private Guna.UI.WinForms.GunaNumeric PSThreads;
        private Guna.UI.WinForms.GunaNumeric CMDThreads;
        private Guna.UI2.WinForms.Guna2Button runButton;
        private Guna.UI.WinForms.GunaLabel notifyLabel1;
        private Guna.UI.WinForms.GunaLabel notifyLabel2;
        private Guna.UI2.WinForms.Guna2Button stopButton;
        private Guna.UI.WinForms.GunaLabel ThreadsLabel;
        private Guna.UI.WinForms.GunaLabel Packets;
        private Guna.UI.WinForms.GunaGoogleSwitch ddTools;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private Guna.UI.WinForms.GunaNumeric ddThreads;
        private Guna.UI2.WinForms.Guna2CheckBox hardkor;
    }
}

