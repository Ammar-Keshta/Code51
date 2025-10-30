using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class QuestionsManger : MonoBehaviour
{

    public bool[] Questions;
    public UnityEvent OnQuestionsDone;
    private bool eventTriggered = false;
    public HintText Door;
    public Text counttext;
    public int count;
    //--------------------------
    [SerializeField] private Material targetMaterial; 
    [SerializeField] private string propertyName = "_DisTir";
    [SerializeField] private float fromValue = 0f; 
    [SerializeField] private float toValue = 1f;   
    [SerializeField] private float duration = 1f;

    public Light targetLight;
    [SerializeField] private float lightFromValue = 0f;
    [SerializeField] private float lightToValue = 10f;

    private float currentLerpTime;
    private bool isLerping;
    private bool goingForward = true;
    private bool playlerb = false;
    void Start()
    {
        targetLight.intensity = 0f;
        targetMaterial.SetFloat(propertyName, 0);
    }

    void Update()
    {
        counttext.text = count.ToString() + "/" + 4;

        if (!eventTriggered && AllTrue())
        {
            eventTriggered = true;
            OnQuestionsDone.Invoke();
        }
        if (Questions[0] && Questions[1] && Questions[2] && Questions[3]) {
            if (!playlerb) {
                playlerb = true;
                StartLerp();
            }


            if (Door.id == 4)
            {
                Door.canSolve = true;

            }
        }

        //----------------------------
        if (isLerping)
        {
            currentLerpTime += Time.deltaTime;
            float t = Mathf.Clamp01(currentLerpTime / duration);

            if (targetMaterial != null)
            {
                float shaderValue = Mathf.Lerp(fromValue, toValue, t);
                targetMaterial.SetFloat(propertyName, shaderValue);
            }

            if (targetLight != null)
            {
                float lightValue = Mathf.Lerp(lightFromValue, lightToValue, t);
                targetLight.intensity = lightValue;
            }

            if (t >= 1f)
            {
                isLerping = false;
                goingForward = !goingForward;
                SwapValues(ref fromValue, ref toValue);
                SwapValues(ref lightFromValue, ref lightToValue);

            }
        }
    }
    private void SwapValues(ref float a, ref float b)
    {
        float temp = a;
        a = b;
        b = temp;
    }
    public void StartLerp()
    {
        currentLerpTime = 0f;
        isLerping = true;
    }
    public void restquestions()
    {
        for (int i = 0; i < Questions.Length; i++)
        {
            Questions[i] = false;
        }
        count = 0;
        Door.canSolve = false;
        playlerb = false;
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
