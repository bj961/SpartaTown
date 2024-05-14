using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UndoButton : MonoBehaviour
{
    private Button undoButton;
    [SerializeField]
    private GameObject characterSelectUI;

    private void Awake()
    {
        undoButton = GetComponent<Button>();
        undoButton.onClick.AddListener(Undo);
    }

    void Undo()
    {
        gameObject.SetActive(false);
        characterSelectUI.SetActive(true);
    }
}
