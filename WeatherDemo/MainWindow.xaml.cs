using System;
using System.IO;
using System.ComponentModel;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Text;
using System.Windows;

namespace WeatherDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp("http://www.worldweather.cn/zh/json/194_zh.xml");
            webRequest.Method = "Get";
            webRequest.Timeout = 2000;

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));

            String content = reader.ReadToEnd();
            reader.Close();
            stream.Close();
            MessageBox.Show(content);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp("http://www.weather.com.cn/data/cityinfo/101010100.html");
            webRequest.Method = "Get";
            webRequest.Timeout = 2000;

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));

            String content = reader.ReadToEnd();
            reader.Close();
            stream.Close();

            MessageBox.Show(content);

        }

    }
}
