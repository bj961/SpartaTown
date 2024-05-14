using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static PlayerCharacter;

public class StartManager : MonoBehaviour
{
    public static StartManager Instance;

    private GameObject selectedCharacterPrefab;
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

    public void SetCharacterPrefab(GameObject prefab)
    {
        selectedCharacterPrefab = prefab;
    }


    public void GameStart(string name)
    {
        characterName = name;
        PlayerCharacter.Instance.CreateCharacter(selectedCharacterPrefab, characterName);
        //Destroy(gameObject);
        SceneManager.LoadScene("MainScene");
    }
}
