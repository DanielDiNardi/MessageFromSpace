using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipForward : MonoBehaviour
{
    public float speed = 10f;
    public AudioSource audioSource;

    IEnumerator PlayBoosterSound()
    {
        yield return new WaitForSeconds(4);
        audioSource.Play();
        audioSource.loop = true;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine("PlayBoosterSound");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
