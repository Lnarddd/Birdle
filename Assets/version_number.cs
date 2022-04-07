using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class version_number : MonoBehaviour
{
    [SerializeField] Text version;

    // Start is called before the first frame update
    void Start()
    {
         version.text = Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
