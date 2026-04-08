using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CharacterStat : MonoBehaviour
{

    public string characterName;
    public int maxHealth = 100;
    public int currentHealth;

    //UI ¿ä¼Ò
    public Slider healthBar;
    public TextMeshProUGUI healthText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
    }
}
