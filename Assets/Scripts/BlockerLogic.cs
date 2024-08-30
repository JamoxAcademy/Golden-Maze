using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerLogic : MonoBehaviour
{

    MeshRenderer mesh;
    BoxCollider box;
    [SerializeField] float time;
    PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        box = GetComponent<BoxCollider>();
        player = FindObjectOfType<PlayerController>();
        StartCoroutine(NaoPodePassar());
    }
    //J
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NaoPodePassar()
    {
        mesh.material.color = Color.red;
        box.enabled = true;
        if (box.enabled == true)
        {   
            yield return new WaitForSeconds(time);
            StartCoroutine(PodePassar());
        }
    }

    IEnumerator PodePassar()
    {
        mesh.material.color = Color.green;
        box.enabled = false;
        if(mesh.material.color == Color.green)
        {
            yield return new WaitForSeconds(time);
            StartCoroutine(NaoPodePassar());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.GameOver();
        }
    }
}
