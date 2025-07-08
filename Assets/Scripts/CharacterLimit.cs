using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLimit : MonoBehaviour
{

    // limit the input field character to a maximum of one

    public InputField inputField;

    void Start()
    {
        if (inputField != null)
            inputField.characterLimit = 1;
    }
}
