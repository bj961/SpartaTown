using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    public static PlayerCharacter Instance { get; private set; }

    public GameObject character;
    private Text characterNameText;

    public GameObject temp_prefab; //�׽�Ʈ�� �ӽ��ڵ�

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


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            //�׽�Ʈ���ӽ�
            CreateCharacter(temp_prefab, "������");
            //

            characterNameText = GetComponentInChildren<Text>();
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
        character = Instantiate(characterPrefab, gameObject.transform);
        CharacterName = name;
    }

    public void ChangeCharacter(GameObject newCharacterPrefab)
    {
        Vector3 position = character.transform.position;
        string name = CharacterName;

        Destroy(gameObject);
        var newCharacter = Instantiate(newCharacterPrefab, position, Quaternion.identity);
        var newPlayerCharacter = newCharacter.GetComponent<PlayerCharacter>();
        newPlayerCharacter.ChangeName(name);
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
