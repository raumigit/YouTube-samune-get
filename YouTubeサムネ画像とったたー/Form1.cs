using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace YouTubeサムネ画像とったたー
{
    public partial class Form1 : Form
    {
        
        string imgURL;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (end ==true)
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start(imgURL);
            }
            else
            {
                loglist.Items.Add("一度も変換されていません");
                return;
            }
            
        }
        bool end = false;
        //button
        public void Button1_Click(object sender, EventArgs e)
        {
            string inurl = textBox_input.Text;
            string convurl;
            string maxresdefault = "https://img.youtube.com/vi/@/maxresdefault.jpg";
            string sddfault="https://img.youtube.com/vi/@/sddefault.jpg";

            //string hqdefault = "https://img.youtube.com/vi/@/hqdefault.jpg";
            //string mqdefault = "https://img.youtube.com/vi/@/mqdefault.jpg";
            //string defaultpic = "https://img.youtube.com/vi/@/default.jpg";
            //
            //string samune1 = "https://img.youtube.com/vi/@/1.jpg";
            //string samune2 = "https://img.youtube.com/vi/@/2.jpg";
            //string samune3 = "https://img.youtube.com/vi/@/3.jpg";

            string[] arraysamune =new string[] {"https://img.youtube.com/vi/@/maxresdefault.jpg",
            "https://img.youtube.com/vi/@/sddefault.jpg",
            "https://img.youtube.com/vi/@/hqdefault.jpg","https://img.youtube.com/vi/@/mqdefault.jpg","https://img.youtube.com/vi/@/default.jpg",
            "https://img.youtube.com/vi/@/1.jpg","https://img.youtube.com/vi/@/2.jpg","https://img.youtube.com/vi/@/3.jpg" };


            

            //抽出
            Task.Delay(9200);
            

            //test https://youtu.be/uBn1frMI_6Q


            bool Urlcheck = true;

            if (textBox_input.Text == "")
            {
               loglist.Items.Add("Warn:空");
                Urlcheck = false;
                return;
            }

            if (textBox_input.Text.StartsWith("https://youtu.be")) { }
            else
            {
                loglist.Items.Add("URLが一致しません");
                Urlcheck = false;
            }
            if (Urlcheck==false)
            {
                return;
            }


            
            try
            {
                convurl = inurl.Substring(17, 11);
                loglist.TopIndex = loglist.Items.Add (convurl);
            
            
                

                if (radioButtonMaxresdefault.Checked == true)//サイズ判定
                {
                    //convimage https://img.youtube.com/vi/uBn1frMI_6Q/maxresdefault.jpg
                    imgURL = maxresdefault.Replace("@",convurl);
                }
                else if (radioButtonSdddefault.Checked==true)
                {
                    imgURL = sddfault.Replace("@", convurl);
                }
                

                if (checkBoxテキスト.Checked == true)
                {
                    if (radioButtonMaxresdefault.Checked == true)
                    {
                        File.AppendAllText(@"URL.txt", imgURL+"\n");
                    }
                    else if (radioButtonSdddefault.Checked == true)
                    {
                        File.AppendAllText(@"URL.txt", imgURL+"\n");
                    }
                }

                

                if (checkBoxクリップボード.Checked==true)
                {
                    if (radioButtonMaxresdefault.Checked==true)
                    {
                        Clipboard.SetData(DataFormats.Text, imgURL);
                    }
                    else if(radioButtonSdddefault.Checked==true)
                    {
                        Clipboard.SetData(DataFormats.Text, imgURL);
                    }
                }

                if (checkBoxAll.Checked == true) { 
                    if (Directory.Exists(@"全サムネイル") !=true)
                    {
                        Directory.CreateDirectory("全サムネイル");
                    }
                   
                
                    for (int i = 0; i < arraysamune.Length; i++)
                    {
                        arraysamune[i] = arraysamune[i].Replace("@", convurl);

                       
                        File.AppendAllText(@"全サムネイル/URL.txt", arraysamune[i] + "\n");
                    }
                    File.AppendAllText(@"全サムネイル/URL.txt", "_____________________________________________________\n");
                }
                
                end = true;



            }
            catch (Exception)
            {
                loglist.Items.Add("ERROR:変換に失敗");

            }
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            textBox_input.SelectAll();
        }

        private void SelectedYTcode(object sender, EventArgs e)
        {
            //Clipboard.SetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String discrimination;
                discrimination = loglist.SelectedItem.ToString();

                if (discrimination.IndexOfAny(new Char[]{ '>',':','.'}) ==-1)
                {
                    Clipboard.SetDataObject(loglist.SelectedItem);
                }
                
            }
            catch (Exception)
            {

                loglist.Items.Add("ERROR:選択したリストはNULLです");
            }
            
        }

        
    }
}
