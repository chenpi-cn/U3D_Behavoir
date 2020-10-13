using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//获取用户输入的按键
public class GetAnyKey : MonoBehaviour
{
    public Text TextLog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (Input.anyKeyDown)
        {
            getKeyDownCode();
        }
    }
    
    public KeyCode getKeyDownCode()  
    {  
        if (Input.anyKeyDown)  
        {  
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))  
            {  
                if (Input.GetKeyDown(keyCode))  
                {  
                    Debug.Log(keyCode.ToString());
                    TextLog.text = keyCode.ToString();
                    return keyCode;  
                }  
            }  
        }  
        return KeyCode.None;  
    }  
}
