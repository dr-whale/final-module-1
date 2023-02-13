string[] ShortStrings (string[] array)
{
    List<string> shortsList = new List<string>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) shortsList.Add(array[i]);
    }
    string[] shorts = new string[shortsList.Count];
    for (int i = 0; i < shorts.Length; i++)
    {
        shorts[i] = shortsList[i];
    }
    return shorts;
}
