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
    /// Interaction logic for LimpezaWindow.xaml
    /// </summary>
    public partial class LimpezaWindow : Window
    {


        public VM_Limpeza ViewModel { get; set; } = new VM_Limpeza();

        public LimpezaWindow()
        {
            InitializeComponent();

            tb_Product.Text = Sistema.GetProductName();
            tb_Version.Text = Sistema.GetProductVersion();
            this.DataContext = ViewModel = new VM_Limpeza();
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

        private void mn_Salvar_Click(object sender, RoutedEventArgs e)
        {
            if (MsgBox.Pergunta("Tem certeza que deseja salvar as alterações realizadas?"))
            {
                ViewModel.SalvarAsync();
            }
        }

        private void btn_Remover_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pasta pasta = dg_pastas.SelectedItem as Pasta;
                if (MsgBox.Pergunta("Tem certeza que deseja remover a pasta selecionada?"))
                {
                    ViewModel.Remover(pasta);
                }
            }
            catch (Exception)
            {
                MsgBox.Atencao("Selecione uma pasta para remover.");
            }
        }

        private void ctx_add_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.AddFolder();
        }

        private void mn_Limpar_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.LimparAsync();
        }

        private void btn_Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pasta pasta = dg_pastas.SelectedItem as Pasta;
                ViewModel.Open(pasta);
            }
            catch (Exception)
            {
            }

        }
    }
}
