using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimator : MonoBehaviour
{
    private Animator animator;
    private Vector3 lastPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastPosition = transform.position;
    }

    void Update()
    {
        // 如果NPC的位置发生变化
        if (transform.position != lastPosition)
        {
            // 切换到移动动画
            animator.SetBool("IsMoving", true);
        }
        else
        {
            // NPC的位置没有变化，保持静止动画
            animator.SetBool("IsMoving", false);
        }

        // 更新位置
        lastPosition = transform.position;
    }
}
