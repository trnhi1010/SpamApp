using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IllusionColor : MonoBehaviour
{
    public Text txt_Score;
    public Text txt_Warning;
    int _score;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;

    bool isRightClick = false;

    public void RightOne()
    {
        if (!isRightClick)
        {
            txt_Warning.gameObject.SetActive(false);
            _score++;
            txt_Score.text = _score.ToString();
            switch (_score)
            {
                case 1:
                    StartCoroutine(PassLevel(1));
                    break;
                case 2:
                    StartCoroutine(PassLevel(2));
                    break;
                case 3:
                    StartCoroutine(PassLevel(3));
                    break;
                case 4:
                    StartCoroutine(PassLevel(4));
                    break;
                case 5:
                    StartCoroutine(PassLevel(5));
                    txt_Score.text = "YOU HAVE AN AMAZING EYES";
                    break;
            }
            isRightClick = true;
        }
        
    }
    public void WrongOne()
    {
        txt_Warning.gameObject.SetActive(true);
        txt_Warning.text = "Wrong one";
    }

    IEnumerator PassLevel(int level)
    {
        yield return new WaitForSeconds(0.5f);
        switch (level)
        {
            case 1:
                level1.SetActive(false);
                isRightClick = false;
                break;
            case 2:
                level2.SetActive(false);
                isRightClick = false;

                break;
            case 3:
                level3.SetActive(false);
                isRightClick = false;

                break;
            case 4:
                level4.SetActive(false);
                isRightClick = false;

                break;
            case 5:
                level5.SetActive(false);
                isRightClick = false;
                ResetScore();
                break;
        }    
    }

    public void ResetScore()
    {
        _score = 0;
        txt_Score.text = "TRY AGAIN?";
    }
}
