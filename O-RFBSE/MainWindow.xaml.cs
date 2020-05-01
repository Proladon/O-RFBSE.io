using O_RFBSE.User_Controls;
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

namespace O_RFBSE
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

        private void preChangePage()
        {
            rules.Visibility = Visibility.Collapsed;
            knowledge.Visibility = Visibility.Collapsed;
            owl.Visibility = Visibility.Collapsed;
        }

        // 導航.首頁
        private void changeTo_index(object sender, RoutedEventArgs e)
        {
            preChangePage();
            rules.Visibility = Visibility.Collapsed;
        }
        
        // 導航.規則
        private void changeTo_rulesPage(object sender, RoutedEventArgs e)
        {
            preChangePage();
            rules.Visibility = Visibility.Visible;
        }

        // 導航.知識
        private void changeTo_knowledgePage(object sender, RoutedEventArgs e)
        {
            preChangePage();
            knowledge.Visibility = Visibility.Visible;
        }
        
        // 導航.知識
        private void changeTo_owlPage(object sender, RoutedEventArgs e)
        {
            preChangePage();
            owl.Visibility = Visibility.Visible;
        }
    }
}
