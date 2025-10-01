using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleBTN : MonoBehaviour, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
    GameObject selection;
   
    

    public void OnDeselect(BaseEventData eventData)
    {
        selection.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        selection.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        selection.SetActive(false);
    }

    public void OnSelect(BaseEventData eventData)
    {
        selection.SetActive(true);
    }

   
    
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // o -= remove a função para evitar múltiplas adições, porem passa pelo erro de Race Case
        selection = GetComponentInChildren<Animator>(true).gameObject;
        //btn.onClick.RemoveAllListeners();
       
    }    
}
