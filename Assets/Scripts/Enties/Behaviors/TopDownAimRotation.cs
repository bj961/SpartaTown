using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        characterRenderer = GetComponentInChildren<SpriteRenderer>();
        controller = GetComponent<TopDownController>();
    }

    void Start()
    {
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
