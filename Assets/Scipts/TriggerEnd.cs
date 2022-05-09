using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        Debug.Log("End");
        Application.Quit();
    }
}
