using UnityEngine;

public class MoveHand : MonoBehaviour
{
    [SerializeField] private Transform _hand;
    [SerializeField] private Vector3 _target1;
    [SerializeField] private Vector3 _target2;
    [SerializeField] private float _speed;

    private Vector3 _currentTarget;

    private void Start() => _currentTarget = _target1;

    private void Update()
    {
        if (_currentTarget != _hand.localPosition)
            _hand.localPosition = Vector3.MoveTowards(_hand.localPosition, _currentTarget, _speed * Time.deltaTime);
        else
            _currentTarget = _currentTarget == _target1 ? _target2 : _target1;
    }
}
