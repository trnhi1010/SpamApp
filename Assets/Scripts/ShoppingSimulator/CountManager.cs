using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountManager : MonoBehaviour
{
    public Text txt_Amount;
    int count = 0;
    public void OnCount()
    {
        count++;
        txt_Amount.text = count.ToString();
    }
}

