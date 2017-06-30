using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour {
    public Text timerText;
    public Text countText;
    public Text instruction;
    public GameObject nameField;
    public Text[] rankText;

    private GameManager gameManager;
    private RankingController rankingController;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
        rankingController = GetComponent<RankingController>();
        countText.text = "Remain : " + gameManager.maxCube.ToString();
        SetInstructionText("Press 'Space' to Start");
    }

    public float SetTimerText(float timeLap)
    {
        timeLap += Time.deltaTime;
        timerText.text = "TimeLap : " + timeLap.ToString("N2");
        return timeLap;
    }

    public void SetCountText(int count)
    {
        countText.text = "Remain : " + count.ToString();
    }

    public void SetInstructionText(string text)
    {
        instruction.text = text;
    }

    public void SetNameField()
    {
        SetInstructionText("");
        nameField.SetActive(true);
        nameField.GetComponent<InputField>().Select();
        nameField.GetComponent<InputField>().lineType = InputField.LineType.SingleLine;
    }
    
    private void LoadLeaderBoard()
    {
        bool success = false;
        List<string[]> rank = new List<string[]>();
        do
        {
            //try
            {
                rank = rankingController.GetRanking(nameField.GetComponent<InputField>().text, gameManager.timeLap);
                nameField.GetComponent<InputField>().text = "";
                SetInstructionText("Press 'R' to Restart Game");
                nameField.SetActive(false);

                for (int i = 0; i < rank.Count - 1; i++)
                {
                    //rankText[i].text = rank[i][0] + " : " + rank[i][1];
                }

                foreach (string[] record in rank)
                {
                    Debug.Log("Entire Ranking");
                    Debug.Log(record[0] + " : " + record[1]);
                }
                success = true;
            }
            //catch
            {
                nameField.GetComponent<InputField>().text = "";
                SetInstructionText("That name already registered");
            }
        } while (success);
        
        
    }
    
    void OnGUI()
    {
        if (nameField.GetComponent<InputField>().isFocused && nameField.GetComponent<InputField>().text != "" && Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
        {
            LoadLeaderBoard();
        }
    }
}
