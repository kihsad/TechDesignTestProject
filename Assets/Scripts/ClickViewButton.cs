using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickViewButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject _button;

    private void Start()
    {
        _button.SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _button.SetActive(true);
    }

}
