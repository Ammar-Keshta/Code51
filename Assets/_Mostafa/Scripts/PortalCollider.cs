using BNG;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalCollider : MonoBehaviour
{

    public InputBridge Bridge;
    public GameObject Hint;
    bool AmInArea;
    void Start()
    {
        AmInArea = false;
    }

    void Update()
    {
        if (Bridge.XButtonDown && AmInArea) {

            SceneManager.LoadScene("Blackscene");
        
        }
        if (Input.GetKeyDown(KeyCode.X) && AmInArea)
        {

            SceneManager.LoadScene("Blackscene");

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Portal")) {
            AmInArea = true;
            Hint.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Portal"))
        {
            AmInArea = false;
            Hint.SetActive(false);
        }
    }
}
