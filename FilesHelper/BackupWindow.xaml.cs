using FilesHelper.Classes;
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

namespace FilesHelper
{
    /// <summary>
    /// Interaction logic for BackupWindow.xaml
    /// </summary>
    public partial class BackupWindow : Window
    {
        public VM_Backup ViewModel { get; set; } = new VM_Backup();

        public BackupWindow()
        {
            InitializeComponent();

            tb_Product.Text = Sistema.GetProductName();
            tb_Version.Text = Sistema.GetProductVersion();
            this.DataContext = ViewModel = new VM_Backup();
        }

        private void mn_Sair_Click(object sender, RoutedEventArgs e)
        {
            if (MsgBox.Pergunta("Tem certeza que deseja sair?"))
            {
                this.Close();
            }
        }

        private void mn_Salvar_Click(object sender, RoutedEventArgs e)
        {
            if (MsgBox.Pergunta("Tem certeza que deseja salvar as alterações realizadas?"))
            {
                ViewModel.SalvarAsync();
            }
        }

        private void mn_Backup_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ExecutarBackup();
        }

        private void ctx_add_Click(object sender, RoutedEventArgs e)
        {
            AddBackupItemWindow window = new AddBackupItemWindow();
            window.ShowDialog();
            if (window.ViewModel.IsSave)
            {
                ViewModel.AddItem(window.ViewModel.Item);
            }
        }

        private void btn_Remover_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BackupItem item = dg_items.SelectedItem as BackupItem;
                if (MsgBox.Pergunta("Tem certeza que deseja remover o item selecionado?"))
                {
                    ViewModel.Remover(item);
                }
            }
            catch (Exception)
            {
                MsgBox.Atencao("Selecione um item para remover.");
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            ViewModel.InicializarAsync();
        }

        private void btn_Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BackupItem item = dg_items.SelectedItem as BackupItem;
                ViewModel.Open(item);
            }
            catch (Exception)
            {
            }

        }
    }
}
