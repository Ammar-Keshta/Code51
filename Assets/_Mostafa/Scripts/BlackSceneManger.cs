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
        if (SceneManager.GetActiveScene().name == "Blackscene")
        {
            if (Bridge.XButtonDown)
            {

                Application.Quit();

            }

            if (Bridge.YButtonDown)
            {

                SceneManager.LoadScene("SampleScene");

            }
        }
    }
}
