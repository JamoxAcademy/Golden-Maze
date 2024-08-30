using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObs : MonoBehaviour
{

    [SerializeField] float value;

    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotacao();
    }

    void Rotacao()
    {
        transform.Rotate(0, value, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerController.GameOver();
        }
    }
}
