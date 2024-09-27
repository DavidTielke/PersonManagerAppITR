﻿namespace PersonManagerApp;

public class PersonParser
{
    public Person ParseFromCsv(string dataLine)
    {
        var parts = dataLine.Split(",");
        var person = new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2]),
        };
        return person;
    }
}