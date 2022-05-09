using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource audioSource;

    IEnumerator PullTrigger()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(bullet, transform.position, transform.rotation);
            audioSource.Play();
        }
    }

    private void Awake()
    {
        audioSource = transform.parent.GetComponent<AudioSource>();
    }

    void Start()
    {
        StartCoroutine("PullTrigger");
    }

    void Update()
    {

    }
}
