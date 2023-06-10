using Godot;
using System;

public partial class node_2d : Sprite2D
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		uint randomNumber = GD.Randi() % 4;
		float AMOUNT = 5;
		if (randomNumber == 0){
			this.Position += new Vector2(0, -AMOUNT);
		}
		if (randomNumber == 1){
			this.Position += new Vector2(0, AMOUNT);
		}
		if (randomNumber == 2){
			this.Position += new Vector2(-AMOUNT, 0);
		}
		if (randomNumber == 3){
			this.Position += new Vector2(AMOUNT, 0);
		}
	}
}
