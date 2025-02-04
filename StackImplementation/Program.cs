namespace StackImplementation
{
	 public class Stack
    {
        private int[] data;
        private int top;
        public int Size { get; }

        public Stack(int size)
        {
            Size = size;
            data = new int[size];
            top = -1;
        }

        public void Push(int value)
        {
            if (top >= Size - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            data[++top] = value;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            return data[top--];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(data[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            int choice;
            
            do
            {
                Console.WriteLine("\nStack Operations:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to push: ");
                        int value = int.Parse(Console.ReadLine());
                        stack.Push(value);
                        break;
                    case 2:
                        Console.WriteLine("Popped item: " + stack.Pop());
                        break;
                    case 3:
                        Console.WriteLine("Stack contents:");
                        stack.Display();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
