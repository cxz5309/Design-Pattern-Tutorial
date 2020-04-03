using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scPlayerCommand3 : MonoBehaviour
{
    Stack<CommandKey3> stack = new Stack<CommandKey3>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveForward();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveUndo();
        }
    }

    public void MoveForward()
    {
        CommandKey3 command = new CommandMoveForward3();
        stack.Push(command);
        command.Execute(transform, new Vector3(0, 0, 1));
    }
    public void MoveRight()
    {
        CommandKey3 command = new CommandMoveRight3();
        stack.Push(command);
        command.Execute(transform, new Vector3(1, 0, 0));
    }
    public void MoveUndo()
    {
        if (stack.Count > 0)
        {
            CommandKey3 command = stack.Pop();
            command.Undo(transform);
        }
    }
}
