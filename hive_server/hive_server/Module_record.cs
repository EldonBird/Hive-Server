using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace hive_server;

public class Module_record {

    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string _id {get;set;}
    public int id {get;set;}
    public int module_id {get;set;}
    public string location {get;set;}
    public string datetime {get;set;}
    public int heat {get;set;}
    public int moisture {get;set;}

}