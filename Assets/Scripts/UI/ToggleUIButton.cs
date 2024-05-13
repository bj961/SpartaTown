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
            Debug.LogError("해당 버튼에 연결된 UI가 없습니다.");
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
