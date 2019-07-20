using MP3_player_project.CS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_player_project
{
    public partial class Save : Form
    {
        public static string temp;
        public Save()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            var PlayList = Vars.Files.ToArray();
            temp = @"C:\Users\Альбина\Desktop\Play\" + text + ".dat";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(temp, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, PlayList);
                fs.Close();
            }      
            Close();            
        }
    }
}
