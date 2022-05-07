using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        Vector3 lookAtPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        transform.LookAt(lookAtPosition);

    }
}
