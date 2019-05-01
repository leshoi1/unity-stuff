using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    Rigidbody2D rb2d;
    MovementData md;
    Transform trm;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        md = GetComponent<MovementData>();
        trm = GetComponent<Transform>();
    }

    void NullChecks()
    {
        if(md == null)
        {
            md = GetComponent<MovementData>();
        }

        if(rb2d == null)
        {
            rb2d = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        NullChecks();
        if (md != null && rb2d != null)
        {
            rb2d.velocity = new Vector2(md.GetxAxis(), md.GetyAxis()) * md.GetSpeed();
            if(md.xAxis < 0)
            {
                trm.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (md.xAxis > 0)
            {
                trm.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}
