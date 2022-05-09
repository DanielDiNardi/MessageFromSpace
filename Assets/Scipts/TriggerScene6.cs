using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene6 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        Debug.Log("Switch to scene 6");
        SceneManager.LoadScene(sceneName: "6-BomberDetach");
    }
}
