using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keydestroy : MonoBehaviour
{
    public GameObject key;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Debug.Log("Coll");
            //Destroy(this.gameObject);
        }
    }
}
