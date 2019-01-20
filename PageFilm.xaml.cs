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

namespace ProjektZalWPF
{
    public partial class PageFilm : Page
    {
        public PageFilm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            imgPZPN.Visibility = Visibility.Hidden;
            imgPZPN.Height = 0;
            filmPromocyjny.Visibility = Visibility.Visible;
            filmPromocyjny.MinHeight = 250;
            filmPromocyjny.Play();
            InitializePropertyValues();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            filmPromocyjny.Stop();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            filmPromocyjny.Pause();
        }

        private void sldrSound_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            filmPromocyjny.Volume = (double)sldrSound.Value;
        }


        void InitializePropertyValues()
        {
            filmPromocyjny.Volume = (double)sldrSound.Value;
        }

        private void sldrTimeline_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int SlideVal = (int)sldrTimeline.Value;
            TimeSpan ts = new TimeSpan(SlideVal);
            filmPromocyjny.Position = ts;
        }
    }
}
