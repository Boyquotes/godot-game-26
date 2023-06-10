using Godot;
using System;

public partial class world : Node2D
{
	PackedScene packedscene;
	public override void _Ready()
	{
		
	}

	public override void _Process(double delta)
	{
	}

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent){
			// create instance of sprite scene

		}
	}
}
