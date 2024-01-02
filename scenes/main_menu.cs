using Godot;
using System;

public partial class main_menu : Node
{
	private void _on_level_1_pressed()
	{
		GetTree().CallDeferred("change_scene_to_file","res://scenes/level1.tscn");
	}

	private void _on_level_2_pressed()
	{
		GetTree().CallDeferred("change_scene_to_file","res://scenes/level2.tscn");
	}
}

