using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.DataAccess.Concrete;

public class IMCategoryDal : ICategoryDal
{
    List<Category> _categories;
    public IMCategoryDal()
    {
        _categories = new List<Category>
            {
                new Category{Id=1, Name = "Web/Masaüstü programlama"},
                new Category{Id=2, Name ="Mobil programlama"},
                new Category{Id=3, Name ="Oyun geliştirme"}
            };

    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }
    public void Delete(int categoryId)
    {
        _categories.Remove(_categories.SingleOrDefault(c => c.Id == categoryId));
    }
    public List<Category> GetAll()
    {
        return _categories.ToList();
    }
    public void Update(Category category)
    {
        Category updateCategory = _categories.SingleOrDefault(c => c.Id == category.Id);
        updateCategory.Name = category.Name;
    }
}
