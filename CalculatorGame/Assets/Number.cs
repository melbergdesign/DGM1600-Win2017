using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class Number : MonoBehaviour {

    //number buttons

	public int numButton;
    public string entry;

    public TextEntry numEntry;
    public TextEntry num2Entry;

    public HoldList NumberList;

    
	public void OnClick()
    {
        if (num2Entry.numberEntry2.interactable)
        {
            AddToEntry2();
        }
        else
        {
            AddToEntry1();
        }
    }
    public void AddToEntry1()
    {
        print(numButton);


        numEntry.charList.Add(numButton);

        StringBuilder builder = new StringBuilder();

        foreach (int i in numEntry.charList)
        {
            //print(i);
            builder.Append(i);
        }
        entry = builder.ToString();
        //print(entry);
        numEntry.numberEntry.text = entry;
    }

	public void AddToEntry2()
    {
        print(numButton);


        num2Entry.charList.Add(numButton);

        StringBuilder builder = new StringBuilder();

        foreach (int i in num2Entry.charList)
        {
            //print(i);
            builder.Append(i);
        }
        entry = builder.ToString();
        num2Entry.numberEntry2.text = entry;
    }
}
