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
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.MinimizeBoxC);
            this.TopPanel.Controls.Add(this.MaximizeBoxC);
            this.TopPanel.Controls.Add(this.TextLabel);
            this.TopPanel.Controls.Add(this.CloseBoxC);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(800, 30);
            this.TopPanel.TabIndex = 0;
            // 
            // MinimizeBoxC
            // 
            this.MinimizeBoxC.Animated = true;
            this.MinimizeBoxC.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBoxC.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBoxC.FillColor = System.Drawing.Color.White;
            this.MinimizeBoxC.HoverState.Parent = this.MinimizeBoxC;
            this.MinimizeBoxC.IconColor = System.Drawing.Color.Black;
            this.MinimizeBoxC.Location = new System.Drawing.Point(665, 0);
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
            this.MaximizeBoxC.FillColor = System.Drawing.Color.White;
            this.MaximizeBoxC.HoverState.Parent = this.MaximizeBoxC;
            this.MaximizeBoxC.IconColor = System.Drawing.Color.Black;
            this.MaximizeBoxC.Location = new System.Drawing.Point(710, 0);
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
            this.CloseBoxC.FillColor = System.Drawing.Color.White;
            this.CloseBoxC.HoverState.Parent = this.CloseBoxC;
            this.CloseBoxC.IconColor = System.Drawing.Color.Black;
            this.CloseBoxC.Location = new System.Drawing.Point(755, 0);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TDDoSer";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBoxC;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeBoxC;
        private Guna.UI.WinForms.GunaLabel TextLabel;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBoxC;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
    }
}

