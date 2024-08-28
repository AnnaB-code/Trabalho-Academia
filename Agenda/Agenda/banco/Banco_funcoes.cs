using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using Agenda.banco;


namespace Agenda.banco
{
    class Banco_funcoes
    {
        private SQLiteConnection conexao;
        string pasta = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);


        public void CriarBancoDeDados()
        {
            string dbPath = System.IO.Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Alunos.db3");
            conexao = new SQLiteConnection(dbPath);
            conexao.CreateTable<Alunos>();
        }

        public void InserirAluno(string nome, string ende, string fone, string idade)
        {
            conexao.Query<Alunos>("INSERT INTO alunos (Nome,Ende,Fone,Idade) " +
                "VALUES('" + nome + "','" + ende + "','" + fone + "'," + idade + ")");

        }

        private void DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public List<Alunos> GetAlunos()
        {
            return conexao.Query<Alunos>("SELECT * FROM alunos");
        }

        public void ExcluirAluno(string id)
        {
            conexao.Query<Alunos>("DELETE FROM alunos WHERE Id = " + id);

        }

        public void EditarAluno(string id, string nome, string ende, string fone, string idade)
        {
            conexao.Query<Alunos>("UPDATE alunos SET Nome = '" + nome + "', Ende = '" + ende + "', Fone = '" + fone + "', Idade = '"
                + idade + "' WHERE Id = '" + id + "' ");

        }

        //PESQUISAR COMMAND
        public List<Alunos> PesquisarAlunos(string query)
            => conexao.Query<Alunos>
            ("SELECT * FROM alunos WHERE Nome like \"%" + query.Trim() + "%\"");

    }

}
