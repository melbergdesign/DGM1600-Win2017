using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour {

	//public string color;
	//limit the possiblities with a constant value enum; tiny chunks of data that allows you to change gameplay
	public enum ColorsChoices {RED, GREEN, BLUE};
	//Colors is now an object, creating an instance of Colors
	public ColorsChoices playerColor;

	public enum GameStates//prettier and easier to read
	{
		LOADING,
		STARTING,
		PLAYING,
		ENDING
	}
	//need a variable to load the enum

	public GameStates currentGameState = GameStates.LOADING;//this is how the gamestate starts

	// Use this for initialization
	void Start () {

		switch (playerColor) {//checks for more than two things

		case ColorsChoices.GREEN:
			print ("This gives access to all weapons");
			break;//does not check every single option, stops once it finds an answer that resolves
			//the fastest code is the code that never runs

		case ColorsChoices.RED:
			print ("This gives access to all power ups");
			break;

		case ColorsChoices.BLUE:
			print ("Just dies");
			break;

		default:
			print (playerColor);
			break;
		}//everything is about making your code smaller
	
	}
	

}
