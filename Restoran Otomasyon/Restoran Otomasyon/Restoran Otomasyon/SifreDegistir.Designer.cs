
namespace Restoran_Otomasyon
{
    partial class SifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SifreTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EskiTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tekrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.BackButon = new Guna.UI2.WinForms.Guna2Button();
            this.ChangeButon = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(85, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tekrari:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(74, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "Yeni Şifre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(79, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(23, 32, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "Eski Şifre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(446, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 57);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.SifreTextBox.Location = new System.Drawing.Point(224, 144);
            this.SifreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.PasswordChar = '\0';
            this.SifreTextBox.PlaceholderText = "Yeni Şifrenizi Giriniz";
            this.SifreTextBox.SelectedText = "";
            this.SifreTextBox.ShadowDecoration.Parent = this.SifreTextBox;
            this.SifreTextBox.Size = new System.Drawing.Size(188, 32);
            this.SifreTextBox.TabIndex = 34;
            // 
            // EskiTextBox
            // 
            this.EskiTextBox.Animated = true;
            this.EskiTextBox.AutoRoundedCorners = true;
            this.EskiTextBox.BorderRadius = 15;
            this.EskiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EskiTextBox.DefaultText = "";
            this.EskiTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EskiTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EskiTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EskiTextBox.DisabledState.Parent = this.EskiTextBox;
            this.EskiTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EskiTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EskiTextBox.FocusedState.Parent = this.EskiTextBox;
            this.EskiTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.EskiTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EskiTextBox.HoverState.Parent = this.EskiTextBox;
            this.EskiTextBox.Location = new System.Drawing.Point(224, 86);
            this.EskiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EskiTextBox.Name = "EskiTextBox";
            this.EskiTextBox.PasswordChar = '\0';
            this.EskiTextBox.PlaceholderText = "Eski Şifreniniz Giriniz...";
            this.EskiTextBox.SelectedText = "";
            this.EskiTextBox.ShadowDecoration.Parent = this.EskiTextBox;
            this.EskiTextBox.Size = new System.Drawing.Size(188, 32);
            this.EskiTextBox.TabIndex = 33;
            // 
            // tekrar
            // 
            this.tekrar.Animated = true;
            this.tekrar.AutoRoundedCorners = true;
            this.tekrar.BorderRadius = 15;
            this.tekrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tekrar.DefaultText = "";
            this.tekrar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tekrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tekrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tekrar.DisabledState.Parent = this.tekrar;
            this.tekrar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tekrar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tekrar.FocusedState.Parent = this.tekrar;
            this.tekrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tekrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tekrar.HoverState.Parent = this.tekrar;
            this.tekrar.Location = new System.Drawing.Point(224, 218);
            this.tekrar.Margin = new System.Windows.Forms.Padding(2);
            this.tekrar.Name = "tekrar";
            this.tekrar.PasswordChar = '\0';
            this.tekrar.PlaceholderText = "Yeni Şifrenizi Tekrar Giriniz";
            this.tekrar.SelectedText = "";
            this.tekrar.ShadowDecoration.Parent = this.tekrar;
            this.tekrar.Size = new System.Drawing.Size(188, 32);
            this.tekrar.TabIndex = 35;
            // 
            // BackButon
            // 
            this.BackButon.AutoRoundedCorners = true;
            this.BackButon.BackColor = System.Drawing.Color.Transparent;
            this.BackButon.BorderColor = System.Drawing.Color.Transparent;
            this.BackButon.BorderRadius = 22;
            this.BackButon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BackButon.CheckedState.FillColor = System.Drawing.Color.Olive;
            this.BackButon.CheckedState.Parent = this.BackButon;
            this.BackButon.CustomImages.Parent = this.BackButon;
            this.BackButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButon.DisabledState.Parent = this.BackButon;
            this.BackButon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.BackButon.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.BackButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.BackButon.HoverState.Parent = this.BackButon;
            this.BackButon.Image = ((System.Drawing.Image)(resources.GetObject("BackButon.Image")));
            this.BackButon.Location = new System.Drawing.Point(63, 292);
            this.BackButon.Name = "BackButon";
            this.BackButon.ShadowDecoration.Parent = this.BackButon;
            this.BackButon.Size = new System.Drawing.Size(87, 47);
            this.BackButon.TabIndex = 36;
            this.BackButon.Text = "Geri";
            this.BackButon.UseTransparentBackground = true;
            this.BackButon.Click += new System.EventHandler(this.BackButon_Click);
            // 
            // ChangeButon
            // 
            this.ChangeButon.AutoRoundedCorners = true;
            this.ChangeButon.BackColor = System.Drawing.Color.Transparent;
            this.ChangeButon.BorderColor = System.Drawing.Color.Transparent;
            this.ChangeButon.BorderRadius = 22;
            this.ChangeButon.CheckedState.FillColor = System.Drawing.Color.Olive;
            this.ChangeButon.CheckedState.Parent = this.ChangeButon;
            this.ChangeButon.CustomImages.Parent = this.ChangeButon;
            this.ChangeButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangeButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangeButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangeButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangeButon.DisabledState.Parent = this.ChangeButon;
            this.ChangeButon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.ChangeButon.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ChangeButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            this.ChangeButon.HoverState.Parent = this.ChangeButon;
            this.ChangeButon.Image = ((System.Drawing.Image)(resources.GetObject("ChangeButon.Image")));
            this.ChangeButon.Location = new System.Drawing.Point(325, 292);
            this.ChangeButon.Name = "ChangeButon";
            this.ChangeButon.ShadowDecoration.Parent = this.ChangeButon;
            this.ChangeButon.Size = new System.Drawing.Size(109, 47);
            this.ChangeButon.TabIndex = 37;
            this.ChangeButon.Text = "Değiştir";
            this.ChangeButon.UseTransparentBackground = true;
            this.ChangeButon.Click += new System.EventHandler(this.ChangeButon_Click);
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(506, 374);
            this.Controls.Add(this.ChangeButon);
            this.Controls.Add(this.BackButon);
            this.Controls.Add(this.tekrar);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.EskiTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox SifreTextBox;
        private Guna.UI2.WinForms.Guna2TextBox EskiTextBox;
        private Guna.UI2.WinForms.Guna2TextBox tekrar;
        private Guna.UI2.WinForms.Guna2Button BackButon;
        private Guna.UI2.WinForms.Guna2Button ChangeButon;
    }
}