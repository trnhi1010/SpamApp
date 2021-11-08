using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterManager : MonoBehaviour
{
    public CharacterData characterDB;
    public SpriteRenderer artworkSprite;
    //public Text txt_Alert;
    public Text nameText;
    private int selectedOption = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        //txt_Alert.text = "";
        selectedOption++;
        if(selectedOption >= characterDB.characterCount)
        {
            selectedOption = 0;
        }
        UpdateCharacter(selectedOption);
    }

    public void BackOption()
    {
        //txt_Alert.text = "";

        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.characterCount - 1;
        }
        UpdateCharacter(selectedOption);
    }

    public void AddFriendButtonOnClcik()
    {
        //txt_Alert.text = "ADD FRIEND SUCCESS";
    }

    private void UpdateCharacter(int selectOption)
    {
        Character character = characterDB.GetCharacter(selectOption);
        artworkSprite.sprite = character.CharacterSprite;
        nameText.text = character.characterName;
    }
}
