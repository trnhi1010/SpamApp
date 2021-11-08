using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsWorldManager : MonoBehaviour
{
    public GameObject splashPanel;
    public GameObject mainPanel;
    public GameObject detailPanel;
    // Start is called before the first frame update
    void Start()
    {
        splashPanel.SetActive(true);
        mainPanel.SetActive(false);
        detailPanel.SetActive(false);
        StartCoroutine(TurnOffSplashPanel());
    }
    IEnumerator TurnOffSplashPanel()
    {
        yield return new WaitForSeconds(2.2f);
        splashPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
}
