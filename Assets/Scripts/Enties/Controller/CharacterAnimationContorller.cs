using UnityEngine;

public class CharacterAnimationContorller : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private readonly float magnitudeThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    protected void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnitudeThreshold);
    }
}
