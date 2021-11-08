using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuickReflex : MonoBehaviour
{

    public static QuickReflex instance;

    public GameObject startPanel;
    public GameObject mainPanel;
    public GameObject gamePanel;
    public Text txt_Score;

    Vector3 mousePos;

    [SerializeField]
    private GameObject[] points;

    private float timeIntervalBetweenStepts;

    private int stepCounter;

    public GameObject bluePoint;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);
        bluePoint.SetActive(false);
        gamePanel.SetActive(false);
        foreach (var item in points)
        {
            item.SetActive(false);
        }
    }

    public void ButtonStartOnClick()
    {
        startPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void ButtonEasyOnClick()
    {
        gamePanel.SetActive(true);
        bluePoint.SetActive(true);
        foreach (var item in points)
        {
            item.SetActive(true);
        }
        mainPanel.SetActive(false);
        StartCoroutine(SetUpMode());
        StartCoroutine(Go());

    }

    IEnumerator SetUpMode()
    {
        yield return new WaitForSeconds(2f);
        timeIntervalBetweenStepts = 0.7f;
        stepCounter = 0;
    }

    private IEnumerator Go()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            bluePoint.transform.position = points[stepCounter].transform.position;
            stepCounter += 1;
            if(stepCounter > points.Length -1)
            {
                stepCounter = 0;
            }
            yield return new WaitForSeconds(timeIntervalBetweenStepts);

        }
    }

    
    public void IncreaseScore(int score)
    {
        txt_Score.text = "Score :  " + score;
    }

    //private void OnMouseDown()
    //{
    //        Debug.Log("Click");
    //        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        if (mousePos == bluePoint.transform.position)
    //        {
    //            score++;
    //            txt_Score.text = "Score :  " + score;
    //        }
    //}

    public void Back()
    {
        mainPanel.SetActive(true);
        gamePanel.SetActive(false);
        bluePoint.SetActive(false);
        foreach (var item in points)
        {
            item.SetActive(false);
        }
    }
}
