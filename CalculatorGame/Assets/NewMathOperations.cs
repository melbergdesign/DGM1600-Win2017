using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NewMathOperations : MonoBehaviour {

    //Just make it add the two entries
    
    public float sum;
    public float diff;
    public float product;
    public float quotient;

    public HoldList EntryList;
    public SolutionDisplay MySolDisplay;
    public Button thisButton;

    public void AddButtonClick()
    {
        sum = EntryList.myHoldList[0] + EntryList.myHoldList[1];
        
        print("The sum is " + sum);

        MySolDisplay.Solution.text = sum.ToString();

        //Set interactable to false
        thisButton.interactable = false;
    }

    public void SubtractButtonClick()
    {
        diff = EntryList.myHoldList[0] - EntryList.myHoldList[1];
        
        print("The difference is " + diff);

        MySolDisplay.Solution.text = diff.ToString();
        thisButton.interactable = false;
    }

    public void MultiplyButton()
    {
        product = EntryList.myHoldList[0] * EntryList.myHoldList[1];
        
        print("The product is " + product);

        MySolDisplay.Solution.text = product.ToString();
        thisButton.interactable = false;
    }

    public void DivideButton()
    {
        quotient = EntryList.myHoldList[0] / EntryList.myHoldList[1];

        print("The first entry is " + EntryList.myHoldList[0]);
        print("The second entry is " + EntryList.myHoldList[1]);

        print("The quotient is " + quotient);

        MySolDisplay.Solution.text = quotient.ToString();
        thisButton.interactable = false;

    }
}
