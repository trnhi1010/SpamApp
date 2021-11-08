using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueOrFalse : MonoBehaviour
{
    int _score;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    bool isRightClick = false;
    public GameObject menuPanel;

    public void RightAnswer()
    {
        if (!isRightClick)
        {
            _score++;
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
                    WrongAnswer();
                    break;
            }
        }
    }
    public void WrongAnswer()
    {
        menuPanel.SetActive(true);
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);

        ResetScore();
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
        }
    }
    public void ResetScore()
    {
        _score = 0;
    }
}
