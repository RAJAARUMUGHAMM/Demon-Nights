using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public float isNear = 0;
    
    public GameObject bookmsg;
    // Start is called before the first frame update
    void Start()
    {
        bookmsg.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        Debug.Log("Collided");
        isNear = 1;
        bookmsg.SetActive(true);
    }
    private void OnTriggerExit(Collider player)
    {
        bookmsg.SetActive(false);
    }

   
}
