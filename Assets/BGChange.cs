using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BGChange : MonoBehaviour
{
    [SerializeField] private GameObject BgMain;
    [SerializeField] private List<GameObject> Bg;
    
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeBG);
    }

    void ChangeBG()
    {
        foreach (var temp in Bg)
        {
            temp.SetActive(false);
        }
        BgMain.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
