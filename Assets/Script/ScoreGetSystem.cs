using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreGetSystem : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score = 0 ;

    public void UpdateUI()
    {
        score++;
        scoreText.text  = score.ToString();
    }

}
