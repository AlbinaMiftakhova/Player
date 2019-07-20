using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;

namespace MP3_player_project.CS
{
    public class TagModel
    {
        //данные о треке
        public int Bitrate;
        public int Freq; //частота дискретизации
        public string Channels;
        public string Artist;
        public string Album;
        public string Title;
        public string Year;
        Dictionary<int, string> ChannelsDict = new Dictionary<int, string>()
        {
            {0, "Null" },
            {1, "Mono" },
            {2, "Stereo" }
        };
        public TagModel(string file)
        {
            //создаем переменную для хранения тегов
            TAG_INFO tag_info = new TAG_INFO();
            //вытаскиваем тег из файла
            tag_info = BassTags.BASS_TAG_GetFromFile(file);
            Bitrate = tag_info.bitrate;
            Freq = tag_info.channelinfo.freq;
            Channels = ChannelsDict[tag_info.channelinfo.chans];
            Artist = tag_info.artist;
            Album = tag_info.album;
            //если нет заголовка песни, присваиваем название трека
            if (tag_info.title == "")
            {
                Title = Vars.GetFileName(file);
            }
            else Title = tag_info.title;
            Year = tag_info.year;
        }
    }
}
