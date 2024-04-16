using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Helper
{
    public interface IHelp<TEntity>
    {
        IQueryable<TEntity> Queryable { get; }

        void Actualizar(int id, TEntity entity);
        void Eliminar(int id);
        void Guardar(TEntity entity);
        







    }
}
