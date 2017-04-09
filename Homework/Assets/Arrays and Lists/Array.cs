using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour {
    //an array has a set number of items contained
    public string[] groceryArray = new string[5];//creates a new array called groceryArray that can hold 5 items

    //an array can have the items set when it is initialized
    public int[] lottoNums = { 18, 24, 3, 29, 7};//do not need to specify the length of the array b/c it 

	// Use this for initialization
	void Start () {
        //set each item in the array manually
        groceryArray[0] = "milk"; //arrays count beginning with 0
        groceryArray[1] = "bread";
        groceryArray[2] = "eggs";
        groceryArray[3] = "cheese";
        groceryArray[4] = "apples";
        //groceryArray[5] = "steak"; this is the 6th item, not valid

        //a foreach loop is used to perform an action on each item in an array
        foreach (string item in groceryArray){
            print(item);
        }

        print("The winning lotto numbers are...");
        foreach (int num in lottoNums) {
            print(num);
        }
	}

    public void OnClick()
    {
        //groceryArray[5].Add("steak");
    }
	
	
}
