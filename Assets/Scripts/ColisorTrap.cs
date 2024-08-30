using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorTrap : MonoBehaviour
{
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerController.GameOver();
        }
    }
}
