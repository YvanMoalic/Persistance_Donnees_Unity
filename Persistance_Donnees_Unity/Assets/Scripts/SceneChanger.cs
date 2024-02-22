using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            if(SceneManager.GetActiveScene().buildIndex == 0)
            {
                SceneManager.LoadScene("Niveau2");
            }

            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene("Niveau1");
            }

        }
    }
}
