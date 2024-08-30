using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField]int totalCoin;
    [SerializeField]int currentCoin;
    public bool coletouTodas;
    // Start is called before the first frame update
    void Start()
    {
        coletouTodas = false;
        currentCoin = totalCoin;
    }

    // Update is called once per frame
    void Update()
    {
        ColetouTodas();
    }
    
    void ColetouTodas()
    {
        if(currentCoin == 0)
        {
            coletouTodas = true;
        }
    }

    public void Coleta()
    {
        currentCoin--;
    }
}
