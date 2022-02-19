using UnityEngine;
using UnityEngine.UI;

public class DamagePopup : MonoBehaviour
{
    public Animator animator;
    public void Start()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);
    }

    public void SetText(string text)
    {
        animator.GetComponent<Text>().text = text;
    }
}
