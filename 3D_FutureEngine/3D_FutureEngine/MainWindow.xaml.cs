using System;
using System.Collections.Generic;
using System.IO;
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

namespace _3D_FutureEngine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createproject_FUNC(object sender, MouseButtonEventArgs e)
        {
            Directory.CreateDirectory(projectname_TXTBOX.Text);
            File.WriteAllText(projectname_TXTBOX.Text + "/main.py", "import ursina\nfrom ursina.prefabs.first_person_controller import FirstPersonController\napp = Ursina()\n\n# Player controller\nplayer = FirstPersonController()");
            File.WriteAllText("projects.txt", projectname_TXTBOX.Text);
        }
    }
}
