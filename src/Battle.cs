using Godot;
using System;

public class Battle : Node {
    [Export] PackedScene Victory;
    [Export] PackedScene Defeat;
    
    void OnWin(Unit.Side side) {
        if (side == Unit.Side.Left) {
            GetTree().ChangeSceneTo(Victory);
        } else {
            GetTree().ChangeSceneTo(Defeat);
        }
    }
}
