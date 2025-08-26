    using UnityEngine;

    public class GyroControls : MonoBehaviour
    {
        void Start()
        {
            // Enable the gyroscope
            Input.gyro.enabled = true;
        }

        void Update()
        {
            // Apply the gyroscope's attitude to the object's rotation
            transform.rotation = Input.gyro.attitude;

            // Optional: Adjust for coordinate system differences if needed
            transform.Rotate(0f, 0f, 180f, Space.Self); // Swap handedness
            transform.Rotate(90f, 180f, 0f, Space.World); // Orient for camera
        }
    }