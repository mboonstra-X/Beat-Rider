using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Transform textObject;

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = textObject.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        textObject.localScale = originalScale * 1.075f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textObject.localScale = originalScale;
    }
}
