using UnityEngine;

public interface IReloadable
{
    void Reload();
}
public class WaterBottleRecharge : MonoBehaviour
{
    bool canReload;
    IReloadable reloadObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canReload)
        {
            if (Input.GetButtonDown("Fire2"))
            { 
                reloadObject.Reload();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IReloadable reloadObj))
        {
            canReload = true;
            reloadObject = reloadObj;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IReloadable reloadObj))
        {
            canReload = false;
        }
    }
}
