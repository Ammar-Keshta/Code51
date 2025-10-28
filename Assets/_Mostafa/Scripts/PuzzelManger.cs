using UnityEngine;
using UnityEngine.Events;

public class PuzzelManger : MonoBehaviour
{

    public bool[] Buzzels;
    public UnityEvent OnBuzzelSolved;
    private bool eventTriggered = false; 

    void Start()
    {
        
    }

    void Update()
    {
        if (!eventTriggered && AllTrue())
        {
            eventTriggered = true;
            OnBuzzelSolved.Invoke();
        }
    }

    private bool AllTrue()
    {
        if (Buzzels == null || Buzzels.Length == 0)
            return false;

        for (int i = 0; i < Buzzels.Length; i++)
        {
            if (!Buzzels[i])
                return false;
        }

        return true;
    }
}
