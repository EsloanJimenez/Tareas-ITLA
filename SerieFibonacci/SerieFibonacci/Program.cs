int a = 0, b = 1;

while (a <= 50) {
        Console.WriteLine(a);
        int temp = a;
        a = b;
        b = temp + b;
}

Console.ReadKey();