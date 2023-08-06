using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //Restart the Scene (Testing purposes) 
    void Update()
    {


        if(Input.GetKeyDown(KeyCode.R)) {

            Reload(); 
        
        }


        if(Input.GetKeyDown(KeyCode.Escape))
        {

            Exit();
        }

    }

    void Reload()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Exit Program (Testing Purposes)
    void Exit()
    {
        Application.Quit();
    }
}
