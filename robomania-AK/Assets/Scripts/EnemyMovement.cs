using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    private Rigidbody2D enemyRigidBody;
    void start(){
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate(){
        if(transform.position.x <= -8){
            
        }
        if(transform.position.x >= 8){
            
        }
        
    }
}
