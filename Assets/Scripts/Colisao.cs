using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colidiu");
        GetComponent<MeshRenderer>().material.color = Color.red;

        playerController.GameOver();
    }

    private void OnCollisionExit(Collision collision)
    {
      
        Debug.Log("Nao esta colidindo");
        GetComponent<MeshRenderer>().material.color = Color.magenta;
       
    }
}
