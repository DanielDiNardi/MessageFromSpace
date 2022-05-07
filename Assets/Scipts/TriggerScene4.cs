using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene4 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        Debug.Log("Switch to scene 4");
        // SceneManager.LoadScene(sceneName: "4-TurretCloseUp");
    }
}
