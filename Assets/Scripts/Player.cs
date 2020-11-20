using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Rigidbody2D rb;

    public healthBar healthBar;

    public GameObject deathEffect;
    public GameObject loseScreen;

    public Button button;



    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void playerDamaged(int damage)
    {

        currentHealth -= damage;
        Debug.Log("You have: " + currentHealth + " health left");
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Die();
        }

    }


    void Die()
    {
        Destroy(gameObject);
        Debug.Log("You lost loser");

        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Instantiate(button, transform.position, Quaternion.identity);
        //FindObjectOfType<GameManager>().EndGame();

        //Instantiate(button, transform.position, Quaternion.identity);
    }
}
