using System;
using MP3_player_project.CS;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MP3_player_project
{
    public partial class Form1 : Form
    {
        //переключатель режима воспроизведения
        public int mode;
        public Form1()
        {
            InitializeComponent();
            //инициализация библиотеки при запуске
            BassLike.InitBass(BassLike.HZ);
            Vars.Link = this;
            Vars.SetInputFormats();
            //стандартный режим - по умолчанию
            toolStripStatusLabel1.Text = "Standard mode";
            playlist.HorizontalScrollbar = true;
        }

        //остановка воспроизведения
        private void button2_Click(object sender, EventArgs e)
        {
            BassLike.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            label1.Text = "00:00:00";
        }

        //показ диалогового окна
        private void btnEj_Click(object sender, EventArgs e)
        {
            //открываем окно выбора файла
            openFileDialog1.ShowDialog();
        }

        //добавление в плейлист
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            playlist.Items.Clear();
            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                Vars.Files.Add(tmp[i]);
                TagModel TM = new TagModel(tmp[i]);
                playlist.Items.Add(TM.Artist + " - " + TM.Title);
            }

        }
        //открыть плейлист
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string temp = openFileDialog2.FileName;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(temp, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string[] tmp = (string[])binaryFormatter.Deserialize(fileStream);
            Vars.Files = tmp.ToList();
            for (int i = 0; i < Vars.Files.Count; i++)
            {
                TagModel TM = new TagModel(Vars.Files[i]);
                playlist.Items.Add(TM.Artist + " - " + TM.Title);
            }
        }

        //воспроизведение трека
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //если в плейлисте есть файлы и если трек выделен
            if ((playlist.Items.Count != 0) && (playlist.SelectedIndex != -1))
            {
                //создаем переменную текущего трека, записываем туда путь к треку
                string current = Vars.Files[playlist.SelectedIndex];
                Vars.trackNum = playlist.SelectedIndex;
                //воспроизводим трек (громкость указанная по умолчанию - 100)
                BassLike.Play(current, BassLike.Volume);
                //получаем позицию и время трека с помощью методов класса BassLike
                //переводим их в формат hh:mm:ss с помощью timespan
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                //максимальному значению слайдера воспроизведения присваиваем длительность трека
                slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                //текущее положение слайдера определяется этим методом
                slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                //включаем таймер
                timer1.Enabled = true;
            }
        }

        //таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
            if (mode == 2)
            {
                if (BassLike.AutoPlay())
                {
                    playlist.SelectedIndex = Vars.trackNum;
                    label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                    label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                    slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                    slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);

                }
                if (BassLike.EndPlaylist)
                {
                    button2_Click(this, new EventArgs());
                    playlist.SelectedIndex = Vars.trackNum = 0;
                    BassLike.EndPlaylist = false;
                }
            }
            if (mode == 1)
            {
                if (BassLike.RandPlay())
                {
                    playlist.SelectedIndex = Vars.trackNum;
                    label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                    label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                    slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                    slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                }
            }
            if (mode == 3)
            {
                if (BassLike.Repeat())
                {
                    playlist.SelectedIndex = Vars.trackNum;
                    label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                    label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                    slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                    slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                }
            }
        }

        //перемотка через слайдер
        private void slTime_Scroll(object sender, ScrollEventArgs e)
        {
            BassLike.SetPosOfScroll(BassLike.Stream, slTime.Value);
        }

        //установка громкости через слайдер
        private void slVol_Scroll(object sender, ScrollEventArgs e)
        {
            BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
            if (slVol.Value == 0)
            {
                VolumePic.Image = new Bitmap(Properties.Resources.icons8_выключить_звук_100);
            }
            if (slVol.Value > 0)
            {
                VolumePic.Image = new Bitmap(Properties.Resources.icons8_средняя_громкость_100);
            }
        }

        //пауза
        private void btnPause_Click(object sender, EventArgs e)
        {
            BassLike.Pause();
        }

        //переход к предыдущему треку
        private void btnPre_Click(object sender, EventArgs e)
        {
            string current;
            if (playlist.Items.Count != 0 && playlist.SelectedIndex != 0)
            {
                current = Vars.Files[playlist.SelectedIndex - 1];
                playlist.SelectedIndex = playlist.SelectedIndex - 1;
                Vars.trackNum = playlist.SelectedIndex;
            }
            else
            {
                current = Vars.Files[Vars.Files.Count - 1];
                playlist.SelectedIndex = Vars.trackNum = Vars.Files.Count - 1;
            }
            BassLike.Play(current, BassLike.Volume);
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
            slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
            slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
            timer1.Enabled = true;
        }

        //переход к следующему треку
        private void btnNext_Click(object sender, EventArgs e)
        {
            string current;
            if (playlist.Items.Count != 0 && playlist.SelectedIndex < Vars.Files.Count - 1)
            {
                current = Vars.Files[playlist.SelectedIndex + 1];
                playlist.SelectedIndex = playlist.SelectedIndex + 1;
                Vars.trackNum = playlist.SelectedIndex;
            }
            else
            {
                current = Vars.Files[0];
                playlist.SelectedIndex = Vars.trackNum = 0;
            }
            BassLike.Play(current, BassLike.Volume);
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
            slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
            slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
            timer1.Enabled = true;
        }

        //выделение выбранного трека серым цветом
        private void playlist_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Gray);
            e.DrawBackground();
            e.Graphics.DrawString(playlist.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        //закрыть программу
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //воспроизведение по порядку
        private void поПорядкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Сonsistently mode";
            mode = 2;
        }

        //справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа Мифтаховой Альбины\n\n" +
                "Плеер позволяет прослушивать музыку в различных форматах, " +
                "формировать и сохранять плейлисты, а также запускать " +
                "воспроизведение в трех режимах помимо стандартного: " +
                "в режиме повторения трека, в хронологическом " +
                "и в случайном порядке.\n\nПри написании приложения " +
                "была использована библиотека Bass.Net.dll.", "Справка");
        }

        //повтор трека
        private void button1_Click(object sender, EventArgs e)
        {
            mode = 3;
            toolStripStatusLabel1.Text = "Repeat";
        }

        //случайное воспроизведение
        private void рандомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
            toolStripStatusLabel1.Text = "Random mode";
        }

        //воспроизведение одного трека
        private void одинТрекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 4;
            toolStripStatusLabel1.Text = "Standard mode";
            btnPlay_Click(btnPlay, new EventArgs());
        }

        //сохранение плейлиста (в формате .dat)
        private void сохранитьПлейлистAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save s = new Save();
            s.Show();
        }

        //кнопка загрузки плейлиста
        private void btnAddPlayList_Click(object sender, EventArgs e)
        {
            playlist.Items.Clear();
            openFileDialog2.InitialDirectory = @"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\My Playlists";
            openFileDialog2.ShowDialog();
        }
    }
}
