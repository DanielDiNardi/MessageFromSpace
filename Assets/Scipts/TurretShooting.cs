using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    public GameObject bullet;

    IEnumerator PullTrigger()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    void Start()
    {
        StartCoroutine("PullTrigger");
    }

    void Update()
    {

    }
}
