using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandKey3
{
    public virtual void Execute(Transform tr, Vector3 newPos) { }
    public virtual void Undo(Transform tr) { }
}

public class CommandMoveRight3 : CommandKey3
{
    Vector3 prevPos;

    public override void Execute(Transform tr, Vector3 newPos)
    {
        prevPos = tr.position;
        tr.Translate(newPos);
    }
    public override void Undo(Transform tr)
    {
        tr.position = prevPos;
    }
}
public class CommandMoveForward3 : CommandKey3
{
    Vector3 prevPos;

    public override void Execute(Transform tr, Vector3 newPos)
    {
        prevPos = tr.position;
        tr.Translate(newPos);
    }
    public override void Undo(Transform tr)
    {
        tr.position = prevPos;
    }
}