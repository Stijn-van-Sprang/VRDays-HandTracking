using UnityEngine;

public class AudioPitchEdited : MonoBehaviour
{
    public AudioSource AudioPavement;
    public GameObject RotatingValve;
    public float PitchValue;
    public float PitchChangeRate = 1.0f; // Adjust this value in the Inspector

    public enum RotationAxis { X, Y, Z };
    public RotationAxis rotationAxis = RotationAxis.Y;

    private float OldValueRotator;

    // Update is called once per frame
    void Update()
    {
        float rotationValue = 0f;

        switch (rotationAxis)
        {
            case RotationAxis.X:
                rotationValue = RotatingValve.transform.rotation.eulerAngles.x;
                break;
            case RotationAxis.Y:
                rotationValue = RotatingValve.transform.rotation.eulerAngles.y;
                break;
            case RotationAxis.Z:
                rotationValue = RotatingValve.transform.rotation.eulerAngles.z;
                break;
        }

        //Debug.Log(rotationValue);

        AudioPavement.pitch = PitchValue;

        if (rotationValue < OldValueRotator)
        {
            OldValueRotator = rotationValue;
            PitchValue += PitchChangeRate;
        }
        else if (rotationValue > OldValueRotator)
        {
            OldValueRotator = rotationValue;
            PitchValue -= PitchChangeRate;
        }
    }
}
