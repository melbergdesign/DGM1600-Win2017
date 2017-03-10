using UnityEngine;
using System.Collections;

public class Notes : MonoBehaviour {
    //functions are resusable
    //able to debug easier because you divide code into chunks
    //functions that require inputs = parameters
    //void functions = set instructions that require no input and give no output
    int num1 = 5;
    int num2 = 3;

    void AddNumbers()//functions start with capitals;
    {
        //function code block
        int sum;//scope is limited to the AddNumbers();
        sum = num1 + num2;
        print(sum);
    }

	// Use this for initialization
	void Start () {
        AddNumbers();//runs (calls) function
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
