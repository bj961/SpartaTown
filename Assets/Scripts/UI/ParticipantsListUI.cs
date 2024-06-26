using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterListUI : MonoBehaviour
{

    public Text participantsText;
    public Button refreshButton;
    public Button exitButton;

    private void Awake()
    {
        refreshButton.onClick.AddListener(UpdateList);
        exitButton.onClick.AddListener(DisableUI);
        PlayerCharacter.Instance.OnNameChanged += UpdateList;
    }

    private void OnEnable()
    {
        UpdateList();
    }

    public void UpdateList()
    {
        GameObject[] characters = GameObject.FindGameObjectsWithTag("Character");

        participantsText.text = "";

        foreach (GameObject character in characters)
        {
            participantsText.text += (character.GetComponentInChildren<Text>().text + "\n");
        }
    }

    private void DisableUI()
    {
        gameObject.SetActive(false);
    }
}
