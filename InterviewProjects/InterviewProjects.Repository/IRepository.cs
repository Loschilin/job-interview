using System.Collections.Generic;
using System.Text;

namespace InterviewProjects.Repository
{
    public interface IRepository<TEntity>
    {
        void Save(TEntity entity);
        void Delete(TEntity entity);
        IReadOnlyCollection<TEntity> GetCollection();
        IReadOnlyCollection<TEntity> GetById();
    }
}
