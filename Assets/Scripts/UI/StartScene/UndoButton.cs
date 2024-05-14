using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UndoButton : MonoBehaviour
{
    [SerializeField]
    private Button undoButton;
    [SerializeField]
    private GameObject characterSelectUI;

    void Undo()
    {
        gameObject.SetActive(false);
        characterSelectUI.SetActive(true);
    }
}
