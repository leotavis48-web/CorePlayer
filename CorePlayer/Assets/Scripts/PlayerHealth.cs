using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxhealth;
    public Image HealthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxhealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (maxhealth > 0)
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1);
        }
        else
        {
        HealthBar.fillAmount = 0;
        }   
    }
}