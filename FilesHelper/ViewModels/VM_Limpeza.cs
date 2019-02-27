using FilesHelper.Classes;
using General_Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesHelper.ViewModels
{
    public class VM_Limpeza : BaseView
    {

        private Limpeza _limpeza = new Limpeza();
        public Limpeza Limpeza
        {
            get
            {
                return _limpeza;
            }
            set
            {
                _limpeza = value;
                OnPropertyChanged(nameof(Limpeza));
            }
        }

        public async Task InicializarAsync()
        {
            this.IsBusy = true;
            this.BusyContent = "Carregando configurações... Por favor, aguarde...";
            OnPropertyChanged(null);
            await Task.Run(() => Inicializar());
            this.IsBusy = false;
            OnPropertyChanged(null);
        }

        private void Inicializar()
        {
            Limpeza = new Limpeza();
        }

        public void AddFolder()
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Limpeza.Pastas.ToList().FindAll(x => x.Caminho == dialog.SelectedPath).Count == 0)
                {

                    Limpeza.Pastas.Add(new Pasta(dialog.SelectedPath));
                    OnPropertyChanged(null);
                }
            }

        }

        private void Salvar()
        {
            Limpeza.Salvar();
        }

        public async Task SalvarAsync()
        {
            this.IsBusy = true;
            this.BusyContent = "Salvando configurações... Por favor, aguarde...";
            OnPropertyChanged(null);
            await Task.Run(() => Salvar());
            this.IsBusy = false;
            OnPropertyChanged(null);
        }

        public void Remover(Pasta pasta)
        {
            Limpeza.RemoverPasta(pasta);
        }

        public void Open(Pasta pasta)
        {
            if (Directory.Exists(pasta.Caminho))
            {
                Sistema.Executar(pasta.Caminho);
            }
        }

        public async Task LimparAsync()
        {
            this.IsBusy = true;
            this.BusyContent = "Executando limpeza... Por favor, aguarde...";
            OnPropertyChanged(null);
            await Task.Run(() => Limpeza.Limpar());
            this.IsBusy = false;
            OnPropertyChanged(null);
        }
    }
}
