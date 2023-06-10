using Godot;
using System;

public partial class world : Node2D
{
	PackedScene packedscene;
	public override void _Ready()
	{
		packedscene = (PackedScene)GD.Load("res://node_2d.tscn");
	}

	public override void _Process(double delta)
	{
	}

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent){
			// create instance of sprite scene
			GD.Print("reached mouse event callback");
			Sprite2D sprite = (Sprite2D)packedscene.Instantiate();
			sprite.Position = mouseEvent.Position;
			this.AddChild(sprite);

		}
	}
}
