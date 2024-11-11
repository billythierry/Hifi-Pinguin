using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinScript : MonoBehaviour
{
    public Rigidbody2D myRigitBody;
    public float flapStrength;
    public LogicScript logic;
    public bool IsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsAlive)
        {
            myRigitBody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y < -6.3 || transform.position.y > 6.3 && IsAlive)
        {
            if (IsAlive)
            {
            GameOver();
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            logic.quitGame();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    private void GameOver()
    {
        logic.gameOver();
        IsAlive = false;
        Time.timeScale = 0; // Menghentikan waktu ketika game over
    }
}
