public static class MenuService
{
    public static void Start(Board board, Dictionary<int, Person> teamMembers)
    {
        bool isRunning = true;

        while (isRunning)
        {
            ShowMenu();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BoardService.ListBoard(board);
                    break;
                case "2":
                    BoardService.AddCard(board, teamMembers);
                    break;
                case "3":
                    BoardService.DeleteCard(board);
                    break;
                case "4":
                    BoardService.MoveCard(board);
                    break;
                case "0":
                    isRunning = false;
                    break;
            }
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
        Console.WriteLine("******************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart Eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");
        Console.WriteLine("(4) Kart Taşımak");
        Console.WriteLine("(0) Çıkış");
    }
}
