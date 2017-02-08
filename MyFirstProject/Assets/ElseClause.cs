using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseClause : MonoBehaviour {

    //If statements are only used to check things that are constant
    //if possibilities are more than 2, do NOT use an IF statement

    //Microsoft Vitual Academy
    //Codecademy

    public bool myBool; //defaults to false
    public string animal = "Dog";
    public string password;
    public bool userAgreement;

	// Use this for initialization
	void Start () {

        /*if (myBool)//if(parameters)
        {
            print(true);
        }
        else if(!myBool){
            print(false);
        }
        else //cannot exist without an if statement
        //if(!myBool) == bad practices
        //find shortest path to do the same thing
        {
            print(false);
        }*/



        /*if (animal == "Cat")
        {
            print("Cat");
        }
		//utterly absurd long if statement; learn to identify ridiculous code
        //else clause ties into the if statement. It all becomes one if statement
        else if(animal == "Fish")
        {
            print("Fish");
        }
        //copying and pasting code is a signal that you could create more elegant code
        //this code will check every single one of these items; this is gross!
        //switch statements and functions will fix this
        //never use the else if in this class
        else if (animal == "Bird")
        {
            print("Bird");
        }
        else if (animal == "Shark")
        {
            print("Shark");
        }*/

        if(password == "OU812" || userAgreement)//checking if two conditionals are correct
            //&& AND
            //|| OR
        {
            print("Correct");
        }
        else
        {
            print("Incorrect");
        }
        
    }
	
	
}
