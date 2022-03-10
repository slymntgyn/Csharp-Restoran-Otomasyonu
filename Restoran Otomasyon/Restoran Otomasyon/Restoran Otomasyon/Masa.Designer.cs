
namespace Restoran_Otomasyon
{
    partial class Masa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masa));
            this.ToolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Ürün = new System.Windows.Forms.ToolStripSplitButton();
            this.ürünleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.şifreyiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ToolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.Ürün,
            this.toolStripButton1});
            this.ToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(800, 25);
            this.ToolStripMenu.Stretch = true;
            this.ToolStripMenu.TabIndex = 0;
            this.ToolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton2.Text = "WAHSED";
            // 
            // Ürün
            // 
            this.Ürün.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Ürün.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünleriGösterToolStripMenuItem,
            this.ürünEkleToolStripMenuItem});
            this.Ürün.Image = ((System.Drawing.Image)(resources.GetObject("Ürün.Image")));
            this.Ürün.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ürün.Name = "Ürün";
            this.Ürün.Size = new System.Drawing.Size(49, 22);
            this.Ürün.Text = "Ürün";
            this.Ürün.ToolTipText = "Ürün";
            // 
            // ürünleriGösterToolStripMenuItem
            // 
            this.ürünleriGösterToolStripMenuItem.Name = "ürünleriGösterToolStripMenuItem";
            this.ürünleriGösterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ürünleriGösterToolStripMenuItem.Text = "Ürünleri Göster";
            this.ürünleriGösterToolStripMenuItem.Click += new System.EventHandler(this.ürünleriGösterToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreyiDeğiştirToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton1.Text = "Kullanıcı";
            // 
            // şifreyiDeğiştirToolStripMenuItem
            // 
            this.şifreyiDeğiştirToolStripMenuItem.Name = "şifreyiDeğiştirToolStripMenuItem";
            this.şifreyiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.şifreyiDeğiştirToolStripMenuItem.Text = "Şifreyi Değiştir";
            this.şifreyiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreyiDeğiştirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ımageList1;
            this.listView1.Location = new System.Drawing.Point(0, 19);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 401);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ToolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Masa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa";
            this.Load += new System.EventHandler(this.Masa_Load_1);
            this.ToolStripMenu.ResumeLayout(false);
            this.ToolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSplitButton Ürün;
        private System.Windows.Forms.ToolStripMenuItem ürünleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem şifreyiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.ListView listView1;
    }
}