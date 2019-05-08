using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Database")]
public class Database : ScriptableObject
{
    private static GameObject player;


    public static void RegPlayer(GameObject p)
    {
        player = p;
    }
    public static GameObject GetPlayer()
    {
        return player;
    }
}
