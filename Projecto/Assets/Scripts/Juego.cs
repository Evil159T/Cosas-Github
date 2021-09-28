using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Juego : MonoBehaviour
{
    bool active;
    Canvas canvas;

    public Pause pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void ContinueGame()
    {

        Debug.Log("CONTINUE");
        Time.timeScale = 1f;
       
    }


}
