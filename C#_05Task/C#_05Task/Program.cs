using C__05Task;

class Program
{
    static void Main(string[] args)
    {
        Department dept = new Department(1, "Engineering");
        Club club = new Club("Zohor Sports Club");

        SalesPerson sp = new SalesPerson { EmployeeID = 401, BirthDate = new DateTime(1985, 6, 15), vacationStock = 5, AchievedTarget = 150 };
        BoardMember bm = new BoardMember { EmployeeID = 501, BirthDate = new DateTime(1955, 8, 10), vacationStock = 10 };

        dept.AddStaff(sp);
        club.AddMember(sp);

        dept.AddStaff(bm);
        club.AddMember(bm);

        // Trigger layoff conditions
        sp.vacationStock = 0; // UnderStock
        bm.BirthDate = new DateTime(1955, 8, 10); // OverAge

        // SalesPerson target check
        Console.WriteLine($"SalesPerson met target: {sp.CheckTarget(100)}");

        // BoardMember resigns
        bm.Resign();
    }
}
