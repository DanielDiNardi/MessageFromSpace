using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;
    public float speed = 50f;

    void Awake()
    {
        transform.position = startPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, endPosition.position, speed * Time.deltaTime / Vector3.Distance(startPosition.position, endPosition.position));
    }
}
