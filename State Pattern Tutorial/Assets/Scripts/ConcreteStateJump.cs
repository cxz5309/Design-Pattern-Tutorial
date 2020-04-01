using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateJump : State
{
    float gravity = 0f;
    Vector3 velocity;
    const int MAX_CHARGE = 20;

    public override void DoAction(MyState state)
    {
        Debug.Log("Jump");
        velocity = transform.position;
        StartCoroutine(HandleJump(state));
    }
    IEnumerator HandleJump(MyState state)
    {
        gravity = 0.7f;

        while (true)
        {
            if(state == MyState.STATE_DIVING)
            {
                break;
            }

            velocity.y = velocity.y + gravity;

            transform.position = velocity;

            if (velocity.y < 1f)
            {
                break;
            }

            gravity = gravity - 0.1f;

            yield return new WaitForSeconds(0.05f);
        }

        gravity = 0;
        velocity.y = 1f;
        transform.position = velocity;
        GetComponent<MyAction>().setActionType(MyState.STATE_STANDING);

        yield return null;
    }
}