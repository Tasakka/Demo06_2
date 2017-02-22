using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Laskebutton_Click(object sender, RoutedEventArgs e)
        {
            double ikkunaleveys = double.Parse(LeveystextBox.Text);
            double ikkunakorkeus = double.Parse(KorkeustextBox.Text);
            double karmileveys = double.Parse(KarmiLeveystextBox.Text) * 0.1;
            double ikkunala = ikkunaleveys * ikkunakorkeus;
            string value = ikkunala.ToString() + " cm ^ 2";
            IkkunaAlatextBox.Text = value;
            double lasiala = (ikkunakorkeus - (2 * karmileveys)) * (ikkunaleveys - (2 * karmileveys));
            string value2 = lasiala.ToString() + " cm ^ 2";
            LasiAlatextBox.Text = value2;
            double karmipiiri = 2 * ikkunakorkeus + 2 * ikkunaleveys - ((2 * ikkunakorkeus - 2 * karmileveys) + (2 * ikkunaleveys - 2 * karmileveys));
            string value3 = karmipiiri.ToString();
            PiiritextBox.Text = value3 + " cm";
        }
    }
}
