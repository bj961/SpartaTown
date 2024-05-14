using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static PlayerCharacter;

public class StartManager : MonoBehaviour
{
    public static StartManager Instance;

    public GameObject selectedCharacterPrefab;
    public string characterName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void GameStart()
    {
        PlayerCharacter.Instance.CreateCharacter(selectedCharacterPrefab, characterName);
        SceneManager.LoadScene("MainScene");
    }
}
