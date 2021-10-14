
namespace Windows_XP_Simulator
{
    partial class os
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.apptext = new System.Windows.Forms.Label();
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.maxim = new Guna.UI2.WinForms.Guna2Button();
            this.minim = new Guna.UI2.WinForms.Guna2Button();
            this.loadingform = new Guna.UI2.WinForms.Guna2PictureBox();
            this.shutdownosimage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pfpic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.signin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownosimage)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Red;
            this.guna2Panel1.Controls.Add(this.minim);
            this.guna2Panel1.Controls.Add(this.maxim);
            this.guna2Panel1.Controls.Add(this.exit);
            this.guna2Panel1.Controls.Add(this.apptext);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(955, 37);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // apptext
            // 
            this.apptext.AutoSize = true;
            this.apptext.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptext.Location = new System.Drawing.Point(439, 10);
            this.apptext.Name = "apptext";
            this.apptext.Size = new System.Drawing.Size(71, 17);
            this.apptext.TabIndex = 0;
            this.apptext.Text = "APPTITLE";
            // 
            // exit
            // 
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit.DisabledState.Parent = this.exit;
            this.exit.FillColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Location = new System.Drawing.Point(899, 7);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(39, 20);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // maxim
            // 
            this.maxim.CheckedState.Parent = this.maxim;
            this.maxim.CustomImages.Parent = this.maxim;
            this.maxim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maxim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maxim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maxim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maxim.DisabledState.Parent = this.maxim;
            this.maxim.FillColor = System.Drawing.Color.Red;
            this.maxim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maxim.ForeColor = System.Drawing.Color.White;
            this.maxim.HoverState.Parent = this.maxim;
            this.maxim.Location = new System.Drawing.Point(854, 7);
            this.maxim.Name = "maxim";
            this.maxim.ShadowDecoration.Parent = this.maxim;
            this.maxim.Size = new System.Drawing.Size(39, 20);
            this.maxim.TabIndex = 4;
            this.maxim.Text = "O";
            // 
            // minim
            // 
            this.minim.CheckedState.Parent = this.minim;
            this.minim.CustomImages.Parent = this.minim;
            this.minim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minim.DisabledState.Parent = this.minim;
            this.minim.FillColor = System.Drawing.Color.Red;
            this.minim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minim.ForeColor = System.Drawing.Color.White;
            this.minim.HoverState.Parent = this.minim;
            this.minim.Location = new System.Drawing.Point(809, 7);
            this.minim.Name = "minim";
            this.minim.ShadowDecoration.Parent = this.minim;
            this.minim.Size = new System.Drawing.Size(39, 20);
            this.minim.TabIndex = 5;
            this.minim.Text = "-";
            // 
            // loadingform
            // 
            this.loadingform.FillColor = System.Drawing.Color.Black;
            this.loadingform.ImageRotate = 0F;
            this.loadingform.Location = new System.Drawing.Point(0, 29);
            this.loadingform.Name = "loadingform";
            this.loadingform.ShadowDecoration.Parent = this.loadingform;
            this.loadingform.Size = new System.Drawing.Size(952, 584);
            this.loadingform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingform.TabIndex = 3;
            this.loadingform.TabStop = false;
            // 
            // shutdownosimage
            // 
            this.shutdownosimage.BackColor = System.Drawing.Color.Black;
            this.shutdownosimage.FillColor = System.Drawing.Color.Black;
            this.shutdownosimage.ImageRotate = 0F;
            this.shutdownosimage.Location = new System.Drawing.Point(12, 565);
            this.shutdownosimage.Name = "shutdownosimage";
            this.shutdownosimage.ShadowDecoration.Parent = this.shutdownosimage;
            this.shutdownosimage.Size = new System.Drawing.Size(28, 22);
            this.shutdownosimage.TabIndex = 5;
            this.shutdownosimage.TabStop = false;
            this.shutdownosimage.Click += new System.EventHandler(this.shutdownosimage_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.signin);
            this.guna2Panel2.Controls.Add(this.guna2TextBox1);
            this.guna2Panel2.Controls.Add(this.pfpic);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(68)))), ((int)(((byte)(167)))));
            this.guna2Panel2.Location = new System.Drawing.Point(482, 255);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(366, 91);
            this.guna2Panel2.TabIndex = 6;
            // 
            // pfpic
            // 
            this.pfpic.ImageRotate = 0F;
            this.pfpic.Location = new System.Drawing.Point(14, 12);
            this.pfpic.Name = "pfpic";
            this.pfpic.ShadowDecoration.Parent = this.pfpic;
            this.pfpic.Size = new System.Drawing.Size(70, 67);
            this.pfpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pfpic.TabIndex = 0;
            this.pfpic.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(90, 58);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(211, 30);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.Transparent;
            this.signin.ImageRotate = 0F;
            this.signin.Location = new System.Drawing.Point(318, 58);
            this.signin.Name = "signin";
            this.signin.ShadowDecoration.Parent = this.signin;
            this.signin.Size = new System.Drawing.Size(34, 30);
            this.signin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signin.TabIndex = 2;
            this.signin.TabStop = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "WINXP  BY MAZK#9154";
            // 
            // os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 615);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.shutdownosimage);
            this.Controls.Add(this.loadingform);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "os";
            this.Text = "os";
            this.Load += new System.EventHandler(this.os_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownosimage)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label apptext;
        private Guna.UI2.WinForms.Guna2Button minim;
        private Guna.UI2.WinForms.Guna2Button maxim;
        private Guna.UI2.WinForms.Guna2Button exit;
        private Guna.UI2.WinForms.Guna2PictureBox loadingform;
        private Guna.UI2.WinForms.Guna2PictureBox shutdownosimage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pfpic;
        private Guna.UI2.WinForms.Guna2PictureBox signin;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
    }
}