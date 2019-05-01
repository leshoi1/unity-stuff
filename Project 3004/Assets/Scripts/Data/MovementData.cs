using UnityEngine;

public class MovementData : MonoBehaviour
{
    public float xAxis;
    public float yAxis;
    public float Speed;

    public float GetxAxis()
    {
        return xAxis;
    }
    public float GetyAxis()
    {
        return yAxis;
    }
    public float GetSpeed()
    {
        return Speed;
    }

    public void SetxAxis(float value)
    {
        xAxis = value;
    }

    public void SetyAxis(float value)
    {
        yAxis = value;
    }

    public void SetSpeed(float value)
    {
        Speed = value;
    }
}
