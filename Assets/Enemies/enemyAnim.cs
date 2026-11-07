using UnityEngine;

public class enemyAnim : MonoBehaviour
{
    private Animator Animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Animator != null)
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                Animator.SetTrigger("TrAntWalk");
                Animator.SetTrigger("TrBeeFly");
                Animator.SetTrigger("TrStickRun");
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                Animator.SetTrigger("TrAntAttk");
                Animator.SetTrigger("TrBeeAttk");
                Animator.SetTrigger("TrStickAttk");
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                Animator.SetTrigger("TrAntHurt");
                Animator.SetTrigger("TrBeeHurt");
                Animator.SetTrigger("TrStickHurt");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                Animator.SetTrigger("TrAntDie");
                Animator.SetTrigger("TrBeeDie");
                Animator.SetTrigger("TrStickDie");
            }

        }
    }
}
