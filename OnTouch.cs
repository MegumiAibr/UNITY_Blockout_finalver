using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;  //実行時のシーン管理


public class OnTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickToGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnClickToEnd()
    {
        Application.Quit();
    }

}
