class Menu
{
    private List<string> mainMenu, createGoalMenu;
    public Menu()
    {
        mainMenu = new List<string>
        {
            "Menu Options",
            "   1. Create New Goal",
            "   2. List Goals",
            "   3. Save Goals",
            "   4. Load Goals",
            "   5. Record Event",
            "   6. Quit"
        };
        
        createGoalMenu = new List<string>
        {
            "The types of Goals are:",
            "   1. Simple Goal",
            "   2. Eternal Goal",
            "   3. Checklist Goal"
        };
    }
    public int DisplayGetMainMenu()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
    public int DisplayGetCreateNewGoalMenu()
    {
        Console.WriteLine();
        foreach (string menuItem in createGoalMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a Choice from the menu: ");
        return int.Parse(Console.ReadLine());
        }
}