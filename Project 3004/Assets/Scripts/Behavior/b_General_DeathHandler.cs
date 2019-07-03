using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_General_DeathHandler : MonoBehaviour
{
    d_General_UtilityStats utilStats_ptr;
    void Awake()
    {
        utilStats_ptr = GetComponent<d_General_UtilityStats>();
    }

    void Update()
    {
        if(utilStats_ptr.currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
