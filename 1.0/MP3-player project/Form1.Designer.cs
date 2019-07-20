using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MP3_player_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПорядкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рандомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одинТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПлейлистAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slVol = new MB.Controls.ColorSlider();
            this.slTime = new MB.Controls.ColorSlider();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddPlayList = new System.Windows.Forms.Button();
            this.VolumePic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnEj = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumePic)).BeginInit();
            this.SuspendLayout();
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.SystemColors.Window;
            this.playlist.Cursor = System.Windows.Forms.Cursors.Default;
            this.playlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.playlist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlist.ForeColor = System.Drawing.Color.Black;
            this.playlist.FormattingEnabled = true;
            this.playlist.HorizontalScrollbar = true;
            this.playlist.ItemHeight = 29;
            this.playlist.Location = new System.Drawing.Point(16, 56);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(555, 323);
            this.playlist.TabIndex = 0;
            this.playlist.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.playlist_DrawItem);
            this.playlist.DoubleClick += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(279, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Create new playlist";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимToolStripMenuItem,
            this.сохранитьПлейлистAsToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(583, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поПорядкуToolStripMenuItem,
            this.рандомToolStripMenuItem,
            this.одинТрекToolStripMenuItem});
            this.режимToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.режимToolStripMenuItem.Text = "Mode";
            // 
            // поПорядкуToolStripMenuItem
            // 
            this.поПорядкуToolStripMenuItem.Name = "поПорядкуToolStripMenuItem";
            this.поПорядкуToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.поПорядкуToolStripMenuItem.Text = "Consistently";
            this.поПорядкуToolStripMenuItem.Click += new System.EventHandler(this.поПорядкуToolStripMenuItem_Click);
            // 
            // рандомToolStripMenuItem
            // 
            this.рандомToolStripMenuItem.Name = "рандомToolStripMenuItem";
            this.рандомToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.рандомToolStripMenuItem.Text = "Random";
            this.рандомToolStripMenuItem.Click += new System.EventHandler(this.рандомToolStripMenuItem_Click);
            // 
            // одинТрекToolStripMenuItem
            // 
            this.одинТрекToolStripMenuItem.Name = "одинТрекToolStripMenuItem";
            this.одинТрекToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.одинТрекToolStripMenuItem.Text = "Standard";
            this.одинТрекToolStripMenuItem.Click += new System.EventHandler(this.одинТрекToolStripMenuItem_Click);
            // 
            // сохранитьПлейлистAsToolStripMenuItem
            // 
            this.сохранитьПлейлистAsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранитьПлейлистAsToolStripMenuItem.Name = "сохранитьПлейлистAsToolStripMenuItem";
            this.сохранитьПлейлистAsToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.сохранитьПлейлистAsToolStripMenuItem.Text = "Save playlist";
            this.сохранитьПлейлистAsToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПлейлистAsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.справкаToolStripMenuItem.Text = "About";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(583, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // slVol
            // 
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.BarInnerColor = System.Drawing.Color.White;
            this.slVol.BarOuterColor = System.Drawing.Color.White;
            this.slVol.BarPenColor = System.Drawing.Color.Black;
            this.slVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.DrawFocusRectangle = false;
            this.slVol.DrawSemitransparentThumb = false;
            this.slVol.ElapsedInnerColor = System.Drawing.Color.Black;
            this.slVol.ElapsedOuterColor = System.Drawing.Color.Black;
            this.slVol.LargeChange = ((uint)(5u));
            this.slVol.Location = new System.Drawing.Point(392, 424);
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(179, 30);
            this.slVol.SmallChange = ((uint)(1u));
            this.slVol.TabIndex = 6;
            this.slVol.Text = "colorSlider2";
            this.slVol.ThumbInnerColor = System.Drawing.Color.White;
            this.slVol.ThumbPenColor = System.Drawing.Color.Black;
            this.slVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.Value = 100;
            this.slVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slVol_Scroll);
            // 
            // slTime
            // 
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.BarInnerColor = System.Drawing.Color.White;
            this.slTime.BarOuterColor = System.Drawing.Color.White;
            this.slTime.BarPenColor = System.Drawing.Color.Black;
            this.slTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.DrawFocusRectangle = false;
            this.slTime.DrawSemitransparentThumb = false;
            this.slTime.ElapsedInnerColor = System.Drawing.Color.Black;
            this.slTime.ElapsedOuterColor = System.Drawing.Color.Black;
            this.slTime.LargeChange = ((uint)(5u));
            this.slTime.Location = new System.Drawing.Point(11, 424);
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(348, 30);
            this.slTime.SmallChange = ((uint)(1u));
            this.slTime.TabIndex = 5;
            this.slTime.Text = "colorSlider1";
            this.slTime.ThumbInnerColor = System.Drawing.Color.Black;
            this.slTime.ThumbOuterColor = System.Drawing.Color.Black;
            this.slTime.ThumbPenColor = System.Drawing.Color.Black;
            this.slTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.Value = 0;
            this.slTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slTime_Scroll);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Title = "Open playlist";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // btnAddPlayList
            // 
            this.btnAddPlayList.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_добавить_альбом_filled_100;
            this.btnAddPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPlayList.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPlayList.FlatAppearance.BorderSize = 0;
            this.btnAddPlayList.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPlayList.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlayList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPlayList.Location = new System.Drawing.Point(524, 473);
            this.btnAddPlayList.Name = "btnAddPlayList";
            this.btnAddPlayList.Size = new System.Drawing.Size(47, 44);
            this.btnAddPlayList.TabIndex = 16;
            this.btnAddPlayList.UseVisualStyleBackColor = true;
            this.btnAddPlayList.Click += new System.EventHandler(this.btnAddPlayList_Click);
            // 
            // VolumePic
            // 
            this.VolumePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumePic.Image = global::MP3_player_project.Properties.Resources.icons8_средняя_громкость_100;
            this.VolumePic.Location = new System.Drawing.Point(392, 385);
            this.VolumePic.Name = "VolumePic";
            this.VolumePic.Size = new System.Drawing.Size(39, 39);
            this.VolumePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VolumePic.TabIndex = 15;
            this.VolumePic.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_повторение_filled_100;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(392, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_быстрая_перемотка_вперед_filled_100;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(312, 474);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 44);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_перемотка_назад_filled_100;
            this.btnPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPre.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPre.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPre.Location = new System.Drawing.Point(245, 474);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(47, 44);
            this.btnPre.TabIndex = 11;
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_пауза_filled_100;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPause.Location = new System.Drawing.Point(11, 474);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(47, 44);
            this.btnPause.TabIndex = 9;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnEj
            // 
            this.btnEj.BackColor = System.Drawing.Color.White;
            this.btnEj.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_папка_с_музыкой_filled_100;
            this.btnEj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEj.FlatAppearance.BorderSize = 0;
            this.btnEj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEj.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEj.ForeColor = System.Drawing.Color.White;
            this.btnEj.Location = new System.Drawing.Point(458, 470);
            this.btnEj.Name = "btnEj";
            this.btnEj.Size = new System.Drawing.Size(51, 48);
            this.btnEj.TabIndex = 4;
            this.btnEj.UseVisualStyleBackColor = false;
            this.btnEj.Click += new System.EventHandler(this.btnEj_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_стоп_filled_100;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(111, 474);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(47, 44);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::MP3_player_project.Properties.Resources.icons8_воспроизведение_filled_100;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(63, 474);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(42, 43);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 558);
            this.Controls.Add(this.btnAddPlayList);
            this.Controls.Add(this.VolumePic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slVol);
            this.Controls.Add(this.slTime);
            this.Controls.Add(this.btnEj);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEj;
        private MB.Controls.ColorSlider slVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private MB.Controls.ColorSlider slTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПорядкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рандомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox VolumePic;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem одинТрекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПлейлистAsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPlayList;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        public System.Windows.Forms.ListBox playlist;
    }
}

