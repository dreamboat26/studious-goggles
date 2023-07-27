using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool isGameStarted = false;
    public bool IsGameStarted => this.isGameStarted;

    private bool isGameFinished = false;
    public bool IsGameFinished
    {
        get { return this.isGameFinished; }
        set { this.isGameFinished = value; }
    }

    private GUIStyle helpText = new GUIStyle();

    private BallBehaviour ball;
    public BallBehaviour Ball => this.ball;
    private LevelTimer levelTimer;

    // Start is called before the first frame update
    void Start()
    {
        this.helpText.alignment = TextAnchor.MiddleCenter;
        this.helpText.fontSize = 20;
        this.helpText.fontStyle = FontStyle.Bold;

        this.ball = GameObject.FindObjectOfType<BallBehaviour>();
        this.levelTimer = this.gameObject.GetComponent<LevelTimer>();

        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isGameStarted)
        {
            if (Input.anyKeyDown)
            {
                Time.timeScale = 1;
                this.isGameStarted = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void OnGUI()
    {
        if (!this.isGameStarted)
        {
            GUI.Label(new Rect((float)Display.main.renderingWidth / 2 - 250, (float)Display.main.renderingHeight / 2 -250,
                      500, 500), "Welcome to Obstacle Course!\n\nGet the ball to the finish line as fast as possible without bumping into anything.\n\n" +
                                 "Alter the ground inclination's angle by moving the mouse, the ball will react to this. Be careful!\nStepping outside the red square will start the timer." +
                                 "\n\nPress R to restart from the beginning.\nPress Esc to make the mouse cursor appear." +
                                 "\nPress Q to quit the game\n\nPress any key to begin.",
                      this.helpText);
        }

        if (this.isGameFinished)
        {
            GUI.Label(new Rect((float)Display.main.renderingWidth / 2 - 250, (float)Display.main.renderingHeight / 2 - 250,
                      500, 500), "Congratulations!\nYou completed the obstacle course!\n\n Your total time is: " + this.levelTimer.Timer.ToString("F2") + " seconds\n\n" +
                                 "You bumped into " + this.ball.ObstacleBumpCount.ToString() + " obstacles\n\nPress R to Retry or Q to quit the game.",
                      this.helpText);
        }
    }
}
