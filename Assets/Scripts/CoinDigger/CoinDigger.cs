using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinDigger : MonoBehaviour
{
    public Text txt_Score;
    public Text txt_Warning;

    public Animator animClick;
    int score;

    public List<GameObject> time;
    public bool isNight = false;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    public void ButtonGoldOnClick()
    {
        if (isNight)
        {
            score++;
            txt_Score.text = score.ToString();
        }
        else
        {
            txt_Warning.gameObject.SetActive(true);
            txt_Warning.text = "You are so busted";
            Time.timeScale = 0f;
        }
    }
}
