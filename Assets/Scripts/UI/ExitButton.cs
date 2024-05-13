using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    private Button exitButton;

    private void Awake()
    {
        exitButton = GetComponentInChildren<Button>();
        exitButton.onClick.AddListener(DisableUI);
    }
    private void DisableUI()
    {
        Transform parentUI = transform.parent;
        if (parentUI != null)
        {
            parentUI.gameObject.SetActive(false);
        }
    }
}
