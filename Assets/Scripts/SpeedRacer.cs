using UnityEngine;

// Well this was genuinely upsetting. It took me over two hours just to get 5 lines of text printed.
// I got lost for over half an hour just trying to figure out why the script wasn't appearing in the console.
// I tried looking at earlier scripts to no avail. 
// Turns out I just had to attach the script to a game object. That instruction came near the end.
// I thought I was being dumb (to be fair, I was) so I ended up using the cheat sheet to help me.
// It didn't solve my problem, but I was already looking at it, so I ended up using it quite a bit.
// I still don't understand a few things:
//      - How the heck does the calculate age thing work? I could use an in-depth walkthrough on how these functions work
// -----> Why can't Visual Studio just tell me when I've forgotten a semi-colon? <----------------------------------------------------------------
//      - can I start an else function, then put an if statement within the braces? Instead of using elseif?
// I have other questions, but I'll try to get to them later. The above are the most pressing, I guess (or the ones at top of mind)


public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    // Changes for A.04.2
    public string carMaker;

    // Public subclass for "fuel" from assignment 4.2
    // I don't understand the "amount" thing. Where were we supposed to have learned about this new thing?
    // It shows up in a different color. Why?

    public class Fuel
    {
        public int fuelLevel;
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    // I started to cheat here because I don't understand your instructions
    // Why did you say, "Back in the SpeedRacer class..." when we never left?
    // I was trying to move the previous public class Fuel thing out of the Speed Racer class... but then it wouldn't work at all
    // This is making me feel very stupid, but I think the Unity instruction is simply a failure
    // I understand maybe 10% of what the main instructor is trying to tell us
    // The information doesn't seem to apply to what we're doing here
    // I'm learning more from copying your code while following along with the instructions than I learned from any of the videos
    // So it goes...

    public Fuel carFuel = new Fuel(100);

    // Where did we get the "new" idea from?
    // I don't recall this being covered in class or the videos
    // I see it in your instructions, but I don't know what it does




    



    // Start is called before the first frame update
    void Start()
    {
        print("The racer model is " + carModel + " made by " + carMaker + ". It has a " + engineType + ".");
        CheckWeight();
        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade + ".");
            int carAge = CalculateAge(yearMade);
            print("The car is " + carAge + " years old.");
        }
        else
        {
            print("The car was introduced in the 2010's.");
            print("The car's maximum acceleration is " + maxAcceleration);
        }
        print(CheckCharacteristics());

    }


    // Update is called once per frame
    // I'm using this, original, update function instead of making my own. I hope that's okay.
    // If I made a second update function, would it break everything? Does update need to go after start?
    // Does everything need to go after start????
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
    
    // Starting the "consumeFuel" and "CheckFuelLevel" area (instructions marked as "Maniulating the Fuel Levels")
    
    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
        // so, I remember this from the videos, but I still don't understand how the dot operator works. I hope you'll explain this in class.
        // I hope you'll explain all of this in class
        // I hope that this class hasn't just been a waste of my time... I truly feel dumber now than I did two months ago
        // Is that the point?
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two-thirds.");
                break;
            case 50:
                print("Fuel level is at one-half.");
                break;
            case 10:
                print("Warning! Fuel level is critically low!");
                break;

            // Added a couple lines of code just to play around with the idea. 
            // I'm leaving them in to see if you notice :)

            case 0:
                print("You've run out of fuel!");
                break;
            case < 0:
                print("You can't run a car on no fuel.");
                break;

            // I am curious what sort of check you do on homework assignments... do you just see that a file was submitted?
            // Do you view the file?
            // Does it matter if we just copy and paste your work into our own?

            default:
                print("Nothing to report.");
                break;
                // I didn't copy and paste, but I certainly didn't do any of this work on my own. I'm lost and confused.
                // why do we include the "break" line? I don't remember this part of the video...
                // This is what I get for doing the coding a couple days after watching the videos...
                // TBF, the videos were just about worthless. And the one guy had the worst voice I think I've ever heard recorded.
                // Not the worst recorded voice... but certainly the worst voice that wasn't recorded as a joke or prank
                // I'm sure he's a very nice man. But he shouldn't be teaching. Or recording his voice teaching. 
                // He should work on his emphasis as well. If you emphasized every other word, no words have emphasis anymore...
                // Anyway, the code works now.
        }
    }

    /*
    void Update()
    {

    }
    bruh... there's already a void Update in this file... why did you ask us to make a new one? can there be more than one?
    */


    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The car weighs less than 1500kg.");
        }
        else
        {
            print("The car weighs more than 1500kg.");
        }
    }




    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }




    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car is a sedan.";
        }
        else if (hasFrontEngine)
        {
            return "The car is not a sedan, and it has a front engine.";
        }
        else
        {
            return "The car is not a sedan, and it does not have a front engine.";
        }
    }
}
