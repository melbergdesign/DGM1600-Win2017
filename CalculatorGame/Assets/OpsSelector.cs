using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpsSelector : MonoBehaviour {

    public EqualsButton equals;
    public Button thisButton;
    public TextEntry Entry1;
    public TextEntry Entry2;
    public HoldList EntryList;

    public void AddButtonClick()
    {
        equals.add = true;
        print(Entry1.numberEntry.text);
        EntryList.AddToList(float.Parse(Entry1.numberEntry.text));
        thisButton.interactable = false;
        Entry2.numberEntry2.interactable = true;
    }
}
