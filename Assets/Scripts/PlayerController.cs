using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform partida;

    // int float bool string bool trge
    MeshRenderer mesh;
    // int numero = 9;
    // public private proteted 
    [SerializeField] float velocidade = 10f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = partida.position;
        mesh = GetComponent<MeshRenderer>();
        //apoieocanal();
    }

    // Update is called once per frame
    void Update()
    {
        //Condicional();
        MovePlayer();
    }

    void MovePlayer()
    {
        float eixoHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * velocidade;
        float eixoVertical = Input.GetAxis("Vertical") * Time.deltaTime * velocidade;
        transform.Translate(eixoHorizontal, 0, eixoVertical);
    }

    void apoieocanal()
    {
        Debug.Log("Se inscreva");
        Debug.Log("Ative o sininho");
        Debug.Log("Deixe o Like");

    }

    void Condicional()
    {
        if (mesh.enabled == true)
        {
            Debug.Log("Habilitado");
        }
        else if(mesh.enabled == false)
        {
            Debug.Log("Desabilitado");
        }
    }

    public void GameOver()
    {
        transform.position = partida.position;
    }

}
