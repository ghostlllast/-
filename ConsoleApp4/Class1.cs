using System;
using System.Collections.Generic;

// Класс, описывающий резервуар
public class Reservoir
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Department { get; set; }
    public string Factory { get; set; }
}

// Класс, описывающий установку
public class Installation
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Capacity { get; set; }
    public string Factory { get; set; }
}

// Класс, описывающий завод
public class Plant
{
    public string Name { get; set; }
    public string Location { get; set; }
}

