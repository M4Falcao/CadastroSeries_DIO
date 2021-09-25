using System;
using System.Collections.Generic;
using CadastroSeries_DIO.Interface;

namespace CadastroSeries_DIO
{
    public class FilmesRepositorio : IRepositorio<Filmes>
    {
        private List<Filmes> ListaFilmes = new List<Filmes>();
        public void Atualiza(int id, Filmes objeto)
        {
            ListaFilmes[id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaFilmes[id].Excluir();
        }

        public void Insere(Filmes objeto)
        {
            ListaFilmes.Add(objeto);
        }

        public List<Filmes> Lista()
        {
            return ListaFilmes;
        }

        public int ProximoId()
        {
            return ListaFilmes.Count;
        }

        public Filmes RetornaPorId(int id)
        {
            return ListaFilmes[id];
        }
    }
}