using KodlamaioDemo.Entities.Concrete;
namespace KodlamaioDemo.DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Delete(int categoryId);
    void Update(Category category);
}
