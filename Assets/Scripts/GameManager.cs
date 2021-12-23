using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<string> items = new List<string>();
    public static string code;
    // Start is called before the first frame update
    void Start()
    {
        code = "";
    }

  public static void SetCode(string key)
    {
        code += key;
        if(code == "5512")
        {
            Debug.Log("Perfecto");
        }
        else if(code.Length > 4)
           
        {
            code = "";
            Debug.Log("Error");
        }

    }
}
