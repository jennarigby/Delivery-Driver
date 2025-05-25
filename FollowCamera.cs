using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject car;
    //Camera's position is the same as the cars

    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3(0, 0, -10);
    }
}
