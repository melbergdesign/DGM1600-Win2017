using UnityEngine;
using System.Collections;

public class Add : MonoBehaviour {
    public int entry1;
    public int entry2;

    public void OnClick()
    {
        print (AddNums(4, 6));
        
    }

    //adding function
    public int AddNums(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }

	
}
