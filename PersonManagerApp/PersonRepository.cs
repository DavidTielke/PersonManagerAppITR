namespace PersonManagerApp;

public class PersonRepository
{
    private readonly FileReader _reader;
    private readonly PersonParser _parser;

    public PersonRepository()
    {
        _reader = new FileReader();
        _parser = new PersonParser();
    }

    public IQueryable<Person> Query()
    {
        var lines = _reader.ReadAllLines("data.csv");
        var persons = lines.Select(l => _parser.ParseFromCsv(l));
        return persons.AsQueryable();
    }
}