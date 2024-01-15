using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategoryId(int categoryId);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
    }
}
