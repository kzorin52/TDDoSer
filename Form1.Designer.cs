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
            this.banditSwitch = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.pingSwitch = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.banditLabel = new Guna.UI.WinForms.GunaLabel();
            this.pingLabel = new Guna.UI.WinForms.GunaLabel();
            this.banditThreads = new Guna.UI.WinForms.GunaNumeric();
            this.pingThreads = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.runButton = new Guna.UI2.WinForms.Guna2Button();
            this.notifyLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.notifyLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.notifyLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.stopButton = new Guna.UI2.WinForms.Guna2Button();
            this.ThreadsLabel = new Guna.UI.WinForms.GunaLabel();
            this.TopPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.TargetTextBox.Location = new System.Drawing.Point(107, 36);
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
            this.gunaLabel1.Location = new System.Drawing.Point(22, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 28);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Цель:";
            // 
            // banditSwitch
            // 
            this.banditSwitch.BaseColor = System.Drawing.SystemColors.Control;
            this.banditSwitch.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.banditSwitch.CheckedOnColor = System.Drawing.Color.Red;
            this.banditSwitch.FillColor = System.Drawing.Color.White;
            this.banditSwitch.Location = new System.Drawing.Point(7, 19);
            this.banditSwitch.Name = "banditSwitch";
            this.banditSwitch.Size = new System.Drawing.Size(38, 20);
            this.banditSwitch.TabIndex = 4;
            // 
            // pingSwitch
            // 
            this.pingSwitch.BaseColor = System.Drawing.SystemColors.Control;
            this.pingSwitch.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.pingSwitch.CheckedOnColor = System.Drawing.Color.Red;
            this.pingSwitch.FillColor = System.Drawing.Color.White;
            this.pingSwitch.Location = new System.Drawing.Point(7, 59);
            this.pingSwitch.Name = "pingSwitch";
            this.pingSwitch.Size = new System.Drawing.Size(38, 20);
            this.pingSwitch.TabIndex = 5;
            // 
            // banditLabel
            // 
            this.banditLabel.AutoSize = true;
            this.banditLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banditLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.banditLabel.ForeColor = System.Drawing.Color.White;
            this.banditLabel.Location = new System.Drawing.Point(51, 11);
            this.banditLabel.Name = "banditLabel";
            this.banditLabel.Size = new System.Drawing.Size(65, 28);
            this.banditLabel.TabIndex = 6;
            this.banditLabel.Text = "Bandit";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pingLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.pingLabel.ForeColor = System.Drawing.Color.White;
            this.pingLabel.Location = new System.Drawing.Point(51, 51);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(49, 28);
            this.pingLabel.TabIndex = 7;
            this.pingLabel.Text = "Ping";
            // 
            // banditThreads
            // 
            this.banditThreads.BaseColor = System.Drawing.Color.Black;
            this.banditThreads.BorderColor = System.Drawing.Color.DarkRed;
            this.banditThreads.ButtonColor = System.Drawing.Color.Red;
            this.banditThreads.ButtonForeColor = System.Drawing.Color.White;
            this.banditThreads.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.banditThreads.ForeColor = System.Drawing.Color.White;
            this.banditThreads.Location = new System.Drawing.Point(122, 11);
            this.banditThreads.Maximum = ((long)(5000));
            this.banditThreads.Minimum = ((long)(0));
            this.banditThreads.Name = "banditThreads";
            this.banditThreads.Size = new System.Drawing.Size(75, 30);
            this.banditThreads.TabIndex = 9;
            this.banditThreads.Text = "gunaNumeric1";
            this.banditThreads.Value = ((long)(0));
            // 
            // pingThreads
            // 
            this.pingThreads.BaseColor = System.Drawing.Color.Black;
            this.pingThreads.BorderColor = System.Drawing.Color.DarkRed;
            this.pingThreads.ButtonColor = System.Drawing.Color.Red;
            this.pingThreads.ButtonForeColor = System.Drawing.Color.White;
            this.pingThreads.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.pingThreads.ForeColor = System.Drawing.Color.White;
            this.pingThreads.Location = new System.Drawing.Point(122, 51);
            this.pingThreads.Maximum = ((long)(5000));
            this.pingThreads.Minimum = ((long)(0));
            this.pingThreads.Name = "pingThreads";
            this.pingThreads.Size = new System.Drawing.Size(75, 30);
            this.pingThreads.TabIndex = 10;
            this.pingThreads.Value = ((long)(0));
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(12, 113);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(89, 28);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "Потоков:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pingThreads);
            this.guna2Panel1.Controls.Add(this.banditSwitch);
            this.guna2Panel1.Controls.Add(this.pingSwitch);
            this.guna2Panel1.Controls.Add(this.banditThreads);
            this.guna2Panel1.Controls.Add(this.banditLabel);
            this.guna2Panel1.Controls.Add(this.pingLabel);
            this.guna2Panel1.Location = new System.Drawing.Point(107, 77);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 95);
            this.guna2Panel1.TabIndex = 12;
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
            this.runButton.Location = new System.Drawing.Point(107, 186);
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
            this.notifyLabel2.Location = new System.Drawing.Point(331, 136);
            this.notifyLabel2.Name = "notifyLabel2";
            this.notifyLabel2.Size = new System.Drawing.Size(250, 86);
            this.notifyLabel2.TabIndex = 15;
            this.notifyLabel2.Text = " - ВНИМАНИЕ! \r\nПинг, если больше 100, убьёт ВАШ комп";
            // 
            // notifyLabel3
            // 
            this.notifyLabel3.AutoSize = true;
            this.notifyLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyLabel3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.notifyLabel3.ForeColor = System.Drawing.Color.White;
            this.notifyLabel3.Location = new System.Drawing.Point(331, 90);
            this.notifyLabel3.Name = "notifyLabel3";
            this.notifyLabel3.Size = new System.Drawing.Size(230, 25);
            this.notifyLabel3.TabIndex = 16;
            this.notifyLabel3.Text = " - Специальная библиотека";
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
            this.stopButton.Location = new System.Drawing.Point(213, 186);
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
            this.ThreadsLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.ThreadsLabel.ForeColor = System.Drawing.Color.White;
            this.ThreadsLabel.Location = new System.Drawing.Point(63, 225);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(89, 28);
            this.ThreadsLabel.TabIndex = 18;
            this.ThreadsLabel.Text = "Потоков:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(588, 259);
            this.ControlBox = false;
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.notifyLabel3);
            this.Controls.Add(this.notifyLabel2);
            this.Controls.Add(this.notifyLabel1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaLabel4);
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
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
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
        private Guna.UI.WinForms.GunaGoogleSwitch banditSwitch;
        private Guna.UI.WinForms.GunaGoogleSwitch pingSwitch;
        private Guna.UI.WinForms.GunaLabel banditLabel;
        private Guna.UI.WinForms.GunaLabel pingLabel;
        private Guna.UI.WinForms.GunaNumeric banditThreads;
        private Guna.UI.WinForms.GunaNumeric pingThreads;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button runButton;
        private Guna.UI.WinForms.GunaLabel notifyLabel1;
        private Guna.UI.WinForms.GunaLabel notifyLabel2;
        private Guna.UI.WinForms.GunaLabel notifyLabel3;
        private Guna.UI2.WinForms.Guna2Button stopButton;
        private Guna.UI.WinForms.GunaLabel ThreadsLabel;
    }
}

