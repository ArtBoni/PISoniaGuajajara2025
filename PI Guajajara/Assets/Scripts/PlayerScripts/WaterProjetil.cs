using UnityEngine;

public class WaterProjetil : MonoBehaviour
{
    [SerializeField] private float velocity = 10f;
    [SerializeField] private float lifeTime = 0.5f;

    private float damage;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * velocity * Time.deltaTime);
    }

    public void SetDamage(float dmg)
    {
        damage = dmg;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamegabled enemy = collision.GetComponent<IDamegabled>();
        if (enemy != null)
        {
            enemy.Hit(damage);
            Destroy(gameObject);
        }
    }
}