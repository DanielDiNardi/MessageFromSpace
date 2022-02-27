using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader : MonoBehaviour{

    public Vector3 velocity;
    public float currentSpeed;
    public Vector3 acceleration;
    public Vector3 force;
    public float speed = 5f;
    public float mass = 1;
    public float banking = 0.1f;
    public float damping = 0.1f;

    

    public Vector3 CalculateForce(){
        
        Vector3 f = Vector3.zero;

        f += f/* Behaviour */;

        return f;
    }

    void Update(){

        force = CalculateForce();
        acceleration = force / mass;
        velocity = velocity + acceleration * Time.deltaTime;
        transform.position = transform.position + velocity * Time.deltaTime;
        currentSpeed = velocity.magnitude;
        if (currentSpeed > 0)
        {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + (acceleration * banking), Time.deltaTime * 3.0f);
            transform.LookAt(transform.position + velocity, tempUp);

            velocity -= (damping * velocity * Time.deltaTime);
        }        
    }
}
