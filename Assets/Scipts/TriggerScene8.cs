using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene8 : MonoBehaviour
{
    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(sceneName: "8-Victory");
    }

    void OnTriggerEnter(Collider collider){
        Debug.Log("Switch to scene 8");
        StartCoroutine("SwitchScene");
    }
}
