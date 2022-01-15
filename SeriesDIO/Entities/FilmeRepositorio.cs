using System;
using System.Collections.Generic;
using SeriesDIO.Interfaces;
using System.Linq;

namespace SeriesDIO //O programa vai instanciar o repositório e mexemos só com ele
{
    public class FilmeRepositorio : IRepositorio<Filme> //Implementando uma interface repositório de filmes
    {
        private List<Filme> listaFilmes = new List<Filme>();
        public void Atualiza(int id, Filme filme)
        {
            listaFilmes[id] = filme;
        }

        public void Exclui(int id)
        {
            listaFilmes[id].Excluir();
        }

        public void Insere(Filme filme)
        {
            listaFilmes.Add(filme);
        }

        public List<Filme> Lista() //O método List() vai retornar uma List de Filmes
        {
            return listaFilmes;
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilmes.FirstOrDefault(_ => _.Id == id);
        }
    }
}