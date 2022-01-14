using System;
using System.Collections.Generic;
using SeriesDIO.Interfaces;

namespace SeriesDIO
{
    public class FilmeRepositorio : IRepositorio<Filme> //Implementando uma interface repositório de filmes
    {
        private List<Filme> listaFilmes = new List<Filme>();
        public void Atualiza(int id, Filme entidade)
        {
            listaFilmes[id] = entidade;
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Filme entidade)
        {
            throw new NotImplementedException();
        }

        public List<Filme> Lista() //O método List() vai retornar uma List de Filmes
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Filme RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}