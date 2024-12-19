using System.IO;
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

namespace MyTyping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string keymap;

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Oem2) // Key.Oem2 represents the '/' key on most keyboards
            {
                WriteKeymapToFile();
            }
            else
            {
                keymap += "\r\n" + e.Key.ToString();
            }
        }

        private void WriteKeymapToFile()
        {
            string desktopPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "keymap.txt");
            File.WriteAllText(desktopPath, keymap);
        }
    }

}
