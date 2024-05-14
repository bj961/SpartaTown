using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterListUI : MonoBehaviour
{
    public Text participantsText;
    public Button refreshButton;

    private void Awake()
    {
        refreshButton.onClick.AddListener(UpdateList);
    }

    private void OnEnable()
    {
        UpdateList();
    }

    void UpdateList()
    {
        GameObject[] characters = GameObject.FindGameObjectsWithTag("character");

        participantsText.text = "";
        
        foreach (GameObject character in characters)
        {
            participantsText.text += character.GetComponentInChildren<Text>().text;
        }
    }
}
