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
            Title.text = "ﺎﻨﻫ ﻚﺘﻤﻬﻣ ﺖﻴﻬﻧﺍ";
        }
        else if (SM.Score >= 650)
        {
            Title.text = "ﺎﻨﻫ ﻚﺘﻤﻬﻣ ﺖﻴﻬﻧﺍ";
        }
        else if (SM.Score >= 400)
        {
            Title.text = "ﺎﻨﻫ ﻚﺘﻤﻬﻣ ﺖﻴﻬﻧﺍ";
        }
        else
        {
            Title.text = ".ﺔﻴﻘﻴﻘﺤﻟﺍ ﺓﺮﻴﺼﺒﻟﺍ ﺪﻌﺑ ﺪﺠﺗ ﻢﻟ  ﺝ";
        }

    }
}
