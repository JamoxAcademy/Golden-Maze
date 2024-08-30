using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    PlayerController controller;
    [SerializeField] float velocidade;
    [SerializeField] float tempo;
    bool isMoveRight;
    // Start is called before the first frame update
    void Start()
    {
        isMoveRight = true;
        StartCoroutine(MoveRight());
        controller = FindObjectOfType<PlayerController>();
    }

    void direita() 
    {
        transform.Translate(velocidade, 0, 0);
    }

    void esquerda()
    {
        transform.Translate(-velocidade, 0, 0);
    }

    IEnumerator MoveRight()
    {
        direita();
        if (isMoveRight)
        {           
            yield return new WaitForSeconds(tempo);
            isMoveRight = false;
            StartCoroutine(MoveLeft());
        }      
    }

    IEnumerator MoveLeft()
    {
        esquerda();
        if (!isMoveRight)
        {        
            yield return new WaitForSeconds(tempo);
            isMoveRight = true;
            StartCoroutine(MoveRight());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            controller.GameOver();
        }
    }
}
