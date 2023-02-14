using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoverBigger : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private float _Multiplier;
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.localScale *= _Multiplier;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.transform.localScale = Vector3.one;
    }
}
