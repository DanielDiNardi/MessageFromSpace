using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipForward : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
