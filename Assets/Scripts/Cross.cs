using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    public readonly Point centerPoint;
    public Side[] HasNeighbours;

	#region �����������
	public Cross(Point centerPoint, Side[] hasNeighbours)
	{
		this.centerPoint = centerPoint;
		HasNeighbours = hasNeighbours;
	}
	#endregion

	#region ������

	/// <summary>
	/// ������� ������ ������ �������
	/// </summary>
	/// <returns>������ ������ �������</returns>
	public Side[] GetNeighboursSide() => HasNeighbours;

	/// <summary>
	/// ������� ������ �������� �����
	/// </summary>
	/// <returns>������ �������� �����</returns>
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
    /// ��������� ������
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
                    // ����� ����� ��������� �����
					break;
				case Side.top:
                    edge = new Edge(centerPoint, Side.top);
                    // ����� ����� ��������� �����
					break;
				case Side.right:
                    edge = new Edge(centerPoint, Side.right);
                    // ����� ����� ��������� �����
					break;
				case Side.bottom:
					edge = new Edge(centerPoint, Side.bottom);
					// ����� ����� ��������� �����
					break;
				default:
					break;
			}
		}
    }
	#endregion
}
