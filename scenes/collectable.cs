
using Godot;
using System;

public partial class collectable : Area2D
{
	private game_manager game_manager;

	public override void _Ready()
	{
		game_manager = GetNode<game_manager>("../../../GameManager");
	}
	
	

	private void _on_body_entered(Node2D body)
	{
		if (body.Name == "CharacterBody2D")
		{
			QueueFree();
			game_manager.add_point();
		}
	}
}

