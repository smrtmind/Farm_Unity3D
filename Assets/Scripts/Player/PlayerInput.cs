using UnityEngine;

namespace Scripts.Player
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerController _player;

        private void Update()
        {
            _player._upPressed = Input.GetKey(KeyCode.UpArrow);
            _player._downPressed = Input.GetKey(KeyCode.DownArrow);
        }
    }
}
