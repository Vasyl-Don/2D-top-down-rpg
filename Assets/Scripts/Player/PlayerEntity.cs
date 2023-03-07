using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerEntity : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Rigidbody2D _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {

        }

        public void Move(float horizontalInput, float verticalInput)
        {
            _rigidbody.velocity = _speed * new Vector2(horizontalInput, verticalInput);
        }
    }
}