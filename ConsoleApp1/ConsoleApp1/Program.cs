using System.Text;

static string Encrypt(string text, string key)
{
    StringBuilder encypted = new StringBuilder();
    key = key.ToLower();
    int key_index = 0;

    foreach (char c in text.ToLower())
    {
        if (char.IsLetter(c))
        {
            char letter = (char)((c - 'a' + key[key_index % key.Length] - 'a') % 26 + 'a');
            encypted.Append(letter);
            key_index++;
        }
        else
        {
            encypted.Append(c);
        }
    }
    return encypted.ToString();
}
static string Decrypt(string text, string key)
{
    StringBuilder descypted = new StringBuilder(); 
    key = key.ToLower();
    int key_index = 0;
    foreach (char c in text.ToLower())
    {
        if (char.IsLetter(c))
        {
            char letter = (char)((c - 'a' - (key[key_index % key.Length] - 'a') + 26) % 26 + 'a');
            descypted.Append(letter);
            key_index++;
        }
        else
        {
            descypted.Append(c);
        }
    }
    return descypted.ToString();
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Шифрувальник англійських текстів Шифром Віжінера\n1.Зашифрувати текcт\n2.Розшифрувати текcт\nВаш вибір: ");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    case(1):
        {
            Console.WriteLine("Введіть текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("Введіть ключ: ");
            string key = Console.ReadLine();
            Console.WriteLine(Encrypt(text,key));
            break;
        }
    case (2):
        {
            Console.WriteLine("Введіть текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("Введіть ключ: ");
            string key = Console.ReadLine();
            Console.WriteLine(Decrypt(text, key));
            break;
        }
}