using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Agenda.banco
{
    internal class Alunos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ende { get; set; }
        public string Fone { get; set; }
        public int Idade { get; set; }

    }
}
