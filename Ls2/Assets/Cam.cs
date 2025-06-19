using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int targetFrameRate = 15;

    void Start()
    {
        Application.targetFrameRate = targetFrameRate;
    }
}
