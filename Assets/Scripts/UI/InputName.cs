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
            // �̸� ����

            Time.timeScale = 1f;
            //DeactivateUI();
        }
        else
        {
            nameInputField.text = "";
            Debug.LogError("�̸��� 2~10���ڷ� �Է����ּ���");
        }
    }

    public void ActivateUI()
    {
        gameObject.SetActive(true); // UI�� Ȱ��ȭ�մϴ�.
    }

    public void DeactivateUI()
    {
        gameObject.SetActive(false); // UI�� ��Ȱ��ȭ�մϴ�.
    }
}
