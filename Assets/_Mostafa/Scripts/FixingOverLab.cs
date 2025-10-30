using UnityEngine;

public class FixingOverLab : MonoBehaviour
{
 
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "1") {
            StartCoroutine(DoSomethingAfterDelay(0));

        }
        if (other.tag == "2")
        {
            StartCoroutine(DoSomethingAfterDelay(1));

        }
        if (other.tag == "3")
        {
            StartCoroutine(DoSomethingAfterDelay(2));

        }
        if (other.tag == "4")
        {
            StartCoroutine(DoSomethingAfterDelay(3));

        }
    } 
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "1")
        {
            FindFirstObjectByType<PuzzelManger>().Sokets[0] = false;
        }
        if (other.tag == "2")
        {
            FindFirstObjectByType<PuzzelManger>().Sokets[1] = false;
        }
        if (other.tag == "3")
        {
            FindFirstObjectByType<PuzzelManger>().Sokets[2] = false;
        }
        if (other.tag == "4")
        {
            FindFirstObjectByType<PuzzelManger>().Sokets[3] = false;
        }
    }

    System.Collections.IEnumerator DoSomethingAfterDelay(int x)
    {
        yield return new WaitForSeconds(0.2f);
        FindFirstObjectByType<PuzzelManger>().Sokets[x] = true;

    }
}
