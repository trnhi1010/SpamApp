using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinDigger : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject gameOverPanel;
    public GameObject gamePanel;

    public Text txt_Score;
    public Text txt_Warning;

    public Image img_Guard;
    public Image img_busted;

    public Animator animClick;
    int score;

    public List<GameObject> timeList;
    public bool isNight;

    private void Start()
    {
        animClick.StopPlayback();
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
            gameOverPanel.SetActive(true);
            txt_Warning.text = "You are so busted";
            img_busted.gameObject.SetActive(true);
            img_Guard.gameObject.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    void SwitchTime()
    {
        int n = Random.Range(0, 2);
        Debug.Log(n);
        switch(n)
        {
            case 0:
                timeList[0].SetActive(true);
                timeList[1].SetActive(false);
                img_Guard.gameObject.SetActive(true);
                isNight = false;
                break;
            case 1:
                timeList[0].SetActive(false);
                timeList[1].SetActive(true);
                img_Guard.gameObject.SetActive(false);
                isNight = true;
                animClick.SetTrigger("Night");
                break;
        }
    }

    public void Play()
    {
        gameOverPanel.SetActive(false);
        gamePanel.SetActive(true);
        menuPanel.SetActive(false);
        SwitchTime();
        InvokeRepeating("SwitchTime", 2f, 2f);
    }

    public void Home()
    {
        foreach (var item in timeList)
        {
            item.SetActive(false);
        }
        CancelInvoke("SwitchTime");
        gameOverPanel.SetActive(false);
        gamePanel.SetActive(false);
        menuPanel.SetActive(true);


    }   
    public void Replay()
    {
        img_busted.gameObject.SetActive(false);
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
        score = 0;
        txt_Score.text = score.ToString();
    }
}
