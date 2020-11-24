using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform player;

    Vector3 position;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            position = player.transform.position;
            position.z = -15f;
            transform.position = position;
            transform.rotation = Quaternion.identity;
        }
        else return;
    }
}
