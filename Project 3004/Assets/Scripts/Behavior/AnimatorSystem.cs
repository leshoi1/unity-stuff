using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSystem : MonoBehaviour
{

    Animator animator;
    MovementData md;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        md = GetComponent<MovementData>();
    }

    void Update()
    {
        animator.SetFloat("MovementVec", Mathf.Max(Mathf.Abs(md.xAxis), Mathf.Abs(md.yAxis)));
    }
}
