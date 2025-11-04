using UnityEngine;
using UnityEngine.Events;

public class QuestionManger : MonoBehaviour
{
    public bool LastQuestion;
    public AudioClip[] Clips;
    public AudioSource source;
    public UnityEvent OnQuestiosDone;
    private bool eventTriggered = false;
    public int id;
    bool isasnwertrue;
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
                    if (!isasnwertrue)
                    {
                        FindFirstObjectByType<ScoreManger>().AddToScore(150);
                        isasnwertrue = true;
                    }

                    FindFirstObjectByType<QuestionsManger>().Questions[id] = true;
                    FindFirstObjectByType<QuestionsManger>().count += 1;
                    source.clip = Clips[0];
                    source.Play();
                    transform.root.gameObject.SetActive(false);

                    break;


                case false:
                    FindFirstObjectByType<QuestionsManger>().restquestions();
                    FindFirstObjectByType<ScoreManger>().MinusToScore(25);

                    source.clip = Clips[1];
                    source.Play();
                    transform.root.gameObject.SetActive(false);
                    if (FindFirstObjectByType<QuestionsManger>().targetLight.intensity > 0) {
                    FindFirstObjectByType<QuestionsManger>().StartLerp();

                    }

                    break;
            }



        }
        else {
            if (!eventTriggered)
            {
                eventTriggered = true;
                OnQuestiosDone.Invoke();
                transform.parent.gameObject.SetActive(false);

            }

        }
    }
}
