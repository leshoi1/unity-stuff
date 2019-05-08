using UnityEngine;
using UnityEditor;

public class PlayerMovementInput : MonoBehaviour
{
    MovementData md;
    private void Awake()
    {
        md = GetComponent<MovementData>();
    }

    void FixedUpdate()
    {
        md.SetxAxis(Input.GetAxis("Horizontal"));
        md.SetyAxis(Input.GetAxis("Vertical"));
    }
}
