using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]

public class BackGround : MonoBehaviour
{
    [SerializeField] private float _speed;

    private RawImage _backGround;
    private float _imagePositionX;

    private void Start()
    {
        _backGround = GetComponent<RawImage>();
    }

    private void Update()
    {
        _imagePositionX += _speed * Time.deltaTime;

        if (_imagePositionX > 1)
        {
            _imagePositionX = 0;
        }

        _backGround.uvRect = new Rect(_imagePositionX, 0, _backGround.uvRect.width, _backGround.uvRect.height);
    }
}
