using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerrRoom : MonoBehaviour
{

    public bool playerIsTrackable;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerIsTrackable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerIsTrackable = false;
        }
    }

    public bool IsPlayerTrackable()
    {
        return playerIsTrackable;
    }

    public bool PlayerTrack()
    {
        return playerIsTrackable;
    }
}

