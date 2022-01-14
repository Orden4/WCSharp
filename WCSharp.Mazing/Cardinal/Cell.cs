using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Mazing.Cardinal
{
	public class Cell
	{
		/// <summary>
		/// The id of this cell. Is unique within its <see cref="Maze"/>.
		/// </summary>
		public int Id { get; }
		/// <summary>
		/// The <see cref="Cardinal.Maze"/> that this cell belongs to.
		/// </summary>
		public Maze Maze { get; }
		/// <summary>
		/// The relative X index of this cell within its <see cref="Maze"/>.
		/// </summary>
		public int MazeX { get; }
		/// <summary>
		/// The relative Y index of this cell within its <see cref="Maze"/>.
		/// </summary>
		public int MazeY { get; }
		/// <summary>
		/// The absolute X position of this cell on the map.
		/// </summary>
		public float X { get; }
		/// <summary>
		/// The absolute Y position of this cell on the map.
		/// </summary>
		public float Y { get; }
		/// <summary>
		/// Whether there is a structure currently blocking this cell.
		/// </summary>
		public bool Blocked { get; internal set; }
		/// <summary>
		/// Whether this cell is adjacent to a wall of the <see cref="Maze"/>.
		/// </summary>
		public bool IsAdjacentToWall => MazeX == 0 || MazeY == 0 || MazeX == Maze.Width - 1 || MazeY == Maze.Height - 1;
		/// <summary>
		/// The structure currently blocking this cell, if any.
		/// </summary>
		public unit Unit { get; internal set; }

		internal Cell(Maze maze, int mazeX, int mazeY)
		{
			Id = mazeX + (mazeY * maze.Width);
			Maze = maze;
			MazeX = mazeX;
			MazeY = mazeY;
			X = maze.OriginX + (mazeX * Maze.CELL_SIZE);
			Y = maze.OriginY + (mazeY * Maze.CELL_SIZE);
		}

		/// <summary>
		/// Returns all cells cardinally or diagonally adjacent to this cell.
		/// <para>This will return at most 8 cells in the in the following order:</para>
		/// <para>North-West, North, North-East, West, East, South-West, South, South-East</para>
		/// </summary>
		public IEnumerable<Cell> GetAdjacent()
		{
			var endX = MazeX + 1;
			var endY = MazeY + 1;
			for (var i = MazeX - 1; i < endX; i++)
			{
				if (i < 0 || i >= Maze.Width)
					continue;

				for (var j = MazeY - 1; j < endY; j++)
				{
					if (j >= 0 && j < Maze.Height && i != MazeX && j != MazeY)
					{
						yield return Maze.Cells[i, j];
					}
				}
			}
		}

		/// <summary>
		/// Returns all cells cardinally adjacent to this cell.
		/// <para>This will return at most 4 cells in the in the following order:</para>
		/// <para>North, West, East, South</para>
		/// </summary>
		public IEnumerable<Cell> GetCardinalAdjacent()
		{
			if (MazeY < Maze.Height - 1)
				yield return Maze.Cells[MazeX, MazeY + 1];
			if (MazeX < Maze.Width - 1)
				yield return Maze.Cells[MazeX + 1, MazeY];
			if (MazeX > 0)
				yield return Maze.Cells[MazeX - 1, MazeY];
			if (MazeY > 0)
				yield return Maze.Cells[MazeX, MazeY - 1];
		}

		/// <summary>
		/// Returns all cells cardinally or diagonally adjacent to this cell assuming the given width/height.
		/// <para>Example: With a <paramref name="width"/> of 1 and a <paramref name="height"/> of 1, this will return at most 8 cells and is identical to <see cref="GetAdjacent"/>.</para>
		/// <para>Example: With a <paramref name="width"/> of 2 and a <paramref name="height"/> of 2, this will return at most 12 cells.</para>
		/// <para>The return order starts with the North-West corner and moves East, then moves 1 row down, and continues until reaching the far South.</para>
		/// </summary>
		public IEnumerable<Cell> GetAdjacent(int width, int height)
		{
			var left = MazeX - 1;
			var bottom = MazeY - 1;
			var right = MazeX + 1 + width;
			var top = MazeY + 1 + height;

			for (var i = left; i <= right; i++)
			{
				if (i < 0 || i >= Maze.Width)
					continue;

				if (i == left || i == right)
				{
					for (var j = bottom; j <= top; j++)
					{
						if (j >= 0 && j < Maze.Height && i != MazeX && j != MazeY)
						{
							yield return Maze.Cells[i, j];
						}
					}
				}
				else
				{
					if (bottom >= 0)
						yield return Maze.Cells[i, bottom];
					if (top < Maze.Height)
						yield return Maze.Cells[i, top];
				}
			}
		}

		/// <summary>
		/// Returns all cells cardinally adjacent to this cell assuming the given width/height.
		/// <para>Example: With a <paramref name="width"/> of 1 and a <paramref name="height"/> of 1, this will return at most 4 cells and is identical to <see cref="GetCardinalAdjacent"/>.</para>
		/// <para>Example: With a <paramref name="width"/> of 2 and a <paramref name="height"/> of 2, this will return at most 8 cells.</para>
		/// <para>The return order starts with the North-West corner and moves East, then moves 1 row down, and continues until reaching the far South.</para>
		/// </summary>
		public IEnumerable<Cell> GetCardinalAdjacent(int width, int height)
		{
			var left = MazeX - 1;
			var bottom = MazeY - 1;
			var right = MazeX + 1 + width;
			var top = MazeY + 1 + height;

			for (var i = left; i <= right; i++)
			{
				if (i < 0 || i >= Maze.Width)
					continue;

				if (i == left || i == right)
				{
					for (var j = bottom + 1; j < top; j++)
					{
						if (j >= 0 && j < Maze.Height && i != MazeX && j != MazeY)
						{
							yield return Maze.Cells[i, j];
						}
					}
				}
				else
				{
					if (bottom >= 0)
						yield return Maze.Cells[i, bottom];
					if (top < Maze.Height)
						yield return Maze.Cells[i, top];
				}
			}
		}
	}
}
