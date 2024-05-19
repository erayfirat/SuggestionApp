
namespace SuggestionAppLibrary.DataAccess;

internal interface ICategoryData
{
    Task CrateCategory(CategoryModel category);
    Task<List<CategoryModel>> GetAllCategories();
}