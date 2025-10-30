using DIO.Series.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series.Model.Repositorio
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public List<Serie> Listar()
        {
            return listaSerie;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        public void inserir(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public void Excluir(int id)
        {
            listaSerie[id].foiExcluido();
        }

        public void Atualizar(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }
    }
}
