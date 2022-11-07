using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_prj_cadserie.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(Task entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
