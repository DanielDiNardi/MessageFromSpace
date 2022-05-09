using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipForward : MonoBehaviour
{
    public float speed = 10f;

    IEnumerator ActivateBoosters()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Boosters Activated");
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ActivateBoosters");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
