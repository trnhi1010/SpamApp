using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GestureDetector : MonoBehaviour
{
    [SerializeField]
    private GameObject tap, swipe;

    private Touch touch;
    private Vector2 beginTouchPos, endTouchPos;

    public Text txt_Required;
    string[] text = { "TAP", "SWIPE" };
    
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Invoke("ChangeText", 3f);
            touch = Input.GetTouch(0);
           
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    beginTouchPos = touch.position;
                    break;
                case TouchPhase.Ended:
                    endTouchPos = touch.position;
                    if (beginTouchPos == endTouchPos)
                        Instantiate(tap, transform.position, Quaternion.identity);
                    if (beginTouchPos != endTouchPos)
                        Instantiate(swipe, transform.position, Quaternion.identity);
                    break;
            }
        }
        
    }
    public void btnPlayOnClick()
    {
        Time.timeScale = 1f;
        ChangeText();
    }
    void ChangeText()
    {
        txt_Required.text = "Please: " + text[Random.Range(0, 2)];
    }
}
