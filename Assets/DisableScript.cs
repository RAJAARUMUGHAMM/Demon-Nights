using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScript : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SceneLoad()
    {
        screen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
