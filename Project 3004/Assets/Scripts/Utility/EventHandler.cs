using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public delegate void AttackEventDelegate();
    public static event AttackEventDelegate OnAttackLanded = delegate { };

    public static void AttackEventTrigger()
    {
        OnAttackLanded();
    }
}
