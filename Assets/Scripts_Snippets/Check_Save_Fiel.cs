using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Check_Save_Fiel : MonoBehaviour
{
    [SerializeField] Button Load;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/player_data.bird")){
            Load.interactable = true;
        }
        else{
            Load.interactable = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
