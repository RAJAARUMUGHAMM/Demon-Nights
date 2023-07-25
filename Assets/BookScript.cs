using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BookScript : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(SceneName);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
