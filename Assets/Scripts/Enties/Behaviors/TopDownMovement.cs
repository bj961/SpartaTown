using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TopDownMovement : MonoBehaviour
{
    // ������ �̵��� �Ͼ ������Ʈ

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
            Debug.LogError("controller NULL�̴�!!");
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
            Debug.LogError("rigidbody2D NULL�̴�!!");
        }
        
        //characterStatHandler = GetComponent<CharacterStatHandler>();
    }

    private void Start()
    {

        if (GetComponentInChildren<Rigidbody2D>() != null)
        {
            movementRigidbody = GetComponentInChildren<Rigidbody2D>();
            Debug.Log("Start() rigidbody2D NULL �ƴѵ�??");
        }

        //if (GetComponent<Rigidbody2D>() != null)
        //{
        //    movementRigidbody = GetComponent<Rigidbody2D>();
        //    Debug.Log("Start() rigidbody2D NULL �ƴѵ�??");
        //}
        else
        {
            Debug.LogError("Start() rigidbody2D NULL�̴�!!");
        }
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        // FixedUpdate�� ���� ������Ʈ����
        // rigidbody�� ���� �ٲٴϱ� ���
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
