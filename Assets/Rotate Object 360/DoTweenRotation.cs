using DG.Tweening;
using UnityEngine;

public class DoTweenRotation : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(360, 0, 0), 2, RotateMode.FastBeyond360).SetEase(Ease.Linear);
    }
}
