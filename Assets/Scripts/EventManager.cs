using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerCharacter;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }

    //public delegate void CharacterNameChanged();
    //public event CharacterNameChanged OnCharacterNameChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
