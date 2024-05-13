using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    private InputField nameInputField;
    private Button submitButton;
    void Awake()
    {
        nameInputField = GetComponentInChildren<InputField>();
        submitButton = GetComponentInChildren<Button>();
        submitButton.onClick.AddListener(SetName);
    }

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    public void SetName()
    {
        string name = nameInputField.text;

        if(name.Length >= 2 && name.Length <= 10)
        {
            Debug.Log("Name set : " + name);
            // 이름 설정

            Time.timeScale = 1f;
            //DeactivateUI();
        }
        else
        {
            nameInputField.text = "";
            Debug.LogError("이름은 2~10글자로 입력해주세요");
        }
    }

    public void ActivateUI()
    {
        gameObject.SetActive(true); // UI를 활성화합니다.
    }

    public void DeactivateUI()
    {
        gameObject.SetActive(false); // UI를 비활성화합니다.
    }
}
