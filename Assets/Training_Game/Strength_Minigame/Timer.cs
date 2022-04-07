using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField] float startingTime = 10f;
    [SerializeField] Text countdownText;
    [SerializeField] Text hits;

    public void play() {
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1){
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0.00");
        }

        if(currentTime <= 0){
            SceneManager.LoadScene("Strength_Minigame_EndScreen");
        }

        hits.text = "HITS " + player_progress.score_strength.ToString();
    }
}
