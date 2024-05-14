using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterNameUI : MonoBehaviour
{
    private Text nameText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject canvasObj = new GameObject("Canvas");
        canvasObj.transform.SetParent(transform);
        canvasObj.transform.localPosition = new Vector3(0, 1, 0);

        // 캔버스 설정
        Canvas canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.WorldSpace;
        CanvasScaler scaler = canvasObj.AddComponent<CanvasScaler>();
        scaler.scaleFactor = 10.0f;
        scaler.dynamicPixelsPerUnit = 10f;

        // 이름을 표시할 Text 오브젝트 생성
        GameObject textObj = new GameObject("Text");
        textObj.transform.SetParent(canvasObj.transform);
        textObj.transform.localPosition = Vector3.zero;

        RectTransform textTransform = textObj.AddComponent<RectTransform>();
        textTransform.sizeDelta = new Vector2(200, 200);
        textTransform.position = new Vector3(0, 100, 0);

        textObj.AddComponent<CanvasRenderer>();

        // Text 컴포넌트 설정
        nameText = textObj.AddComponent<Text>();
        nameText.font = Resources.Load<Font>("Fonts/Maplestory Light");
        nameText.fontSize = 36;
        nameText.text = PlayerCharacter.Instance.CharacterName;
        nameText.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
