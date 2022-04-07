using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_Scene_Spawn : MonoBehaviour
{
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject Salve;
    [SerializeField] GameObject Stone;
    [SerializeField] GameObject Talon;
    [SerializeField] GameObject Sand;
    [SerializeField] GameObject Dart;
    [SerializeField] GameObject Peck;
    [SerializeField] GameObject Seeds;
    [SerializeField] GameObject Juju;
    [SerializeField] GameObject Boost;
    [SerializeField] GameObject Flute;

    // Start is called before the first frame update
    void Start()
    {
        spawn_item_1();
        if (player_stats.item_2_unlocked == true){
            spawn_item_2();
        }
    }

    void spawn_item_1(){
        switch (player_stats.item_1){
            case "Salve":
                Salve = Instantiate(Salve, new Vector3( 4,-3,10), Quaternion.identity);
                Salve.transform.SetParent(Canvas.transform);
                Salve.transform.localScale = new Vector3(1,1,1);
                break;
            case "Stone":
                Stone = Instantiate(Stone, new Vector3( 4,-3,10), Quaternion.identity);
                Stone.transform.SetParent(Canvas.transform);
                Stone.transform.localScale = new Vector3(1,1,1);
                break;
            case "Talon":
                Talon = Instantiate(Talon, new Vector3( 4,-3,10), Quaternion.identity);
                Talon.transform.SetParent(Canvas.transform);
                Talon.transform.localScale = new Vector3(1,1,1);
                break;
            case "Sand":
                Sand = Instantiate(Sand, new Vector3( 4,-3,10), Quaternion.identity);
                Sand.transform.SetParent(Canvas.transform);
                Sand.transform.localScale = new Vector3(1,1,1);
                break;
            case "Dart":
                Dart = Instantiate(Dart, new Vector3( 4,-3,10), Quaternion.identity);
                Dart.transform.SetParent(Canvas.transform);
                Dart.transform.localScale = new Vector3(1,1,1);
                break;
            case "Peck":
                Peck = Instantiate(Peck, new Vector3( 4,-3,10), Quaternion.identity);
                Peck.transform.SetParent(Canvas.transform);
                Peck.transform.localScale = new Vector3(1,1,1);
                break;
            case "Seeds":
                Seeds = Instantiate(Seeds, new Vector3( 4,-3,10), Quaternion.identity);
                Seeds.transform.SetParent(Canvas.transform);
                Seeds.transform.localScale = new Vector3(1,1,1);
                break;
            case "Juju":
                Juju = Instantiate(Juju, new Vector3( 4,-3,10), Quaternion.identity);
                Juju.transform.SetParent(Canvas.transform);
                Juju.transform.localScale = new Vector3(1,1,1);
                break;
            case "Boost":
                Boost = Instantiate(Boost, new Vector3( 4,-3,10), Quaternion.identity);
                Boost.transform.SetParent(Canvas.transform);
                Boost.transform.localScale = new Vector3(1,1,1);
                break;
            case "Flute":
                Flute = Instantiate(Flute, new Vector3( 4,-3,10), Quaternion.identity);
                Flute.transform.SetParent(Canvas.transform);
                Flute.transform.localScale = new Vector3(1,1,1);
                break;
        }
    }

    void spawn_item_2(){
        switch (player_stats.item_2){
            case "salve":
                Salve = Instantiate(Salve, new Vector3( 7,-2,10), Quaternion.identity);
                Salve.transform.SetParent(Canvas.transform);
                Salve.transform.localScale = new Vector3(1,1,1);
                break;
            case "stone":
                Stone = Instantiate(Stone, new Vector3( 7,-2,10), Quaternion.identity);
                Stone.transform.SetParent(Canvas.transform);
                Stone.transform.localScale = new Vector3(1,1,1);
                break;
            case "talon":
                Talon = Instantiate(Talon, new Vector3( 7,-2,10), Quaternion.identity);
                Talon.transform.SetParent(Canvas.transform);
                Talon.transform.localScale = new Vector3(1,1,1);
                break;
            case "Sand":
                Sand = Instantiate(Sand, new Vector3( 7,-2,10), Quaternion.identity);
                Sand.transform.SetParent(Canvas.transform);
                Sand.transform.localScale = new Vector3(1,1,1);
                break;
            case "Dart":
                Dart = Instantiate(Dart, new Vector3( 7,-2,10), Quaternion.identity);
                Dart.transform.SetParent(Canvas.transform);
                Dart.transform.localScale = new Vector3(1,1,1);
                break;
            case "Peck":
                Peck = Instantiate(Peck, new Vector3( 7,-2,10), Quaternion.identity);
                Peck.transform.SetParent(Canvas.transform);
                Peck.transform.localScale = new Vector3(1,1,1);
                break;
            case "Seeds":
                Seeds = Instantiate(Seeds, new Vector3( 7,-2,10), Quaternion.identity);
                Seeds.transform.SetParent(Canvas.transform);
                Seeds.transform.localScale = new Vector3(1,1,1);
                break;
            case "Juju":
                Juju = Instantiate(Juju, new Vector3( 7,-2,10), Quaternion.identity);
                Juju.transform.SetParent(Canvas.transform);
                Juju.transform.localScale = new Vector3(1,1,1);
                break;
            case "Boost":
                Boost = Instantiate(Boost, new Vector3( 7,-2,10), Quaternion.identity);
                Boost.transform.SetParent(Canvas.transform);
                Boost.transform.localScale = new Vector3(1,1,1);
                break;
            case "Flute":
                Flute = Instantiate(Flute, new Vector3( 7,-2,10), Quaternion.identity);
                Flute.transform.SetParent(Canvas.transform);
                Flute.transform.localScale = new Vector3(1,1,1);
                break;
        }
    }
}
