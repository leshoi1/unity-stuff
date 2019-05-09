using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_General_DamageReceiver : MonoBehaviour
{
    d_General_UtilityStats utilStats_ptr;

    void Awake()
    {
        utilStats_ptr = GetComponent<d_General_UtilityStats>();
    }

    public void DamageInput(DamageData di)
    {
        utilStats_ptr.currentHealth -= di.damageValue;
    }
}
