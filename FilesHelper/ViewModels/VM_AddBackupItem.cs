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
    public class VM_AddBackupItem : BaseView
    {
        private BackupItem _item = new BackupItem("", "", true);
        public BackupItem Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }


        private bool _isSave = false;
        public bool IsSave
        {
            get
            {
                return _isSave;
            }
            set
            {
                _isSave = value;
                OnPropertyChanged(nameof(IsSave));
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
            Item = new BackupItem("", "", true);
        }

        public void AddFrom()
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(dialog.SelectedPath))
                {
                    Item.From = dialog.SelectedPath;
                    OnPropertyChanged(null);
                }
            }
        }

        public void AddTo()
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(dialog.SelectedPath))
                {
                    Item.To = dialog.SelectedPath;
                    OnPropertyChanged(null);
                }
            }
        }

        public bool Salvar()
        {
            if (string.IsNullOrWhiteSpace(Item.From))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(Item.To))
            {
                return false;
            }

            if (Item.From == Item.To)
            {
                return false;
            }

            IsSave = true;
            return true;
        }



    }
}
