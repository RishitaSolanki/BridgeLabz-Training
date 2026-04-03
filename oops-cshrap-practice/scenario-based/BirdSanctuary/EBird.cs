using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.BirdSanctuary
{
    public class EBird
    {
    public string NameOfBird { get; set; }
    public string SpecieOfBird { get; set; }

        //Constructor
    public EBird(string NameOfBird, string Species)
    {
        this.NameOfBird = NameOfBird;
        this.SpecieOfBird = Species;
    }

        //method to display info
    public void DisplayInfo()
    {
        Console.WriteLine("Name of the bird : " + NameOfBird + " and  species is  : " + SpecieOfBird);
    }
}

    }

