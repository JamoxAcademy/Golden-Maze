using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapControll : MonoBehaviour
{
    [SerializeField] GameObject trapObject;
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {
        trapObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("ddd");
            StartCoroutine(AtiveTrap());
        }
    }

    IEnumerator AtiveTrap()
    {
        
        trapObject.SetActive(true);
        yield return new WaitForSeconds(time);
        trapObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
