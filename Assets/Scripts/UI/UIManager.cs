using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public GameObject mainSceneUI;
    //public GameObject bottomUIBar;
    //public GameObject timeUI;
    //public GameObject nameInputUI;
    //public GameObject participantsListUI;

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
        Instantiate(mainSceneUI);

        //Instantiate(bottomUIBar);
        //Instantiate(timeUI);
        //Instantiate(nameInputUI);
        //Instantiate(participantsListUI);
    }

}
