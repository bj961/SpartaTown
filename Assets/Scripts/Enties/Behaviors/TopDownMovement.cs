using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 컴포넌트

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    //private CharacterStatHandler characterStatHandler;
    private int speed = 10;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        if (GetComponent<TopDownController>() != null)
        {
            controller = GetComponent<TopDownController>();
        }
        else
        {
            Debug.LogError("controller NULL이다!!");
        }

        if (GetComponentInChildren<Rigidbody2D>() != null)
        {
            movementRigidbody = GetComponentInChildren<Rigidbody2D>();
        }
        else
        {
            Debug.LogError("rigidbody2D NULL이다!!");
        }
        
        //characterStatHandler = GetComponent<CharacterStatHandler>();
    }

    private void Start()
    {
        if (GetComponentInChildren<Rigidbody2D>() != null)
        {
            movementRigidbody = GetComponentInChildren<Rigidbody2D>();
            Debug.Log("Start() rigidbody2D NULL 아닌데??");
        }
        else
        {
            Debug.LogError("Start() rigidbody2D NULL이다!!");
        }
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        // FixedUpdate는 물리 업데이트관련
        // rigidbody의 값을 바꾸니까 사용
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        //direction = direction * characterStatHandler.CurrentStat.speed; // 정규화 되어 들어오기 때문에 속도 곱해줌.
        direction = direction * speed;
        movementRigidbody.velocity = direction;
    }

}
