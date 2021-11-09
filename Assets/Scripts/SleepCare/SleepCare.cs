using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepCare : MonoBehaviour
{
    public GameObject background;
    public GameObject panel_Title;
    public GameObject panel_Setting;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    public GameObject btnBack;
    public GameObject btnNext;
    public GameObject btnPlay;
    public GameObject btnHome;

    int count;

    private void Start()
    {
        background.SetActive(true);
        panel_Title.SetActive(true);
        panel_Setting.SetActive(false);
    }

    public void StartButton()
    {
        panel_Title.SetActive(false);
        panel_Setting.SetActive(true);
        panel1.SetActive(true);
        btnNext.SetActive(true);
    }    

    public void NextButton()
    {
        count++;
        switch (count)
        {
            case 1:
                btnBack.SetActive(true);
                panel1.SetActive(false);
                panel2.SetActive(true);
                break;
            case 2:
                btnBack.SetActive(false);
                btnNext.SetActive(false);
                btnPlay.SetActive(true);
                break;
        }
    }

    public void PlayButton()
    {
        btnPlay.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        btnHome.SetActive(true);
    }
    public void BackButton()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        btnBack.SetActive(false);
        count--;
    }

    public void HomeButton()
    {
        panel_Title.SetActive(true);
        panel_Setting.SetActive(false);
        btnHome.SetActive(false);
        count = 0;
    }

    public void Exit()
    {
        Application.Quit();
    }
}

