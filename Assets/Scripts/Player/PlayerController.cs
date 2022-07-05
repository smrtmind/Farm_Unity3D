using Scripts.Utils;
using UnityEngine;

namespace Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _body;
        [SerializeField] private float _runSpeed = 5f;
        [SerializeField] private float _movementSpeed = 5f;
        [SerializeField] private float _gravityMultiplier = 1f;
        [SerializeField] private SpawnComponent _boardSpawner;

        public bool _upPressed { get; set; }
        public bool _downPressed { get; set; }

        private void Update()
        {
            _body.velocity = new Vector3(0f, 0f, _runSpeed);

            if (_upPressed)
            {
                _boardSpawner.Spawn();
                _body.AddForce(new Vector3(0f, _movementSpeed, 0f));
            }
            else if (_downPressed)
            {
                _boardSpawner.Spawn();
                _body.AddForce(new Vector3(0f, -_movementSpeed, 0f));
            }
            else
                _body.AddForce(new Vector3(0f, -_gravityMultiplier, 0f));
        }
    }
}
