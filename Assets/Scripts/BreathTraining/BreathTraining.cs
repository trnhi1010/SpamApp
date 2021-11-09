using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BreathTraining : MonoBehaviour
{
    public AudioSource backgroundAudio;
    public GameObject button_SoundOn;
    public GameObject button_SoundOff;

    public GameObject panel_Start;
    public GameObject panel_Breath;
    public GameObject panel_Info;

    public float timeValue = 300f;
    public Text txt_Timer;

    bool isPlay = false;

    private void Update()
    {
        if (isPlay)
        {
            CountDown();
        }
    }

    
    public void InfoButton()
    {
        panel_Info.SetActive(true);
        panel_Start.SetActive(false);
    }

    public void InfoBack()
    {
        panel_Info.SetActive(false);
        panel_Start.SetActive(true);
    }    


    public void PlayButton()
    {
        panel_Start.SetActive(false);
        panel_Breath.SetActive(true);
        backgroundAudio.Play();
        isPlay = true;
    }

    public void Back()
    {
        panel_Start.SetActive(true);
        panel_Breath.SetActive(false);
        backgroundAudio.Stop();
        isPlay = false;
    }
    void DisplayTime(float timeToDisPlay)
    {
        if (timeToDisPlay < 0)
        {
            timeToDisPlay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisPlay / 60);
        float seconds = Mathf.FloorToInt(timeToDisPlay % 60);
        float milliseconds = timeToDisPlay % 1 * 1000;
        txt_Timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    void CountDown()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

   
    public void Mute()
    {
        backgroundAudio.Play();
        button_SoundOn.SetActive(true);
        button_SoundOff.SetActive(false);

    }
    public void PlaySound()
    {
        backgroundAudio.Pause();
        button_SoundOff.SetActive(true);
        button_SoundOn.SetActive(false);
    }

    

    
}
