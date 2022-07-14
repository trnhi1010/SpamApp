using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScipData/Data",order = 1)]
[System.Serializable]
public class DataTest : ScriptableObject
{
    public float sound;
    public int A;
}
