using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyNumber : MonoBehaviour {

    public float enemy;
    public Text enemyText;
    public string enemyDisplay;

    public EqualsButton equals;

    public GameObject thisObject;

    

    

    // Use this for initialization
    void Start () {

        enemy = Random.Range(1, 20);
        print("Enemy is " + enemy);
        enemyDisplay = enemy.ToString();
        enemyText.text = enemyDisplay;
	}

    public void ValueCheck()
    {
        if (enemy == equals.sum || enemy == equals.diff || enemy == equals.prod || enemy == equals.quot)
        {
            Destroy(thisObject);

                     
        }
    }

}
