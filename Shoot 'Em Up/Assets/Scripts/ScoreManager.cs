using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    private const string s = "Score\t\tHi-Score\n";
    private int score = 0, hiScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI.text = s + score.ToString("D4") + "\t\t" + hiScore.ToString("D4");
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = s +score.ToString("D4") + "\t\t" + hiScore.ToString("D4");
    }

    public void Scored(int value)
    {
        switch (value)
        {
            case 1:
                score += 10;
                break;
            case 2:
                score += 20;
                break;
            case 3:
                score += 30;
                break;
            case 4:
                score += 100;
                break;
            default:
                break;
        }
    }
    public void onDeath()
    {
        if (hiScore < score){
            hiScore = score;
        }
        score = 0;
    }
}
