using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterData : ScriptableObject
{
    public Character[] characters;
    public int characterCount
    {
        get
        {
            return characters.Length;
        }
    }
    public Character GetCharacter(int index)
    {
        return characters[index];
    }

}
