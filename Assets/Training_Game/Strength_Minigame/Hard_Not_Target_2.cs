using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard_Not_Target_2 : MonoBehaviour
{
    private float time = 00.5f;
    private int tagnumber = 0;

    void Start() {
        tagnumber = GameObject.Find("GameControl").GetComponent<Strength_Minigame_3>().lastspawned;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        gameObject.transform.localScale += new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);    
        if(time >= 1.2)
        {
            KillSelf();
        }
    }

    private void OnMouseDown() {
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_3>().spawntargets += 1;
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_3>().itemtoremove = tagnumber;
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_3>().wrong();
        if(player_progress.score_strength > 0){
            player_progress.score_strength -= 1;
        }
        Destroy(gameObject);   
    }

    public void KillSelf() {
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_3>().spawntargets += 1;
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_3>().itemtoremove = tagnumber;
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_3>().wrongMiss();
        Destroy(gameObject); 
    }
}
