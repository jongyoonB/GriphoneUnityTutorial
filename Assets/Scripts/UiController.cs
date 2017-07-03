using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour {
    /*
     * timerText : 画面上のタイムラップ
     * countText : 画面上のカウンター
     * instruction : 画面上の指示門
     * isEnterPressed : エンターキーのpressを判別
     */
    public Text timerText;
    public Text countText;
    public Text instruction;
    public GameObject nameField;
    public GameObject[] rankText;
    public GameObject current;
    private GameManager gameManager;
    private RankingController rankingController;
    private bool isEnterPressed;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
        rankingController = GetComponent<RankingController>();
        countText.text = "Remain : " + gameManager.maxCube.ToString();
        SetInstructionText("Press 'Space' to Start");
    }

    //画面上のタイマーのテキストを設定
    public float SetTimerText(float timeLap)
    {
        timeLap += Time.deltaTime;
        timerText.text = "TimeLap : " + timeLap.ToString("N2");
        return timeLap;
    }

    //画面上のカウンターのテキストを設定
    public void SetCountText(int count)
    {
        countText.text = "Remain : " + count.ToString();
    }

    //画面上の指示門のテキストを設定
    public void SetInstructionText(string text)
    {
        instruction.text = text;
    }

    //名前入力のフィールドのテキストを設定
    public void SetNameField()
    {
        SetInstructionText("");
        nameField.SetActive(true);
        nameField.GetComponent<InputField>().Select();
        nameField.GetComponent<InputField>().lineType = InputField.LineType.SingleLine;
    }
    
    //Playerprefsからランキングを読みだす
    public void LoadLeaderBoard()
    {
        List<string[]> rank = new List<string[]>();
        isEnterPressed = false;
        try
        {
            rank = rankingController.GetRanking(nameField.GetComponent<InputField>().text, gameManager.timeLap);
            for (int i = 0; i < (rank.Count > 3 ? 3 : rank.Count); i++)
            {
                rankText[i].SetActive(true);
                rankText[i].GetComponent<Text>().text = "No." + (i + 1).ToString() + " : " + rank[i][0] + " : " + rank[i][1];
            }

            if (!nameField.GetComponent<InputField>().text.Equals(""))
            {
                if (rank.Count > 3 && gameManager.timeLap > float.Parse(rank[2][1]))
                {
                    current.SetActive(true);
                    current.GetComponent<Text>().text = "You" + " : " + gameManager.timeLap.ToString("N2");
                }
                nameField.GetComponent<InputField>().text = "";
                nameField.SetActive(false);
                SetInstructionText("Press 'R' to Restart Game");
            }
            
        }
        catch (Exception ex)
        {
            nameField.GetComponent<InputField>().text = "";
            SetInstructionText(ex.Message);
            throw ex; 
        }
        
    }

    void OnGUI()
    {
        if (nameField.GetComponent<InputField>().isFocused && nameField.GetComponent<InputField>().text != "" && (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter)))
        {
            Debug.Log(isEnterPressed);
        }
            if (!isEnterPressed && nameField.GetComponent<InputField>().isFocused && nameField.GetComponent<InputField>().text != "" && (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter)))
        {
            isEnterPressed = true;
            LoadLeaderBoard();
        }
    }
}