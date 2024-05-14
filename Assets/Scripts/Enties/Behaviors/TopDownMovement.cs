using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TopDownMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 컴포넌트

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    
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

        //if (GetComponent<Rigidbody2D>() != null)
        //{
        //    movementRigidbody = GetComponent<Rigidbody2D>();
        //}
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

        //if (GetComponent<Rigidbody2D>() != null)
        //{
        //    movementRigidbody = GetComponent<Rigidbody2D>();
        //    Debug.Log("Start() rigidbody2D NULL 아닌데??");
        //}
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

        direction = direction * speed;
        movementRigidbody.velocity = direction;
        /*
        if (PlayerCharacter.Instance.character.GetComponent<Rigidbody2D>())
        {
            PlayerCharacter.Instance.character.GetComponent<Rigidbody2D>().velocity = direction;
        }
        */
    }

}
