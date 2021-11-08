using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "EndGame")
        {
            Time.timeScale = 0f;
            Destroy(gameObject);
            SpawnTileScript._instance.EndGame();
        }
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        SpawnTileScript._instance.count++;
        SpawnTileScript._instance.Score();
    }
}
