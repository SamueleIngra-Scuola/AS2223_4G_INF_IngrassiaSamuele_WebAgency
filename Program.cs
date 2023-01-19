using Library;

Console.WriteLine("Prof;AS 22/23 4G;12/12/22; Gestione reparti");

// Department of Developer
Department r = new Department("Developer", 5, new Developer("Mario", "Rossi", "c#,javascript e typescript"));
r.AddEmployee(new Developer("Ernesto", "Sparalesto", "c#"));
r.AddEmployee(new Developer("Tizio", "Bacchini", "vb.net"));
r.AddEmployee(new Developer("Caio", "Cecchini", "Java"));
Console.WriteLine(
    $"Department {r.Name} " +
    $"Head of Department {r.HeadDepartment.Description()} " +
    $"employees {r.GetEmployees()}");

// Department of Administration
r = new Department("Administration", 5, new Developer("Primo", "Verdi", "javascript e typescript"));
r.AddEmployee(new Developer("Giulia", "Alberti", "c#"));
r.AddEmployee(new UserInterface("Sonia", "Pasquali", 5));
Console.WriteLine(
    $"Department {r.Name} " +
    $"Head of Department {r.HeadDepartment.Description()} " +
    $"employees {r.GetEmployees()}");