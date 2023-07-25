using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
               
                
            }
        }
        
    }
    public void Resume()
    {
        camera.SetActive(true);
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
    public void mainmenu()
    {
        Debug.Log("load");
        Resume();
        SceneManager.LoadScene("Dark");
    }
    public void Pause()
    {
        Cursor.visible = true;
        camera.SetActive(false);
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        isPaused = true;
    }
}
