using UnityEngine;

public class FlashlightFlicker : MonoBehaviour
{
    public Light flashlight; // 手电筒的光源
    public float minIntensity = 0f; // 最小光强
    public float maxIntensity = 1f; // 最大光强
    public float flickerSpeed = 0.1f; // 闪烁速度
    public bool useRandomFlicker = true; // 是否使用随机闪烁

    private float flickerTimer = 0f;

    void Start()
    {
        if (flashlight == null)
        {
            flashlight = GetComponent<Light>();
        }

        if (flashlight == null || flashlight.type != LightType.Spot)
        {
            Debug.LogWarning("No spot light found or the light type is not Spot");
        }
    }

    void Update()
    {
        if (flashlight != null)
        {
            flickerTimer += Time.deltaTime;

            if (flickerTimer >= flickerSpeed)
            {
                if (useRandomFlicker)
                {
                    // 随机光强
                    flashlight.intensity = Random.Range(minIntensity, maxIntensity);
                }
                else
                {
                    // 固定间隔切换光强
                    flashlight.intensity = (flashlight.intensity == minIntensity) ? maxIntensity : minIntensity;
                }

                flickerTimer = 0f;
            }
        }
    }
}
