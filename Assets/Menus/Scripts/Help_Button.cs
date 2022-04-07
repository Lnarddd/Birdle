using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help_Button : MonoBehaviour
{
    [SerializeField] GameObject Window;

    public void open(){
        Window.SetActive(true);
    }

    public void close(){
        Window.SetActive(false);
    }

}
