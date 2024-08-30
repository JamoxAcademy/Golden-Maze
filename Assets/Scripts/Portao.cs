using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portao : MonoBehaviour
{
    CoinManager coinManager;
    // Start is called before the first frame update
    void Start()
    {
        coinManager = FindObjectOfType<CoinManager>();
    }

    // Update is called once per frame
    void Update()
    {
        AbrirPortao();
        Debug.Log("iejrf");
    }

    void AbrirPortao()
    {
        if(coinManager.coletouTodas == true)
        {
            Destroy(gameObject);
        }
    }
}
