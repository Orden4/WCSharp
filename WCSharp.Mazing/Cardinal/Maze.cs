using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WCSharp.Mazing.Cardinal
{
	public class Maze
	{
		public const float CELL_SIZE = 64.0f;

		/// <summary>
		/// The X coordinate of the origin (absolute center) of this maze on the map.
		/// </summary>
		public float OriginX { get; }
		/// <summary>
		/// The Y coordinate of the origin (absolute center) of this maze on the map.
		/// </summary>
		public float OriginY { get; }
		/// <summary>
		/// The height of the maze in cells. Each cells size on the map is equal to <see cref="CELL_SIZE"/>.
		/// </summary>
		public int Height { get; }
		/// <summary>
		/// The width of the maze in cells. Each cells size on the map is equal to <see cref="CELL_SIZE"/>.
		/// </summary>
		public int Width { get; }

		/// <summary>
		/// The rectangle within which the entirety of this maze fits.
		/// </summary>
		public Rectangle Rectangle { get; }

		internal Cell[,] Cells { get; }
		internal HashSet<Cell> Waypoints { get; private set; }

		private List<effect> debugEffects;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="originX">The X coordinate of the origin (absolute center) of this maze on the map.</param>
		/// <param name="originY">The Y coordinate of the origin (absolute center) of this maze on the map.</param>
		/// <param name="width">The height of the maze in cells. Each cells size on the map is equal to <see cref="CELL_SIZE"/>.</param>
		/// <param name="height">The width of the maze in cells. Each cells size on the map is equal to <see cref="CELL_SIZE"/>.</param>
		public Maze(float originX, float originY, int width, int height)
		{
			OriginX = originX;
			OriginY = originY;
			Width = width;
			Height = height;
			Waypoints = new HashSet<Cell>();

			Rectangle = new Rectangle(originX - (CELL_SIZE / 2), originY - (CELL_SIZE / 2), originX + (CELL_SIZE / 2) + (CELL_SIZE * width), originY + (CELL_SIZE / 2) + (CELL_SIZE * height));

			Cells = new Cell[width, height];
			for (var i = 0; i < width; i++)
			{
				for (var j = 0; j < height; j++)
				{
					Cells[i, j] = new Cell(this, i, j);
				}
			}
		}

		/// <summary>
		/// Sets the waypoints to be used to determine a path and whether a structure would cause a block.
		/// </summary>
		public bool SetWaypoints(IEnumerable<Point> waypoints)
		{
			var cells = waypoints
				.Select(x => GetCellByPosition(x.X, x.Y))
				.ToList();
			return SetWaypoints(cells);
		}

		/// <summary>
		/// Sets the waypoints to be used to determine a path and whether a structure would cause a block.
		/// </summary>
		public bool SetWaypoints(IEnumerable<Cell> cells)
		{
			if (cells.All(x => x != null && x.Maze == this))
			{
				Waypoints.Clear();
				foreach (var cell in cells)
				{
					Waypoints.Add(cell);
				}
				return true;
			}
			else
			{
				return false;
			}
		}

		public void DebugDraw(string emptyEffect)
		{
			DebugDrawClear();

			foreach (var cell in Cells)
			{
				if (!cell.Blocked && !Waypoints.Contains(cell))
				{
					this.debugEffects.Add(AddSpecialEffect(emptyEffect, cell.X, cell.Y));
				}
			}
		}

		public void DebugDrawClear()
		{
			this.debugEffects ??= new List<effect>();
			foreach (var effect in this.debugEffects)
			{
				DestroyEffect(effect);
			}
			this.debugEffects.Clear();
		}

		/// <summary>
		/// Assigns the cells at the given position and <paramref name="width"/>/<paramref name="height"/> offset to the given unit and blocks them for pathing.
		/// <para>This does not check for whether this would cause a block or not or whether an existing unit already claims the affected cells.</para>
		/// </summary>
		/// <returns>Whether the given location is within this maze.</returns>
		public bool Build(unit unit, float x, float y, int width, int height)
		{
			var originCell = GetOriginCell(x, y, width, height);
			if (originCell != null)
			{
				var endX = Math.Min(Width, originCell.MazeX + width);
				var endY = Math.Min(Height, originCell.MazeY + height);
				for (var i = originCell.MazeX; i < endX; i++)
				{
					for (var j = originCell.MazeY; j < endY; j++)
					{
						var cell = Cells[i, j];
						cell.Blocked = true;
						cell.Unit = unit;
					}
				}

				return true;
			}

			return false;
		}

		/// <summary>
		/// Returns whether a valid path exists after building at the given position with the given <paramref name="width"/>/<paramref name="height"/> offset.
		/// <para>Note: Ensure this does not affect a cell already blocked, as this would cause its blocked flag to be cleared upon completion of this method.</para>
		/// </summary>
		public bool WouldBlock(float x, float y, int width, int height)
		{
			var originCell = GetOriginCell(x, y, width, height);
			if (originCell != null)
			{
				if (Waypoints.Contains(originCell))
				{
					return true;
				}

				var endX = Math.Min(Width, originCell.MazeX + width);
				var endY = Math.Min(Height, originCell.MazeY + height);
				for (var i = originCell.MazeX; i < endX; i++)
				{
					for (var j = originCell.MazeY; j < endY; j++)
					{
						Cells[i, j].Blocked = true;
					}
				}

				var pathExists = PathExists();

				for (var i = originCell.MazeX; i < endX; i++)
				{
					for (var j = originCell.MazeY; j < endY; j++)
					{
						Cells[i, j].Blocked = false;
					}
				}

				return !pathExists;
			}

			return false;
		}

		/// <summary>
		/// Clears the unit assigned to the cells at the given position with the given <paramref name="width"/>/<paramref name="height"/> offset and frees the cells for pathing.
		/// </summary>
		public void Destroy(float x, float y, int width, int height)
		{
			var originCell = GetOriginCell(x, y, width, height);
			if (originCell != null)
			{
				var endX = Math.Min(Width, originCell.MazeX + width);
				var endY = Math.Min(Height, originCell.MazeY + height);
				for (var i = originCell.MazeX; i < endX; i++)
				{
					for (var j = originCell.MazeY; j < endY; j++)
					{
						var cell = Cells[i, j];
						cell.Blocked = false;
						cell.Unit = null;
					}
				}
			}
		}

		/// <summary>
		/// Returns true if a path exists between <paramref name="start"/> and <paramref name="end"/>.
		/// </summary>
		public static bool PathExists(Cell start, Cell end)
		{
			var visitedCells = new HashSet<int>
			{
				start.Id
			};
			var currentCells = new List<Cell>
			{
				start
			};

			while (currentCells.Count > 0)
			{
				var nextCells = new List<Cell>();

				foreach (var cell in currentCells)
				{
					foreach (var cardinalAdjacentCell in cell.GetCardinalAdjacent())
					{
						if (!cardinalAdjacentCell.Blocked && !visitedCells.Contains(cardinalAdjacentCell.Id))
						{
							nextCells.Add(cardinalAdjacentCell);
							visitedCells.Add(cardinalAdjacentCell.Id);
						}
					}
				}

				if (visitedCells.Contains(end.Id))
				{
					return true;
				}

				currentCells = nextCells;
			}

			return false;
		}

		/// <summary>
		/// Returns true if a path exists between all waypoints.
		/// </summary>
		public bool PathExists()
		{
			if (Waypoints.Count <= 1)
				return true;

			var first = Waypoints.First();
			var visitedCells = new HashSet<int>
			{
				first.Id
			};
			var currentCells = new List<Cell>
			{
				first
			};
			var waypointsEncountered = 1;

			while (currentCells.Count > 0)
			{
				var nextCells = new List<Cell>();

				foreach (var cell in currentCells)
				{
					foreach (var cardinalAdjacentCell in cell.GetCardinalAdjacent())
					{
						if (!cardinalAdjacentCell.Blocked && !visitedCells.Contains(cardinalAdjacentCell.Id))
						{
							if (Waypoints.Contains(cardinalAdjacentCell) &&
								++waypointsEncountered == Waypoints.Count)
							{
								return true;
							}
							nextCells.Add(cardinalAdjacentCell);
							visitedCells.Add(cardinalAdjacentCell.Id);
						}
					}
				}

				currentCells = nextCells;
			}

			return false;
		}

		/// <summary>
		/// Returns the shortest path (inclusive) between <paramref name="start"/> and <paramref name="end"/>.
		/// <para>Note: Path is determined purely in cardinal direction movements, with a bias according to <see cref="Cell.GetCardinalAdjacent"/>.</para>
		/// </summary>
		public static List<Cell> FindShortestPath(Cell start, Cell end)
		{
			var visitedCells = new HashSet<int>
			{
				start.Id
			};
			var paths = new List<List<Cell>>
			{
				new List<Cell>
				{
					start
				}
			};

			while (paths.Count > 0)
			{
				var newPaths = new List<List<Cell>>();

				for (var i = 0; i < paths.Count; i++)
				{
					var path = paths[i];
					for (var j = 0; j < path.Count; j++)
					{
						var current = path[j];
						foreach (var adjacent in current.GetCardinalAdjacent())
						{
							if (adjacent.Id == end.Id)
							{
								return new List<Cell>(path)
								{
									adjacent
								};
							}
							else if (!visitedCells.Contains(adjacent.Id))
							{
								newPaths.Add(new List<Cell>(path)
								{
									adjacent
								});
							}
						}
					}
				}

				paths = newPaths;
			}

			return null;
		}

		/// <summary>
		/// Returns the origin cell for a sturcture of the given <paramref name="width"/> and <paramref name="height"/>
		/// being built on the given (<paramref name="x"/>, <paramref name="y"/>) map coordinates.
		/// </summary>
		public Cell GetOriginCell(float x, float y, int width, int height)
		{
			x -= CELL_SIZE * width / 2;
			y -= CELL_SIZE * height / 2;
			return GetCellByPosition(x, y);
		}

		/// <summary>
		/// Returns the <see cref="Cell"/> located at the given <paramref name="x"/> and <paramref name="y"/> index.
		/// </summary>
		public Cell GetCellByIndex(int x, int y)
		{
			if (x >= 0 && x < Width &&
				y >= 0 && y < Height)
			{
				return Cells[x, y];
			}

			return null;
		}

		/// <summary>
		/// Returns the <see cref="Cell"/> located at the given (<paramref name="x"/>, <paramref name="y"/>) map coordinates.
		/// </summary>
		public Cell GetCellByPosition(float x, float y)
		{
			if (Rectangle.Contains(x, y))
			{
				var i = (int)Math.Min(Width - 1, 1 + ((x - OriginX) / CELL_SIZE));
				var j = (int)Math.Min(Height - 1, 1 + ((y - OriginY) / CELL_SIZE));
				return Cells[i, j];
			}

			return null;
		}
	}
}
