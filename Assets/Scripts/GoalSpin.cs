using UnityEngine;

public class GoalSpin : MonoBehaviour
{
    public Animator Anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Anim.Play("GoalSpin");
    }
}
