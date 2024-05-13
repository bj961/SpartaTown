using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected TopDownController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownController>();
    }

    protected virtual void Start()
    {
        if (GetComponentInChildren<Animator>() != null)
        {
            animator = GetComponentInChildren<Animator>();
            Debug.Log("animationCont Start animator Null �ƴ�");
        }
        else
        {
            Debug.LogError("animationCont Start animator Null�̾�~!!");
        }


        if (GetComponent<TopDownController>() != null)
        {
            controller = GetComponent<TopDownController>();
            Debug.Log("animationCont Start ��Ʈ�ѷ� Null �ƴ�");
        }
        else
        {
            Debug.LogError("animationCont Start ��Ʈ�ѷ� Null�̾�!!");
        }
    }
}
