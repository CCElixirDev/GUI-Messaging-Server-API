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

namespace MessagingServer
{
    /// <summary>
    /// Interaction logic for WindowsServerGUI.xaml
    /// </summary>
    public partial class WindowsServerGUI : UserControl
    {
        public WindowsServerGUI()
        {
            InitializeComponent();
        }

        private void PortTextBox_Initialized(object sender, EventArgs e)
        {
            PortTextBox.IsEnabled = false;
        }

        private void CommandBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CommandBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ExecuteCommand(CommandBox.Text);
            }
        }

        private int ExecuteCommand(string com) {
            return 0;
        }
    }
}
