using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class AnimationBottom : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private float _animatedTime = 0.2f;
    private float _enterScale = 2.5f;
    private float _exitScale = 2f;
    
    private Button _button;

    public void Start()
    {
        _button= GetComponent<Button>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _button.transform.DOScale(_enterScale, _animatedTime);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _button.transform.DOScale(_exitScale, _animatedTime);
    }
}
