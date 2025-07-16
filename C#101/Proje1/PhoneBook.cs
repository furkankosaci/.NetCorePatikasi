using System;
using System.Collections.Generic;
using System.Linq;

public class PhoneBook
{
    private List<Contact> contacts;

    public PhoneBook()
    {
        contacts = new List<Contact>()
        {
            new Contact("Ali", "Yılmaz", "05551234567"),
            new Contact("Ayşe", "Demir", "05559876543"),
            new Contact("Mehmet", "Kaya", "05557654321"),
            new Contact("Zeynep", "Arslan", "05553456789"),
            new Contact("Ahmet", "Çelik", "05552345678")
        };
    }

    public void AddContact()
    {
        Console.Write("Lütfen isim giriniz             : ");
        string name = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          : ");
        string surname = Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz : ");
        string number = Console.ReadLine();

        contacts.Add(new Contact(name, surname, number));
        Console.WriteLine("Kayıt başarıyla eklendi!");
    }

    public void DeleteContact()
    {
        while (true)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine();

            var person = contacts.FirstOrDefault(c => c.FirstName.Equals(input, StringComparison.OrdinalIgnoreCase) || c.LastName.Equals(input, StringComparison.OrdinalIgnoreCase));
            if (person == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                var choice = Console.ReadLine();
                if (choice == "1") break;
                continue;
            }

            Console.WriteLine($"{person.FirstName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
            var confirm = Console.ReadLine();
            if (confirm.ToLower() == "y")
            {
                contacts.Remove(person);
                Console.WriteLine("Kişi silindi.");
            }
            else
            {
                Console.WriteLine("Silme işlemi iptal edildi.");
            }
            break;
        }
    }

    public void UpdateContact()
    {
        while (true)
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine();

            var person = contacts.FirstOrDefault(c => c.FirstName.Equals(input, StringComparison.OrdinalIgnoreCase) || c.LastName.Equals(input, StringComparison.OrdinalIgnoreCase));
            if (person == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");
                var choice = Console.ReadLine();
                if (choice == "1") break;
                continue;
            }

            Console.Write("Yeni telefon numarasını giriniz: ");
            string newNumber = Console.ReadLine();
            person.PhoneNumber = newNumber;
            Console.WriteLine("Numara başarıyla güncellendi.");
            break;
        }
    }

    public void ListContacts()
    {
        Console.WriteLine("Sıralama türünü seçin: (1) A-Z (2) Z-A");
        var order = Console.ReadLine();

        List<Contact> sortedList;
        if (order == "2")
            sortedList = contacts.OrderByDescending(c => c.FirstName).ToList();
        else
            sortedList = contacts.OrderBy(c => c.FirstName).ToList();

        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("**********************************************");
        foreach (var contact in sortedList)
        {
            Console.WriteLine(contact);
        }
    }

    public void SearchContact()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        var type = Console.ReadLine();

        Console.Write("Arama terimini giriniz: ");
        string search = Console.ReadLine();

        List<Contact> result = new();

        if (type == "1")
        {
            result = contacts.Where(c =>
                c.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                c.LastName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        else if (type == "2")
        {
            result = contacts.Where(c => c.PhoneNumber.Contains(search)).ToList();
        }

        Console.WriteLine("Arama Sonuçlarınız:");
        Console.WriteLine("**********************************************");
        foreach (var contact in result)
        {
            Console.WriteLine(contact);
        }

        if (result.Count == 0)
            Console.WriteLine("Sonuç bulunamadı.");
    }
}
