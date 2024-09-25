using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    private InputField inputTextField;

    void Start()
    {
        inputTextField = GetComponent<InputField>();
    }

    public void CheckPassword()
    {
        switch (inputTextField.text)
        {   
            case "98752":
            //    SceneManager.LoadScene("");
                break;
            
            default:
                inputTextField.text = "";
                break;
        }
    }
}
