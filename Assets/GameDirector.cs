using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject info;
    AoController ao;
    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.Find("info");
        ao = FindObjectOfType<AoController>();
    }

    // Update is called once per frame
    void Update()
    {
        info.GetComponent<TextMeshProUGUI>().text = ao.Rotate < 0.8 ? "あおちゃん停止中" : "あおちゃん回転中";
    }
}
