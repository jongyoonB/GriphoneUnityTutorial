using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject pickUpPrefab;
    public UiController uiController;
    public int maxCube;
    public int count;
    public float timeLap;
    private bool isGameStart;
    public bool isGameOver;

    void Start()
    {
        uiController = GetComponent<UiController>();
        count = maxCube;
    }

    void FixedUpdate()
    {
        if (isGameStart)
        {
            if (!isGameOver)
            {
                timeLap = uiController.SetTimerText(timeLap);
                if (count == 0)
                {
                    isGameOver = true;
                    uiController.SetNameField();
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Restart Game");
                RestartGame();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log("Reset Records");
                PlayerPrefs.DeleteAll();
            }
            if (Input.GetKeyDown(KeyCode.Space)){
                CreateCube();
                isGameStart = true;
                Debug.Log("Game Start");
                uiController.SetInstructionText("");
            }
        }
    }

    void RestartGame()
    {
        timeLap = 0;
        count = maxCube;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void CreateCube()
    {
        //create cube randomly
        for (int i = 0; i < maxCube; i++)
        {
            Instantiate(pickUpPrefab, new Vector3(Random.Range(-9f, 9f), 0.5f, Random.Range(-9f, 9f)), Quaternion.identity);
        }
    }
}
