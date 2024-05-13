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
        // awake는 주로 내 컴포넌트 안에서 끝나는 것 처리

        // 'controller와 TopdownMovement가 같은 게임오브젝트 안에 있다' 라는 가정
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        //characterStatHandler = GetComponent<CharacterStatHandler>();
    }

    private void Start()
    {
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
