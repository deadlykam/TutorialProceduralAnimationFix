using UnityEngine;

public class MoveHand : MonoBehaviour
{
    [SerializeField] private Transform _hand; // For moving the hand's target
    [SerializeField] private Vector3 _target1;// First move point
    [SerializeField] private Vector3 _target2;// Second move point
    [SerializeField] private float _speed;    // Hand movement speed

    private Vector3 _currentTarget;           // The current point to move the hand towards

    private void Start() => _currentTarget = _target1;

    private void Update()
    {
        if (_currentTarget != _hand.localPosition)
            _hand.localPosition = Vector3.MoveTowards(_hand.localPosition, _currentTarget, _speed * Time.deltaTime);
        else
            _currentTarget = _currentTarget == _target1 ? _target2 : _target1;
    }
}
