using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAngledShip : MonoBehaviour
{
    public GameObject targetAngledShip;

    public void ChooseTurret()
    {
        GameObject[] angledShips = FindObjectsOfType<GameObject>();
        List<GameObject> angledShipsList = new List<GameObject>();

        for(var i = 0; i < angledShips.Length; i++) {
            if(angledShips[i].tag == "AngledShip") {
                angledShipsList.Add(angledShips[i]);
            }
        }

        while(targetAngledShip == null) {
            int index = Random.Range(0, angledShipsList.Count);

            targetAngledShip = angledShipsList[index];
        }
    }

    void Awake() 
    {
        ChooseTurret();
    }

    void Update()
    {
        transform.LookAt(targetAngledShip.transform.position);
        transform.rotation *= Quaternion.FromToRotation(Vector3.back, Vector3.forward);
    }
}