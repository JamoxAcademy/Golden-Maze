using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorInvisivel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Parabens");
        }
    }

}
