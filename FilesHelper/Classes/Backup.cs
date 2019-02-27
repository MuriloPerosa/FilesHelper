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
    public class Backup : BaseView
    {

        public ObservableCollection<BackupItem> Items { get; set; } = new ObservableCollection<BackupItem>();

        public Backup()
        {
            Items.CollectionChanged += Items_CollectionChanged;

            if (File.Exists(Configuracoes.Backup_Config))
            {
                //Leitura das onfigurações aqui...
                GetConfig();
            }
            else
            {
                Items = new ObservableCollection<BackupItem>();
            }

            OnPropertyChanged(null);

        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Items));
        }

        public void GetConfig()
        {
            List<string> linhas = new List<string>();
            linhas.AddRange(Log.Ler(Configuracoes.Backup_Config));

            List<BackupItem> lista = new List<BackupItem>();
            BackupItem item = null;
            foreach (var linha in linhas)
            {
                item = new BackupItem(linha.Split('|')[0].Replace("|", ""), linha.Split('|')[1].Replace("|", ""), bool.Parse(linha.Split('|')[2].Replace("|", "")));
                lista.Add(item);
            }

            Items = new ObservableCollection<BackupItem>(lista);
        }

        public void Salvar()
        {

            FileInfo fi = new FileInfo(Configuracoes.Backup_Config);
            Diretorio.CreateIfNotExists(fi.DirectoryName);

            List<string> linhas = new List<string>();
            foreach (var item in Items)
            {
                linhas.Add(string.Format("{0}|{1}|{2}", item.From, item.To, item.Zipar.ToString()));
            }
            Log.Escrever(Configuracoes.Backup_Config, linhas);
        }

        public void Executar()
        {
            foreach (var item in Items)
            {
                if (Directory.Exists(item.From) && Directory.Exists(item.To))
                {
                    DirectoryInfo di = new DirectoryInfo(item.From);
                    string toDir = item.To + @"\" + di.Name;

                    if (Directory.Exists(toDir))
                    {
                        Diretorio.Delete(toDir, true);
                    }

                    if (!item.Zipar)
                    {
                        //Items não Zipados
                        try
                        {
                            Diretorio.CreateIfNotExists(toDir);
                            Diretorio.CopyAll(item.From, toDir);

                        }
                        catch (Exception ex)
                        {
                            MsgBox.Erro(ex.Message);
                        }
                    }
                    else
                    {
                        //Items Zipados
                        FileInfo fi = new FileInfo(item.From);
                        string zipName = fi.Name + ".zip";

                        if (File.Exists(item.To + @"\" + zipName))
                        {
                            Arquivo.Delete(item.To + @"\" + zipName);
                        }
                        List<string> arquivos = new List<string>();
                        arquivos.Add(item.From);
                        Zip.Compress(arquivos, item.To + @"\" + zipName, true);
                    }
                }
            }
        }
    }
}
