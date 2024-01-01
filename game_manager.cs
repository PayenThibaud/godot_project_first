using Godot;
using System;


public partial class game_manager : Node
{
	int points = 0;

	public void add_point()
	{
		points += 1;
		GD.Print(points);
	}
}
