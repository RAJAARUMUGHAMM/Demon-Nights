using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditScreenScript : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        
    }
    public void SceneLoad()
    {
        SceneManager.LoadScene(SceneName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
