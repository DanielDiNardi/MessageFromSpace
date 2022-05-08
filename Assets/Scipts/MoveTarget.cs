using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public Transform endPosition;
    public float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, endPosition.position, speed * Time.deltaTime / Vector3.Distance(transform.position, endPosition.position));
    }
}
