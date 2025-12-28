internal class Program
{
    static void Main(string[] args)
    {
        var teamMembers = SeedData.CreateTeamMembers();
        var board = SeedData.CreateBoard(teamMembers);

        MenuService.Start(board, teamMembers);
    }

}