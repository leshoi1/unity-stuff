using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_Player_Input : MonoBehaviour
{
    d_General_Input genInput_ptr;
    private void Awake()
    {
        genInput_ptr = GetComponent<d_General_Input>();
    }

    void FixedUpdate()
    {
        genInput_ptr.xAxis = Input.GetAxis("Horizontal");
        genInput_ptr.yAxis = Input.GetAxis("Vertical");
        genInput_ptr.skill_1 = Input.GetButton("Fire1");
    }
}
