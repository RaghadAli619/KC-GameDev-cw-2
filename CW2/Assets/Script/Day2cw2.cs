using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2cw2 : MonoBehaviour
{
    // Hero information
    string heroName = "Jay";
    float heroHeight = 180.5f +5.0f;
    int heroAge = 27;
    string heroSuperPower = "memory manipulation";
    void Start()
    {
        // Printing 
        print("There lived a town with crimes and distruction.The one responsible for all this is " + villainName + ".");
        print("He was huge and feared by everyone. His height was " + villainHeight + "cm.");
        print("Some believe he's 40 years old but he's actually only " + villainAge + " years old.");
        print("His super power is " + villainSuperPower + ". This is the most shocking information about William.");
        print("Then came the hero of this town " + heroName + ".");
        print("Jay is " + heroAge);
    
        print("He's also " + heroHeight + "cm tall.");
        print("Jay was able to defeat William thanks to his " + heroSuperPower + "super power bringing back peace to the town. The end.");
        int agedifference = villainAge - heroAge;
        print("Thei age difference was " + agedifference);
}

    // Villain information
    string villainName = "William";
    float villainHeight = 190.7f;
    int villainAge = 31;
    string villainSuperPower = "none";

    void Update()
    {
        
    }
   
}
