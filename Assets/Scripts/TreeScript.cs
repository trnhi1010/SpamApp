using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeScript : MonoBehaviour
{
    public GameObject txt_Alert;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Drop"))
        {
            transform.localScale = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f, transform.localScale.z);
            collision.gameObject.transform.parent.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if(transform.localScale.x >= 5 || transform.localScale.y >= 5)
        {
            txt_Alert.SetActive(true);
            Invoke("ResetSize", 1.5f);
        }
    }

    private void ResetSize()
    {
        transform.localScale = new Vector3(1, 1, 1);
        txt_Alert.SetActive(false);
    }
}
