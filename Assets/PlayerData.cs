using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public int hp = 100;

    public Button hitButton;

    void Start()
    {
        hitButton.onClick.AddListener(TakeDamage);
    }

    public void TakeDamage()
    {
        hp -= 5;
        Signals.onHealthChanged.Invoke(hp);
    }

}
