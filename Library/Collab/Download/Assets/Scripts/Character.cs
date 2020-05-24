﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour{
    public Transform player;
    public float moveSpeed = 5.0f;
    private Rigidbody rb;
    private Vector2 movement;
   
    // Start is called before the first frame update
    void Start(){
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        Vector3 direction = player.position - transform.position;
        //Debug.Log(direction);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate(){
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2) transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    //void OnTriggerEnter(Collider other){
       // if (other.gameObject.CompareTag("Animal")){
            //transform.Translate(Vector3.forward * Time.deltaTime);
       // }
    //}
}
