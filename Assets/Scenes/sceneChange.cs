using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class sceneChange : MonoBehaviour
{
    public void play(string F)
    {
        SceneManager.LoadScene(F);
    }
    public void Exit(string g)
    {
        SceneManager.LoadScene(g);
    }


}
