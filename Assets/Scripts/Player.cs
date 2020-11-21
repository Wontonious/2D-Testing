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

    public GameObject winScreen;

    int[] enemy = new int[18];
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void FixedUpdate()
    {
        for (int i = 0; i < enemy.Length; i++)
        {

            int[i] enemy = new int gameObject.FindGameObjectsWithTag("Enemy")[i];
        }
        if (enemy.Length == 0)
        {
            Instantiate(winScreen, transform.position, Quaternion.identity);
        }
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
        Instantiate(loseScreen, transform.position, Quaternion.identity);
    }
}
