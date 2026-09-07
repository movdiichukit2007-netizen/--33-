public static int IndexOf<T>(T[] array, T value) { return -1; }

public static T[] Reverse<T>(T[] array) { return array; }

public static T Min<T>(T[] array) where T : IComparable<T> { return array[0]; }

public static T Max<T>(T[] array) where T : IComparable<T> { return array[0]; }
