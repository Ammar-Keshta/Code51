using UnityEngine;
using UnityEngine.SceneManagement;

public class Waiting : MonoBehaviour
{
    public float timetowait = 5f; 
    public string scenename; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("wait", timetowait);

    }

    // Update is called once per frame
    void Update()
    {

    }



public void wait()
{

    SceneManager.LoadScene(scenename);
}
}
