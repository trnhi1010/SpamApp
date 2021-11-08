using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Wheel : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;
    private bool coroutineAllowed;
    private int finalAngle;
    public Text txtPrice;

    private void Start()
    {
        coroutineAllowed = true;
    }

    //private void Update()
    //{
    //    if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && coroutineAllowed)
    //    {
            
    //    }
    //}

    public void OnButtonPlayClick()
    {
        StartCoroutine(Spin());
    }

    private IEnumerator Spin()
    {
        coroutineAllowed = false;
        randomValue = Random.Range(20, 30);
        timeInterval = 0.1f;
        for(int i = 0; i < randomValue; i++)
        {
            transform.Rotate(0, 0, 22.5f);
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 1f * Time.deltaTime;
            if (i < Mathf.RoundToInt(randomValue * 0.85f))
                timeInterval = 4f * Time.deltaTime;
            yield return new WaitForSeconds(timeInterval);
        }
        if(Mathf.RoundToInt(transform.eulerAngles.z)%45 !=0)
        {
            transform.Rotate(0, 0, 22.5f);
        }
        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);
        switch (finalAngle)
        {
            case 0:
                txtPrice.text = "YOU HAVE TO SING A SONG";
                break;
            case 45:
                txtPrice.text = "YOU WON 15$";
                break;
            case 90:
                txtPrice.text = "YOU WON 500$";
                break;
            case 135:
                txtPrice.text = "NOTHING LOL";
                break;
            case 180:
                txtPrice.text = "DANCE!!!";
                break;
            case 225:
                txtPrice.text = "YOU GOT 1$";
                break;
            case 270:
                txtPrice.text = "DRINK A BEER!";
                break;
            case 315:
                txtPrice.text = "YOU WON 100$";
                break;
        }
        coroutineAllowed = true;
    }
}
