using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject creditsPainel;
    
    public void Teleport(string name)
    {
        SceneManager.LoadScene(name);
    }


    public void OpenBTN()
    {
        creditsPainel.SetActive(true);
    }

    public void CloseBTN() 
    {
        creditsPainel.SetActive(false);
    }


    public void QuitBTN()
    {
        Application.Quit();
        print("Quitou");
    }
}
