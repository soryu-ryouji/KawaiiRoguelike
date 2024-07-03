using UnityEngine;

namespace KawaiiRoguelike
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private MobileJoystick _joystick;
        [SerializeField] private float _moveSpeed;
        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rb.velocity = _joystick.GetMoveVector() * _moveSpeed * Time.deltaTime;
        }
    }
}
