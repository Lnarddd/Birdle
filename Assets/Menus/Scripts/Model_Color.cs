using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_Color : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        m_NewColor = new UnityEngine.Color32((byte)(player_stats.red), (byte)(player_stats.green), (byte)(player_stats.blue), 255);
        m_SpriteRenderer.color = m_NewColor;
    }
}
