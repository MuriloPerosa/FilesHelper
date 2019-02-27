using General_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace FilesHelper.Classes
{
    public class BackupItem : BaseView
    {
        private string _from = "";
        public string From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;
                OnPropertyChanged(nameof(From));
            }
        }

        private string _to = "";
        public string To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
                OnPropertyChanged(nameof(To));
            }
        }

        private bool _zipar = true;
        public bool Zipar
        {
            get
            {
                return _zipar;
            }
            set
            {
                _zipar = value;
                OnPropertyChanged(nameof(Zipar));
            }
        }


        public BitmapImage Imagem
        {
            get
            {
                return General_Lib.Dados.Imagem.BitmapToBitmapImage(Properties.Resources.folder_yellow);
            }
        }

        public BackupItem(string from, string to, bool zipar)
        {
            From = from;
            To = to;
            Zipar = zipar;
        }

    }
}
