public class Edge
{
    public Point StartPoint;
    public Side Side;

    private int length = 1;

	public Edge(Point startPoint, Side side)
	{
		StartPoint = startPoint;
		Side = side;
	}

    public void SetLength(int length) => this.length = length;
    // Можно добавить метод рисовки грани
}
