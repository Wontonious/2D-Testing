using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPreFab;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Player player = gameObject.GetComponent<Player>();
        if (player.AmmoChecker() == true)
        {
            GameObject bullet = Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

            player.ShootAmmo();
        }
        if (player.AmmoChecker() == false)
        {
            player.OutOfAmmo();
        }
    }
}
