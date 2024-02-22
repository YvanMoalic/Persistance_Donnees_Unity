using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private GameObject overlapedActor;
    private bool onForgeron;


    private void OnTriggerEnter(Collider other)
    {
        overlapedActor= other.gameObject;
        ICollectible iCollect = other.GetComponent<Collectible>();
        if (iCollect != null)
        {
            iCollect.Collect();
        }

        if (other.CompareTag("Forgeron"))
        {
            onForgeron= true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Forgeron"))
        {
            onForgeron = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onForgeron == true)
        {
            overlapedActor.GetComponent<Quete>().StartQuest();

        }
    }
}
