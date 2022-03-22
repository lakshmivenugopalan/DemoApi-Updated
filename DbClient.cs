using job_portal.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;



namespace job_portal
{
   
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Job> _jobs;
        public DbClient(IOptions<JobPortalDbConfig> jobPortalDbConfig)
        {
            var client = new MongoClient(jobPortalDbConfig.Value.Connection_String);
            var database = client.GetDatabase(jobPortalDbConfig.Value.Database_Name);
            _jobs = database.GetCollection<Job>(jobPortalDbConfig.Value.Collection_Name);


        }
        public IMongoCollection<Job> GetJobCollection()
        {
            return _jobs;
        }
    }
}
