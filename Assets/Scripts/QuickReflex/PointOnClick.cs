using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOnClick : MonoBehaviour
{
    public int score;
    private void OnMouseDown()
    {
        //Debug.Log("Click");
        score++;
        QuickReflex.instance.IncreaseScore(score);
    }
}
