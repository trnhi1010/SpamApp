using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SpawnTileScript : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject gamePanel;
    public GameObject endGamePanel;


    public static SpawnTileScript _instance;
    public int count;
    public List<Transform> listSpawnPoint;
    public GameObject prefabs;
    public Text txt_Text;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this);
    }
    private void Start()
    {
        menuPanel.SetActive(true);
        gamePanel.SetActive(false);
        endGamePanel.SetActive(false);
    }

    private void Update()
    {
        
    }
    public void Play()
    {
        txt_Text.text = "START";
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);
        InvokeRepeating("Spawn", Random.Range(1, 3), Random.Range(1, 3));
    }

    public void EndGame()
    {
        endGamePanel.SetActive(true);
    }

    private void Spawn()
    {
        Instantiate(prefabs, listSpawnPoint[Random.Range(0, listSpawnPoint.Count)].position, Quaternion.identity);
    }

    public void Score()
    {
        txt_Text.text = "SCORE: " + count;
    }

    public void Back()
    {
        gamePanel.SetActive(false);
        endGamePanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void Replay()
    {
        endGamePanel.SetActive(false);
        count = 0;
        txt_Text.text = "START";
        Time.timeScale = 1f;
        Spawn();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
