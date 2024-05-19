using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;
public interface IDbConnection
{
    IMongoCollection<CategoryModel> CategoryCollection { get; set; }
    string CategoryCollectionName { get; }
    MongoClient Client { get; }
    string DbName { get; }
    IMongoCollection<StatusModel> StatusCollection { get; set; }
    string StatusCollectionName { get; }
    IMongoCollection<SuggestionModel> SuggestionCollection { get; set; }
    string SuggestionCollectionName { get; }
    IMongoCollection<UserModel> UserCollection { get; set; }
    string UserCollectionName { get; }
}