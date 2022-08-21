using ApplicationApp.Interfaces;
using Entities;
using System;
using System.Windows.Forms;
using Utils;

namespace SistemaLDA
{
    public partial class MainScreen : Form
    {
        private readonly IAppCharacter _appCharacter;

        public MainScreen(IAppCharacter appCharacter)
        {
            InitializeComponent();
            _appCharacter = appCharacter;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var personagem = new Character
            {
                Name = TxtNome.Text,
                //IdClass = uint.Parse(TxtClasse.Text),
                //IdBreed = uint.Parse(TxtRaca.Text),
                //SpellCastSpeed = uint.Parse(TxtVelConjuracao.Text),
                //IdElement = uint.Parse(TxtElemento.Text),
                //Level = uint.Parse(TxtNivel.Text),
                //Exp = uint.Parse(TxtExp.Text),
                //Constitution = uint.Parse(TxtConstituicao.Text),
                //AuraPower = uint.Parse(TxtPoderAura.Text)
            };

            _appCharacter.AddCharacter(personagem);

            _appCharacter.ImprimirFicha(personagem);
            if (HelpArquivoPdf.FichaEstaNaPasta())
                MessageBox.Show("Sua ficha foi impressa.");

        }
    }
}
