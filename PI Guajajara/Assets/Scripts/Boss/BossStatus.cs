using UnityEngine;
using UnityEngine.UI;

public class BossStatus : MonoBehaviour
{
    float damege = 1;
    [SerializeField] float health;
    float timeBtwDamage = 1.5f;

    [SerializeField] Slider healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        health -= damege;
    }
}
