using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void mainmenu()
    {
        Debug.Log("load");
        SceneManager.LoadScene("Dark");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
