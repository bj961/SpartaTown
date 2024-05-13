using UnityEngine;

public class CharacterAnimationContorller : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int isHit = Animator.StringToHash("isHit");
    private static readonly int Attack = Animator.StringToHash("attack");

    private readonly float magnitudeThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
        //controller.OnAttackEvent += Attacking;
        controller.OnMoveEvent += Move;
    }
    /*
    private void Attacking(AttackSO sO)
    {
        animator.SetTrigger(Attack);
    }

    private void Hit()
    {
        animator.SetBool(isHit, true);
    }
    
    private void InvincibilityEnd()
    {
        animator.SetBool(isHit, false);
    }
    */
    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnitudeThreshold);
    }
}
