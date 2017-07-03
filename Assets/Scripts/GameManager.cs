using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    /*
     * cubePrefab : cubeのprefab
     * maxCube : cubeの数
     * count : 現在の残っていいるcubeの数
     * timeLap : スタートからの時間
     * isGameStart : ゲームのスタート判別
     * isGameOver : ゲームオーバ―の判別
    */

    public GameObject cubePrefab;
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
                //count = 0 -> gameOver
                if (count == 0)
                {
                    isGameOver = true;
                    uiController.SetNameField();
                    uiController.LoadLeaderBoard();
                }
            }
            //isGameover = false &&'R' pressed -> call restart method
            if (Input.GetKeyUp(KeyCode.R) && !uiController.nameField.activeInHierarchy)
            {
                Debug.Log("Restart Game");
                RestartGame();
            }
        }
        else
        {
            //Reset Records
            if (Input.GetKeyUp(KeyCode.T))
            {
                Debug.Log("Reset Records");
                PlayerPrefs.DeleteAll();
            }
            //Start Game
            if (Input.GetKeyUp(KeyCode.Space))
            {
                CreateCube();
                isGameStart = true;
                Debug.Log("Game Start");
                uiController.SetInstructionText("");
            }
        }
    }

    /*
    * ゲームをリスタートする
    * timeLapとcountを０に初期化
    */
    void RestartGame()
    {
        timeLap = 0;
        count = maxCube;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /*
    * 画面上にcubeをランダムに生成
    */
    void CreateCube()
    {
        //create cube randomly
        for (int i = 0; i < maxCube; i++)
        {
            Instantiate(cubePrefab, new Vector3(Random.Range(-9f, 9f), 0.5f, Random.Range(-9f, 9f)), Quaternion.identity);
        }
    }
}