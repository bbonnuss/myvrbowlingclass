using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> balls;
    public GameObject pin;
    public TextMeshPro scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBalls() {
        //Instantiate(balls[0]);
        yield return new WaitForSeconds(1);
    }

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame() {
        score = 0;
        scoreText.gameObject.SetActive(true);
        //StartCoroutine(SpawnBalls());
        UpdateScore(0); 
    }
}
