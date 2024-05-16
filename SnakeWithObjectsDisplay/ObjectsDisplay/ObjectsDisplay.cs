#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

public class ObjectsDisplay<T>
{
    private int Width;
    private int Height;
    private int Capacity;
    private Object<T>[,] Display;

    public ObjectsDisplay(int ObjectsAmount, T CustomObject)
    {
        if (ObjectsAmount <= 0)
            ObjectsAmount = 1;
        Capacity = ObjectsAmount;
        int tWidth = 0; // t- for Temporary
        int tHeight = 0;
        //if (ObjectsAmount > 100)
        //    tHeight = ObjectsAmount / 8;
        while (tWidth * tHeight != ObjectsAmount)
        {
            tHeight++;
            tWidth = 0;
            while (tWidth <= tHeight && tWidth * tHeight != ObjectsAmount)
            {
                tWidth++;
            }
        }
        Width = tWidth;
        Height = tHeight;
        Display = new Object<T>[Width, Height];
        FillDisplay(CustomObject);
    }
    public ObjectsDisplay(int ObjectsAmount)
    {
        if (ObjectsAmount <= 0)
            ObjectsAmount = 1;
        Capacity = ObjectsAmount;
        int tWidth = 0; // t- for Temporary
        int tHeight = 0;
        while (tWidth * tHeight != ObjectsAmount)
        {
            tHeight++;
            tWidth = 0;
            while (tWidth <= tHeight && tWidth * tHeight != ObjectsAmount)
            {
                tWidth++;
            }
        }
        Width = tWidth;
        Height = tHeight;
        Display = new Object<T>[Width, Height];
    }
    public ObjectsDisplay(int Width, int Height)
    {
        if (Width >= 0 && Height >= 0)
        {
            this.Width = Width;
            this.Height = Height;
            Capacity = Width * Height;
            Display = new Object<T>[Width, Height];
        }
    }

    public ObjectsDisplay(int Width, int Height, T CustomObject)
    {
        if (Width >= 0 && Height >= 0)
        {
            this.Width = Width;
            this.Height = Height;
            Capacity = Width * Height;
            Display = new Object<T>[Width, Height];
            FillDisplay(CustomObject); // Initialize display with custom object
        }
    }
    public void FillDisplay(T CustomObject)
    {
        if (Display != null)
            if (CustomObject != null)
                for (int i = 0; i < Width; i++)
                    for (int j = 0; j < Height; j++)
                        if (Display[i, j] != null)
                            Display[i, j].SetValue(CustomObject);
                        else
                            Display[i, j] = new Object<T>(CustomObject);
            else
                for (int i = 0; i < Width; i++)
                    for (int j = 0; j < Height; j++)
                        if (Display[i, j] != null)
                            Display[i, j].SetValue("null");
                        else
                            Display[i, j] = new Object<T>("null");
    }
    public void FillDisplay(string CustomObject)
    {
        if (Display != null)
            if (CustomObject != null)
                for (int i = 0; i < Width; i++)
                    for (int j = 0; j < Height; j++)
                        if (Display[i, j] != null)
                            Display[i, j].SetValue(CustomObject);
                        else
                            Display[i, j] = new Object<T>(CustomObject);
            else
                for (int i = 0; i < Width; i++)
                    for (int j = 0; j < Height; j++)
                        if (Display[i, j] != null)
                            Display[i, j].SetValue("null");
                        else
                            Display[i, j] = new Object<T>("null");
    }
    public void ClearDisplay()
    {
        if (Display != null)
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (Display[i, j] != null)
                        Display[i, j].SetValue();
                    else
                        Display[i, j] = new Object<T>();
    }
    public void PrintRender()
    {
        if (this != null)
            Console.WriteLine(this.ToString());
    }
    public override string ToString()
    {
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return "null";
        }
        string str = "";
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
                if (Display[j, i] != null)
                    str += Display[j, i].ToString() + "\t";
                else str += "null\t";
            str += "\n";
        }
        return str;
    }
    public void SetObject(int x, int y, T CustomObject)
    {
        x--;
        y = Height - y;
        if (x > Width || x < 0 || y < 0 || y > Height)
        {
            Console.WriteLine("\n\tOut of bounds of array\n");
            return;
        }
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return;
        }
        if (CustomObject != null)
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue(CustomObject);
            else
                Display[x, y] = new Object<T>(CustomObject);
        }
        else
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue("null");
            else
                Display[x, y] = new Object<T>("null");
        }
    }
    public void SetObject(int x, int y, string CustomObject)
    {
        x--;
        y = Height - y;
        if (x > Width || x < 0 || y < 0 || y > Height)
        {
            Console.WriteLine("\n\tOut of bounds of array\n");
            return;
        }
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return;
        }
        if (CustomObject != null)
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue(CustomObject);
            else
                Display[x, y] = new Object<T>(CustomObject);
        }
        else
        {
            if (Display[x, y] != null)
                Display[x, y].SetValue("null");
            else
                Display[x, y] = new Object<T>("null");
        }
    }
    public void SetObject(int x, int y)
    {
        x--;
        y = Height - y;
        if (x > Width || x < 0 || y < 0 || y > Height)
        {
            Console.WriteLine("\n\tOut of bounds of array\n");
            return;
        }
        if (Display == null)
        {
            Console.WriteLine("\n\tDisplay has not been created before action\n");
            return;
        }
        if (Display[x, y] != null)
            Display[x, y].SetValue();
        else
            Display[x, y] = new Object<T>();
    }
    public string GetObject(int x, int y)
    {
        return Display[x, y].GetValue();
    }
    public T GetCustomObject(int x, int y)
    {
        return Display[x, y].GetCustomObject();
    }
    public int GetWidth()
    {
        return Width;
    }
    public int GetHeight()
    {
        return Height;
    }
    public int GetCapacity()
    {
        return Capacity;
    }
}