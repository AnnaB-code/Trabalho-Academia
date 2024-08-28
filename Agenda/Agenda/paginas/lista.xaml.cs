using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lista : ContentPage
    {
        public lista()
        {
            InitializeComponent();
            btn_recarregar.Clicked += listar;
        }
        public void listar(object sender, EventArgs args)
        {
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            List<Alunos> listaAlunos = new List<Alunos>();
            listaAlunos = dbf.GetAlunos();
            var array = listaAlunos.ToArray();
            List<Alunos> lista = new List<Alunos>();
            for (int c = 0; c < array.Length; c++)
            {
                lista.Add(new Alunos
                {
                    Nome = array[c].Nome.ToString(),
                    Ende = array[c].Ende.ToString(),
                    Fone = array[c].Fone.ToString(),
                    Idade = array[c].Idade
                });
            }
            ls_alunos.ItemsSource = lista;
        }
    }

}