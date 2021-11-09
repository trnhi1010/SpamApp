using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetTimeScript : MonoBehaviour
{
    public Text textTime;

    void Time()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString(@"M / d / yyyy - hh : mm : ss  tt");
        print(time);
        textTime.text = time;
    }
    private void Start()
    {
        Time();
    }

}
