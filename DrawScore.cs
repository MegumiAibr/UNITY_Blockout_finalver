using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;   //フォントデータを画面に描画するデフォルトのグラフィック
using UnityEngine.SceneManagement;  //実行時のシーン管理


public class DrawScore : MonoBehaviour
{
    Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + Score.score;
    }

    public void OnClickToGame()
    {
        if (SceneManager.GetActiveScene().name == "Main") {
            SceneManager.LoadScene("Result");
        }
        else
        {
            SceneManager.LoadScene("Title");
        }
    }
}
