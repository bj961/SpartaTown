using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    //[SerializeField] private SpriteRenderer armRenderer;
    //[SerializeField] private Transform armPivot;
    //[SerializeField]
    private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {

        if (GetComponentInChildren<SpriteRenderer>() != null)
        {
            characterRenderer = GetComponentInChildren<SpriteRenderer>();
        }
        else
        {
            Debug.LogError("Aim.cs Awake() Renderer NULL이다!!");
        }

        //characterRenderer = GetComponentInChildren<SpriteRenderer>();



        if (GetComponent<TopDownController>() != null)
        {
            controller = GetComponent<TopDownController>();
        }
        else
        {
            Debug.LogError("Aim.cs controller NULL이다!!");
        }

        //controller = GetComponent<TopDownController>();
    }

    void Start()
    {
        if (GetComponentInChildren<SpriteRenderer>() != null)
        {
            characterRenderer = GetComponentInChildren<SpriteRenderer>();
            Debug.Log("Aim.cs Start() Renderer NULL아닌데?");
        }
        else
        {
            Debug.LogError("Aim.cs Start() Renderer NULL이다!!");
        }



        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;

        //armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
