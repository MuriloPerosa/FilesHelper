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
    public class VM_Backup : BaseView
    {

        private Backup _backup = new Backup();
        public Backup Backup
        {
            get
            {
                return _backup;
            }
            set
            {
                _backup = value;
                OnPropertyChanged(nameof(Backup));
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
            Backup = new Backup();
        }

        private void Salvar()
        {
            Backup.Salvar();
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

        public void AddItem(BackupItem item)
        {
            Backup.Items.Add(item);
        }

        public void Remover(BackupItem item)
        {
            foreach (var i in Backup.Items.ToList().FindAll(x => x.From == item.From && x.To == item.To))
            {
                Backup.Items.Remove(i);
            }

            OnPropertyChanged(null);
        }

        public void Open(BackupItem item)
        {
            if (Directory.Exists(item.To))
            {
                Sistema.Executar(item.To);
            }

            if (Directory.Exists(item.From))
            {
                Sistema.Executar(item.From);
            }
        }

        public async Task ExecutarBackup()
        {
            this.IsBusy = true;
            this.BusyContent = "Executando backup... Por favor, aguarde...";
            OnPropertyChanged(null);
            await Task.Run(() => Backup.Executar());
            this.IsBusy = false;
            OnPropertyChanged(null);
        }

    }
}
