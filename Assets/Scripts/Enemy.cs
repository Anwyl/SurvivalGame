using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public BoxCollider territory;
    GameObject player;
    public Transform target;
    public float speed = 3f;

    bool playerinTerritory;

    public GameObject enemy;
    Monster monster;


    void Start()

    {
        Debug.Log(playerinTerritory);
        player = GameObject.FindGameObjectWithTag("Player");
        monster = enemy.GetComponent<Monster>();
        playerinTerritory = false;
    }

    void Update()
    {
        
        if(playerinTerritory == true)
        {
            transform.LookAt(target);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            playerinTerritory = true;
        }
    }


}
