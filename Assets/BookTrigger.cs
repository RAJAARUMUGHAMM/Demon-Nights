using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BookTrigger : MonoBehaviour
{
    public string SceneName;
    public float isNear=0;
    public GameObject bookmsg;
    // Start is called before the first frame update
    void Start()
    {

    }
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        isNear = 1;
        bookmsg.SetActive(true);
            
       

    }
    private void OnTriggerExit(Collider other)
    {
        bookmsg.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)&& isNear==1)
        {
            SceneManager.LoadScene(SceneName);
        }

    }
}
