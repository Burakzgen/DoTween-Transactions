using UnityEngine;
using DG.Tweening;

public class DoTweenMove : MonoBehaviour
{
    public Transform targetPosition;
    public GameObject cube;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cube.transform.position == targetPosition.position)
            {
                cube.transform.DOMove(Vector3.zero, 2f);
                return;
            }
            //cube.transform.DOMove(targetPosition.position, 2f).SetLoops(5, LoopType.Yoyo); // 5 =Yapilacak olan adet
            cube.transform.DOMove(targetPosition.position, 2f).OnComplete(() => // Fonksiyon tetiklemek için kullanýrýz.
            {
                cube.transform.DORotate(new Vector3(0, 90, 0), 2, RotateMode.WorldAxisAdd).OnComplete(() =>
                {
                    cube.transform.DOScale(Vector3.one * 3, 3);
                });
            });
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (cube.transform.position == Vector3.zero)
            {
                ChangeColor();
                return;
            }
            cube.transform.DOMove(Vector3.zero, 2f).OnComplete(() => // Fonksiyon tetiklemek için kullanýrýz.
            {
                cube.transform.DORotate(new Vector3(0, 90, 0), 2, RotateMode.WorldAxisAdd).OnComplete(() =>
                {
                    ChangeColor();
                });
            });
        }
    }
    private void ChangeColor()
    {
        cube.GetComponent<MeshRenderer>().material.DOColor(Color.yellow,2f);
    }
}
