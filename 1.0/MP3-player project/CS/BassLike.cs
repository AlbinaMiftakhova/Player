using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;

namespace MP3_player_project.CS
{
    public static class BassLike
    {
        //частота дискретизации
        public static int HZ = 44100;
        //состояние инициализации библиотеки
        public static bool InitDefaultDevice;
        //канал (звуковой поток)
        public static int Stream;
        //громкость
        public static int Volume = 100;
        //плагины
        private static readonly List<int> BassPluginsHandles = new List<int>();
        //воспроизведение остановлено пользователем
        public static bool isStopped = true;
        //плейлист доиграл до конца
        public static bool EndPlaylist;
        //инициализация bass.dll
        public static bool InitBass(int hz)
        {
            if (!InitDefaultDevice)
            {
                //если библиотека не инициализирована, то с помощью bass init инициализируем
                //-1 - звуковая карта по умолчанию
                //hz - частота дискретизации
                //Bass device default - устройство по умолчанию
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                //если библиотека инициализирована, грузим плагины
                //они позволяют воспроизводить музыку разных форматов
                if (InitDefaultDevice)
                {
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bass_aac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bass_ac3.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bass_ape.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bass_mpc.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bass_tta.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bassalac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bassflac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\bassopus.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\basswma.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(@"C:\Users\Альбина\source\repos\MP3-player project\MP3-player project\bin\x64\Release\plugins\basswv.dll"));
                    //счетчик незагруженных плагинов
                    int ErrorCount = 0;
                    for (int i = 0; i < BassPluginsHandles.Count; i++)
                    {
                        if (BassPluginsHandles[i] == 0)
                        {
                            ErrorCount++;
                        }
                    }
                    if (ErrorCount != 0)
                    {
                        MessageBox.Show(ErrorCount + " plugins were not loaded",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    ErrorCount = 0;
                }
            }
            return InitDefaultDevice;
        }

        //запуск воспроизведения
        public static void Play(string filename, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                //чтобы не начало одновременно играть два трека
                Stop();
                //с помощью метода InitBass(HZ) проверяем инициализацию библиотеки
                //если она инициализирована, загружаем трек
                //filename - какой трек будет воспроизводиться
                //0 - воспроизводится с начала
                //0 - длительность (до конца, т.е. оригинальный размер)
                if (InitBass(HZ))
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    //если файл открыт удачно, то Stream не равен нулю
                    if (Stream != 0)
                    {
                        //устанавливаем громкость трека
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        //запускаем воспроизведение
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else Bass.BASS_ChannelPlay(Stream, false);
            isStopped = false;
        }

        //остановка воспроизведения
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStopped = true;
        }
        //пауза
        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(Stream);
            }
        }
        //получение длительности в секундах
        public static int GetTimeOfStream(int stream)
        {
            //получаем длительность трека, который сейчас в потоке и воспроизводится
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            //перевод в секунды
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }

        //получение текущей позиции в секундах
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        //перемотка
        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        //установка громкости
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }

        public static bool AutoPlay()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStopped))
            {
                if (Vars.Files.Count > Vars.trackNum + 1)
                {
                    Play(Vars.Files[++Vars.trackNum], Volume);
                    EndPlaylist = false;
                    return true;
                }
                else EndPlaylist = true;
            }            
            return false;
        }

        //рандомное воспроизведение
        public static bool RandPlay()
        {
            Random tmp = new Random();
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStopped))
            {
                    int k = tmp.Next(0, Vars.Files.Count);
                    Vars.trackNum = k;
                    Play(Vars.Files[Vars.trackNum], Volume);
            }
            return true;
        }
        //повторение трека
        public static bool Repeat()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStopped))
            {
                Play(Vars.Files[Vars.trackNum], Volume);
            }
            return true;
        }
    }
}
