int c = 0;

void tambah(int a, int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}
void kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}
void kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
void bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}
tambah(1,1);
kurang(100, 20);
kali(1, 1);
bagi(6, 7);
