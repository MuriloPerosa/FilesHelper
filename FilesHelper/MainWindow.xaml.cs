using FilesHelper.ViewModels;
using General_Lib;
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

namespace FilesHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public VM_MainWindow ViewModel { get; set; } = new VM_MainWindow();

        public MainWindow()
        {
            InitializeComponent();

            tb_Product.Text = Sistema.GetProductName();
            tb_Version.Text = Sistema.GetProductVersion();
            this.DataContext = ViewModel = new VM_MainWindow();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            ViewModel.InicializarAsync();
        }

        private void mn_Sair_Click(object sender, RoutedEventArgs e)
        {
            if (MsgBox.Pergunta("Tem certeza que deseja sair?"))
            {
                this.Close();
            }
        }

        private void mn_Limpeza_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            LimpezaWindow window = new LimpezaWindow();
            window.ShowDialog();
            this.Visibility = Visibility.Visible;
            ViewModel.InicializarAsync();
        }

        private void btn_Limpar_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.LimparAsync();
        }

        private void mn_Backup_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            BackupWindow window = new BackupWindow();
            window.ShowDialog();
            this.Visibility = Visibility.Visible;
            ViewModel.InicializarAsync();
        }

        private void btn_Bkp_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ExecutarBackup();
        }
    }
}
