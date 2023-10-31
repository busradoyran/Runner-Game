using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScore;
    public bool gameOver;
    int score = 0;

    

    public void Update()
    {
        // player's position starts from negative numbers
        // and moves too fast better if the number moves slower
        if (gameOver)
        {
            score = PlayerPrefs.GetInt("Score",0);
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
        else
        {
            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);

            }
            score = (((int)player.position.z) + 198) /2;
            PlayerPrefs.SetInt("Score", score);
        }
        

        scoreText.text = score.ToString("0");
        

        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
    }

    // Play Again Button
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
