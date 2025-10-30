using DIO.Series.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series.Model
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int Id, Genero Genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string str = "";
            str += "Género: " + this.Genero + Environment.NewLine;
            str += "Titulo: " + this.Titulo + Environment.NewLine;
            str += "Descrição: " + this.Descricao + Environment.NewLine;
            str += "Ano: " + this.Ano + Environment.NewLine;
            str += "Excluído: " + this.Excluido;
            return str;
        }

        //Emcapsulamento
        public string GetTitulo()
        {
            return this.Titulo;
        }

        public int GetId()
        {
            return this.Id;
        }

        public void foiExcluido()
        {
            this.Excluido = true;
        }

        public bool GetExcluido()
        {
            return Excluido;
        }
    }
}
