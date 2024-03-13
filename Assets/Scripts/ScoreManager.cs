using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    #region Singleton

    private static ScoreManager instance;

    public static ScoreManager Instance 
    {
        get 
        {
            return instance;
        }
    }

    void Awake() 
    {
        if (instance == null)
        {
            instance = this;
            return;
        }

        Destroy(gameObject);
    }

    #endregion

    [SerializeField] TMP_Text scoreText;

    int currentScore;

    public void AddScore() 
    {
        currentScore += 1;

        scoreText.text = currentScore.ToString();
    }
}
