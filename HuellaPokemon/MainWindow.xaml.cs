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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PokemonGBAFrameWork;
using Microsoft.Win32;
using Gabriel.Cat.Extension;

namespace HuellaPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            byte b= 0x33;
            bool[] bits = b.ToBits();
            OpenFileDialog opnFile;
            RomData romData;
            InitializeComponent();
            opnFile = new OpenFileDialog();
            opnFile.Filter = "GBA|*.gba";
            if (opnFile.ShowDialog().GetValueOrDefault())
            {
                romData = RomData.GetRomData(new RomGBA(new System.IO.FileInfo(opnFile.FileName)));
                for (int i = 0; i < romData.Pokedex.Count; i++)
                    ungPokemon.Children.Add(new PokemonYHuella(romData.Pokedex[i]));
            }
            else this.Close();
        }
    }
}
