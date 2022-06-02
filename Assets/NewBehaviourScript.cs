using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{

    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Hello there";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            texto.text = "General Kenobi";
        }
    }
}
