namespace car
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
            this.components = new System.ComponentModel.Container();
            this.Model = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Vendor = new System.Windows.Forms.Label();
            this.Engine = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomRadioButton3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2CustomRadioButton2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2CustomRadioButton1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.BackColor = System.Drawing.Color.Transparent;
            this.Model.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Model.ForeColor = System.Drawing.Color.ForestGreen;
            this.Model.Location = new System.Drawing.Point(132, 0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(76, 30);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Vendor
            // 
            this.Vendor.AutoSize = true;
            this.Vendor.BackColor = System.Drawing.Color.Transparent;
            this.Vendor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vendor.ForeColor = System.Drawing.Color.ForestGreen;
            this.Vendor.Location = new System.Drawing.Point(0, 0);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(84, 30);
            this.Vendor.TabIndex = 3;
            this.Vendor.Text = "Vendor";
            // 
            // Engine
            // 
            this.Engine.AutoSize = true;
            this.Engine.BackColor = System.Drawing.Color.Transparent;
            this.Engine.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Engine.ForeColor = System.Drawing.Color.ForestGreen;
            this.Engine.Location = new System.Drawing.Point(128, 41);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(80, 30);
            this.Engine.TabIndex = 4;
            this.Engine.Text = "Engine";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BackColor = System.Drawing.Color.Transparent;
            this.Year.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Year.ForeColor = System.Drawing.Color.ForestGreen;
            this.Year.Location = new System.Drawing.Point(9, 41);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(54, 30);
            this.Year.TabIndex = 5;
            this.Year.Text = "Year";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.guna2CustomRadioButton3);
            this.panel1.Controls.Add(this.guna2CustomRadioButton2);
            this.panel1.Controls.Add(this.guna2CustomRadioButton1);
            this.panel1.Controls.Add(this.Engine);
            this.panel1.Controls.Add(this.Vendor);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Location = new System.Drawing.Point(162, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 91);
            this.panel1.TabIndex = 6;
            // 
            // guna2CustomRadioButton3
            // 
            this.guna2CustomRadioButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CustomRadioButton3.CausesValidation = false;
            this.guna2CustomRadioButton3.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton3.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton3.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton3.CheckedState.InnerColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton3.Location = new System.Drawing.Point(108, 74);
            this.guna2CustomRadioButton3.Margin = new System.Windows.Forms.Padding(1);
            this.guna2CustomRadioButton3.Name = "guna2CustomRadioButton3";
            this.guna2CustomRadioButton3.Padding = new System.Windows.Forms.Padding(20, 50, 40, 30);
            this.guna2CustomRadioButton3.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.guna2CustomRadioButton3.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.guna2CustomRadioButton3.ShadowDecoration.Depth = 40;
            this.guna2CustomRadioButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CustomRadioButton3.Size = new System.Drawing.Size(13, 10);
            this.guna2CustomRadioButton3.TabIndex = 8;
            this.guna2CustomRadioButton3.Tag = "2";
            this.guna2CustomRadioButton3.Text = "guna2CustomRadioButton3";
            this.guna2CustomRadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton3.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton3.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton3.Click += new System.EventHandler(this.guna2CustomRadioButton1_Click);
            // 
            // guna2CustomRadioButton2
            // 
            this.guna2CustomRadioButton2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CustomRadioButton2.CausesValidation = false;
            this.guna2CustomRadioButton2.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton2.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton2.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton2.CheckedState.InnerColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton2.Location = new System.Drawing.Point(93, 74);
            this.guna2CustomRadioButton2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2CustomRadioButton2.Name = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.Padding = new System.Windows.Forms.Padding(20, 50, 40, 30);
            this.guna2CustomRadioButton2.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.guna2CustomRadioButton2.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.guna2CustomRadioButton2.ShadowDecoration.Depth = 40;
            this.guna2CustomRadioButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CustomRadioButton2.Size = new System.Drawing.Size(13, 10);
            this.guna2CustomRadioButton2.TabIndex = 7;
            this.guna2CustomRadioButton2.Tag = "1";
            this.guna2CustomRadioButton2.Text = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton2.Click += new System.EventHandler(this.guna2CustomRadioButton1_Click);
            // 
            // guna2CustomRadioButton1
            // 
            this.guna2CustomRadioButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2CustomRadioButton1.CausesValidation = false;
            this.guna2CustomRadioButton1.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton1.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton1.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton1.CheckedState.InnerColor = System.Drawing.Color.Silver;
            this.guna2CustomRadioButton1.Location = new System.Drawing.Point(78, 74);
            this.guna2CustomRadioButton1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2CustomRadioButton1.Name = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.Padding = new System.Windows.Forms.Padding(20, 50, 40, 30);
            this.guna2CustomRadioButton1.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.guna2CustomRadioButton1.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.guna2CustomRadioButton1.ShadowDecoration.Depth = 40;
            this.guna2CustomRadioButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CustomRadioButton1.Size = new System.Drawing.Size(13, 10);
            this.guna2CustomRadioButton1.TabIndex = 6;
            this.guna2CustomRadioButton1.Tag = "0";
            this.guna2CustomRadioButton1.Text = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton1.Click += new System.EventHandler(this.guna2CustomRadioButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label Model;
        private PictureBox pictureBox1;
        private Label Vendor;
        private Label Engine;
        private Label Year;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton2;
    }
}