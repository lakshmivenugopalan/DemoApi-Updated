using job_portal.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_portal
{
     public interface IDbClient
    {
        IMongoCollection<Job> GetJobCollection();
    }
}
