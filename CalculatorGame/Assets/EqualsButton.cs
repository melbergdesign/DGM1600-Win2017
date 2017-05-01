using UnityEngine;
using System.Collections;

public class EqualsButton : MonoBehaviour {
    public bool add;
    public bool subtract;
    public bool multiply;
    public bool divide;

    public HoldList EntryList;

    public TextEntry Entry2;

	public void OnClick()
    {
        EntryList.AddToList(float.Parse(Entry2.numberEntry2.text));

        if (add)
        {
            print("Add");
            add = false;
        }
        if (subtract)
        {
            print("subtract");
            subtract = false;
        }
        if (multiply)
        {
            print("multiply");
            multiply = false;
        }
        if (divide)
        {
            print("divide");
            divide = false;
        }
    }
}
