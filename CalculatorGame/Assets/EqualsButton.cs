using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EqualsButton : MonoBehaviour {
    public bool add;
    public bool subtract;
    public bool multiply;
    public bool divide;

    public HoldList EntryList;

    public float sum;
    public float diff;
    public float prod;
    public float quot;

    public TextEntry Entry1;
    public TextEntry Entry2;

    public SolutionDisplay mySolDisplay;

    public EnemyNumber firstEnemy;
    public EnemyNumber secondEnemy;
    public EnemyNumber thirdEnemy;
    public EnemyNumber fourthEnemy;

    public GameObject[] gos;

    public Text gameOver;

    public void OnClick()
    {
        EntryList.AddToList(float.Parse(Entry2.numberEntry2.text));

        if (add)
        {
            //print("Add");
            sum = EntryList.myHoldList[0] + EntryList.myHoldList[1];
            print(sum);
            mySolDisplay.Solution.text = sum.ToString();
            AnswerCheck();
            ResetEntries();
            Win();
            add = false;
        }
        if (subtract)
        {
            //print("subtract");
            diff = EntryList.myHoldList[0] - EntryList.myHoldList[1];
            print(diff);
            mySolDisplay.Solution.text = diff.ToString();
            AnswerCheck();
            ResetEntries();
            Win();
            subtract = false;
        }
        if (multiply)
        {
            //print("multiply");
            prod = EntryList.myHoldList[0] * EntryList.myHoldList[1];
            print(prod);
            mySolDisplay.Solution.text = prod.ToString();
            AnswerCheck();
            ResetEntries();
            Win();
            multiply = false;
        }
        if (divide)
        {
            //print("divide");
            quot = EntryList.myHoldList[0] / EntryList.myHoldList[1];
            print(quot);
            mySolDisplay.Solution.text = quot.ToString();
            AnswerCheck();
            ResetEntries();
            Win();
            divide = false;
        }
    }
    public void AnswerCheck()
    {
        firstEnemy.ValueCheck();
        secondEnemy.ValueCheck();
        thirdEnemy.ValueCheck();
        fourthEnemy.ValueCheck();
    }

    public void ResetEntries()
    {
        EntryList.ClearEntries();
        Entry1.numberEntry.text = null;
        Entry2.numberEntry2.text = null;
        Entry2.numberEntry2.interactable = false;
        Entry1.charList.Clear();
        Entry2.charList.Clear();
    }

    public void Win()
    {
        gos = GameObject.FindGameObjectsWithTag("Enemy");

        if (gos.Length == 1)
        {
            gameOver.text = "YOU WIN!";
            gameOver.enabled = true;
        }
    }
}
