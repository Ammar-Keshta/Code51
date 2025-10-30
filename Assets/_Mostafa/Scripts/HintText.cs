using BNG;
using UnityEngine;

public class HintText : MonoBehaviour
{
    public GameObject hintText;
    public Transform Player;
    public bool amClose;
    public InputBridge bridge;
    public GameObject Quesutions;
    public float Distance;
    public bool canSolve;
    public int id;
    void Start()
    {
        
    }

    void Update()
    {
        Distance = Vector3.Distance(transform.position, Player.position);
        if (Vector3.Distance(transform.position, Player.position) < 3F && canSolve)
        {
            hintText.SetActive(true);
            amClose = true;
        }
        else
        {
            hintText.SetActive(false);
            amClose = false;
        }

        if (bridge.BButtonDown && canSolve && amClose  ) {
            Quesutions.SetActive(true);
            hintText.SetActive(false);


        }   
        
        if (Input.GetKeyDown(KeyCode.B) && canSolve && amClose) {
            Quesutions.SetActive(true);
            hintText.SetActive(false);
        }

        if (FindFirstObjectByType<QuestionsManger>().Questions[id] == true) { canSolve = false; } 
        
        else if(id!=4) { canSolve = true; }
    }
}
