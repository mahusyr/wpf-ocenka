using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MojeDzwieki
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        Collection collection = new Collection();

        public MainWindow()
        {
            InitializeComponent();

            tbBand.Text = "13";
            // collection.overwrite_items();

            // tbAlbum.Text = collection.items[0].album;
        }

        public void update_album(bool direction)
        {
            return;
        }

    } 

    class Collection
    {
        public List<Album> items { get; set; }

        public void add_item(Album album)
        {
            items.Add(album);
        }
        public void overwrite_items()
        {
            ArrayList data = new ArrayList();
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string line;
                while ((line = reader.ReadLine().Trim()) != null)
                {
                    Album album = new Album(line, reader.ReadLine(), uint.Parse(reader.ReadLine()), uint.Parse(reader.ReadLine()), ulong.Parse(reader.ReadLine()), reader.ReadLine());
                    add_item(album);
                }
            }
        }
    }

    class Album
    {
        public String band { get; set; }
        public String album { get; set; }
        public uint trackCount { get; set; }
        public uint releaseYear { get; set; }
        public ulong downloadCount { get; set; }
        public string whitespace { get; set; }

        public Album(string band, string album, uint trackCount, uint releaseYear, ulong downloadCount, string whitespace)
        {
            this.band = band;
            this.album = album;
            this.trackCount = trackCount;
            this.releaseYear = releaseYear;
            this.downloadCount = downloadCount;
            this.whitespace = whitespace;
        }
    }
}
