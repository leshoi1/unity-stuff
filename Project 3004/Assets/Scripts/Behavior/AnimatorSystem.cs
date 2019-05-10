using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSystem : MonoBehaviour
{

    Animator animator;
    MovementData md;
    InputData id;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        md = GetComponent<MovementData>();
        id = GetComponent<InputData>();

    }

    void Update()
    {
        animator.SetFloat("MovementVec", Mathf.Max(Mathf.Abs(md.xAxis), Mathf.Abs(md.yAxis)));
        animator.SetBool("Attack", id.skill_1);
    }
}
