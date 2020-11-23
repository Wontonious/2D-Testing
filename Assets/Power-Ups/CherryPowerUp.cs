using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryPowerUp : MonoBehaviour
{
    public int health = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);

            player.AddHealth(health);
        }
    }
}
