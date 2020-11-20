using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1.10f);
        Destroy(gameObject);

        Enemy badGuy = collision.gameObject.GetComponent<Enemy>();
        if(collision.gameObject.tag == "Enemy")
        {
            badGuy.TakeDamage(damage);
        }
    }
}
