using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene3 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        Debug.Log("Switch to scene 3");
        SceneManager.LoadScene(sceneName: "3-EnemySpotted");
    }
}
