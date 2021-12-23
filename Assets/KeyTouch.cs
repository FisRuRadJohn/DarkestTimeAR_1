using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTouch : MonoBehaviour
{
    public int valor = 0;
    // Start is called before the first frame update
 

    void OnMouseDown()
    {
        GameManager.SetCode(valor.ToString());
        
    }
}
