using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MP3_player_project.CS
{
    public static class Vars
    {
        public static Form1 Link;
        //номер трека
        public static int trackNum;
        //список полных имен файлов (треков)
        public static List<string> Files = new List<string>();
        //получаем имя файла
        public static string GetFileName(string file)
        {
            //разбиваем путь к файлу на массив 
            //и возвращаем последний элемент (т.е. его имя)
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];            
        }
        //фильтры (для того, чтобы скрывать файлы неподходящего формата)
        public static void SetInputFormats()
        {
            Link.openFileDialog1.Filter = 
                "Музыкальные файлы|*.mp3; *.aac; *.ac3; *.ape; " +
                "*.mpc; *.tta; *.alac; *.flac; *.opus; " +
                "*.wma; *.wv;" + "|Все файлы|*.*";
        }
    }    
}
