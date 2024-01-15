using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        bool ICategoryRepository.CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        ICollection<Pokemon> ICategoryRepository.GetPokemonByCategoryId(int id)
        {
            return _context.PokemonCategories.Where(c => c.Id == id).Select(c => c.Pokemon).ToList();
        }

        ICollection<Category> ICategoryRepository.GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }

        Category ICategoryRepository.GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(C => C.Id == id);
        }

        public bool CreateCategory(Category category)
        { 
            _context.Add(category); 
            var saved = _context.SaveChanges(); 
            return saved > 0 ? true : false; 
        } 
    }
}
