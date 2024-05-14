using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour
{
    private Button changeCharacterbutton;
    [SerializeField] private GameObject characterPrefab;
    [SerializeField] private GameObject ChangeCharacterUI;

    private void Awake()
    {
        changeCharacterbutton = GetComponent<Button>();
        changeCharacterbutton.onClick.AddListener(InvokeChangeCharacter);
    }

    void InvokeChangeCharacter()
    {
        PlayerCharacter.Instance.ChangeCharacter(characterPrefab);
        ChangeCharacterUI.SetActive(false);
    }
}
