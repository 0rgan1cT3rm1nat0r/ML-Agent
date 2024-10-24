using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotated : MonoBehaviour
{
    public GameObject Target;

    void Update()
    {

        Vector3 Look = transform.InverseTransformPoint(Target.transform.position);
        float Angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg + 0;

        transform.Rotate(0, 0, Angle);
    }
}
