using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberManager : MonoBehaviour
{
    public Text txtAlert;
    public InputField inputNumber;

    int rightNum;
    private void Start()
    {
        RestartGame();
        txtAlert.text = "CHOOSE A NUMBER FROM 1 TO 100";

    }

    public void Update()
    {
        if(inputNumber.text != "")
        {
            CheckWin();
        }
    }

    private void CheckWin()
    {
        if(int.Parse(inputNumber.text) ==  rightNum)
        {
            txtAlert.color = Color.red;
            txtAlert.text = "AMAZING IT'S " + rightNum;
            Invoke(nameof(RestartGame), 2f);
        }
        if (int.Parse(inputNumber.text) > rightNum)
        {
            txtAlert.color = Color.grey;
            txtAlert.text = "The right number is smaller";

        }
        if (int.Parse(inputNumber.text) < rightNum)
        {
            txtAlert.color = Color.black;
            txtAlert.text = "The right number is larger";

        }
    }

    void RestartGame()
    {
        rightNum = Random.Range(1, 100);
        Debug.Log(rightNum);
        txtAlert.text = "NEW GAME";
        inputNumber.text = "";
    }
}
