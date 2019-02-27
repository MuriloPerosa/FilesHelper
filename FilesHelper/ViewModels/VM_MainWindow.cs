using FilesHelper.Classes;
using General_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.ViewModels
{
    public class VM_MainWindow : BaseView
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
            this.BusyContent = "Inicializando aplicação... Por favor, aguarde...";
            OnPropertyChanged(null);
            await Task.Run(() => Inicializar());
            this.IsBusy = false;
            OnPropertyChanged(null);
        }

        private void Inicializar()
        {
            Limpeza = new Limpeza();
            Backup = new Backup();
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
