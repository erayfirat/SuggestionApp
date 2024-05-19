
namespace SuggestionAppLibrary.DataAccess;

public interface ICategoryData
{
    Task CrateCategory(CategoryModel category);
    Task<List<CategoryModel>> GetAllCategories();
}