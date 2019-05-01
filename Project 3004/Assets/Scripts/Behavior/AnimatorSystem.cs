using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSystem : MonoBehaviour
{

    Animator animator;
    MovementData md;

    void Start()
    {
        animator = GetComponent<Animator>();
        md = GetComponent<MovementData>();
    }

    void Update()
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }
        if (md == null)
        {
            md = GetComponent<MovementData>();
        }
        if(animator != null && md != null)
        {
            animator.SetFloat("MovementVec", Mathf.Max(Mathf.Abs(md.xAxis), Mathf.Abs(md.yAxis)));
        }
    }
}
