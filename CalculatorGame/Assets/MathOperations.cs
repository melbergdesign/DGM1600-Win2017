using UnityEngine;
using System.Collections;

public class MathOperations : MonoBehaviour {

    /*public bool mathAdd = false;
    public bool mathSub = false;
    public bool mathMult = false;
    public bool mathDiv = false;*/
    public int mathFunction;

    //public Operator myOperator;

    //switch statement that assigns the math operator used
    public void ButtonClick()
    {

        MathSelector();
        /*if(mathAdd = true)
        {
            print("Add");
        }
        else if(mathSub = true)
        {
            print("sub");
        }
        else if (mathMult = true)
        {
            print("Mult");
        }
        else if(mathDiv = true)
        {
            print("Div");
        }*/
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
