using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // ������ �̵��� �Ͼ ������Ʈ

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    //private CharacterStatHandler characterStatHandler;
    private int speed = 10;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // awake�� �ַ� �� ������Ʈ �ȿ��� ������ �� ó��

        // 'controller�� TopdownMovement�� ���� ���ӿ�����Ʈ �ȿ� �ִ�' ��� ����
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
        // FixedUpdate�� ���� ������Ʈ����
        // rigidbody�� ���� �ٲٴϱ� ���
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        //direction = direction * characterStatHandler.CurrentStat.speed; // ����ȭ �Ǿ� ������ ������ �ӵ� ������.
        direction = direction * speed;
        movementRigidbody.velocity = direction;
    }

}
