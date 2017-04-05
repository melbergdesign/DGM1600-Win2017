using UnityEngine;
using System.Collections;

public class Add : MonoBehaviour {
    public float entry1;
    public float entry2;

    public void OnClick()
    {
        print(AddNums(entry1, entry2));
        
    }

    //adding function
    public float AddNums(float num1, float num2)
    {
        float sum = num1 + num2;
        return sum;
    }

	
}
