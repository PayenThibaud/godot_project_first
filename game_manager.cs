using Godot;
using System;

public partial class game_manager : Node
{
	
 [Export]
	private Label pointsLabel;

	private int points = 0;

	public override void _Ready()
	{
		 pointsLabel = GetNode<Label>("../UI/Panel/Label");
	}


	public void add_point()
	{
			points += 1;
			GD.Print(points);

			pointsLabel.Text = "Points : " + points.ToString();
	}
}
