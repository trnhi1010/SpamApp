using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NoteList : MonoBehaviour
{
    public GameObject prefabs;
    public GameObject toDoListContain;
    public GameObject shoppingListContain;
    public GameObject studyListContain;

    List<GameObject> toDoList = new List<GameObject>();
    List<GameObject> shoppingList = new List<GameObject>(); 
    List<GameObject> studyList = new List<GameObject>();

    
    public void ButtonAddToDoListOnClick()
    {
        GameObject newItem = Instantiate(prefabs, toDoListContain.transform, false);
        toDoList.Add(newItem);

    }
    public void ButtonRemoveToDoListOnClick()
    {
        foreach (GameObject item in toDoList)
        {
            Destroy(item);
        }
    }
    public void ButtonAddShoppingOnClick()
    {
        GameObject newShopItem = Instantiate(prefabs, shoppingListContain.transform, false);
        shoppingList.Add(newShopItem);

    }
    public void ButtonRemoveShoppingOnClick()
    {
        foreach (GameObject item in shoppingList)
        {
            Destroy(item);
        }
    }

    public void ButtonAddStudyOnClick()
    {
        GameObject newShopItem = Instantiate(prefabs, studyListContain.transform, false);
        studyList.Add(newShopItem);

    }
    public void ButtonRemoveStudyOnClick()
    {
        foreach (GameObject item in studyList)
        {
            Destroy(item);
        }
    }
}
