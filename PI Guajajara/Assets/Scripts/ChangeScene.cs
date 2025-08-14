using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] string sceneName;
    public void Teleport(string name)
    {
        SceneManager.LoadScene(sceneName);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            Teleport(sceneName);
        }
    }

}
