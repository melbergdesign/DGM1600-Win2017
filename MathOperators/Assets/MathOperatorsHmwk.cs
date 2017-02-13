using UnityEngine;
using System.Collections;

public class MathOperatorsHmwk : MonoBehaviour {
	//Math Operators perform basic math functions within the program
	public int firstInt = 5;
	public int secondInt = 4;
	public int thirdInt = 2;

	//operators can be performed when assigning a value
	public int firstSum = 10+5;

	public int firstEquation;
	public int secondEquation;
	public int thirdEquation;


	// Use this for initialization
	void Start () {
		print (firstSum);

		//addition
		print (firstInt + secondInt);

		//subtraction
		print (firstInt - secondInt);

		//multiplication
		print (firstInt*secondInt);

		//division
		print (secondInt / thirdInt);

		//This operator. Modulus, will perform the division, but return the remainder in the form of a whole number
		print (firstInt % thirdInt);

		//Math operators are affected by precedence (aka PEDMAS) therefore
			firstEquation = (thirdInt+secondInt*firstInt);
		print(firstEquation);
		//will have a different result from
		secondEquation = (firstInt*thirdInt+secondInt);
		print (secondEquation);

		//You can show priority within an equation by using ()
		thirdEquation = firstInt * (thirdInt+secondInt);
		print (thirdEquation);
	}
}
