using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseRegister : MonoBehaviour
{
    private void Awake()
    {
        Database.RegPlayer(gameObject);
    }
}
