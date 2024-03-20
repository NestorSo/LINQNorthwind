
using TableEmployees.Data;
using TableEmployees.Models;

List<Employee> Employees = new List<Employee>(); //Supongamos que esta función devuelve una lista de objetos de la clase Persona.



using (var context = new NorthwindContext())
{

    var personasEnMadrid = Employees.Where(p => p.Ciudad == "Madrid");
    foreach (var Employee in EmployeeTitle)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}, Ciudad: {persona.Ciudad}");
    }
}
