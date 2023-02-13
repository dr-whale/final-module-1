List<string> ShortStrings (string[] array)
{
    List<string> shorts = new List<string>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) shorts.Add(array[i]);
    }
    return shorts;
}
