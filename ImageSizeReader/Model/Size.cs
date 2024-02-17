namespace ImageSizeReader.Model;

public readonly struct Size(int width, int height)
    {
	public readonly int Width { get; } = width;
	public readonly int Height { get; } = height;
}
