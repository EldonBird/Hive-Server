using MongoDB.Driver;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace hive_server;

public class HiveServices {

    private readonly IMongoCollection<Module_record> _records;

    public HiveServices(IOptions<HiveDataBaseSettings> options) {
        var mongoClient = new MongoClient(options.Value.ConnectionString);

        _records = mongoClient.GetDatabase(options.Value.DatabaseName)
            .GetCollection<Module_record>(options.Value.HiveCollectionName);
    }

    public async Task<List<Module_record>> Get() =>
    await _records.Find(module => true).ToListAsync();

    public async Task<Module_record> Get(string module_id) => await _records.Find(module => module._id == module_id).FirstOrDefaultAsync();

    public async Task Create(Module_record record) => await _records.InsertOneAsync(record);

    public async Task Update(string id, Module_record updateRecord) => await _records.ReplaceOneAsync(module => module._id == id, updateRecord);

    public async Task Remove(string id) => await _records.DeleteOneAsync(module => module._id == id);
}