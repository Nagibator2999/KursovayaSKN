using KursovayaP.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KursovayaP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CharactersViewModel();
            DataContext = new ArtifactsVM();
            DataContext = new VMWeapons();
            //WrapPanel st = new ();
            //while (true)
            //{
            //    var i = new ImageBrush(new BitmapImage(new Uri(@"Sourse/Images/Backgrounde/image1.jpg", UriKind.Relative)));
            //    Button bt = new Button();
            //    bt.Background = i;
            //    bt.Width = 100;
            //    bt.Height = 100;
            //    bt.Content = "name";
            //    st.Children.Add(bt);
            //}
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"Sourse/Images/Backgrounde/image1.jpg", UriKind.Relative)));
        }
        private void OpenCharactersWindow(object sender, RoutedEventArgs e)
        {
            var charactersWindow = new CharactersWindow
            {
                DataContext = new ViewModel.CharactersViewModel()
            };
            charactersWindow.Show();
        }

        private void OpenWeaponsWindow(object sender, RoutedEventArgs e)
        {
            var weaponsWindow = new WeaponsWindow
            {
                //DataContext = new WeaponsViewModel()
            };
            weaponsWindow.Show();
        }

        private void OpenArtifactsWindow(object sender, RoutedEventArgs e)
        {
            var artifactsWindow = new ArtifactsWindow
            {
                //DataContext = new ArtifactsViewModel()
            };
            artifactsWindow.Show();
        }
    }
}