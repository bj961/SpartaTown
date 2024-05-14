using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectButton : MonoBehaviour
{
    private Button button;
    [SerializeField] private GameObject selectedCharcter;
    
    [SerializeField] private GameObject nameInputUI;
    [SerializeField] private GameObject characterSelectUI;

    private Image thisImage;
    [SerializeField] private Image targetImage;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
        //thisImage = GetComponent<Image>();
    }

    public void OnButtonClicked()
    {
        StartManager.Instance.SetCharacterPrefab(selectedCharcter);
        //targetImage.sprite = thisImage.sprite;
        nameInputUI.SetActive(true);
        characterSelectUI.SetActive(false);
    }

}
