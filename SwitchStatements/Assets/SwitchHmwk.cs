using UnityEngine;
using System.Collections;

public class SwitchHmwk : MonoBehaviour {
	//a switch statement can be used to quickly check for certain states
	//it is recommended for three or more options, as an if statement will suffice for 2 or less options

	public int skillPoints = 3;

	//use an Enum to create a unique data type; name is capitalized b/c it acts similar to a new class type

	public enum BeverageType
	{
		Water,
		Juice,
		Soda,
		Alcohol,
		Coffee
	}
	//you can declare the value 'array' either in line or in a top-down list like above. Both work, it is merely a matter of readability
	public BeverageType yourDrink = BeverageType.Coffee;

	// Use this for initialization
	void Start () {
		switch (skillPoints) {
			case 1:
				print ("Enough for Jump");
				break;

			case 2:
				print ("Enough for Duck");
				break;
		case 3:
			print ("Enough for Double Jump");
			break;

		case 4:
			print ("Enough for another heart container");
			break;

		default:
			print ("You need more points");
			break;
		}

		switch (yourDrink) {

		case BeverageType.Water:
			print ("Quenching.");
			break;

		case BeverageType.Juice:
			print ("Are you 5?");
			break;

		case BeverageType.Soda:
			print ("Ooh, bubbles.");
			break;

		case BeverageType.Coffee:
			print ("You'll stunt your growth, kid.");
			break;

		case BeverageType.Alcohol:
			print ("I'm gonna need to see some ID.");
			break;

		default:
			print ("This vending machine doesn't have that.");
			break;
		}

	}
	
}
