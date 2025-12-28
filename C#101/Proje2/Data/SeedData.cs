public static class SeedData
{
    public static Dictionary<int, Person> CreateTeamMembers()
    {
        return new Dictionary<int, Person>
        {
            {1, new Person(1, "Ali")},
            {2, new Person(2, "Ayşe")},
            {3, new Person(3, "Can")}
        };
    }

    public static Board CreateBoard(Dictionary<int, Person> teamMembers)
    {
        Board board = new Board();

        board.TodoLine.Add(
            new Card(
                "Veritabanı Tasarımı",
                "SQL tabloları oluşturulacak",
                teamMembers[1],
                CardSize.M
            )
        );

        board.InProgressLine.Add(
            new Card(
                "Arayüz Çizimi",
                "Figma ile tasarım yapılacak",
                teamMembers[2],
                CardSize.S
            )
        );

        board.DoneLine.Add(
            new Card(
                "API Geliştirme",
                "Login endpoint yazılacak",
                teamMembers[3],
                CardSize.L
            )
        );

        return board;
    }
}