using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCamera : MonoBehaviour
{
    public Transform PlayerTransform;
    public float yoffset;


    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 targetPosition = PlayerTransform.position;
        targetPosition.y += yoffset;
        transform.position = targetPosition;
    }

}
