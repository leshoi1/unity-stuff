using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    Rigidbody2D rb2d;
    MovementData md;
    Transform trm;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        md = GetComponent<MovementData>();
        trm = GetComponent<Transform>();
    }

    void Update()
    {
        if (md.GetxAxis() != 0 || md.GetyAxis() != 0) {
            rb2d.velocity = new Vector2(md.GetxAxis(), md.GetyAxis()) * (md.GetSpeed() * Time.deltaTime / (float)Mathf.Sqrt(Mathf.Abs(md.GetxAxis()) + Mathf.Abs(md.GetyAxis())));
        }
        else
        {
            rb2d.velocity = new Vector2(0f, 0f);
        }
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
