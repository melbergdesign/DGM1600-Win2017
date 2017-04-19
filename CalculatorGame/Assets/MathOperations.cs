using UnityEngine;
using System.Collections;

public class MathOperations : MonoBehaviour {

    //switch statement that assigns the math operator used

    public int mathFunction;
    
    
        
    public void ButtonClick()
    {

        MathSelector();
     }
    public void MathSelector()
    {
        switch (mathFunction)//changes depending on operator button selected
        {
            case 1://add
                print("add");
                break;

            case 2://subtract
                print("subtract");
                break;

            case 3://multiply
                print("multiply");
                break;

            case 4://divide
                print("divide");
                break;

            default:
                print("That is not a valid operation");
                break;
        }
    }
}
