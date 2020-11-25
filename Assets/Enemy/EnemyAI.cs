using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{

    public Transform target;

    public float speed = 200f;
    public float nextWaypointDistance = 3f;

    public Transform enemyGFX;

    Path path;
    int currentWaypoint = 0;
    //bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;
    DetectPlayerrRoom detector;

    public bool playerIsTrackable = false;

    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponent<DetectPlayerrRoom>();
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        if (target != null)
        {
            InvokeRepeating(nameof(UpdatePath), 0f, 0.5f);
        }
        else return;
    }

    void UpdatePath()
    {
        if (target != null)
        {
            if (seeker.IsDone())
                seeker.StartPath(rb.position, target.position, OnPathComplete);
        }
    }
    
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != null)
        {
            if (path == null)
                return;

            if (currentWaypoint >= path.vectorPath.Count)
            {
                //reachedEndOfPath = true;
                return;
            }
            else
            {
                //reachedEndOfPath = false;
            }

            Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
            Vector2 force = direction * speed * Time.deltaTime;

            rb.AddForce(force);

            float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

            if (distance < nextWaypointDistance)
            {
                currentWaypoint++;
            }

            if (rb.velocity.x >= 0.01)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else if (rb.velocity.x <= 0.01)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
        else return;
    }
}
