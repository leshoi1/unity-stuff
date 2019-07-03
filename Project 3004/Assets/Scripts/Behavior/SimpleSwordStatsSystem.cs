using UnityEngine;

public class SimpleSwordStatsSystem : MonoBehaviour
{
    SimpleSwordData sd;
    d_General_OffensiveStats dd;
    private void Awake()
    {
     //   sd = GetComponent<SimpleSwordData>();
     //   dd = Database.GetPlayer().GetComponent<DamageData>();
    }

    void Start()
    {
        sd = GetComponent<SimpleSwordData>();
        dd = Database.GetPlayer().GetComponent<d_General_OffensiveStats>();
        dd.flatDamage += sd.baseDamage;
    }
}
