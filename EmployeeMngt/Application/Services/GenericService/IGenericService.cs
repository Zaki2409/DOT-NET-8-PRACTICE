namespace EmployeeMngt.Application.Services.GenericService
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAllS();
        T GetByIdS(object id);
        void InsertS(T obj);
        void UpdateS(T obj);
        void DeleteS(object id);
        void SaveS();
    }
}
