﻿namespace ZonyLrcTools.UI
{
    partial class UI_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_SetWorkDirectory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_DownLoadLyric = new System.Windows.Forms.ToolStripButton();
            this.button_DownLoadAlbumImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button_FeedBack = new System.Windows.Forms.ToolStripButton();
            this.button_DonateAuthor = new System.Windows.Forms.ToolStripButton();
            this.button_AboutSoftware = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.button_PluginsMrg = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox_MusicInfo = new System.Windows.Forms.GroupBox();
            this.label_MusicTitle = new System.Windows.Forms.Label();
            this.textBox_MusicTitle = new System.Windows.Forms.TextBox();
            this.label_Aritst = new System.Windows.Forms.Label();
            this.textBox_Aritst = new System.Windows.Forms.TextBox();
            this.label_Album = new System.Windows.Forms.Label();
            this.textBox_Album = new System.Windows.Forms.TextBox();
            this.label_AlbumImage = new System.Windows.Forms.Label();
            this.pictureBox_AlbumImage = new System.Windows.Forms.PictureBox();
            this.label_Lryic = new System.Windows.Forms.Label();
            this.textBox_Lryic = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel_StateText = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress_DownLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1.SuspendLayout();
            this.groupBox_MusicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlbumImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_SetWorkDirectory,
            this.toolStripSeparator1,
            this.button_DownLoadLyric,
            this.button_DownLoadAlbumImage,
            this.toolStripSeparator2,
            this.button_FeedBack,
            this.button_DonateAuthor,
            this.button_AboutSoftware,
            this.toolStripSeparator3,
            this.button_PluginsMrg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1007, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip_TopMenus";
            // 
            // button_SetWorkDirectory
            // 
            this.button_SetWorkDirectory.Image = ((System.Drawing.Image)(resources.GetObject("button_SetWorkDirectory.Image")));
            this.button_SetWorkDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_SetWorkDirectory.Name = "button_SetWorkDirectory";
            this.button_SetWorkDirectory.Size = new System.Drawing.Size(76, 22);
            this.button_SetWorkDirectory.Text = "工作目录";
            this.button_SetWorkDirectory.Click += new System.EventHandler(this.button_SetWorkDirectory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button_DownLoadLyric
            // 
            this.button_DownLoadLyric.Image = ((System.Drawing.Image)(resources.GetObject("button_DownLoadLyric.Image")));
            this.button_DownLoadLyric.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_DownLoadLyric.Name = "button_DownLoadLyric";
            this.button_DownLoadLyric.Size = new System.Drawing.Size(76, 22);
            this.button_DownLoadLyric.Text = "下载歌词";
            // 
            // button_DownLoadAlbumImage
            // 
            this.button_DownLoadAlbumImage.Image = ((System.Drawing.Image)(resources.GetObject("button_DownLoadAlbumImage.Image")));
            this.button_DownLoadAlbumImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_DownLoadAlbumImage.Name = "button_DownLoadAlbumImage";
            this.button_DownLoadAlbumImage.Size = new System.Drawing.Size(100, 22);
            this.button_DownLoadAlbumImage.Text = "下载专辑图像";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // button_FeedBack
            // 
            this.button_FeedBack.Image = ((System.Drawing.Image)(resources.GetObject("button_FeedBack.Image")));
            this.button_FeedBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_FeedBack.Name = "button_FeedBack";
            this.button_FeedBack.Size = new System.Drawing.Size(76, 22);
            this.button_FeedBack.Text = "反馈信息";
            // 
            // button_DonateAuthor
            // 
            this.button_DonateAuthor.Image = ((System.Drawing.Image)(resources.GetObject("button_DonateAuthor.Image")));
            this.button_DonateAuthor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_DonateAuthor.Name = "button_DonateAuthor";
            this.button_DonateAuthor.Size = new System.Drawing.Size(76, 22);
            this.button_DonateAuthor.Text = "捐赠作者";
            // 
            // button_AboutSoftware
            // 
            this.button_AboutSoftware.Image = ((System.Drawing.Image)(resources.GetObject("button_AboutSoftware.Image")));
            this.button_AboutSoftware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_AboutSoftware.Name = "button_AboutSoftware";
            this.button_AboutSoftware.Size = new System.Drawing.Size(52, 22);
            this.button_AboutSoftware.Text = "关于";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // button_PluginsMrg
            // 
            this.button_PluginsMrg.Image = ((System.Drawing.Image)(resources.GetObject("button_PluginsMrg.Image")));
            this.button_PluginsMrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_PluginsMrg.Name = "button_PluginsMrg";
            this.button_PluginsMrg.Size = new System.Drawing.Size(76, 22);
            this.button_PluginsMrg.Text = "插件管理";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 496);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox_MusicInfo
            // 
            this.groupBox_MusicInfo.Controls.Add(this.textBox_Lryic);
            this.groupBox_MusicInfo.Controls.Add(this.label_Lryic);
            this.groupBox_MusicInfo.Controls.Add(this.pictureBox_AlbumImage);
            this.groupBox_MusicInfo.Controls.Add(this.label_AlbumImage);
            this.groupBox_MusicInfo.Controls.Add(this.textBox_Album);
            this.groupBox_MusicInfo.Controls.Add(this.label_Album);
            this.groupBox_MusicInfo.Controls.Add(this.textBox_Aritst);
            this.groupBox_MusicInfo.Controls.Add(this.label_Aritst);
            this.groupBox_MusicInfo.Controls.Add(this.textBox_MusicTitle);
            this.groupBox_MusicInfo.Controls.Add(this.label_MusicTitle);
            this.groupBox_MusicInfo.Location = new System.Drawing.Point(764, 21);
            this.groupBox_MusicInfo.Name = "groupBox_MusicInfo";
            this.groupBox_MusicInfo.Size = new System.Drawing.Size(230, 503);
            this.groupBox_MusicInfo.TabIndex = 2;
            this.groupBox_MusicInfo.TabStop = false;
            this.groupBox_MusicInfo.Text = "歌曲信息";
            // 
            // label_MusicTitle
            // 
            this.label_MusicTitle.AutoSize = true;
            this.label_MusicTitle.Location = new System.Drawing.Point(6, 17);
            this.label_MusicTitle.Name = "label_MusicTitle";
            this.label_MusicTitle.Size = new System.Drawing.Size(35, 12);
            this.label_MusicTitle.TabIndex = 0;
            this.label_MusicTitle.Text = "标题:";
            // 
            // textBox_MusicTitle
            // 
            this.textBox_MusicTitle.Location = new System.Drawing.Point(8, 32);
            this.textBox_MusicTitle.Name = "textBox_MusicTitle";
            this.textBox_MusicTitle.Size = new System.Drawing.Size(213, 21);
            this.textBox_MusicTitle.TabIndex = 1;
            // 
            // label_Aritst
            // 
            this.label_Aritst.AutoSize = true;
            this.label_Aritst.Location = new System.Drawing.Point(6, 56);
            this.label_Aritst.Name = "label_Aritst";
            this.label_Aritst.Size = new System.Drawing.Size(77, 12);
            this.label_Aritst.TabIndex = 0;
            this.label_Aritst.Text = "艺术家/歌手:";
            // 
            // textBox_Aritst
            // 
            this.textBox_Aritst.Location = new System.Drawing.Point(8, 71);
            this.textBox_Aritst.Name = "textBox_Aritst";
            this.textBox_Aritst.Size = new System.Drawing.Size(213, 21);
            this.textBox_Aritst.TabIndex = 1;
            // 
            // label_Album
            // 
            this.label_Album.AutoSize = true;
            this.label_Album.Location = new System.Drawing.Point(6, 95);
            this.label_Album.Name = "label_Album";
            this.label_Album.Size = new System.Drawing.Size(77, 12);
            this.label_Album.TabIndex = 0;
            this.label_Album.Text = "专辑/唱片集:";
            // 
            // textBox_Album
            // 
            this.textBox_Album.Location = new System.Drawing.Point(8, 110);
            this.textBox_Album.Name = "textBox_Album";
            this.textBox_Album.Size = new System.Drawing.Size(213, 21);
            this.textBox_Album.TabIndex = 1;
            // 
            // label_AlbumImage
            // 
            this.label_AlbumImage.AutoSize = true;
            this.label_AlbumImage.Location = new System.Drawing.Point(6, 134);
            this.label_AlbumImage.Name = "label_AlbumImage";
            this.label_AlbumImage.Size = new System.Drawing.Size(59, 12);
            this.label_AlbumImage.TabIndex = 0;
            this.label_AlbumImage.Text = "专辑图片:";
            // 
            // pictureBox_AlbumImage
            // 
            this.pictureBox_AlbumImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_AlbumImage.Location = new System.Drawing.Point(14, 149);
            this.pictureBox_AlbumImage.Name = "pictureBox_AlbumImage";
            this.pictureBox_AlbumImage.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_AlbumImage.TabIndex = 2;
            this.pictureBox_AlbumImage.TabStop = false;
            // 
            // label_Lryic
            // 
            this.label_Lryic.AutoSize = true;
            this.label_Lryic.Location = new System.Drawing.Point(6, 352);
            this.label_Lryic.Name = "label_Lryic";
            this.label_Lryic.Size = new System.Drawing.Size(35, 12);
            this.label_Lryic.TabIndex = 3;
            this.label_Lryic.Text = "歌词:";
            // 
            // textBox_Lryic
            // 
            this.textBox_Lryic.Location = new System.Drawing.Point(8, 367);
            this.textBox_Lryic.MaxLength = 0;
            this.textBox_Lryic.Multiline = true;
            this.textBox_Lryic.Name = "textBox_Lryic";
            this.textBox_Lryic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Lryic.Size = new System.Drawing.Size(213, 130);
            this.textBox_Lryic.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_StateText,
            this.progress_DownLoad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel_StateText
            // 
            this.statusLabel_StateText.AutoSize = false;
            this.statusLabel_StateText.Name = "statusLabel_StateText";
            this.statusLabel_StateText.Size = new System.Drawing.Size(762, 17);
            this.statusLabel_StateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progress_DownLoad
            // 
            this.progress_DownLoad.Name = "progress_DownLoad";
            this.progress_DownLoad.Size = new System.Drawing.Size(222, 16);
            // 
            // UI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_MusicInfo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZonyLrcTools";
            this.Load += new System.EventHandler(this.UI_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_MusicInfo.ResumeLayout(false);
            this.groupBox_MusicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlbumImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_SetWorkDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button_DownLoadLyric;
        private System.Windows.Forms.ToolStripButton button_DownLoadAlbumImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton button_FeedBack;
        private System.Windows.Forms.ToolStripButton button_DonateAuthor;
        private System.Windows.Forms.ToolStripButton button_AboutSoftware;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton button_PluginsMrg;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox_MusicInfo;
        private System.Windows.Forms.Label label_MusicTitle;
        private System.Windows.Forms.TextBox textBox_MusicTitle;
        private System.Windows.Forms.TextBox textBox_Aritst;
        private System.Windows.Forms.Label label_Aritst;
        private System.Windows.Forms.TextBox textBox_Album;
        private System.Windows.Forms.Label label_Album;
        private System.Windows.Forms.Label label_AlbumImage;
        private System.Windows.Forms.PictureBox pictureBox_AlbumImage;
        private System.Windows.Forms.Label label_Lryic;
        private System.Windows.Forms.TextBox textBox_Lryic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_StateText;
        private System.Windows.Forms.ToolStripProgressBar progress_DownLoad;
    }
}