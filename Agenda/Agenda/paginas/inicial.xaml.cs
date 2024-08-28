using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agenda.banco;

namespace Agenda.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicial : ContentPage
    {
        public inicial()
        {
            InitializeComponent();
            btn_enviar.Clicked += cadastrar;
        }

        public void cadastrar(object sender, EventArgs args)
        {
            string nome = txt_nome.Text;
            string ende = txt_ende.Text;
            string fone = txt_fone.Text;
            string idade = txt_idade.Text;
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.InserirAluno(nome, ende, fone, idade);
            DisplayAlert("Mensagem", "Registro gravado com Sucesso!", "OK");
        }
    }

}