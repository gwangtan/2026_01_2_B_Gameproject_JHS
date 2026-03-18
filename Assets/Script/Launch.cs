using TMPro;
using UnityEngine;

public class LaunchButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_InputField angleInputField;
    public GameObject spherePrefab;
    public Transform firePoint;
    public float force = 15;

    public void Launch()
    {
        Debug.Log("น฿ป็!");
    }
}
