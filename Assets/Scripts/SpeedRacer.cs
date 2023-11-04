using UnityEngine;

// Well this was genuinely upsetting. It took me over two hours just to get 5 lines of text printed.
// I got lost for over half an hour just trying to figure out why the script wasn't appearing in the console.
// I tried looking at earlier scripts to no avail. 
// Turns out I just had to attach the script to a game object. That instruction came near the end.
// I thought I was being dumb (to be fair, I was) so I ended up using the cheat sheet to help me.
// It didn't solve my problem, but I was already looking at it, so I ended up using it quite a bit.
// I still don't understand a few things:
//      - How the heck does the calculate age thing work? I could use an in-depth walkthrough on how these functions work
//      - Why can't Visual Studio just tell me when I've forgotten a semi-colon?
//      - can I start an else function, then put an if statement within the braces? Instead of using elseif?
// I have other questions, but I'll try to get to them later. The above are the most pressing, I guess (or the ones at top of mind)


public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        print("The racer model is " + carModel + ". It has a " + engineType + ".");
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
            print("The car's maximum acceleration is" + maxAcceleration);
        }
        print(CheckCharacteristics());

    }




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
    // Update is called once per frame
    void Update()
    {
        
    }
}
