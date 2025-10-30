using BNG;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BlackSceneManger : MonoBehaviour
{
     public InputBridge Bridge;
    void Start()
    {
        
    }

    void Update()
    {
       
            if (Bridge.XButtonDown)
            {

            SceneManager.LoadScene("Level_1.1.1");

        }

        if (Bridge.YButtonDown)
            {

                SceneManager.LoadScene("MainMenu");

            }
        
    }
}
