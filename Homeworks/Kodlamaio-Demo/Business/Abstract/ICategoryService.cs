using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.Business.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();
    void Add(Category category);
    void Update(Category category);
    void Delete(int categoryId);
}
