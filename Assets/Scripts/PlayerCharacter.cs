using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    public static PlayerCharacter Instance { get; private set; }

    public delegate void NameChanged();
    public static event NameChanged OnNameChanged;

    [SerializeField]
    private string characterName;
    public string CharacterName
    {
        get { return characterName; }
        set
        {
            characterName = value;
            OnNameChanged?.Invoke();
        }
    }
    public GameObject character;

    private Text characterNameText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            characterNameText = character.GetComponentInChildren<Text>();
            characterNameText.text = CharacterName;
            OnNameChanged += UpdateNameUI;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CreateCharacter(GameObject characterPrefab, string name)
    {
        character = Instantiate(characterPrefab);
        CharacterName = name;
    }

    public void ChangeCharacter(GameObject newCharacterPrefab)
    {
        Vector3 position = character.transform.position;
        string name = CharacterName;

        Destroy(character);

        character = Instantiate(newCharacterPrefab, position, Quaternion.identity);
        CharacterName = name;
    }

    public void ChangeName(string newName)
    {
        CharacterName = newName;
        OnNameChanged?.Invoke();
    }

    public void UpdateNameUI()
    {
        characterNameText.text = characterName;
    }
}
