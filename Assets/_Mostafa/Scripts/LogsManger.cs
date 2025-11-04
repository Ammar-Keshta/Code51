using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class LogsManger : MonoBehaviour
{
    private ScoreManger SM;
    public Text Score;
    public Text Title;
    void Start()
    {
        SM = FindFirstObjectByType<ScoreManger>();
    }

    void Update()
    {
        Score.text = SM.Score.ToString();

        if (SM.Score >= 850)
        {
            Title.text =  "(S) You have mastered the noise.";
        }
        else if (SM.Score >= 650)
        {
            Title.text = "(A) Your insight is stronger than most.";
        }
        else if (SM.Score >= 400)
        {
            Title.text = "(B) Well done… but the noise still haunts you.";
        }
        else
        {
            Title.text = "(C) You have yet to find true insight.";
        }

    }
}
