using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_Enemy_HealthBarScript : MonoBehaviour
{
    d_General_UtilityStats us;
    void Awake()
    {
        us = GetComponentInParent<d_General_UtilityStats>();
    }

    void Update()
    {
        transform.localScale = new Vector3(us.currentHealth / us.maxtHealth, 1, 1);
    }
}
