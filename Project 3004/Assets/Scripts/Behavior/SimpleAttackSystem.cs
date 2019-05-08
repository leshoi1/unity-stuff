using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttackSystem : MonoBehaviour
{
    InputData id;
    BoxCollider2D b2d;

    void Start()
    {
        id = Database.GetPlayer().GetComponent<InputData>();
        b2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (id.skill_1)
        {
            b2d.enabled = true;
        }
        else
        {
            b2d.enabled = false;
        }
    }
}
