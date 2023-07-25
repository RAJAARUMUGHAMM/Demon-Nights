using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{
   public GameObject Theplayer;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Theplayer.transform);
    }
}
