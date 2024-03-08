using Domain.Models;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAL
{
    public abstract class BaseDAL<T> where T : BaseModel
    {
        public abstract void Insert(T entity);
        public abstract void Delete(int id);
        public abstract void Update(int id, T entity);
        public abstract T Select(int id);
        public abstract List<T> Select();
    }
}
