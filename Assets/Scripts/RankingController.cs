using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public List<string[]> GetRanking(string name,float timeLap)
    {
        return LoadRanking(GetUserCount(), name, timeLap);
    }

    private int GetUserCount()
    {
        int userCount;
        if (PlayerPrefs.HasKey("UserCount"))
        {
            userCount = PlayerPrefs.GetInt("UserCount") + 1;
        }
        else
        {
            Debug.Log("userCount ex X");
            userCount = 1;
        }

        PlayerPrefs.SetInt("UserCount", userCount);
        PlayerPrefs.Save();

        return userCount;
    }

    //Load Ranking From playerprefs
    private List<string[]> LoadRanking(int userCount, string name, float timeLap)
    {
        string savedRanking;
        List<string[]> rankList = new List<string[]>();
        string[] substr;

        if (userCount > 1)
        {
            for (int i = 0; i < userCount-1; i++)
            {
                if(PlayerPrefs.HasKey("score" + i.ToString())){
                    savedRanking = PlayerPrefs.GetString("score" + i.ToString());
                    substr = savedRanking.ToString().Split(':');

                    if (substr[0].Equals(name))
                    {
                        //throw new System.ArgumentException("name is duplicated");
                    }

                    rankList.Add(new string[] { substr[0], substr[1] });
                }
                else
                {
                    //throw new System.ArgumentException("no saving data");
                }
            }
        }
        //add current timeLap
        rankList.Add(new string[] { name, timeLap.ToString("N2") });

        //sorting
        rankList.Sort((sa1, sa2) => sa1[1].CompareTo(sa2[1]));

        //update ranking in playerprefs
        UpdateRanking(rankList);

        return rankList;
    }

    private void UpdateRanking(List<string[]> rankList)
    {
        for(int i = 0; i < rankList.Count; i++)
        {
            PlayerPrefs.SetString("score" + i.ToString(), rankList[i][0] + ":" + rankList[i][1]);
        }
        PlayerPrefs.Save();
    }
}