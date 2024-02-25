using KodlamaioDemo.Business.Abstract;
using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.Business.Concrete;

public class CategoryService : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryService(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }
    public void Delete(int categoryId)
    {
        _categoryDal.Delete(categoryId);
    }
    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }
    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
