using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace patternPlayer
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class CustomPlayer : UserControl
    {
        public CustomPlayer()
        {
            Unosquare.FFME.MediaElement.FFmpegDirectory = "C:\\ffmpeg\\";
            InitializeComponent();
            // InitializeMediaEvents();
            //InitializeInputEvents();
            //InitializeMainWindow();

            //UpdateWindowTitle();
           
        }
        public void loadSource(String src)
        {
            Media_Copy.Source = new Uri("file:///C:/ffmpegclientview/Gate_sample.avi");

        }
    }
}
