using UnityEngine;

public class b_General_Movement : MonoBehaviour
{
    Rigidbody2D rb2d_ptr;
    d_General_UtilityStats utilStats_ptr;
    Transform trm_ptr;
    d_General_Input genInput_ptr;

    private void Awake()
    {
        rb2d_ptr = GetComponent<Rigidbody2D>();
        utilStats_ptr = GetComponent<d_General_UtilityStats>();
        trm_ptr = GetComponent<Transform>();
        genInput_ptr = GetComponent<d_General_Input>();
    }

    void Update()
    {
        if (genInput_ptr.xAxis != 0 || genInput_ptr.yAxis != 0) {
            rb2d_ptr.velocity = new Vector2(genInput_ptr.xAxis, genInput_ptr.yAxis) * (utilStats_ptr.maxSpeed * Time.deltaTime / (float)Mathf.Sqrt(Mathf.Abs(genInput_ptr.xAxis) + Mathf.Abs(genInput_ptr.yAxis)));
        }
        else
        {
            rb2d_ptr.velocity = new Vector2(0f, 0f);
        }
        if(genInput_ptr.xAxis < 0)
        {
            trm_ptr.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (genInput_ptr.xAxis > 0)
        {
            trm_ptr.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
