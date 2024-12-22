using KursovayaP.Model;
using KursovayaP.View;
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
using System.Windows.Shapes;

namespace KursovayaP
{
    /// <summary>
    /// Логика взаимодействия для CharactersWindow.xaml
    /// </summary>
    public partial class CharactersWindow : Window
    {
        public CharactersWindow()
        {
            InitializeComponent();
        }
        private void CharacterButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Character character)
            {
                var characterInfoWindow = new CharacterInfoWindow(character);
                characterInfoWindow.ShowDialog();
            }
        }

    }
}
