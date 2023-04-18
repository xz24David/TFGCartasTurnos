using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int vidas;
    bool pausa;
    // Start is called before the first frame update
    void Start()
    {
        if (vidas==0)//prueba del github
        {
            pausa = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
