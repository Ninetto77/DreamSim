using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    public readonly Point centerPoint;
    public Side[] HasNeighbours;

	#region Конструктор
	public Cross(Point centerPoint, Side[] hasNeighbours)
	{
		this.centerPoint = centerPoint;
		HasNeighbours = hasNeighbours;
	}
	#endregion

	#region Методы

	/// <summary>
	/// Вернуть массив сторон соседей
	/// </summary>
	/// <returns>Массив сторон соседей</returns>
	public Side[] GetNeighboursSide() => HasNeighbours;

	/// <summary>
	/// Вернуть список соседних точек
	/// </summary>
	/// <returns>Список соседних точек</returns>
	public List<Point> GetNeighboursCoord()
    {
        var neighboursPoint = new List<Point>();
        foreach (Side neighbour in HasNeighbours)
        {
            switch (neighbour)
            {
                case Side.left:
                    neighboursPoint.Add(new Point(centerPoint.X - 1, centerPoint.Y));
                    break;
                case Side.top:
					neighboursPoint.Add(new Point(centerPoint.X, centerPoint.Y + 1));
					break;
                case Side.right:
                    neighboursPoint.Add(new Point(centerPoint.X + 1, centerPoint.Y));
                    break;
                case Side.bottom:
                    neighboursPoint.Add(new Point(centerPoint.X, centerPoint.Y - 1));
                    break;
                default:
                    break;
            }
        }
        return neighboursPoint;
    }

    /// <summary>
    /// Отрисовка граней
    /// </summary>
    public void DrowWalls()
    {
        Edge edge = null;

		foreach (Side neighbour in HasNeighbours)
        {
			switch (neighbour)
			{
				case Side.left:
                    edge = new Edge(centerPoint, Side.left);
                    // Здесь метод отрисовки грани
					break;
				case Side.top:
                    edge = new Edge(centerPoint, Side.top);
                    // Здесь метод отрисовки грани
					break;
				case Side.right:
                    edge = new Edge(centerPoint, Side.right);
                    // Здесь метод отрисовки грани
					break;
				case Side.bottom:
					edge = new Edge(centerPoint, Side.bottom);
					// Здесь метод отрисовки грани
					break;
				default:
					break;
			}
		}
    }
	#endregion
}
