using System;
using System.Collections.Generic;

namespace InterviewProjects.Repository
{
    public class CommonEntityRepository: IRepository<MyEntity>
    {
        public CommonEntityRepository()
        {
            
        }

        public void Save(MyEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MyEntity entity)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<MyEntity> GetCollection()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<MyEntity> GetById()
        {
            throw new NotImplementedException();
        }
    }
}