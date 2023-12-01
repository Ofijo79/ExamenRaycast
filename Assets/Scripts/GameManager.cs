using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score;
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {

        score = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Contador()
    {
        score --;
        timer.text = "x" + score * Time.deltaTime;
    }

    public void Cube1()
    {
        SceneManager.LoadScene(1);
    }

    public void Esfera()
    {
        SceneManager.LoadScene(2);
    }

    public void Cube2()
    {
        SceneManager.LoadScene(3);
    }
}
