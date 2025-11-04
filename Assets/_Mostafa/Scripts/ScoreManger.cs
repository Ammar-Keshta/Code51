using UnityEngine;

public class ScoreManger : MonoBehaviour
{

    public int Score;
   void Start()
    {
       DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }
 
    public void AddToScore(int _count) { Score = Score + _count; }
    public void MinusToScore(int _count) { Debug.Log("wrong"); Score = Score - _count; }
}
