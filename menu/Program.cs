using System;
using Employee.Classlibrary;
namespace Menu_ITI
{
	

	public struct EmployeeStruct
	{
		public int ID;
		public string Name;
		public float Salary;
		public Gender G;

		public void DisplayData()
		{
			Console.WriteLine($"ID: {ID}\nName: {Name}\nSalary: {Salary}\nGender: {G}\n----------------");
		}
	}

	

	internal class Program
	{
		static EmployeeStruct[] employeesStruct = new EmployeeStruct[3];
		static EmployeeClass[] employeesClass = new EmployeeClass[3];
		static int employeeCount = 0;
		static bool useStruct = true;

		static void Main(string[] args)
		{
			Console.WriteLine("Choose Implementation: 1 for Struct, 2 for Class");
			useStruct = Console.ReadLine() == "1";

			string[] Menu = { "New", "Display", "Exit" };
			int highlight = 0;
			bool looping = true;

			do
			{
				for (int i = 0; i < Menu.Length; i++)
				{
					Console.SetCursorPosition(60, 30 / (Menu.Length + 1) * (i + 1));
					Console.BackgroundColor = (i == highlight) ? ConsoleColor.White : ConsoleColor.Black;
					Console.ForegroundColor = (i == highlight) ? ConsoleColor.Black : ConsoleColor.White;
					Console.WriteLine(Menu[i]);
				}
				ConsoleKeyInfo cki = Console.ReadKey();
				switch (cki.Key)
				{
					case ConsoleKey.UpArrow:
						highlight = (highlight == 0) ? Menu.Length - 1 : highlight - 1;
						break;
					case ConsoleKey.DownArrow:
						highlight = (highlight == Menu.Length - 1) ? 0 : highlight + 1;
						break;
					case ConsoleKey.Enter:
						Console.Clear();
						if (highlight == 0)
						{
							if (useStruct)
								AddEmployee(GetEmployeeInputStruct());
							else
								AddEmployee(GetEmployeeInputClass());
						}
						else if (highlight == 1) DisplayEmployees();
						else looping = false;
						Console.Clear();
						break;
					case ConsoleKey.Home:
						highlight = 0;
						break;
					case ConsoleKey.End:
						highlight = Menu.Length - 1;
						break;
					case ConsoleKey.Escape:
						looping = false;
						break;
				}
			} while (looping);
		}

		static EmployeeStruct GetEmployeeInputStruct()
		{
			EmployeeStruct newEmployee;
			Console.WriteLine("Enter Employee ID:");
			newEmployee.ID = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Employee Name:");
			newEmployee.Name = Console.ReadLine();
			Console.WriteLine("Enter Employee Salary:");
			newEmployee.Salary = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter Gender (0 for Male, 1 for Female):");
			newEmployee.G = (Gender)int.Parse(Console.ReadLine());
			
			return newEmployee;
		}

		static EmployeeClass GetEmployeeInputClass()
		{
			EmployeeClass newEmployee = new EmployeeClass();
			Console.WriteLine("Enter Employee ID:");
			newEmployee.ID = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Employee Name:");
			newEmployee.Name = Console.ReadLine();
			Console.WriteLine("Enter Employee Salary:");
			newEmployee.Salary = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter Gender (0 for Male, 1 for Female):");
			newEmployee.G = (Gender)int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Age:");
			newEmployee.Age = int.Parse(Console.ReadLine());
			return newEmployee;
		}

		static void AddEmployee(EmployeeStruct newEmployee)
		{
			if (employeeCount >= 3)
			{
				Console.WriteLine("Maximum employees reached.");
				Console.ReadLine();
				return;
			}
			employeesStruct[employeeCount] = newEmployee;
			employeeCount++;
			Console.WriteLine("Employee added successfully!");
			Console.ReadLine();
		}

		static void AddEmployee(EmployeeClass newEmployee)
		{
			if (employeeCount >= 3)
			{
				Console.WriteLine("Maximum employees reached.");
				Console.ReadLine();
				return;
			}
			employeesClass[employeeCount] = newEmployee;
			employeeCount++;
			Console.WriteLine("Employee added successfully!");
			Console.ReadLine();
		}

		static void DisplayEmployees()
		{
			if (employeeCount == 0)
			{
				Console.WriteLine("No employee data available.");
			}
			else
			{
				Console.WriteLine("Employee Details:");
				for (int i = 0; i < employeeCount; i++)
				{
					if (useStruct)
						employeesStruct[i].DisplayData();
					else
						employeesClass[i].DisplayData();
				}
			}
			Console.ReadLine();
		}
	}
}
