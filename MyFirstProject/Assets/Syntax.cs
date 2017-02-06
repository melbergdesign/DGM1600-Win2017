using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour {
    //classes do not accept parameters
    //variables are changeable pieces of data
    //strictly typed data = must declare type of data (Unity prefers floats over doubles)

    public string myString = "Hello World";
    public string myOtherString = "1";
    //strings requires "" for data
    //variables start with lowercase camelcase (convention) = identifier; 
    //one word identifier (syntax); cannot begin with a number;
    public int myInt = 1;
    public float myFloat = 1.0f;
    //floats require a f at the end of the number
    //if you don't need a float, use an int
    //doubles are not okay in unity
    public bool myBool = false;
    //bools default to false in C#

    // Use this for initialization
    //functions accept parameters
    void Start () {
        //always end single lines with a semicolon
        //identifiers generally start with Uppercase camelcase
        print("Hello World");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
