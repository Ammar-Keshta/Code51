using UnityEngine;
using UnityEngine.Events;

public class QuestionManger : MonoBehaviour
{
    public GameObject NextQuestion;
    public bool LastQuestion;
    public AudioClip[] Clips;
    public AudioSource source;
    public UnityEvent OnQuestiosDone;
    private bool eventTriggered = false;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnClickAnswer(bool _true)
    {

        if (!LastQuestion)
        {

            switch (_true)
            {

                case true:
                    source.clip = Clips[0];
                    source.Play();
                    this.gameObject.SetActive(false);
                    NextQuestion.SetActive(true);
                    break;


                case false:
                    source.clip = Clips[1];
                    source.Play();
                    this.gameObject.SetActive(false);
                    NextQuestion.SetActive(true);
                    break;
            }



        }
        else {
            if (!eventTriggered)
            {
                eventTriggered = true;
                OnQuestiosDone.Invoke();
                this.gameObject.SetActive(false);

            }

        }
    }
}
