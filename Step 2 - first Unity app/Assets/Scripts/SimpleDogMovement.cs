using UnityEngine;

namespace Assets.Scripts
{
    public class SimpleDogMovement : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                SimpleMove(new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y,
                    gameObject.transform.position.z));
            }

            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                SimpleMove(new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y,
                    gameObject.transform.position.z));
            }
        }

        private void SimpleMove(Vector3 newPosition)
        {
            gameObject.transform.position = newPosition;
        }
    }
}
