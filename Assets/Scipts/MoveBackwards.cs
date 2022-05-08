using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MonoBehaviour
{
    public float speed = 500f;

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    private void Start()
    {
        StartCoroutine("Destroy");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * Time.deltaTime * speed;
    }
}
