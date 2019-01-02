using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance = null;

    public GameObject pipesPrefabs;//管道预制体
    public Text scoreText;//分数
    private int score;

    public Text MaxScore;//最高分
    private int MaxScore1;
    public Text thisScore;

    public Button buttonKaishi;
    public Text GameOverText;

    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
        pipesPrefabs = Resources.Load("Pipes") as GameObject; 
        InvokeRepeating("getPrefabs", 2f, 2f);

        score = 0;
        scoreUI();
        buttonKaishi.onClick.AddListener(GameKaishi);
        buttonKaishi.gameObject.SetActive(false);
        GameOverText.gameObject.SetActive(false);
        MaxScore.gameObject.SetActive(false);
        thisScore.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        
	}
    public void getPrefabs()
    {
        //UnityEngine.Random.Range(-1, 4);
        Vector3 pipes = new Vector3(17, UnityEngine.Random.Range(-1, 4), 0);
        GameObject pp= Instantiate(pipesPrefabs, pipes, Quaternion.identity);
    }
    public void Addscore(int score1)
    {
        score += score1;
        scoreUI();
    }
    public void scoreUI()
    {
        scoreText.text = "分数：" + score;
       
    }
    public void GameOver()
    {
        
        MaxScore1= PlayerPrefs.GetInt("MaxScore");
        if (MaxScore1<score)
        {
            PlayerPrefs.SetInt("MaxScore", score);
            MaxScore.text = "历史最高分" + score;
        }
        else
        {
            MaxScore.text = "历史最高分" + MaxScore1;

        }
        GameOverText.gameObject.SetActive(true);
        buttonKaishi.gameObject.SetActive(true);
        MaxScore.gameObject.SetActive(true);
        thisScore.text = "本次得分：" + score;
        thisScore.gameObject.SetActive(true);
    }
    public void GameKaishi()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }
}
