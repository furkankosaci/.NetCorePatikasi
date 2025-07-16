using System;

class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(0) Çıkış");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    phoneBook.AddContact();
                    break;
                case "2":
                    phoneBook.DeleteContact();
                    break;
                case "3":
                    phoneBook.UpdateContact();
                    break;
                case "4":
                    phoneBook.ListContacts();
                    break;
                case "5":
                    phoneBook.SearchContact();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                    break;
            }
        }
    }
}
