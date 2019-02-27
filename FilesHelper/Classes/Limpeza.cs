using General_Lib;
using General_Lib.Arquivos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Classes
{
    public class Limpeza : BaseView
    {

        public ObservableCollection<Pasta> Pastas { get; set; } = new ObservableCollection<Pasta>();

        public Limpeza()
        {
            Pastas.CollectionChanged += Pastas_CollectionChanged;

            if (File.Exists(Configuracoes.Limpeza_Config))
            {
                //Leitura das onfigurações aqui...
                GetConfig();
            }
            else
            {
                Pastas = new ObservableCollection<Pasta>();
            }

            OnPropertyChanged(null);

        }

        private void Pastas_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Pastas));
        }

        public void GetConfig()
        {
            List<string> linhas = new List<string>();
            linhas.AddRange(Log.Ler(Configuracoes.Limpeza_Config));

            List<Pasta> lista = new List<Pasta>();
            Pasta pasta = null;
            foreach (var linha in linhas)
            {
                pasta = new Pasta(linha.Split('|')[0].Replace("|", ""), bool.Parse(linha.Split('|')[1].Replace("|", "")));
                lista.Add(pasta);
            }

            Pastas = new ObservableCollection<Pasta>(lista);
        }

        public void Salvar()
        {

            FileInfo fi = new FileInfo(Configuracoes.Limpeza_Config);
            Diretorio.CreateIfNotExists(fi.DirectoryName);

            List<string> linhas = new List<string>();
            foreach (var pasta in Pastas)
            {
                linhas.Add(string.Format("{0}|{1}", pasta.Caminho, pasta.Apagar.ToString()));
            }

            Log.Escrever(Configuracoes.Limpeza_Config, linhas);
        }

        public void RemoverPasta(Pasta pasta)
        {
            foreach (var p in Pastas.ToList().FindAll(x => x.Caminho == pasta.Caminho))
            {
                Pastas.Remove(p);
            }

            OnPropertyChanged(nameof(Pastas));
        }

        public void Limpar()
        {
            foreach (var pasta in Pastas)
            {
                if (Directory.Exists(pasta.Caminho))
                {
                    if (pasta.Apagar)
                    {
                        Diretorio.Delete(pasta.Caminho);
                    }
                    else
                    {
                        Diretorio.Limpar(pasta.Caminho);
                    }
                }
            }
        }

    }
}
