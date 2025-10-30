using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class QuestionsManger : MonoBehaviour
{

    public bool[] Questions;
    public UnityEvent OnQuestionsDone;
    private bool eventTriggered = false;
    public HintText Door;
    void Start()
    {
        
    }

    void Update()
    {
        if (!eventTriggered && AllTrue())
        {
            eventTriggered = true;
            OnQuestionsDone.Invoke();
        }
        if (Questions[0] && Questions[1] && Questions[2] && Questions[3]) {

            if (Door.id == 4)
            {
                Door.canSolve = true;
            }
        }
    }

    public void restquestions()
    {
        for (int i = 0; i < Questions.Length; i++)
        {
            Questions[i] = false;
        }
    }

    private bool AllTrue()
    {
        if (Questions == null || Questions.Length == 0)
            return false;

        for (int i = 0; i < Questions.Length; i++)
        {
            if (!Questions[i])
                return false;
        }

        return true;
    }

    public void OnSolved(string name) {

        SceneManager.LoadScene(name);
    }

}
