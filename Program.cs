/*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
*/

using exercicioListas;
using System.Globalization;

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for(int i = 1; i <= n; i++)
{
    Console.WriteLine("Employee #" + i + " :");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employees.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter de employee id that will have salary increase: ");
int idSearch = int.Parse(Console.ReadLine());

Employee emp = employees.Find(x => x.Id == idSearch);
if(emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}



Console.WriteLine("Update");
foreach(Employee obj in employees)
{
    Console.WriteLine(obj);
}