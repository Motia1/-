using System;

public class Customer : IComparable<Customer>
{
    private static int nextId = 1; // Статическое поле для генерации уникальных ID

    public int Id { get; } // Поле только для чтения
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Address { get; set; }
    public string CreditCardNumber { get; set; }
    public decimal Balance { get; set; }

    public Customer()
    {
        Id = nextId++; // Генерация уникального ID
    }

    public Customer(string lastName, string firstName, string middleName, string address, string creditCardNumber, decimal balance)
        : this()
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        Address = address;
        CreditCardNumber = creditCardNumber;
        Balance = balance;
    }

    public static int NumberOfCustomers { get; private set; } = 0; // Статическое поле для подсчета созданных объектов

    static Customer()
    {
        Console.WriteLine("Статический конструктор класса Customer вызван.");
    }

    public static void DisplayInfo()
    {
        Console.WriteLine($"Всего создано {NumberOfCustomers} объектов класса Customer.");
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName} {MiddleName} (ID: {Id})";
    }

    public int CompareTo(Customer other)
    {
        // Сравнение покупателей по фамилии, имени и отчеству
        int result = LastName.CompareTo(other.LastName);
        if (result == 0)
        {
            result = FirstName.CompareTo(other.FirstName);
            if (result == 0)
            {
                result = MiddleName.CompareTo(other.MiddleName);
            }
        }
        return result;
    }

    public override bool Equals(object obj)
    {
        if (obj is Customer other)
        {
            return Id == other.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Иванов", "Иван", "Иванович", "Москва", "1234-5678-9012-3456", 1000);
        Customer customer2 = new Customer("Петров", "Петр", "Петрович", "Санкт-Петербург", "5678-9012-3456-7890", 1500);
        Customer customer3 = new Customer("Сидоров", "Сидор", "Сидорович", "Новосибирск", "9876-5432-1098-7654", 800);

        Customer[] customers = { customer1, customer2, customer3 };

        Console.WriteLine("Список покупателей в алфавитном порядке:");
        Array.Sort(customers);
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer);

        }

        Console.WriteLine("\nСписок покупателей с номерами кредитных карт в заданном интервале:");
        string minCardNumber = "2000-0000-0000-0000";
        string maxCardNumber = "9000-0000-0000-0000";
        foreach (Customer customer in customers)
        {
            if (String.Compare(customer.CreditCardNumber, minCardNumber) >= 0 &&
                String.Compare(customer.CreditCardNumber, maxCardNumber) <= 0)
            {
                Console.WriteLine(customer);
            }
        }

        Customer.DisplayInfo(); // Вывод информации о количестве созданных объектов
    }
}
