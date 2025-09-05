using UnityEngine;
using UnityEngine.UI;

public enum BossAtacks 
{
    None ,Area, LongRange, Close
}



public class BossStatus : MonoBehaviour, IDamegabl
{
    float timeBtwDamage = 1.5f;
    float currentHealth;

     [SerializeField] float maxHealth;
     [SerializeField] Slider healthBar;
    BossAtacks bossAtacks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.value = maxHealth;
        healthBar.value = currentHealth;
    }

    void Die()
    {
        print("Morreu");
    }

  

    public void TakeDamege(int damege)
    {
        currentHealth -= damege;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

   
    private void Atacks(BossAtacks mode)
    {
        switch (mode) 
        {
            case BossAtacks.None:
                break;

            case BossAtacks.Area:
                break;

            case BossAtacks.LongRange:
                break;

            case BossAtacks.Close:
                    break;
        
        }

        
    }

}
