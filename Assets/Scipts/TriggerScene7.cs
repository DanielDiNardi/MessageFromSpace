using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene7 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        Debug.Log("Switch to scene 7");
        SceneManager.LoadScene(sceneName: "7-EnemyFalls");
    }
}
