using UnityEngine;
using DG.Tweening;

public class DoTweenManager : MonoBehaviour
{
    public RectTransform kareRect, inputButtonRect, closeButtonRect;
    public RectTransform panel,panel2;
    private void Start()
    {
        panel.DOAnchorPos(Vector2.zero, 0.25f);
    }
    public void InputButton()
    {
        inputButtonRect.DOScale(Vector2.zero, 0.25f);
        closeButtonRect.DOScale(new Vector2(1f, 1f), 0.25f);
    }
    public void CloseButton()
    {
        closeButtonRect.DOScale(Vector2.zero, 0.25f);
        panel.DOAnchorPos(new Vector2(0, -1086f), 0.25f).SetDelay(0.25f);
        panel2.DOAnchorPos(Vector2.zero, 0.25f);
    }
}
