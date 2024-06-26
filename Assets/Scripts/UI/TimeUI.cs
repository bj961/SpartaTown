using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    private Text timeText;
    private void Awake()
    {
        timeText = GetComponent<Text>();
    }

    void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }
}
