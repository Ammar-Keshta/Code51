using UnityEngine;
using UnityEngine.Events;

public class PuzzelManger : MonoBehaviour
{

    public bool[] Buzzels;
    public UnityEvent OnBuzzelSolved;
    private bool eventTriggered = false;
    public Transform Door;
    public GameObject[] Elements;
    public Animator Animator;
    public GameObject wall;
    void Start()
    {
        
    }

    void Update()
    {
        if (!eventTriggered && AllTrue())
        {
            eventTriggered = true;
            OnBuzzelSolved.Invoke();

            for (int i = 0; i < Elements.Length; i++)
            {
                Elements[i].transform.parent = Door.transform;
            }
            Animator.SetInteger("x", 1);
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

                wall.GetComponent<MeshCollider>().convex = false;
                print("OPENDOOR");
        }

        return true;


    }

}
