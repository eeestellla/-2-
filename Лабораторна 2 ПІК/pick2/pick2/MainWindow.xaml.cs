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

namespace pick2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageBrush darkGreenTexture = new ImageBrush(new BitmapImage(new Uri("leaf_texture_dark.jpg", UriKind.Relative)));
        private ImageBrush autumnTexture = new ImageBrush(new BitmapImage(new Uri("leaf_texture_autumn.jpg", UriKind.Relative)));
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                // Правильний шлях до ресурсів
                darkGreenTexture = new ImageBrush(new BitmapImage(new Uri("/Images/leaf_texture_dark.jpg")));
                autumnTexture = new ImageBrush(new BitmapImage(new Uri("/Images/leaf_texture_autumn.jpg")));

                this.Background = darkGreenTexture;
                this.MouseEnter += MainWindow_MouseEnter;
                this.MouseLeave += MainWindow_MouseLeave;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження зображень: " + ex.Message);
            }
        }

        private void MainWindow_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = autumnTexture;
        }

        private void MainWindow_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = darkGreenTexture;
        }
    }
}
