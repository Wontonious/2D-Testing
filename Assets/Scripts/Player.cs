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

    public GameObject canvas;
    public GameObject restartButton;

    GameObject[] enemyTag;
    bool runOnce = true;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    private void Update()
    {

        enemyTag = GameObject.FindGameObjectsWithTag("Enemy");
        int[] enemyCount = new int[enemyTag.Length];
        if(enemyCount.Length == 0)
        {
            Win();
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

        //FindObjectOfType<GameManager>().Restart();
        GameObject loserScreen = Instantiate(loseScreen) as GameObject;
        GameObject newButton = Instantiate(restartButton) as GameObject;
        newButton.transform.SetParent(canvas.transform, false);
        loserScreen.transform.SetParent(canvas.transform, false);
    }

    void Win()
    {
        if (runOnce)
        {
            runOnce = false;
            GameObject winnerScreen = Instantiate(winScreen) as GameObject;
            winnerScreen.transform.SetParent(canvas.transform, false);

            GameObject newButton = Instantiate(restartButton) as GameObject;
            newButton.transform.SetParent(canvas.transform, false);
        }
    }
}
