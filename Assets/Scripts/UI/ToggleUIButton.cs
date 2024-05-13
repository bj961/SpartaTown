using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUIButton : MonoBehaviour
{
    public GameObject targetUI;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleUI);
    }

    private void ToggleUI()
    {
        if(targetUI == null)
        {
            Debug.LogError("�ش� ��ư�� ����� UI�� �����ϴ�.");
            return;
        }

        if (targetUI.activeSelf)
        {
            targetUI.gameObject.SetActive(false);
        }
        else
        {
            targetUI.gameObject.SetActive(true);
        }
    }
}
