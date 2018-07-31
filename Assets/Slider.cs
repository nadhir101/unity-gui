using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    Slider slider;
    Slider HealthBar;
    Text text;
    public float health;
    public void ResizeHandle()
    {

        text.text = slider.value.ToString() + "%";
        slider.handleRect.sizeDelta = new Vector2(slider.value, slider.value) * 1 / 2;
    }
    public void UpdateHealth()
    {
        //write Slider.value
        HealthBar.value = health;
    }
}