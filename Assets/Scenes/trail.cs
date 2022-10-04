using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class changeScenefrombutton : MonoBehaviour
{
    public void playGame(string F)
    {
        SceneManager.LoadScene(F);
    }
    public void back(string g)
    {
        SceneManager.LoadScene(g);
    }

}
