using System.Reflection;

namespace Employee.Classlibrary
{

	public enum Gender { Male, Female }
	public class EmployeeClass
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public float Salary { get; set; }
		public Gender G { get; set; }
		public int Age { get; set; }

		public void DisplayData()
		{
			Console.WriteLine($"ID: {ID}\nName: {Name}\nSalary: {Salary}\nGender: {G}\nAge: {Age}\n----------------");
		}
	}
}
