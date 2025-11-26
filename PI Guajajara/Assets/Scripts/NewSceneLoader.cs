using UnityEngine;
using UnityEngine.SceneManagement;
public class NewSceneLoader : MonoBehaviour
{
    [SerializeField] string scene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
