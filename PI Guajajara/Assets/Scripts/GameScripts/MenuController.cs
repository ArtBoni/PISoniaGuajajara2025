using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject painel;
    
    public void Teleport(string name)
    {
        SceneManager.LoadScene(name);
    }


    public void OpenBTN()
    {
        painel.SetActive(true);
    }

    public void CloseBTN() 
    {
        painel.SetActive(false);
    }


    public void QuitBTN()
    {
        Application.Quit();
        print("Quitou");
    }
}
