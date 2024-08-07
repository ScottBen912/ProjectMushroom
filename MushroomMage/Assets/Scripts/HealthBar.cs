using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public CharacterScript character;

    public void SetHealth(int health)
    {
        slider.value = health;
    }
    public void Update()
    {
        slider.value = character.health;
    }
}
