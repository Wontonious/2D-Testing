using UnityEngine;

public class TutorialRoom : MonoBehaviour
{
    public GameObject door;

    public GameObject[] enemies;

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("TutorialEnemy");

        if (enemies.Length == 0)
        {
            Destroy(door);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

    }
}
