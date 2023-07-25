using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key1 : MonoBehaviour
{
    public float des = 0;
    public GameObject light;
    public GameObject door;
    public GameObject bookmsg;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")|| other.CompareTag("Light"))
        {
            //Debug.Log("Coll");
            des = 1;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)&&des==1)
        {
            gameObject.SetActive(false);
            door.SetActive(true);
            bookmsg.SetActive(false);
            light.transform.position=new Vector3(339.33f, -42.05f, 282.78f);
            light.transform.localScale=new Vector3(17.7f, 919.33f, 7.33f);
            //Destroy(GameObject.FindWithTag("Light"));
        }
    }
}
