using UnityEngine;
using UnityEditor;

public class PlayerMovementInput : MonoBehaviour
{
    MovementData md;
    private void Start()
    {
        md = GetComponent<MovementData>();
    }

    void FixedUpdate()
    {
        if(md == null)
        {
            md = GetComponent<MovementData>();
        }
        if (md != null)
        {
            md.SetxAxis(Input.GetAxis("Horizontal"));
            md.SetyAxis(Input.GetAxis("Vertical"));
        }
    }
}
