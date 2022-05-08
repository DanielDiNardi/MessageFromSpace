using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngledShip : MonoBehaviour
{

    Seek seek;
    Flee flee;
    public GameObject targetTurret;

    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<StateMachine>().ChangeState(new FindTurret());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class FindTurret : State
    {
        Seek seek;
        public GameObject targetTurret;

        public override void Enter()
        {
            owner.GetComponent<Flee>().enabled = false;
            seek = owner.GetComponent<Seek>();
            owner.GetComponent<Seek>().enabled = true;
            ChooseTurret();
        }

        public override void Think()
        {
            if(Vector3.Distance(targetTurret.transform.position, owner.transform.position) < 500f)
            {
                owner.GetComponent<StateMachine>().ChangeState(new FleeTurret(targetTurret.transform.position));
            }
        }

        public override void Exit()
        {
            
        }

        public void ChooseTurret()
        {
            GameObject[] turrets = FindObjectsOfType<GameObject>();
            List<GameObject> turretList = new List<GameObject>();

            for(var i = 0; i < turrets.Length; i++) {
                if(turrets[i].tag == "Turret") {
                    turretList.Add(turrets[i]);
                }
            }

            while(targetTurret == null) {
                int index = Random.Range(0, turretList.Count);

                targetTurret = turretList[index];
            }

            seek.target = targetTurret.transform.position;
        }
    }

    public class FleeTurret : State
    {
        Flee flee;
        Vector3 turretPosition;

        public FleeTurret(Vector3 turretPosition)
        {
            this.turretPosition = turretPosition;
        }

        public override void Enter()
        {
            owner.GetComponent<Seek>().enabled = false;
            flee = owner.GetComponent<Flee>();
            owner.GetComponent<Flee>().target = turretPosition;
            owner.GetComponent<Flee>().enabled = true;
        }

        public override void Think()
        {
            if(Vector3.Distance(turretPosition, owner.transform.position) > 2000f)
            {
                owner.GetComponent<StateMachine>().ChangeState(new FindTurret());
            }
        }

        public override void Exit()
        {
            
        }
    }
}
