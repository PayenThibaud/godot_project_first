using Godot;
using System;

public partial class trophee : Area2D
{
	[Export]
	public PackedScene target_level;

	private void _on_body_entered(Node2D body)
	{
		if (body.Name == "CharacterBody2D")
		{
			GetTree().CallDeferred("change_scene_to_file", target_level.ResourcePath);
		}
	}
}
