using UnityEngine;

public class SimpleSwordStatsSystem : MonoBehaviour
{
    SimpleSwordData sd;
    DamageData dd;
    private void Awake()
    {
     //   sd = GetComponent<SimpleSwordData>();
     //   dd = Database.GetPlayer().GetComponent<DamageData>();
    }

    void Start()
    {
        sd = GetComponent<SimpleSwordData>();
        dd = Database.GetPlayer().GetComponent<DamageData>();
        dd.flatDamage += sd.baseDamage;
    }
}
