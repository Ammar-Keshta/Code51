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
            FindFirstObjectByType<ScoreManger>().Score = 0 ;
            SceneManager.LoadScene("Level_1.1.1");

        }

        if (Bridge.YButtonDown)
            {
            FindFirstObjectByType<ScoreManger>().Score = 0;
            SceneManager.LoadScene("MainMenu");

            }
        
    }
}
