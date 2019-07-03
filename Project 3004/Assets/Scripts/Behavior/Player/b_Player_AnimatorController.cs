using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UsingActions
{
    public class b_Player_AnimatorController : MonoBehaviour
    {

        Animator animator;
        d_General_Input genInput_ptr;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            genInput_ptr = GetComponent<d_General_Input>();
        }

        void Update()
        {
            animator.SetFloat("MovementVec", Mathf.Max(Mathf.Abs(genInput_ptr.xAxis), Mathf.Abs(genInput_ptr.yAxis)));
            animator.SetBool("Attack", genInput_ptr.skill_1);
        }

        void AttackEvent()
        {
            EventHandler.AttackEventTrigger();
        }
    }
}