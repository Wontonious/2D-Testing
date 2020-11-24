using UnityEngine;

public class DetectPlayerRoom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EnemyAI enemyAI = GetComponent<EnemyAI>();
            enemyAI.PlayerInRoom();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EnemyAI enemyAI = GetComponent<EnemyAI>();
            enemyAI.PlayerOutRoom();
        }
    }
}
