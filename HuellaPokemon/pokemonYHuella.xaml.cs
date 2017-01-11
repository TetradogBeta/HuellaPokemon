using PokemonGBAFrameWork;
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
using Gabriel.Cat.Extension;
namespace HuellaPokemon
{
    /// <summary>
    /// Interaction logic for pokemonYHuella.xaml
    /// </summary>
    public partial class PokemonYHuella : UserControl
    {
        public PokemonYHuella()
        {
            InitializeComponent();
        }
        public PokemonYHuella(Pokemon pkm):this()
        {
            imgPokemon.SetImage(pkm.Sprites.GetImagenFrontal());
            if(pkm.Huella!=null)
               imgHuella.SetImage(pkm.Huella.Imagen);

        }
    }
}
