using UnityEngine;

public class PelletCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (collision.CompareTag("Player"))
            {
                player.AddAmmo();
                Destroy(gameObject);
            }
        }
    }
}
