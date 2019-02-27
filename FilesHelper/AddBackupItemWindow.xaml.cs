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
using System.Windows.Shapes;
using System.Windows.Forms;

namespace FilesHelper
{
    /// <summary>
    /// Interaction logic for AddBackupItemWindow.xaml
    /// </summary>
    public partial class AddBackupItemWindow : Window
    {
        public VM_AddBackupItem ViewModel { get; set; } = new VM_AddBackupItem();

        public AddBackupItemWindow()
        {
            InitializeComponent();

            tb_Product.Text = Sistema.GetProductName();
            tb_Version.Text = Sistema.GetProductVersion();
            this.DataContext = ViewModel = new VM_AddBackupItem();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            ViewModel.InicializarAsync();
        }

        private void btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            if (!ViewModel.Salvar())
            {
                MsgBox.Erro("Falha ao definir. Verifique o preenchimento dos campos do formulário.");
            }
            else
            {
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            if (MsgBox.Pergunta("Tem certeza que deseja sair?"))
            {
                this.Close();
            }
        }

        private void btn_addTo_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.AddTo();
        }

        private void btn_addFrom_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.AddFrom();
        }
    }
}
