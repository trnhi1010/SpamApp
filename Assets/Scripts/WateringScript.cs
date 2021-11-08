using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WateringScript : MonoBehaviour
{
    public Button btnWatering;
    Vector3 _dropStarPos;

    private void Start()
    {
        _dropStarPos = gameObject.transform.GetChild(0).position;
        DeActive();
    }
    public void ButtonWateringOnClick()
    {
        btnWatering.onClick.AddListener(SetActive);
        gameObject.GetComponentInChildren<Rigidbody2D>().gravityScale = 1f;
        //Invoke("DeActive", 2f);
        gameObject.transform.GetChild(0).position = _dropStarPos;
    }

    void SetActive()
    {
        gameObject.SetActive(true);

    }

    void DeActive()
    {
        gameObject.SetActive(false);
    }
}
