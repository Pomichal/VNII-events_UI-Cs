using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{

    TextMeshProUGUI textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<TextMeshProUGUI>();
        Signals.onHealthChanged.AddListener(UpdateScoreText);
    }


    void UpdateScoreText(int value)
    {
        textField.text = "HP: " + value + "/100";
    }

}
