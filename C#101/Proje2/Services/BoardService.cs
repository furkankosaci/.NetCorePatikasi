public static class BoardService
{
    public static void ListBoard(Board board)
    {
        Console.Clear();

        PrintLine("TODO Line", board.TodoLine);
        PrintLine("IN PROGRESS Line", board.InProgressLine);
        PrintLine("DONE Line", board.DoneLine);
    }

    private static void PrintLine(string title, List<Card> cards)
    {
        Console.WriteLine(title);
        Console.WriteLine("************************");

        if (cards.Count == 0)
        {
            Console.WriteLine("~ BOŞ ~\n");
            return;
        }

        foreach (var card in cards)
        {
            Console.WriteLine(card);
            Console.WriteLine("-");
        }

        Console.WriteLine();
    }

    public static void AddCard(Board board, Dictionary<int, Person> teamMembers)
    {
        Console.Clear();

        Console.Write("Başlık Giriniz: ");
        string title = Console.ReadLine();

        Console.Write("İçerik Giriniz: ");
        string content = Console.ReadLine();

        CardSize size;
        if (!TryGetCardSize(out size))
        {
            Console.WriteLine("Hatalı büyüklük seçimi!");
            return;
        }

        Person person;
        if (!TryGetPerson(teamMembers, out person))
        {
            Console.WriteLine("Hatalı girişler yaptınız!");
            return;
        }

        Card newCard = new Card(title, content, person, size);
        board.TodoLine.Add(newCard);

        Console.WriteLine("\nKart başarıyla eklendi!");
    }

    private static bool TryGetCardSize(out CardSize size)
    {
        Console.Write("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int value) &&
            Enum.IsDefined(typeof(CardSize), value))
        {
            size = (CardSize)value;
            return true;
        }

        size = default;
        return false;
    }

    private static bool TryGetPerson(
        Dictionary<int, Person> teamMembers,
        out Person person)
    {
        Console.Write("Kişi Seçiniz (ID): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int id) &&
            teamMembers.TryGetValue(id, out person))
        {
            return true;
        }

        person = null;
        return false;
    }

    public static void DeleteCard(Board board)
    {
        Console.Clear();
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.Write("Lütfen kart başlığını yazınız: ");
        string title = Console.ReadLine();

        bool isDeleted = TryDeleteFromAllLines(board, title);

        if (!isDeleted)
        {
            HandleCardNotFound(() => DeleteCard(board));
            return;
        }

        Console.WriteLine("\nKart(lar) başarıyla silindi.");
    }

    private static bool TryDeleteFromAllLines(Board board, string title)
    {
        int deletedCount = 0;

        deletedCount += board.TodoLine.RemoveAll(c => c.Title == title);
        deletedCount += board.InProgressLine.RemoveAll(c => c.Title == title);
        deletedCount += board.DoneLine.RemoveAll(c => c.Title == title);

        return deletedCount > 0;
    }

    private static void HandleCardNotFound(Action retryAction)
    {
        Console.WriteLine("\nAradığınız kriterlere uygun kart board'da bulunamadı.");
        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");

        string choice = Console.ReadLine();

        if (choice == "2")
        {
            retryAction();
        }
    }

    public static void MoveCard(Board board)
    {
        Console.Clear();
        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        Console.Write("Lütfen kart başlığını yazınız: ");
        string title = Console.ReadLine();

        if (!TryFindCard(board, title, out Card card, out List<Card> currentLine, out string lineName))
        {
            HandleMoveCardNotFound(() => MoveCard(board));
            return;
        }

        Console.WriteLine("\nBulunan Kart Bilgileri:");
        Console.WriteLine("**************************************");
        Console.WriteLine(card);
        Console.WriteLine($"Line : {lineName}");

        Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz:");
        Console.WriteLine("(1) TODO");
        Console.WriteLine("(2) IN PROGRESS");
        Console.WriteLine("(3) DONE");

        string input = Console.ReadLine();

        if (!TryMoveCard(board, card, currentLine, input))
        {
            Console.WriteLine("Hatalı bir seçim yaptınız!");
            return;
        }

        Console.WriteLine("\nKart başarıyla taşındı.\n");
        ListBoard(board);
    }

    private static bool TryFindCard(
    Board board,
    string title,
    out Card foundCard,
    out List<Card> currentLine,
    out string lineName)
    {
        foundCard = board.TodoLine.FirstOrDefault(c => c.Title == title);
        if (foundCard != null)
        {
            currentLine = board.TodoLine;
            lineName = "TODO";
            return true;
        }

        foundCard = board.InProgressLine.FirstOrDefault(c => c.Title == title);
        if (foundCard != null)
        {
            currentLine = board.InProgressLine;
            lineName = "IN PROGRESS";
            return true;
        }

        foundCard = board.DoneLine.FirstOrDefault(c => c.Title == title);
        if (foundCard != null)
        {
            currentLine = board.DoneLine;
            lineName = "DONE";
            return true;
        }

        currentLine = null;
        lineName = null;
        return false;
    }

    private static bool TryMoveCard(
    Board board,
    Card card,
    List<Card> currentLine,
    string input)
    {
        currentLine.Remove(card);

        switch (input)
        {
            case "1":
                board.TodoLine.Add(card);
                break;
            case "2":
                board.InProgressLine.Add(card);
                break;
            case "3":
                board.DoneLine.Add(card);
                break;
            default:
                currentLine.Add(card); // geri al
                return false;
        }

        return true;
    }

    private static void HandleMoveCardNotFound(Action retryAction)
    {
        Console.WriteLine("\nAradığınız kriterlere uygun kart board'da bulunamadı.");
        Console.WriteLine("* İşlemi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");

        string choice = Console.ReadLine();

        if (choice == "2")
        {
            retryAction();
        }
    }

}
