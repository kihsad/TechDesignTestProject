using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAnimation : MonoBehaviour, IPointerClickHandler
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger("animation");
    }
}
