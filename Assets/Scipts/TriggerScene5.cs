using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene5 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        Debug.Log("Switch to scene 5");
        SceneManager.LoadScene(sceneName: "5-Battle");
    }
}
