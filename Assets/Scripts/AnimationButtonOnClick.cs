using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class AnimationButtonOnClick : MonoBehaviour
{
    private float _animatedTime = 0.2f;
    private int _loopsCount = 2;

    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void OnButtonClick()
    {
        _image.DOColor(Color.white, _animatedTime).SetLoops(_loopsCount, LoopType.Yoyo);
    }
}
