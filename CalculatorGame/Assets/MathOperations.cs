using UnityEngine;
using System.Collections;

public class MathOperations : MonoBehaviour {

    //switch statement that assigns the math operator used

    public int mathFunction;

    //public float[] numberArray = new float[2];//change to list

    public HoldList mathList;
    public float answer;//answer does not last outside of switch
    public string solution;
        
    public void ButtonClick()
    {
        MathSelector();
        print ("The answer is " + answer);
        solution = answer.ToString();
        print("The solution is " + solution);
     }
    public void MathSelector()
    {
        switch (mathFunction)//changes depending on operator button selected
        {
            case 1://add
                //print("add");
                answer = mathList.myHoldList[0] + mathList.myHoldList[1];
                //print("The sum is " + answer);
                break;

            case 2://subtract
                //print("subtract");
                answer = mathList.myHoldList[0] - mathList.myHoldList[1];
                //print("The difference is " + answer);
                break;

            case 3://multiply
                //print("multiply");
                answer = mathList.myHoldList[0] * mathList.myHoldList[1];
                //print("The product is " + answer);
                break;

            case 4://divide
                //print("divide");
                answer = mathList.myHoldList[0] / mathList.myHoldList[1];
                //print("The quotient is " + answer);
                break;

            /*case 5:
                print(answer);
                break;*/

            default:
                print("That is not a valid operation");
                break;
        }
    }
}
