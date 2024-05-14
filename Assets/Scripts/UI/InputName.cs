using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public GameObject playerCharacter;
    private Text nameText;
    private InputField nameInputField;
    private Button submitButton;
    void Awake()
    {
        nameText = playerCharacter.GetComponentInChildren<Text>();
        nameInputField = GetComponentInChildren<InputField>();
        submitButton = GetComponentInChildren<Button>();
        submitButton.onClick.AddListener(SetName);
    }

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void SetName()
    {
        string name = nameInputField.text;

        if(name.Length >= 2 && name.Length <= 10)
        {
            Debug.Log("Name set : " + name);
            // �̸� ����
            //Text nameText = playerCharacter.GetComponent<Text>();
            nameText.text = name;
            DeactivateUI();
        }
        else
        {
            nameInputField.text = "";
            Debug.LogError("�̸��� 2~10���ڷ� �Է����ּ���");
        }
    }

    public void ActivateUI()
    {
        gameObject.SetActive(true);
    }

    public void DeactivateUI()
    {
        gameObject.SetActive(false);
    }
}
