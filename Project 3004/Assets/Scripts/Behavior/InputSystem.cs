using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    InputData id;
    private void Awake()
    {
        id = GetComponent<InputData>();
    }

    void FixedUpdate()
    {
        id.skill_1 = Input.GetButton("Fire1");
    }
}
