using System.Collections.Generic;

namespace SeriesDIO.Interfaces
{
    public interface IRepositorio<T>
    {
        //Utilizando T como parâmetro (tipo genérico)
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}