public class Card
{
    public string Title { get; set; }
    public string Content { get; set; }
    public Person AssignedPerson { get; set; }
    public CardSize Size { get; set; }

    public Card(string title, string content, Person assignedPerson, CardSize size)
    {
        Title = title;
        Content = content;
        AssignedPerson = assignedPerson;
        Size = size;
    }

    public override string ToString()
    {
        return $"Başlık      : {Title}\n" +
               $"İçerik      : {Content}\n" +
               $"Atanan Kişi : {AssignedPerson}\n" +
               $"Büyüklük    : {Size}\n";

    }
}