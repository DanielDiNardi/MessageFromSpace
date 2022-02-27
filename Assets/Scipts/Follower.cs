using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour{

    public Vector3 velocity;
    public float currentSpeed;
    public Vector3 acceleration;
    public Vector3 force;
    public float speed = 5f;
    public float mass = 1;
    public float slowingDistance = 10;
    public float banking = 0.1f;
    public float damping = 0.1f;
    public Leader leader;
    public Vector3 offset;
    private Vector3 globalTargetPosition;
    private Vector3 targetPosition;

    public Vector3 CalculateOffsetPosition(Leader leader){

        globalTargetPosition = (leader.transform.rotation * offset) + leader.transform.position;

        float dist = Vector3.Distance(transform.position, globalTargetPosition);
        float time = dist / speed;

        targetPosition = globalTargetPosition + (leader.velocity * time);
        return Arrive(targetPosition);
    }

    public Vector3 Arrive(Vector3 target){

       Vector3 dir = target - transform.position;
       float dist = dir.magnitude;

       if (dist == 0.0f)
       {
           return Vector3.zero;
       }

       float ramped = (dist / slowingDistance) * speed;
       float clamped = Mathf.Min(ramped, speed);
       Vector3 desired = clamped * (dir / dist);

       return desired - velocity;
    }

    public Vector3 CalculateForce(){
        
        Vector3 f = Vector3.zero;

        f += CalculateOffsetPosition(leader);

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
