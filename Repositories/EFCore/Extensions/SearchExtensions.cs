using Entities.Models;

namespace Repositories.EFCore.Extensions
{
    public static class SearchExtensions
    {
        public static IQueryable<Category> SearchCategory(this IQueryable<Category> category, string searchTerm)
        {
            if(string.IsNullOrWhiteSpace(searchTerm))
                return category;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return category.Where(c => c.CategoryName!.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<User> SearchUser(this IQueryable<User> user, string searchTerm)
        {
            if(string.IsNullOrWhiteSpace(searchTerm))
                return user;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return user.Where(u => u.UserName!.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<Product> SearchProduct(this IQueryable<Product> product, string searchTerm)
        {
            if(string.IsNullOrWhiteSpace(searchTerm))
                return product;

            var lowerCase = searchTerm.Trim().ToLower();
            return product.Where(p=>p.ProductName!.ToLower().Contains(lowerCase));
        }
    }
}
