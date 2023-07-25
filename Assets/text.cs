using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public float timer=0;
    public GameObject textline;
    // Start is called before the first frame update
    void Start()
    {
        textline.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer=timer + Time.deltaTime;
        if(timer>12){
            textline.SetActive(false);
        }
        
        
    }
}
