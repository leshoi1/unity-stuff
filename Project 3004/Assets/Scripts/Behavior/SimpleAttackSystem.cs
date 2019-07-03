using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttackSystem : MonoBehaviour
{
    d_General_Input id;
    BoxCollider2D b2d;
    SimpleAttackData sad_ptr;
    Collider2D[] enemiesColliders;
    ContactFilter2D contactFilter;

    public float AttackRate;

    void Start()
    {
        id = Database.GetPlayer().GetComponent<d_General_Input>();
        b2d = GetComponent<BoxCollider2D>();
        sad_ptr = GetComponent<SimpleAttackData>();
        enemiesColliders = new Collider2D[50];
        contactFilter = new ContactFilter2D();
        contactFilter.useLayerMask = true;
        contactFilter.layerMask = LayerMask.GetMask("Enemies");
        EventHandler.OnAttackLanded += Use;
    }

    void Use()
    {
        b2d.enabled = true;
        int len = b2d.OverlapCollider(contactFilter, enemiesColliders);
        if (len > 0)
        {
                for (int i = 0; i < len; ++i)
                {
                    b_General_DamageReceiver damageReceiver = enemiesColliders[i].gameObject.GetComponent<b_General_DamageReceiver>();
                    if (damageReceiver != null)
                    {
                        DamageData damageData = new DamageData();
                        damageData.damageValue = Database.GetPlayer().GetComponent<d_General_OffensiveStats>().flatDamage * (sad_ptr.damagePercent / 100);
                        damageReceiver.DamageInput(damageData);
                    }
                }
        }
        b2d.enabled = false;
    }
}