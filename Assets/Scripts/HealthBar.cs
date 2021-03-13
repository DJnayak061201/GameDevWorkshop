using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;


    public void SetMaxHealth(float MaxHealth)
    {
        slider.maxValue = MaxHealth;
        slider.value = MaxHealth;
    }

    public void SetHealth(float NewHealth)
    {
        slider.value = NewHealth;
    }
}
