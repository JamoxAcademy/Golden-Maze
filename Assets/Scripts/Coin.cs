using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    CoinManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<CoinManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotacao();
    }

    void Rotacao()
    {
        transform.Rotate(0, 0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            manager.Coleta();
            Destroy(gameObject);
        }
    }
}
