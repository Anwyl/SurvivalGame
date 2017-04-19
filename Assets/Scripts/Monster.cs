using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    public Transform target;
    public float speed = 3f;
    public float attackRange = 1f;
    public int attackDamage = 2;
    public float timeBetweenAttacks;


    public void MoveToPlayer()
    {
        transform.LookAt(target.position);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
