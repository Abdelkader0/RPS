using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int PlayerScore { get; private set; }

    public Text Result;
    public Image AIChoice;
    public Text playerScoreText; // Reference to the player score UI text
    public Text aiScoreText; // Reference to the AI score UI text
    public static string Winner;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

    private int playerScore = 0;
    private int aiScore = 0;
    private int winningScore = 3; // Set the default winning score to 3

    public void Play(string myChoice)
    {


        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case "Rock":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Tie!";
                        break;

                    case "Paper":
                        Result.text = "The paper covers the rock, you win!";
                        playerScore++;
                        break;

                    case "Scissors":
                        Result.text = "The rock destroys the scissors, you lose!";
                        aiScore++;
                        break;

                }

                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "The paper covers the rock, you lose!";
                        aiScore++;
                        break;

                    case "Paper":
                        Result.text = "Tie!";
                        break;

                    case "Scissors":
                        Result.text = "The scissors cuts the paper, you win!";
                        playerScore++;
                        break;

                }

                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "The rock destroys the scissors, you win!";
                        playerScore++;
                        break;

                    case "Paper":
                        Result.text = "The scissors cuts the paper, you win!";
                        playerScore++;
                        break;

                    case "Scissors":
                        Result.text = "Tie!";
                        break;

                }

                AIChoice.sprite = Scissors;
                break;

        }
        CheckGameWinner();
        UpdateScores();

    }
    void UpdateScores()
    {
        // Update both player and AI scores on the UI
        playerScoreText.text = playerScore.ToString();
        aiScoreText.text = aiScore.ToString();
    }
    public void RestartGame()
    {
        // Code to start the game (replace with your game's logic
         SceneManager.LoadScene("Setting", LoadSceneMode.Single); // Load Settings scene
       
    }
     string CheckGameWinner()
    {

        if (playerScore == winningScore)
        {
            Result.text = "You Win! ;)";
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single); // Load GameOver scene

        }
        else if (aiScore == winningScore)
        {
            Result.text = "You Lose! and the AI Destroy you F*ckin loser";
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single); // Load GameOver scene
        }
        return Winner;
    }


}



