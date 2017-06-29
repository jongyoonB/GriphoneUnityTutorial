using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float playTime;
    public GameObject pickUpPrefab;
    public GameObject pickUp;
    
    public Material pickUpYellow;
    public Material pickUpPurple;
    public Text TimerText;
    public Text CountText;
    public Text winText;

    private Renderer rend;
    private Rigidbody rb;
    private int Count;
    private int MaxCube;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();

        //set max cube count randomly
        //MaxCube = Random.Range(10, 15);
        MaxCube = 2;
        Count = MaxCube;
        
        //create cube randomly
        for (int i = 0; i <MaxCube ; i++)
        {
            Instantiate(pickUpPrefab, new Vector3(Random.Range(-9f, 9f), 0.5f, Random.Range(-9f, 9f)), Quaternion.identity);
        }
        CountText.text = MaxCube.ToString();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

        playTime += Time.deltaTime;
        TimerText.text = playTime.ToString("N2");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Count--;
        }
        SetCountText();
    }

    void SetCountText()
    {
        CountText.text = Count.ToString();
        if (Count % 2 == 0)
        {
            rend.material = pickUpPurple;
        } else
        {
            rend.material = pickUpYellow;
        }

        if (Count == 0)
        {
            winText.text = "YOU WIN";
            //SaveScore(GetUserCount(),"TEST_NAME", playTime);
        }
    }

    int GetUserCount()
    {
        int userCount;
        if (PlayerPrefs.HasKey("UserCount"))
        {
            userCount = PlayerPrefs.GetInt("UserCount") + 1;
        }
        else
        {
            userCount = 1;
        }

        PlayerPrefs.SetInt("UserCount", userCount);

        return userCount;
    }

    //sorting, check dupliation before save
    string[][] LoadScore(int userCount, string name, float playTime)
    {

        string localScore;
        string[][] score = new string[userCount][];
        string[] substr;

        if (userCount > 1)
        {
            for (int i = 0; i < userCount; i++)
            {
                localScore = PlayerPrefs.GetString("score" + i.ToString());
                substr = localScore.Split(':');
                score[i][0] = substr[0];
                score[i][1] = substr[1];
            }
        }

        score[userCount - 1][0] = name;
        score[userCount - 1][0] = playTime.ToString("N2");
        
        
        //PlayerPrefs.SetString("score" + (userCount - 1).ToString(), name + ":" + playTime.ToString("N2"));

        return score;
    }

}
