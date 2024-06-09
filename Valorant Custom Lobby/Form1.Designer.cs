namespace Valorant_Custom_Lobby
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002521 File Offset: 0x00000721
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002540 File Offset: 0x00000740
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Valorant_Custom_Lobby.Form1));
			this.label1 = new global::System.Windows.Forms.Label();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.bunifuDragControl3 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.timer = new global::System.Windows.Forms.Timer(this.components);
			this.button1 = new global::System.Windows.Forms.Button();
			this.WallpaperInput = new global::Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.button2 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(776, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(16, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "X";
			this.label1.Click += new global::System.EventHandler(this.label1_Click_1);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pictureBox1;
			this.bunifuDragControl2.Vertical = true;
			this.pictureBox1.Image = global::Valorant_Custom_Lobby.Properties.Resources.Valorant_Lobby_Font;
			this.pictureBox1.Location = new global::System.Drawing.Point(48, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(692, 381);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = this.pictureBox2;
			this.bunifuDragControl3.Vertical = true;
			this.pictureBox2.Image = global::Valorant_Custom_Lobby.Properties.Resources.Valorant_Credits_Font;
			this.pictureBox2.Location = new global::System.Drawing.Point(48, 67);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(692, 381);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.timer.Interval = 3000;
			this.timer.Tick += new global::System.EventHandler(this.timer_Tick);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(265, 262);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(105, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "Change Menu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.WallpaperInput.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.WallpaperInput.Font = new global::System.Drawing.Font("Century Gothic", 9.75f);
			this.WallpaperInput.ForeColor = global::System.Drawing.Color.White;
			this.WallpaperInput.HintForeColor = global::System.Drawing.Color.Empty;
			this.WallpaperInput.HintText = "";
			this.WallpaperInput.isPassword = false;
			this.WallpaperInput.LineFocusedColor = global::System.Drawing.Color.FromArgb(255, 70, 84);
			this.WallpaperInput.LineIdleColor = global::System.Drawing.Color.Gray;
			this.WallpaperInput.LineMouseHoverColor = global::System.Drawing.Color.FromArgb(255, 70, 84);
			this.WallpaperInput.LineThickness = 3;
			this.WallpaperInput.Location = new global::System.Drawing.Point(214, 208);
			this.WallpaperInput.Margin = new global::System.Windows.Forms.Padding(4);
			this.WallpaperInput.Name = "WallpaperInput";
			this.WallpaperInput.Size = new global::System.Drawing.Size(379, 33);
			this.WallpaperInput.TabIndex = 5;
			this.WallpaperInput.Text = "Enter Wallpaper Path...";
			this.WallpaperInput.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.WallpaperInput.Enter += new global::System.EventHandler(this.WallpaperInput_Enter);
			this.WallpaperInput.Leave += new global::System.EventHandler(this.WallpaperInput_Leave);
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(413, 262);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(105, 32);
			this.button2.TabIndex = 6;
			this.button2.Text = "Launch Valorant";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(43, 43, 43);
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.WallpaperInput);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.pictureBox2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000005 RID: 5
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000006 RID: 6
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000008 RID: 8
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000009 RID: 9
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Timer timer;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000C RID: 12
		private global::Bunifu.Framework.UI.BunifuMaterialTextbox WallpaperInput;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button button2;
	}
}
