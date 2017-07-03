using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingController : MonoBehaviour {

    public List<string[]> GetRanking(string name,float timeLap)
    {
        return LoadRanking(GetUserCount(), name, timeLap);
    }

    //Playerprefsのダータから登録されているデータの数を読みだす
    private int GetUserCount()
    {
        int userCount;
        if (PlayerPrefs.HasKey("UserCount"))
        {
            userCount = PlayerPrefs.GetInt("UserCount");
        }
        else
        {
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
                //check ranking data exist
                if (PlayerPrefs.HasKey("score" + i.ToString()))
                {
                    savedRanking = PlayerPrefs.GetString("score" + i.ToString());
                    substr = savedRanking.ToString().Split(':');

                    // if name exist &&check name is duplicated
                    if (substr[0].Equals(name))
                    {
                        throw new System.Exception("That name already registered");
                    }

                    rankList.Add(new string[] { substr[0], substr[1] });
                }
                else
                {
                    throw new System.Exception("Failed to Load Ranking");
                }
                
            }
        }
        if (!name.Equals(""))
        {
            //add current timeLap to rankList
            rankList.Add(new string[] { name, timeLap.ToString("N2") });
        }
        rankList.Sort((sa1, sa2) => float.Parse(sa1[1]).CompareTo(float.Parse(sa2[1])));
        //update ranking to playerprefs
        UpdateRanking(rankList);

        return rankList;
    }

    //Playerprefsのランキングをアップデートする
    private void UpdateRanking(List<string[]> rankList)
    {
        //update ranking
        for(int i = 0; i < rankList.Count; i++)
        {
            Debug.Log(rankList[i][0] + " : " + rankList[i][1]);
            PlayerPrefs.SetString("score" + i.ToString(), rankList[i][0] + ":" + rankList[i][1]);
        }

        //update userCount
        PlayerPrefs.SetInt("UserCount", rankList.Count + 1);
        PlayerPrefs.Save();
    }
}