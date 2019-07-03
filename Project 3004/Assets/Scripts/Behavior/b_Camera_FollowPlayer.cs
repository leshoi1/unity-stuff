using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_Camera_FollowPlayer : MonoBehaviour
{
    Transform cameraTransform;
    Transform playerTransform;
    public float speed = 5f;

    private void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    void Update()
    {
        if (playerTransform == null)
        {
            playerTransform = Database.GetPlayer().GetComponent<Transform>();
        }
        else
        {
            Vector3 cameraPosition = Vector3.Lerp(cameraTransform.position, playerTransform.position, Time.deltaTime * speed);
            cameraPosition.z = -10;
            cameraTransform.position = cameraPosition;
        }
    }
}
