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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for Star.xaml
    /// </summary>
    public partial class Star : UserControl
    {
        public bool IsPressed { get; set; }
        public Star()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Image img = button.Content as Image;


                if (IsPressed == false)
                {
                    img.Source = new BitmapImage(new Uri("favourites.png", UriKind.RelativeOrAbsolute));    
                }
                else
                {
                    img.Source = new BitmapImage(new Uri("white-star.png", UriKind.RelativeOrAbsolute));
                }

                IsPressed = !IsPressed;

            }
        }

    }
}
