﻿namespace CodeKatas.Week5;

public record MoveCommand(int MoveDistance): Command(0, MoveDistance)
{
    public override void Execute(MarsRover marsRover)
    {
        throw new NotImplementedException();
    }
}
