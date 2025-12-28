public class Board
{
    public List<Card> TodoLine { get; set; }
    public List<Card> InProgressLine { get; set; }
    public List<Card> DoneLine { get; set; }

    public Board()
    {
        TodoLine = new List<Card>();
        InProgressLine = new List<Card>();
        DoneLine = new List<Card>();
    }
}