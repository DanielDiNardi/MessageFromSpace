using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource audioSource;
    private bool attack = true;

    IEnumerator PullTrigger()
    {
        attack = false;
        while(transform.parent.GetComponent<AngledShip>().stateString == "Attack")
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(bullet, transform.position, transform.rotation);
            audioSource.Play();
        }
        attack = true;
    }

    private void Awake()
    {
        audioSource = transform.parent.GetComponent<AudioSource>();
    }

    void Update()
    {
        if(attack)
        {
            StartCoroutine("PullTrigger");
        }
    }
}
