using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonManager
{
    private readonly PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
    }

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _repository
            .Query()
            .Where(p => p.Age >= 18);
        return adults;
    }

    public IQueryable<Person> GetAllChildren()
    {
        var children = _repository
            .Query()
            .Where(p => p.Age < 18);
        return children;
    }
}