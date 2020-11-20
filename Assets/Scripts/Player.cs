using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public Rigidbody2D rb;

    public GameObject deathEffect;

    public GameObject loseScreen;

    public void playerDamaged(int damage)
    {

        health -= damage;
        Debug.Log("You have: " + health + " health left");


        if(health <= 0)
        {
            Die();
        }

    }


    void Die()
    {
        Destroy(gameObject);
        Debug.Log("You lost loser");

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Instantiate(loseScreen, transform.position, Quaternion.identity);
    }
}
