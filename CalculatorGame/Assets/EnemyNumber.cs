using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyNumber : MonoBehaviour {

    public float enemy;
    public Text enemyText;
    public string enemyDisplay;

    public NewMathOperations Add;
    public NewMathOperations Subtract;
    public NewMathOperations Multiply;
    public NewMathOperations Divide;

    public GameObject thisObject;

	// Use this for initialization
	void Start () {
        enemy = Random.Range(0, 99);
        print("Enemy is " + enemy);
        enemyDisplay = enemy.ToString();
        enemyText.text = enemyDisplay;
	}

    public void ValueCheck()
    {
        if (enemy == Add.sum || enemy == Subtract.diff || enemy == Multiply.product || enemy == Divide.quotient)
        {
            Destroy(thisObject);
        }
    }
    void Update()
    {
        //thisObject.transform.Translate(0,-0.3f,0);
    }

}
