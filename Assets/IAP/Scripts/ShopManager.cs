using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] GameObject Content;
    [SerializeField] private List<GameObject>  music;

    public string ScenePlay;

    public void Show()
    {
        Content.SetActive(true);
        foreach (var temp in music)
        {
            temp.SetActive(false);
        }
    }

    public void Hide()
    {
        Content.SetActive(false);
        foreach (var temp in music)
        {
            temp.SetActive(true);
        }

    }

    public void PlayBtn()
    {
        SceneManager.LoadScene(ScenePlay);
    }
}
