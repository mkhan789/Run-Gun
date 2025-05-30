using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text coinText;
    public Slider healthBar;
    public Text bulletsText;
    public Text healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthBar();
        UpdateCoinst();
    }

    public void UpdateBulletUI(int bullets) 
    {
        bulletsText.text = bullets.ToString();
           
    }
    public void UpdateHealthtUI(int health)
    {
        healthText.text = health.ToString();
        healthBar.value = health;

    }

    public void UpdateCoinst()
    {
        coinText.text = GameManager.gameManager.coins.ToString();

    }

    public void UpdateHealthBar()
    {
        healthBar.maxValue = GameManager.gameManager.health;

    }
}
