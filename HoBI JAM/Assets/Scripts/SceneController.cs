using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{

    public void UploadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
