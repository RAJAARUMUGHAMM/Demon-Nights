using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlButtonScript : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SceneLoad()
    {
       
        screen.SetActive(true);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
