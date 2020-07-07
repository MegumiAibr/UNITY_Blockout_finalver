using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    static public int score = 0;    //scoreの初期化

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (6 <= score)
        {
            SceneManager.LoadScene("Result");
        }
    }
}
