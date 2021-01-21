using System;


#region Task 1 
/*
    Создать класс с именем Address.
    В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого
    поля, создать свойство с двумя методами доступа.
    Создать экземпляр класса Address.
    В поля экземпляра записать информацию о почтовом адресе.
    Выведите на экран значения полей, описывающих адрес.
*/
#endregion

namespace ElemetaryStage
{
    public class Address
    {
        string index;
        string country;
        string city;
        string street;
        string house;
        string apartment;

        public string Index
        {
            get => index;
            set => index = value;
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Street
        {
            get => street;
            set => street = value;
        }

        public string House
        {
            get => house;
            set => house = value;
        }

        public string Apartment
        {
            get => apartment;
            set => apartment = value;
        }

        public override string ToString()
        {
            return $"i: {Index}\ncountry: {Country}\ncity: {City}\naddress: {Street}, {House}, {Apartment}";
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Address address = new Address
            {
                Index = "31110",
                Country = "Ukraine",
                City = "Kiev",
                Street = "Vossoedineniya",
                House = "101",
                Apartment = "20"
            };

            Console.WriteLine("My address: ");
            Console.WriteLine(address);

            Console.ReadLine();
        }
    }
}
