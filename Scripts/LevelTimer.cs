using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    private float timer = 0f;
    public float Timer => this.timer;

    private GameController gameController;

    
    private bool isTimerStarted = false;
    public bool IsTimerStarted => this.isTimerStarted;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isTimerStarted)
            this.timer += Time.deltaTime;
    }

    private void OnGUI()
    {
        if (this.isTimerStarted)
        {
            GUI.Label(new Rect(10, 10, 200, 50), "Level Time: " + this.timer.ToString("F2") + " seconds\nBump Count: " + this.gameController.Ball.ObstacleBumpCount.ToString());
        }
            
    }

    public void StartTimer()
    {
        if (!this.isTimerStarted)
        {
            this.isTimerStarted = true;
        }
    }

    public void StopTimer()
    {
        this.isTimerStarted = false;
        this.gameController.IsGameFinished = true;

        Time.timeScale = 0;
    }
}
