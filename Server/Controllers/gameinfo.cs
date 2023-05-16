using Microsoft.AspNetCore.Mvc;
using System;

public class PaintballPlayersController : ControllerBase
{
    private readonly list<Player> _players;

    public PaintballPlayersController()
    {
        // Initialize the list of players with some dummy data
        _players = new < Player > Get();
        {
            new Player { Id = 1, Name = "John", Age = 25, Gender = "Female", SkillLevel = "Intermediate" };
            new Player { Id = 2, Name = "Steve", Age = 30, Gender = "Male", SkillLevel = "Expert" };
            new Player { Id = 3, Name = "Chris", Age = 20, Gender = "Male", SkillLevel = "Beginner" };
            return _players;
        };
    }

    private bool Get()
    {
        throw new NotImplementedException();
    }

    internal class list<T>
{
}
}
