using Godot;
using System;

public partial class test_2dsprite : Sprite2D
{
	/// <summary>
	/// _Ready called when start.
	/// </summary>
	public override void _Ready()
	{
	}

	/// <summary>
	/// _Process called every frame. 
	/// </summary>
	/// <param name="delta"></param>
	public override void _Process(double delta)
	{
		float AMOUNT = 5;
		if (Input.IsKeyPressed(Key.W)){
			this.Position += new Vector2(0, -AMOUNT);
		}
		if (Input.IsKeyPressed(Key.S)){
			this.Position += new Vector2(0, AMOUNT);
		}
		if (Input.IsKeyPressed(Key.A)){
			this.Position += new Vector2(-AMOUNT, 0);
		}
		if (Input.IsKeyPressed(Key.D)){
			this.Position += new Vector2(AMOUNT, 0);
		}
	}
}
