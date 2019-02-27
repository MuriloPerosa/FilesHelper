using General_Lib;
using General_Lib.Arquivos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FilesHelper.Classes
{
    public class Pasta : BaseView
    {
        private string _caminho = "";
        public string Caminho
        {
            get
            {
                return _caminho;
            }
            set
            {
                _caminho = value;
                OnPropertyChanged(nameof(Caminho));
            }
        }

        private bool _apagar = false;
        public bool Apagar
        {
            get
            {
                return _apagar;
            }
            set
            {
                _apagar = value;
                OnPropertyChanged(nameof(Apagar));
            }
        }



        public BitmapImage Imagem
        {
            get
            {
                return General_Lib.Dados.Imagem.BitmapToBitmapImage(Properties.Resources.folder_yellow);
            }
        }

        public Pasta(string caminho)
        {
            Caminho = caminho;
        }

        public Pasta(string caminho, bool apagar)
        {
            Caminho = caminho;
            Apagar = apagar;
        }

    }
}
