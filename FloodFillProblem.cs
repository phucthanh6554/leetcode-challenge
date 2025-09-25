namespace Leetcode.Algorithm;

public class FloodFillProblem
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) 
    {
        if(image[sr][sc] == color)
            return image;
        
        Recursive(image, sr, sc, image[sr][sc], color);
        
        return image;
    }

    private void Recursive(int[][] image, int x, int y, int origColor, int color)
    {
        if(x < 0 || x >= image.Length || y < 0 || y >= image[0].Length || image[x][y] != origColor)
            return;
        
        image[x][y] = color;
        
        Recursive(image, x + 1, y, origColor, color);
        Recursive(image, x - 1, y, origColor, color);
        Recursive(image, x, y + 1, origColor, color);
        Recursive(image, x, y - 1, origColor, color);
    }
}