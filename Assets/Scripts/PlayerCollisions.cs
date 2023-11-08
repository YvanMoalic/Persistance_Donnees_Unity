using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectible iCollect = other.GetComponent<Collectible>();
        if (iCollect != null)
        {
            iCollect.Collect();
            
        }
    }
}
