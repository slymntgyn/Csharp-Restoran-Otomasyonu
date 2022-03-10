
namespace Restoran_Otomasyon
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.ExitPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SifreTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TCTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SoyAdiTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdiTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EkleButon = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.siltext = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitPicture
            // 
            this.ExitPicture.BackColor = System.Drawing.Color.Transparent;
            this.ExitPicture.FillColor = System.Drawing.Color.Transparent;
            this.ExitPicture.Image = ((System.Drawing.Image)(resources.GetObject("ExitPicture.Image")));
            this.ExitPicture.ImageRotate = 0F;
            this.ExitPicture.Location = new System.Drawing.Point(743, 1);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitPicture.ShadowDecoration.Parent = this.ExitPicture;
            this.ExitPicture.Size = new System.Drawing.Size(55, 49);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPicture.TabIndex = 11;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Personel TC\'si :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(453, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyadı:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(122, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(476, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Animated = true;
            this.SifreTextBox.AutoRoundedCorners = true;
            this.SifreTextBox.BorderRadius = 15;
            this.SifreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SifreTextBox.DefaultText = "";
            this.SifreTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SifreTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SifreTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SifreTextBox.DisabledState.Parent = this.SifreTextBox;
            this.SifreTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SifreTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SifreTextBox.FocusedState.Parent = this.SifreTextBox;
            this.SifreTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SifreTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SifreTextBox.HoverState.Parent = this.SifreTextBox;
            this.SifreTextBox.Location = new System.Drawing.Point(564, 35);
            this.SifreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.PasswordChar = '\0';
            this.SifreTextBox.PlaceholderText = "Personel Şifresini Giriniz";
            this.SifreTextBox.SelectedText = "";
            this.SifreTextBox.ShadowDecoration.Parent = this.SifreTextBox;
            this.SifreTextBox.Size = new System.Drawing.Size(188, 32);
            this.SifreTextBox.TabIndex = 27;
            // 
            // TCTextBox
            // 
            this.TCTextBox.Animated = true;
            this.TCTextBox.AutoRoundedCorners = true;
            this.TCTextBox.BorderRadius = 15;
            this.TCTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCTextBox.DefaultText = "";
            this.TCTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TCTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TCTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCTextBox.DisabledState.Parent = this.TCTextBox;
            this.TCTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCTextBox.FocusedState.Parent = this.TCTextBox;
            this.TCTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TCTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCTextBox.HoverState.Parent = this.TCTextBox;
            this.TCTextBox.Location = new System.Drawing.Point(182, 35);
            this.TCTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TCTextBox.Name = "TCTextBox";
            this.TCTextBox.PasswordChar = '\0';
            this.TCTextBox.PlaceholderText = "Personel TC\'si :";
            this.TCTextBox.SelectedText = "";
            this.TCTextBox.ShadowDecoration.Parent = this.TCTextBox;
            this.TCTextBox.Size = new System.Drawing.Size(188, 32);
            this.TCTextBox.TabIndex = 26;
            // 
            // SoyAdiTextBox
            // 
            this.SoyAdiTextBox.Animated = true;
            this.SoyAdiTextBox.AutoRoundedCorners = true;
            this.SoyAdiTextBox.BorderRadius = 15;
            this.SoyAdiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoyAdiTextBox.DefaultText = "";
            this.SoyAdiTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SoyAdiTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SoyAdiTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoyAdiTextBox.DisabledState.Parent = this.SoyAdiTextBox;
            this.SoyAdiTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoyAdiTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoyAdiTextBox.FocusedState.Parent = this.SoyAdiTextBox;
            this.SoyAdiTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SoyAdiTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoyAdiTextBox.HoverState.Parent = this.SoyAdiTextBox;
            this.SoyAdiTextBox.Location = new System.Drawing.Point(564, 98);
            this.SoyAdiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SoyAdiTextBox.Name = "SoyAdiTextBox";
            this.SoyAdiTextBox.PasswordChar = '\0';
            this.SoyAdiTextBox.PlaceholderText = "Personel Soyadı";
            this.SoyAdiTextBox.SelectedText = "";
            this.SoyAdiTextBox.ShadowDecoration.Parent = this.SoyAdiTextBox;
            this.SoyAdiTextBox.Size = new System.Drawing.Size(188, 32);
            this.SoyAdiTextBox.TabIndex = 29;
            this.SoyAdiTextBox.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // AdiTextBox
            // 
            this.AdiTextBox.Animated = true;
            this.AdiTextBox.AutoRoundedCorners = true;
            this.AdiTextBox.BorderRadius = 15;
            this.AdiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdiTextBox.DefaultText = "";
            this.AdiTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdiTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdiTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdiTextBox.DisabledState.Parent = this.AdiTextBox;
            this.AdiTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdiTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdiTextBox.FocusedState.Parent = this.AdiTextBox;
            this.AdiTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AdiTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdiTextBox.HoverState.Parent = this.AdiTextBox;
            this.AdiTextBox.Location = new System.Drawing.Point(182, 98);
            this.AdiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AdiTextBox.Name = "AdiTextBox";
            this.AdiTextBox.PasswordChar = '\0';
            this.AdiTextBox.PlaceholderText = "Personel Adı";
            this.AdiTextBox.SelectedText = "";
            this.AdiTextBox.ShadowDecoration.Parent = this.AdiTextBox;
            this.AdiTextBox.Size = new System.Drawing.Size(188, 32);
            this.AdiTextBox.TabIndex = 28;
            // 
            // EkleButon
            // 
            this.EkleButon.AutoRoundedCorners = true;
            this.EkleButon.BackColor = System.Drawing.Color.Transparent;
            this.EkleButon.BorderColor = System.Drawing.Color.Transparent;
            this.EkleButon.BorderRadius = 22;
            this.EkleButon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.EkleButon.CheckedState.FillColor = System.Drawing.Color.Olive;
            this.EkleButon.CheckedState.Parent = this.EkleButon;
            this.EkleButon.CustomImages.Parent = this.EkleButon;
            this.EkleButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EkleButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EkleButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EkleButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EkleButon.DisabledState.Parent = this.EkleButon;
            this.EkleButon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.EkleButon.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.EkleButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.EkleButon.HoverState.Parent = this.EkleButon;
            this.EkleButon.Image = ((System.Drawing.Image)(resources.GetObject("EkleButon.Image")));
            this.EkleButon.Location = new System.Drawing.Point(339, 161);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.ShadowDecoration.Parent = this.EkleButon;
            this.EkleButon.Size = new System.Drawing.Size(96, 47);
            this.EkleButon.TabIndex = 30;
            this.EkleButon.Text = "Ekle";
            this.EkleButon.UseTransparentBackground = true;
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdiTextBox);
            this.groupBox1.Controls.Add(this.EkleButon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SoyAdiTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SifreTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TCTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 214);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.guna2Button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.siltext);
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 167);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel çıkar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.Olive;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(546, 44);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(96, 47);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "Çıkar";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(20, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Personel TC\'si :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siltext
            // 
            this.siltext.Animated = true;
            this.siltext.AutoRoundedCorners = true;
            this.siltext.BorderRadius = 15;
            this.siltext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siltext.DefaultText = "";
            this.siltext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siltext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siltext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siltext.DisabledState.Parent = this.siltext;
            this.siltext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siltext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siltext.FocusedState.Parent = this.siltext;
            this.siltext.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.siltext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siltext.HoverState.Parent = this.siltext;
            this.siltext.Location = new System.Drawing.Point(220, 59);
            this.siltext.Margin = new System.Windows.Forms.Padding(2);
            this.siltext.Name = "siltext";
            this.siltext.PasswordChar = '\0';
            this.siltext.PlaceholderText = "Personel TC\'si :";
            this.siltext.SelectedText = "";
            this.siltext.ShadowDecoration.Parent = this.siltext;
            this.siltext.Size = new System.Drawing.Size(188, 32);
            this.siltext.TabIndex = 26;
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox ExitPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox SifreTextBox;
        private Guna.UI2.WinForms.Guna2TextBox TCTextBox;
        private Guna.UI2.WinForms.Guna2TextBox SoyAdiTextBox;
        private Guna.UI2.WinForms.Guna2TextBox AdiTextBox;
        private Guna.UI2.WinForms.Guna2Button EkleButon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox siltext;
    }
}