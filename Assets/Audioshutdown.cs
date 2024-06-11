using UnityEngine;

public class Audioshutdown : MonoBehaviour
{
    private AudioSource audioSource;

    // 指定目标标签
    public string targetTag = "robot"; // 确保这个标签与目标对象的标签一致

    void Start()
    {
        // 获取 AudioSource 组件
        audioSource = GetComponent<AudioSource>();
     
    }

    void OnCollisionEnter(Collision collision)
    {
        // 当发生碰撞时，检测碰撞对象的标签是否为目标标签
        Debug.Log("Collision detected with object: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag(targetTag))
        {
            // 如果标签匹配，静音音频
            Debug.Log("Collision with target object detected. Muting audio.");
            if (audioSource != null)
            {
                audioSource.mute = true;
            }
        }
    }
}
